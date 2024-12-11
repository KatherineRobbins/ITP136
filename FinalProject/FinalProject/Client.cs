using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Client : Person
    {

        public Client (string fn, string ad, string em, int ap) : base ( fn, ad, em)
        {
            
            AnniversaryofPurchase = ap;
        }
       

        public int AnniversaryofPurchase { get; set; }
    }
}
