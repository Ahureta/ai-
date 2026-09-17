namespace _9_11.Domain.Entities
{
    /// <summary>
    /// 设备寄存器映射表（常量定义 + 数据承载）
    /// 常量部分：地址/索引/比例（编译期确定）
    /// 实例部分：承载一次读取的原始数据，提供强类型访问
    /// </summary>
    public class RegisterMap
    {
        // ===== 常量（协议定义，谁都不许改）=====
        public const byte SlaveAddress = 1;
        public const ushort ReadStart = 0;
        public const ushort ReadCount = 4;

        public const int DeviceStatusIndex = 0;
        public const int SetTempIndex = 1;
        public const int RealTempIndex = 2;
        public const int FaultCodeIndex = 3;

        public const double TempScale = 0.1;

        // ===== 实例字段（一次读取的数据）=====
        private readonly ushort[] _rawData;

        // ===== 构造函数：接收原始数据 =====
        public RegisterMap(ushort[] rawData)
        {
            if (rawData == null)
                throw new ArgumentNullException(nameof(rawData));
            if (rawData.Length < ReadCount)
                throw new ArgumentException($"数据长度不足：期望至少 {ReadCount}，实际 {rawData.Length}");

            _rawData = rawData;
        }

        // ===== 强类型属性（按索引解析，对外暴露有意义的字段）=====
        public ushort DeviceStatus => _rawData[DeviceStatusIndex];
        public ushort SetTemp => _rawData[SetTempIndex];
        public ushort RealTemp => _rawData[RealTempIndex];
        public ushort FaultCode => _rawData[FaultCodeIndex];


        public double SetTempDouble => _rawData[SetTempIndex] * TempScale;
        public double RealTempDouble => _rawData[RealTempIndex] * TempScale;
        

        // 原始数据（给需要的人用）
        public ushort[] RawData => _rawData;
    }
}


//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _9_11.Domain.Entities
//{
//    /// <summary>
//    /// 设备寄存器地址映射（对照设备说明书）
//    /// </summary>
//    public class RegisterMap
//    {
//        public const byte SlaveAddress = 1;        

//        // 连续读取的起始地址和数量
//        public const ushort ReadStart = 0;
//        public const ushort ReadCount = 4;  // 一次读4个


//        // 保持寄存器（读写，0x03读 / 0x06写 / 0x10批量写）  
//        public const int DeviceStatusIndex = 0; // 设备状态
//        public const int SetTempIndex = 1;      //设定温度
//        public const int RealTempIndex = 2;     // 温度 ×0.1 °C
//        public const int FaultCodeIndex = 3;    // 报警码

//        // 数据转换比例（假设设备存储为整数，如256代表25.6℃）
//        public const double TempScale = 0.1;

//        public RegisterMap(ushort[] ushorts) { 

//        }
//        public RegisterMap() { }
//    }
//}