using _9_11.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _9_11.Domain.Interfaces
{
    public interface IModbusClient
    {
        abstract bool IsConnected { get; }
        Task<ushort[]> ReadHoldingRegistersAsync(byte SlaveAddress, ushort Offset, ushort Count);
        Task WriteMultipleRegistersAsync(byte slaveAddress, ushort startAddress, ushort[] data);
    }
}
