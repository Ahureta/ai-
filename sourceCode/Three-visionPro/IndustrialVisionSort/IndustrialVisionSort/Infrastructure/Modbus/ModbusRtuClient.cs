using IndustrialVisionSort.Domain.Interfaces;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;

namespace _9_11.Infrastructure.Modbus
{
    public class ModbusRtuClient : IModbusClient
    {
        //// ===== 单例核心 =====
        ////Lazy懒加载，Value属性防多线程重复加载实例
        //private static readonly Lazy<ModbusRtuClient> _instance =
        //    new Lazy<ModbusRtuClient>(() => new ModbusRtuClient());

        //public static ModbusRtuClient Instance => _instance.Value;
        
        public ModbusRtuClient(){}

        // ===== 原有字段 =====
        //应该要从配置文件中读取
        private SerialPort _serialPort;
        private readonly string _portName = "COM1";
        private readonly int _baudRate = 9600;
        private readonly Parity _parity = Parity.None;
        private readonly int _dataBits = 8;
        private readonly StopBits _stopBits = StopBits.One;

        private IModbusSerialMaster _master;

        public bool IsConnected => _serialPort?.IsOpen ?? false;

        // ===== 对外暴露的方法 =====
        public async Task<ushort[]> ReadHoldingRegistersAsync(byte slaveAddress, ushort offset, ushort count)
        {
            if (_master == null)
                throw new InvalidOperationException("Modbus 未连接");

            return await _master.ReadHoldingRegistersAsync(slaveAddress, offset, count);
        }
        public async Task WriteMultipleRegistersAsync(byte slaveAddress, ushort startAddress, ushort[] data)
        {
            if (_master == null)
                throw new InvalidOperationException("Modbus 未连接");
            
            await _master.WriteMultipleRegistersAsync(slaveAddress, startAddress, data);
        }

        

        // ===== 连接（可重复调用）=====
        public void Connect()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(ModbusRtuClient));

            // 如果已连接，先断开
            DisConnect();

            // 重新创建
            _serialPort = new SerialPort(_portName, _baudRate, _parity, _dataBits, _stopBits);
            _serialPort.Open();

            _master = ModbusSerialMaster.CreateRtu(_serialPort);
            _master.Transport.ReadTimeout = 2000;
            _master.Transport.Retries = 3;
        }

        // ===== 断开（不销毁对象，可重连）=====
        public void DisConnect()
        {
            // 先 Dispose __master（它内部会引用 _serialPort）
            _master?.Dispose();
            _master = null;  // ← 关键：置 null

            if (_serialPort?.IsOpen == true)
                _serialPort.Close();
            _serialPort?.Dispose();
            _serialPort = null;  // ← 关键：置 null
        }

        private bool _disposed = false;
        // ===== 彻底销毁（程序退出时）=====
        public void Dispose()
        {
            if (_disposed) return;
            DisConnect();  // 复用断开逻辑
            _disposed = true;
        }        
    }
}


/*
 Modbus 的四种寄存器：
寄存器类型	读写	数据长度	地址前缀	常用功能码
线圈寄存器（Coils）	读/写	1 bit	0x	01/05/15
离散输入（Discrete Inputs）	只读	1 bit	1x	02
输入寄存器（Input Registers）	只读	16 bit	3x	04
保持寄存器（Holding Registers）	读/写	16 bit	4x	03/06/16
 */