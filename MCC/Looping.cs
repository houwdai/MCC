using System;
using System.Collections.Generic;
using System.Text;

namespace MCC
{
    public class Looping
    {
        public static void Exec()
        {
            string[,] Karyawan = new string[,] {
                {"001", "Adi Wiranto", "Engineering"},
                {"002", "Mahesa Akbar", "Developer" },
                {"003", "Adi Wiranto" ,"Operation"},

            };
            for (int i = 0; i < Karyawan.GetLength(0); i++)
            {
                Console.Write("Karyawan ");
                Console.WriteLine(i+1);

                for (int j = 0; j < Karyawan.GetLength(1); j++)
                {
                    Console.WriteLine(Karyawan[i, j]);
                }
            }
           

        }
    }
}

