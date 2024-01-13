using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RVP_Lab1_Yurl
{
    internal class Person : IPerson
    {
        public int CardNumber { get; set; }
        public string Name { get; set; }
        public DateTime Bithday { get; set; }
       
        public Person(string Name, DateTime Bithday, int CardNumber)
        {
            this.Name = Name;
            this.Bithday = Bithday;
            this.CardNumber = CardNumber;
        }
        public int calcAge(DateTime date) 
        {
            var Age=DateTime.Now.Year-date.Year;
            if (DateTime.Now.Month < date.Month ||
            (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) Age--;
            return Age;
        }
        public void SetCardNumber(int CardNumber) {this.CardNumber=CardNumber;}
        public void SetName(string Name) { this.Name = Name; }
        public void SetBithday(DateTime Bithday) {this.Bithday = Bithday;}


    }
}
