using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_29
{
    public partial class BookControl : UserControl
    {
        public BookControl()
        {
            InitializeComponent();
        }
        public BookControl(string Operation)
        {
            InitializeComponent();
            BookOperationLB.Text = Operation;
            BookOperationBT.Text = Operation;
        }
    }
}
