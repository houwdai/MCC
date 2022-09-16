using System;
using System.Collections.Generic;
using System.Text;

namespace MCC
{
    public class Decicions
    {

        public static void Decision()
        {
            Console.WriteLine("##  Program Menghitung Gaji Karyawan  ##");
            string nama;
            string golongan;
            int jam_kerja, upah_per_jam, total_upah;

            // proses input
            Console.Write("Nama Karyawan: ");
            nama = Console.ReadLine();

            Console.Write("Golongan: ");
            golongan = Console.ReadLine();

            
            Console.Write("Jumlah jam kerja: ");
            string input_jamKerja = Console.ReadLine();
            jam_kerja = Int32.Parse(input_jamKerja);

            // tentukan jumlah upah per jam berdasarkan golongan
            switch (golongan)
            {
                case "A":
                   
                    upah_per_jam = 5000;
                    total_upah = jam_kerja * upah_per_jam;
                    Console.Write(" menerima upah Rp.");
                    Console.Write(total_upah);
                    Console.Write(" per minggu");

                    break;
                case "B":
                    upah_per_jam = 7000;
                    total_upah = jam_kerja * upah_per_jam;
                    Console.Write(" menerima upah Rp.");
                    Console.Write(total_upah);
                    Console.Write(" per minggu");

                    break;
                case "C":
                    upah_per_jam = 8000;
                    total_upah = jam_kerja * upah_per_jam;
                    Console.Write(" menerima upah Rp.");
                    Console.Write(total_upah);
                    Console.Write(" per minggu");

                    break;
                case "D":
                    upah_per_jam = 10000;
                    total_upah = jam_kerja * upah_per_jam;
                    Console.Write(" menerima upah Rp.");
                    Console.Write(total_upah);
                    Console.Write(" per minggu");
                    break;
            }

        }
    }
}
