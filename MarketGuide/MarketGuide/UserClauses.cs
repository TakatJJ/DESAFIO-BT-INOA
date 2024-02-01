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

        public async Task CheckClauses(double price , string ativo, List<string> contacts)
        {
            EmailSender sender = new EmailSender();
            
            if (BuyClause > price)
            {
                foreach (string contact in contacts) 
                {
                    await sender.SendEmailAsync("dummietestbr@outlook.com", "Buy", "compra", ativo);
                }
                
            }

            if (SellClause < price)
            {
                foreach (string contact in contacts) 
                {
                    await sender.SendEmailAsync("dummietestbr@outlook.com", "Sell", "venda", ativo);
                }
     
            }
            return ;
        }
    }
}
