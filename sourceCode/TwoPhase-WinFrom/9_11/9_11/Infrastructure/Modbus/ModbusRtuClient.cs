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
        // ===== 单例核心 =====
        //Lazy懒加载，Value属性防多线程重复加载实例
        private static readonly Lazy<ModbusRtuClient> _instance =
            new Lazy<ModbusRtuClient>(() => new ModbusRtuClient());

        public static ModbusRtuClient Instance => _instance.Value;

        // 私有构造函数（外部无法 new）
        private ModbusRtuClient()
        {
            Initialize();
        }

        // ===== 原有字段 =====
        //应该要从配置文件中读取
        private SerialPort? serialPort;
        private readonly string PortName = "COM1";
        private readonly int BaudRate = 9600;
        private readonly Parity Parity = Parity.None;
        private readonly int DataBits = 8;
        private readonly StopBits StopBits = StopBits.One;

        private IModbusSerialMaster? Master;
        private ushort[]? Data;

        private readonly System.Windows.Forms.Timer GlobalTimer = new();

        // ===== 初始化逻辑 =====
        private void Initialize()
        {
            try
            {
                serialPort = new SerialPort(PortName, BaudRate, Parity, DataBits, StopBits);
                serialPort.Open();

                Master = ModbusSerialMaster.CreateRtu(serialPort);
                Master.Transport.ReadTimeout = 2000;
                Master.Transport.Retries = 3;
            }
            catch (Exception err)
            {
                throw new InvalidOperationException($"Modbus 连接失败: {err.Message}", err);
            }
        }

        // ===== 对外暴露的方法 =====
        public async Task<ushort[]> ReadHoldingRegistersAsync(byte slaveAddress, ushort offset, ushort count)
        {
            if (Master == null)
                throw new InvalidOperationException("Modbus 未连接");

            return await Master.ReadHoldingRegistersAsync(slaveAddress, offset, count);
        }
        public async Task WriteMultipleRegistersAsync(byte slaveAddress, ushort startAddress, ushort[] data)
        {
            if (Master == null)
                throw new InvalidOperationException("Modbus 未连接");

            await Master.WriteMultipleRegistersAsync(slaveAddress, startAddress, data);
        }

        public bool IsConnected => serialPort?.IsOpen ?? false;

        // ===== 释放资源 =====
        public void Dispose()
        {
            GlobalTimer?.Stop();
            Master?.Dispose();
            if (serialPort?.IsOpen == true)
                serialPort.Close();
            serialPort?.Dispose();
        }
    }
}
