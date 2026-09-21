using _9_11.Domain.Entities;
using _9_11.Domain.Interfaces;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Text;

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
        private SerialPort? _serialPort;
        private readonly string _portName = "COM1";
        private readonly int _baudRate = 9600;
        private readonly Parity _parity = Parity.None;
        private readonly int _dataBits = 8;
        private readonly StopBits _stopBits = StopBits.One;

        private IModbusSerialMaster? _master;
        private ushort[]? ata;

        //private readonly System.Windows.Forms.Timer GlobalTimer = new();

        //// ===== 初始化逻辑 =====
        //private void Initialize()
        //{
        //    try
        //    {
        //        _serialPort = new SerialPort(_portName, _baudRate, _parity, _dataBits, _stopBits);
        //        _serialPort.Open();

        //        _master = ModbusSerialMaster.CreateRtu(_serialPort);
        //        _master.Transport.ReadTimeout = 2000;
        //        _master.Transport.Retries = 3;
        //    }
        //    catch (Exception err)
        //    {
        //        Dispose();
        //        throw new InvalidOperationException($"Modbus 连接失败: {err.Message}", err);
        //    }
        //}

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

        public bool IsConnected => _serialPort?.IsOpen ?? false;

        // ===== 连接（可重复调用）=====
        public void Connect()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(ModbusRtuClient));

            // 如果已连接，先断开
            Disconnect();

            // 重新创建
            _serialPort = new SerialPort(_portName, _baudRate, _parity, _dataBits, _stopBits);
            _serialPort.Open();

            _master = ModbusSerialMaster.CreateRtu(_serialPort);
            _master.Transport.ReadTimeout = 2000;
            _master.Transport.Retries = 3;
        }

        // ===== 断开（不销毁对象，可重连）=====
        public void Disconnect()
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
            Disconnect();  // 复用断开逻辑
            _disposed = true;
        }        
    }
}
