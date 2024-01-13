using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RVP_Lab1_Yurl
{
    public partial class Form_People : Form
    {
        string passwordAdmin= "gRuF1uJkdNEaDDMgGi2+Kw==";//пароль sashimi20
        bool Admin = false;
        string cardNum;
        public string NamePers
        {
            get { return textBox_Name.Text; }
            set { textBox_Name.Text = value; }
        }
        
        public string CardPers
        {
            get { return textBox_CardNum.Text; }
            set { textBox_CardNum.Text = value; }
        }
        public DateTime Bithday
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public Form_People()
        {
            InitializeComponent();
            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            



        }

        private void Form_People_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox_CardNum_TextChanged(object sender, EventArgs e)
        {
            textBox_CardNum.MaxLength=5;
            if (textBox_CardNum.Text.Length == 5)
            {
                int.TryParse(CardPers, out int parseCard);
                if (parseCard < 10000)
                {
                    MessageBox.Show("Неккоректный номер карты");
                    textBox_CardNum.Clear();
                }
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
        public void Block()
        {
            dateTimePicker1.Enabled=false;
            textBox_CardNum.Enabled=false;
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void Form_People_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox_CardNum.Enabled == false)
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.L)
                {
                    Form_Vip f3 = new Form_Vip();
                    
                    f3.Block();
                    if (f3.ShowDialog() == DialogResult.OK)
                    {
                        
                        if (passwordAdmin == GetHash(f3.Password))
                        {
                            dateTimePicker1.Enabled = true;
                            textBox_CardNum.Enabled=true;
                            cardNum = textBox_CardNum.Text;
                            this.BackColor=Color.Red;
                            Admin = true;


                        }
                        else
                        {
                            MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        

        private void buttonSave_MouseMove(object sender, MouseEventArgs e)
        {
            if (Admin == true && cardNum!=textBox_CardNum.Text)
            {
                Random r = new Random();
                buttonSave.Left = r.Next(0, this.ClientSize.Width - buttonSave.Width);
                buttonSave.Top = r.Next(0, this.ClientSize.Height - buttonSave.Height);
            }
            

        }

        private void textBox_CardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num=e.KeyChar;
            if(!Char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }

        }
    }
}
