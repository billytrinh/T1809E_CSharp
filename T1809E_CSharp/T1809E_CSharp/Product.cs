using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product()
        {
            this.gallery = new List<string>();
        }

        public Product(int id, string name, decimal price, int qty, 
            string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = new List<string>();
        }

        public void getInfo()
        {
            Console.WriteLine("id: "+id);
            Console.WriteLine("name: "+name);
            Console.WriteLine("price: "+price);
            Console.WriteLine("qty: "+qty);
            Console.WriteLine("image: "+image);
            Console.WriteLine("desc: "+desc);
            foreach (string s in gallery)
            {
                Console.WriteLine(s);
            }
        }

        public bool CheckQty()
        {
            if (qty > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddGallery(string img)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(img);
                return true;
            }
            Console.WriteLine("Vuot qua so anh cho phep");
            return false;
        }

        public void AddGallery2()
        {
            if (gallery.Count < 10)
            {
                string img = Console.ReadLine();
                gallery.Add(img);
                return;
            }
            Console.WriteLine("Vuot qua so anh cho phep");
        }

        public void RemoveGallery()
        {
            int i = 0;
            foreach (string s in gallery)
            {
                Console.WriteLine(i+". "+ s);
                i++;
            }
            Console.WriteLine("Nhap vi tri anh muon xoa:");
            int n = Convert.ToInt16(Console.ReadLine());
            gallery.RemoveAt(n);
        }

        public bool RemoveGallery(int n)
        {
            if (n < gallery.Count)
            {
                gallery.RemoveAt(n);
                //gallery.Remove("afafaafa");
                return true;
            }
            Console.WriteLine("Khong tim thay anh hoac khong the xoa");
            return false;
        }
        
    }

}