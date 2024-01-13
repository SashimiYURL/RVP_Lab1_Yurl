using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RVP_Lab1_Yurl
{
    public partial class Form_Vip : Form
    {
        public string Password
        {
            get { return comboBox_Login.Text+textBox_password.Text; }
        }
        public Form_Vip()
        {
            InitializeComponent();
            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            comboBox_Login.SelectedItem = "user";
        }
        public void Block()
        {
            textBox_password.Enabled = false;
        }

       

        private void comboBox_Login_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Login.SelectedIndex == 1)
            {
                textBox_password.Enabled = true;
            }
            else if(comboBox_Login.SelectedIndex == 0)
            {
                textBox_password.Enabled=false;
            }
        }
    }
}
