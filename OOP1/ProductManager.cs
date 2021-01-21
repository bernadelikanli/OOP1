using System;
using System.Collections.Generic;
using System.Text;
//manager Operasyon dosyası
namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //encapsulation
        {
            Console.WriteLine(product.ProductName+" Eklendi");
        }
        public void Update(Product product)     //void=
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        
    }
}

//int str double değer tip değişmez     
//class diziler  referans tip değişir