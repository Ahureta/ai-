using _9_11.Domain.Entities;

namespace _9_11.Infrastructure.Mapping
{
    /// <summary>
    /// 寄存器数据映射器
    /// ushort[] → RegisterMap 实例 → DeviceTempRecord
    /// </summary>
    public static class DeviceDataMapper
    {
        /// <summary>
        /// 原始数据 → 实体
        /// </summary>
        public static DeviceTempRecord Map(ushort[] rawData)
        {
            // 1. 灌进 RegisterMap（校验 + 解析）
            var registerMap = new RegisterMap(rawData);

            if (registerMap == null)
                throw new ArgumentNullException(nameof(registerMap));


            // 2. 用 RegisterMap 实例构造实体
            return new DeviceTempRecord(
                DeviceStatus: registerMap.DeviceStatus,
                SetTemp : registerMap.SetTemp,
                RealTemp : registerMap.RealTemp,
                FaultCode : registerMap.FaultCode
            );
        }
    }
}