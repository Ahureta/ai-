using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_29
{
    public partial class Child : UserControl
    {
        public Child()
        {
            InitializeComponent();
        }
        public Child(string userName,string userAge)
        {
            userNamePT.Text = userName;
            userAgePT.Text = userAge;
        }
    }
}
