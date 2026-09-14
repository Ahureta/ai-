using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _8_29.Info
{
    public class CardInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        public int Id
        {
            get => _id;
            private set => SetProperty(ref _id, value);
        }

        private string _card;
        public string Card
        {
            get => _card;
            set => SetProperty(ref _card, value);
        }

        private string _type;
        public string Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }

        private bool _status;
        public bool Status
        {
            get => _status;
            set => SetProperty(ref _status, value);
        }

        private double _price;
        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ① 无参构造函数：用于创建场景（如表单添加），Id 自动为 0
        public CardInfo()
        {
        }

        // ② 带Id构造函数：用于读取场景（如从数据库加载）
        public CardInfo(int id)
        {
            Id = id;
        }
    }
}