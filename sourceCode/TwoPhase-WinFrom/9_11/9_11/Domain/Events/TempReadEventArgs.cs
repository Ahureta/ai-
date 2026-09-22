using _9_11.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Events
{
    internal class TempReadEventArgs : EventArgs
    {
        internal DeviceTempRecord Record { get; }

        internal TempReadEventArgs(DeviceTempRecord record)
        {
            Record = record ?? throw new ArgumentNullException(nameof(record));
        }
    }
}
