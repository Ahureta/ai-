using _9_11.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _9_11.Domain.Interfaces
{
    public interface IModbusClient
    {        
        Task<ushort[]> ReadHoldingRegistersAsync(byte SlaveAddress, ushort Offset, ushort Count);
    }
}
