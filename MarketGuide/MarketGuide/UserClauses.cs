using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MarketGuide
{
    internal class UserClauses
    {
        public double SellClause {  get; }
        public double BuyClause { get; }

        public UserClauses(string[] args)
        {
            SellClause = double.Parse(args[1], CultureInfo.InvariantCulture);
            BuyClause = double.Parse(args[2], CultureInfo.InvariantCulture);
        }

        public bool CheckClauses(double price)
        {
            if (BuyClause > price)
            {
                Console.WriteLine("Enviar email BUY");
            }

            if (SellClause < price)
            {
                Console.WriteLine("Enviar email SELL");
            }
            return true;
        }
    }
}
