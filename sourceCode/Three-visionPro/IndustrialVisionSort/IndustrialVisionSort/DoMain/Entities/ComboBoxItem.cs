using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Entities
{
    internal class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;  // ComboBox 下拉显示这个
        }
    }
}
