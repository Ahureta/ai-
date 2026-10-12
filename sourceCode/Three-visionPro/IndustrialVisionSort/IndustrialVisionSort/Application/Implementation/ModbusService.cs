using _9_11.Infrastructure.Modbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace IndustrialVisionSort.Application.Implementation
{
    internal class ModbusService
    {
        /// <summary>
        /// 偷懒 不写映射类
        /// </summary>
        /*
            1. 100        1 启动    0 暂停
            2. 101        1 正转    0 倒转
            3. 102        2000  转/秒
         */
        private byte slaveAddress = 2;
        public readonly int DeviceStatusIndex = 100;
        public readonly int ForwardAndReverse = 101;
        public readonly int SpleedIndex = 102;

        private ModbusRtuClient _modbusRtuClient = new ModbusRtuClient();

        public ModbusService(byte slaveAddress = 2,int DeviceStatusIndex = 100, int ForwardAndReverse = 101,int SpleedIndex = 102) {
            this.slaveAddress = slaveAddress;
            this.DeviceStatusIndex = DeviceStatusIndex;
            this.ForwardAndReverse = ForwardAndReverse;
            this.SpleedIndex = SpleedIndex;
        }

        public void Connect() { _modbusRtuClient.Connect(); }
        public void DisConnect() { _modbusRtuClient.DisConnect(); }
        public void Dispose() { _modbusRtuClient.Dispose(); }

        internal async void ForwardRotation()
        {
            await _modbusRtuClient.WriteMultipleRegistersAsync(slaveAddress, (ushort)ForwardAndReverse, new ushort[] {1});
        }
        internal async void Reverse()
        {
            await _modbusRtuClient.WriteMultipleRegistersAsync(slaveAddress, (ushort)ForwardAndReverse, new ushort[] { 0 });
        }
        internal async void Stop()
        {
            await _modbusRtuClient.WriteMultipleRegistersAsync(slaveAddress, (ushort)DeviceStatusIndex, new ushort[] { 0 });
        }

        internal async void SetSpeed(int value)
        {
            await _modbusRtuClient.WriteMultipleRegistersAsync(slaveAddress, (ushort)SpleedIndex, new ushort[] { (ushort)value });
        }

        internal async void Start()
        {
            await _modbusRtuClient.WriteMultipleRegistersAsync(slaveAddress, (ushort)DeviceStatusIndex, new ushort[] { 1 });
        }
    }
}
