using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace _8_29.Info
{
    public class BookInfo: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        public int Id
        {
            get => _id;
            private set => SetProperty(ref _id, value);
        }

        private string _uid;
        public string Uid
        {
            get => _uid;
            private set => SetProperty(ref _uid, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _author;
        public string Author
        {
            get => _author;
            set => SetProperty(ref _author, value);
        }

        private double _price;
        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        private string _label;
        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

        private bool _isBorrow;
        public bool IsBorrow
        {
            get => _isBorrow;
            set => SetProperty(ref _isBorrow, value);
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //private int _Id { get; set; }
        //public int Id
        //{ 
        //    get 
        //    {
        //        return _Id;
        //    }
        //    private set 
        //    {
        //        _Id = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
        //    } 
        //}
        //public string Uid { get; private set; }
        //public string Name { get; set; }
        //public string Author { get; set; }
        //public double Price { get; set; }
        //public string Label { get; set; }
        //public bool IsBorrow { get; set; }


        // ① 无参构造函数：用于“创建”场景（表单添加），Id 自动为 0
        public BookInfo()
        {
            Uid = Guid.NewGuid().ToString();            
        }

        // ② 带Id构造函数：用于“读取”场景（从数据库加载）
        public BookInfo(int id, string uid)
        {
            Id = id;
            Uid = uid;         
        }
    }
}