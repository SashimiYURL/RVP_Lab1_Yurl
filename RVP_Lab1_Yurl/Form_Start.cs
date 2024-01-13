using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RVP_Lab1_Yurl
{
    public partial class Form_Start : Form
    {
        List<List<IPerson>> peoples = new List<List<IPerson>>();
        int Start;
        int count = 0;
        int countleft = 0;
        int countright = 0;
        int countPages=2;
        public Form_Start()
        {
            InitializeComponent();
            ListBox myListBox1 = new ListBox();
            myListBox1.Location = new Point(8, 6);
            myListBox1.Size = new Size(150, 200);
            ListBox myListBox2 = new ListBox();
            myListBox2.Location = new Point(8, 6);
            myListBox2.Size = new Size(150, 200);
            tabPage1.Controls.Add(myListBox1);
            peoples.Add(new List<IPerson>());
            tabPage2.Controls.Add(myListBox2);
            peoples.Add(new List<IPerson>());


        }

        private void Form_Start_Load(object sender, EventArgs e)
        {
          
        }
       


        private void buttonDeletion_Click(object sender, EventArgs e)
        {
            ListBox whichListbox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            if (whichListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали никакой элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Delit = MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Delit == DialogResult.Yes)
                {
                    peoples[tabControl1.SelectedIndex].RemoveAt(whichListbox.SelectedIndex);
                    whichListbox.Items.Remove(whichListbox.SelectedItem);
                }
            }
        }

        private void buttonCreation_Click(object sender, EventArgs e)
        {
            Form_People f2=new Form_People();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                int.TryParse(f2.CardPers, out int CardNum);
                peoples[tabControl1.SelectedIndex].Add(new Person(f2.NamePers,f2.Bithday,CardNum));
                ListBoxLoad();

            }
            f2.Close();

        }
        private void ListBoxLoad()
        {
            ListBox whichListbox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            whichListbox.Items.Add(peoples[tabControl1.SelectedIndex][peoples[tabControl1.SelectedIndex].Count - 1].Name + "-" + peoples[tabControl1.SelectedIndex][peoples[tabControl1.SelectedIndex].Count - 1].calcAge(peoples[tabControl1.SelectedIndex][peoples[tabControl1.SelectedIndex].Count-1].Bithday).ToString());
        }


        private void buttonChangePers_Click(object sender, EventArgs e)
        {
            ListBox whichListbox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            if (whichListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали никакой элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form_People f2 = new Form_People();
                f2.NamePers = peoples[tabControl1.SelectedIndex][whichListbox.SelectedIndex].Name;
                f2.Bithday = peoples[tabControl1.SelectedIndex][whichListbox.SelectedIndex].Bithday;
                f2.CardPers = peoples[tabControl1.SelectedIndex][whichListbox.SelectedIndex].CardNumber.ToString();
                f2.Block();

                if (f2.ShowDialog() == DialogResult.OK)
                {
                    peoples[tabControl1.SelectedIndex][whichListbox.SelectedIndex].SetName(f2.NamePers);
                    peoples[tabControl1.SelectedIndex][whichListbox.SelectedIndex].SetBithday(f2.Bithday);
                    int.TryParse(f2.CardPers, out int CardNum);
                    peoples[tabControl1.SelectedIndex][whichListbox.SelectedIndex].SetCardNumber(CardNum);
                    int index = whichListbox.SelectedIndex;
                    whichListbox.Items.RemoveAt(index);
                    ListBoxChanged(index);

                }
                f2.Close();
            }
            

        }
        private void ListBoxChanged(int i)
        {
            ListBox whichListbox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            whichListbox.Items.Insert(i,peoples[tabControl1.SelectedIndex][i].Name + "-" + peoples[tabControl1.SelectedIndex][i].calcAge(peoples[tabControl1.SelectedIndex][i].Bithday).ToString());
        }

       
        private void Form_Start_Move(object sender, EventArgs e)
        {
            ListBox whichListbox = tabControl1.TabPages[tabControl1.SelectedIndex].Controls.OfType<ListBox>().FirstOrDefault();
            if (count == 2) { Start=this.Location.X; }
            int x = this.Location.X;
            count++;
   
            if (x < Start) 
            { 
                countleft++;
                Start = x;
            }
            if (x > Start) 
            { 
                countright++;
                Start = x;
            }
            if (countleft >= 100 && countright>=100) 
            {
                
                whichListbox.Items.Clear();
                countleft = 0;
                countright = 0;
            }
            
            
        }

        private void buttonAddTab_Click(object sender, EventArgs e)
        {
            countPages++;
            string title = "tabPage " + (countPages).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(CreateNewListbox());
            tabControl1.TabPages.Add(myTabPage);
            peoples.Add(new List<IPerson>());

        }
        private ListBox CreateNewListbox()
        {
            ListBox myListBox = new ListBox();
            myListBox.Location = new Point(8, 6);
            myListBox.Size = new Size(150, 200);
            return myListBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                peoples.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                countPages--;
               
            }
            else
            {
                MessageBox.Show("Нельзя удалить последнюю вкладку!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        
    }
}
