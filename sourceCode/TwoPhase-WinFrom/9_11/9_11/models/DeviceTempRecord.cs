using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace _9_11.models
{
    internal class DeviceTempRecord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private int _id;
        public int Id
        {
            get => _id;
            private set => SetProperty(ref _id, value);
        }

        private DateTime _collectTime;
        public DateTime CollectTime
        {
            get => _collectTime;
            private set => SetProperty(ref _collectTime, value);
        }

        private int _deviceStatus;
        public int DeviceStatus
        {
            get => _deviceStatus;
            private set => SetProperty(ref _deviceStatus, value);
        }

        private double _setTemp;
        public double SetTemp
        {
            get => _setTemp;
            private set => SetProperty(ref _setTemp, value);
        }

        private double _realTemp;
        public double RealTemp
        {
            get => _realTemp;
            private set => SetProperty(ref _realTemp, value);
        }

        private int _faultCode;
        public int FaultCode
        {
            get => _faultCode;
            private set => SetProperty(ref _faultCode, value);
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DeviceTempRecord(ushort[] DTR)
        {            
            CollectTime = DateTime.Now;
            DeviceStatus = DTR[0];
            SetTemp = DTR[1];
            RealTemp = DTR[2];
            FaultCode = DTR[3];
        }
    }
}
