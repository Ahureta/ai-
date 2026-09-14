using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _8_29.Info
{
    public class UserInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        public int Id
        {
            get => _id;
            private set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _idCard;
        public string IdCard
        {
            get => _idCard;
            set => SetProperty(ref _idCard, value);
        }

        private DateTime _regTime;
        public DateTime RegTime
        {
            get => _regTime;
            set => SetProperty(ref _regTime, value);
        }

        private string _gender;
        public string Gender
        {
            get => _gender;
            set => SetProperty(ref _gender, value);
        }

        private string _tel;
        public string Tel
        {
            get => _tel;
            set => SetProperty(ref _tel, value);
        }

        private string _motto;
        public string Motto
        {
            get => _motto;
            set => SetProperty(ref _motto, value);
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // ① 无参构造函数：用于"创建"场景（表单添加），Id 自动为 0，Uid 自动生成
        public UserInfo()
        {            
            RegTime = DateTime.Now;  // 注册时间默认为当前时间
        }

        // ② 带Id构造函数：用于"读取"场景（从数据库加载）
        public UserInfo(int id)
        {
            Id = id;            
        }
    }
}