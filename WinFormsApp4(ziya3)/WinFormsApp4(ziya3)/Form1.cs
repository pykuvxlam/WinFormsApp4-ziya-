using System;
using System.Windows.Forms;

namespace WinFormsApp4__ziya_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string fio = textBoxFio.Text;
            int age = (int)numericAge.Value;
            string gender = comboGender.SelectedItem?.ToString() ?? "не выбран";

            labelResult.Text = $"ФИО: {fio}\nВозраст: {age}\nПол: {gender}";
        }
    }
}
