using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _10_14
{

    public class BookInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));      //通知属性名改变，而不是值（防取值过程处理）
        }

        protected bool SetProperty<T>(
            ref T field,
            T value,
            [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))       //防UI刷新卡顿
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private string _name = "";
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
            //                        ↑ ↑
            // SetProperty 第三个参数 [CallerMemberName] 自动拿到 "Name"
        }
    }
}
