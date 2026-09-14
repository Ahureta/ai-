using _8_29.Data.Repositories;
using _8_29.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _9_12车辆租还
{
    public partial class Form3 : Form
    {
        public UserInfo SavedUser { get; private set; } = new();
        public Form3()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private async void button1_Click(object? sender, EventArgs e)
        {
            SavedUser.Name = input1.Text;
            SavedUser.IdCard = input2.Text;
            SavedUser.Gender = input3.Text;
            SavedUser.Tel = input4.Text;
            SavedUser.Motto = input5.Text;
            
            ICarRepository bookRepository = new CarRepository();                      

            if (await bookRepository.UserAddAsync(SavedUser) != 0) this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
