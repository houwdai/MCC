using MCC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MCC_DTS  //name space adalah folder 
{
    public class Program //folder root nya
    {
        public static void Main()
        {
            var gajiCEO = new CEO();
            var staff1 = new staff();

            //Mulai
            Console.WriteLine("Sebelum Memulai Perhatikan Beberapa Hal Berikut");
            Console.WriteLine("Jabatan Hanya ada \"Staff\" dan \"CEO\" ");
            Console.WriteLine("Huruf CEO harus capital dan S pada staff juga kapital ");

            Console.Write(" Masukkan Nama Pekerja : ");

            string name = Console.ReadLine();
            Console.Write(" Masukkan Status : ");

            string Status = Console.ReadLine();
            if (Status == "CEO")
            {
                double CEOgaji = 1000000;
                gajiCEO.pegawai(name, CEOgaji);

                Console.WriteLine("Bonus = Rp." + gajiCEO.bonus);
                Console.WriteLine("Tunjangan = Rp." + gajiCEO.tunjangan);
                Console.Write("Total Bonus = Rp.");
                Console.WriteLine(gajiCEO.Process());
            }
            else if (Status == "Staff"){
                double staffGaji = 5000000;
                staff1.pegawai(name, staffGaji);
                Console.WriteLine("Bonus = Rp." + staff1.bonus);
                Console.WriteLine("Tunjangan = Rp." + staff1.tunjangan);
                Console.Write("Total Bonus = Rp.");
                Console.WriteLine(staff1.Process());
            }

            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("Penerapan Kasus Looping For");
            Looping.Exec();

            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("Penerapan Kasus Decision CASE");
            Decicions.Decision();

        }
    }
    public class CEO : SlipGaji
    {
        public double bonus { get; set; }
        public double tunjangan { get; set; }
        public CEO()
        {
            bonus = 10000; tunjangan = 7000;
        }

        public override double Process()
        {
            return bonus + tunjangan;
        }

    }
    public class staff : SlipGaji
    {
        public double bonus { get; set; }
        public double tunjangan { get; set; }
        public staff()
        {
            bonus = 5000; tunjangan = 5000;
        }

        public override double Process()
        {
            return bonus + tunjangan;
        }

    }
    public abstract class SlipGaji
    {
        public abstract double Process();
        public void pegawai(string name, double gaji)
        {
            Console.WriteLine("");
            Console.WriteLine("========Slip Gaji Karyawan=======");
            Console.WriteLine("Nama Karyawan = " + name);
            Console.WriteLine("Gaji = Rp. " + gaji);

        }
    }



}

