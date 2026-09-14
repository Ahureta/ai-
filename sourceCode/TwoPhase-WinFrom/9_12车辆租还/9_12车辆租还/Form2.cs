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
    public partial class Form2 : Form
    {
        public CardInfo SavedCar { get; private set; } = new CardInfo();      
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }        

        private async void button1_Click(object sender, EventArgs e)
        {
            SavedCar.Card = input1.Text;
            SavedCar.Type = input2.Text;
            if (!double.TryParse(input3.Text, out double price)) {
                MessageBox.Show("价格不合规");
                return;
            }
            SavedCar.Price = price;
            SavedCar.Status = false;

            ICarRepository bookRepository = new CarRepository();            

            if (await bookRepository.CarAddAsync(SavedCar)!=0)  this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
