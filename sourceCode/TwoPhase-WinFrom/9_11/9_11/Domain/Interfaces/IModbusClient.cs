using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _9_11.Domain.Interfaces
{
    public interface IModbusClient
    {
        //Task<ushort[]> ReadRegistersAsync();
        Task<ushort[]> ReadRegistersAsync(byte SlaveAddress, ushort Offset, ushort Count);
    }
}
