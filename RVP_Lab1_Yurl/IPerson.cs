using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVP_Lab1_Yurl
{
    public interface IPerson
    {
        int CardNumber { get; }
        string Name { get; }
        DateTime Bithday { get; }
        int calcAge(DateTime date);
        void SetName(string name);
        void SetBithday(DateTime date);
        void SetCardNumber(int cardNumber);
    }
}
