using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GİRİLEN_METNİ_HARF_HARF_YAZDIRAN_PROGRAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int sayac1 = 0;
            Console.Write("METİN GİRİNİZ :");
            string metin = Console.ReadLine();
            string sesli = "aeıiuüoöAEIİUÜOÖ";
            string Sessiz = "zyvtşsrpnrmlkhjğgdçcbZYVTŞSRPNRMLKHJĞGDÇCB";
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                }
                if (Sessiz.Contains(metin[i]))
                {
                    sayac1++;
                }
            }
            
            Console.WriteLine("METİNDE BULUNAN HARF SAYISI :" +metin.Count());
            Console.WriteLine("METİNDE BULUNAN SESLİ HARF SAYISI :" + sayac);
            Console.WriteLine("METİNDE BULUNAN SESSİZ HARF SAYISI :" + sayac1);
            Console.ReadKey();

        }
    }
}
