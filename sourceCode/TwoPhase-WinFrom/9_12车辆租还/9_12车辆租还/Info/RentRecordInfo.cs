using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _8_29.Info
{
    public class RentRecordInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        public int Id
        {
            get => _id;
            private set => SetProperty(ref _id, value);
        }

        private int _carId;
        public int CarId
        {
            get => _carId;
            set => SetProperty(ref _carId, value);
        }

        private int _userId;
        public int UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private DateTime _rentTime;
        public DateTime RentTime
        {
            get => _rentTime;
            set => SetProperty(ref _rentTime, value);
        }

        private DateTime? _returnTime;
        public DateTime? ReturnTime
        {
            get => _returnTime;
            set => SetProperty(ref _returnTime, value);
        }

        private decimal _payMoney;
        public decimal PayMoney
        {
            get => _payMoney;
            set => SetProperty(ref _payMoney, value);
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ① 无参构造函数：用于"创建"场景（表单新增租还记录）
        public RentRecordInfo()
        {
            
        }

        // ② 带Id构造函数：用于"读取"场景（从数据库加载）
        public RentRecordInfo(int id, string uid)
        {
            Id = id;            
        }
    }
}