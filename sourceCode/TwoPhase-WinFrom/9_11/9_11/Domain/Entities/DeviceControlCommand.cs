using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Entities
{
    /// <summary>
    /// 设备控制命令（写入用）
    /// 4个保持寄存器全部由上位机写入
    /// </summary>
    public class DeviceControlCommand
    {
        public int DeviceStatus { get; set; }
        public double SetTemp { get; set; }
        public double RealTemp { get; set; }   // 程序模拟的温度
        public int FaultCode { get; set; }

        /// <summary>
        /// 转换为 Modbus 写入用的 ushort[]（地址0~3）
        /// </summary>
        public ushort[] ToRegisters()
        {
            //ushort[]  ushorts = new ushort[];
            //if (DeviceStatus!=null)
            return new ushort[]
            {
                (ushort)DeviceStatus,
                (ushort)(SetTemp / RegisterMap.TempScale),
                (ushort)(RealTemp / RegisterMap.TempScale),
                (ushort)FaultCode,
            };
        }

        /// <summary>
        /// 从 RegisterMap 实例反向构造命令（用于回写/同步）
        /// </summary>
        public static DeviceControlCommand FromRegisterMap(RegisterMap registerMap)
        {
            return new DeviceControlCommand
            {
                DeviceStatus = registerMap.DeviceStatus,
                SetTemp = registerMap.SetTemp,
                RealTemp = registerMap.RealTemp,
                FaultCode = registerMap.FaultCode,
            };
        }
    }
}


/*
 // UI 层
var cmd = new DeviceControlCommand
{
    DeviceStatus = 1,    // 运行
    SetTemp = 25.5
};

await _monitoringService.SetDeviceAsync(cmd);

// Service 层
public async Task SetDeviceAsync(DeviceControlCommand cmd)
{
    ushort[] data = cmd.ToRegisters();  // 命令自己知道怎么转
    await _modbus.WriteRegistersAsync(0, data);
}
 */