using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace practice
{
 
    class Program
    {

        static void Main(string[] args)
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("http://codeforces.com/problemset");
            int i = 0;
            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table/tr"))
            {
                i++;
                    
                foreach (HtmlNode cell in table.SelectNodes("//td[2]/div[1]"))
                {
                       Console.WriteLine(cell.InnerText);
                }
                

            }
           
        }



    }
}
