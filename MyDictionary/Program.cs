using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isim = new MyDictionary<int, string>();
            isim.Add(9,"Salih Gül");
            isim.Add(4, "Ali Candan");
            isim.Add(6, "Polat Alemdar");
            isim.Add(75, "Kadir Alıcı");
            isim.Add(786, "Rüştü Gelir");
            isim.Add(52, "Engin Demiroğ");
            isim.Add(31, "Hakan Arıcı");


            isim.ListShow();

            Console.ReadKey();
        }
    }
}
