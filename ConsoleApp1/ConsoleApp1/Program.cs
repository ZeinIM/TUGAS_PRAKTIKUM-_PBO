using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tugaspraktikum1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

/*          laptop1.ngoding(); #Soal nomor 2, kalau dijalankan, akan error*/ 

/*          Console.WriteLine(laptop1);
            Console.WriteLine(laptop1.vga);
            Console.WriteLine(laptop1.processor);  #Soal nomor 3 */

            Laptop laptop2 = new Ideapad();
            laptop2.vga = new AMD_Vga();
            laptop2.processor = new Ryzen();

            laptop2.LaptopDinyalakan(); /*#Soal nomor 1*/ 

            Predator predator = new Predator();
            predator.vga = new AMD_Vga();
            predator.processor = new Corei7();
            /*predator.BermainGame(); #Soal nomor 4*/

            /*ACER acer = new Predator();
            acer.BermainGame(); #Soal nomor 5*/
        }
    }
    
    internal class Vivobook : Laptop
    {
    }

    class Processor
    {
        public string merk, tipe;
    }
    class Intel : Processor
    {
        public Intel()
        {
            base.tipe = "Intel";
        }
    }
    class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "CoreI3";
        }
    }
    class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "CoreI5";
        }
    }
    class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core I7";
        }
    }

    class AMD : Processor
    {
        public string merk;
    }
    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "Athlon";
        }
    }


    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD_Vga : Vga
    {
        public AMD_Vga()
        {
            base.merk = "AMD_Vga";
        }
    }


    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;
        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop " + merk + tipe + "menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop " + merk + tipe + "mati");
        }
        class ASUS : Laptop
        {
            public string merk;
        }
        class ROG : ASUS
        {
            public string tipe;
        }
        class Vivobook : ASUS
        {
            public Vivobook()
            {
                base.tipe = "Vivobook";
            }
            public void Ngoding()
            {
                Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
            }
        }


        class ACER : Laptop
        {
            public string merk;
        }
        class Swift : ACER
        {
            public Swift()
            {
                base.merk = "Swift";
            }
        }
        class Predator : ACER
        {
            public Predator()
            {
                base.tipe = "Predator";
            }
            public void BermainGame()
            {
                Console.WriteLine("Laptop" + merk + tipe + "sedang memainkan game");
            }
        }


        class Lenovo : Laptop
        {
            public string merk;
        }
        class Ideapad : Lenovo
        {
            public Ideapad()
            {
                base.merk = "Ideapad";
            }
        }
        class Legion : Lenovo
        {
            public Legion()
            {
                base.merk = "Legion";
            }
        }
    }
}

    
