using System;
using System.Collections.Generic;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            //Ogrenci.Add(10,"Ahmet");
            //Console.WriteLine(Ogrenci[10]); // yazdırmak için sadece ögrenci numarası giriliyor ama ödevde istenen sadece add komutu o yüzden sadece add komutu yazıldı 
            MyDictionary<int,string> isimler = new MyDictionary<int, string>();
            isimler.Add(10,"Ahmet");
            isimler.Add(20,"Engin");
            isimler.Add(10,"Büşra");
            
        }
    }
}
