﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("Koneksi ke Database\n");
                    Console.WriteLine("Masukkan User ID :");
                    string user = Console.ReadLine();
                    Console.WriteLine("Masukkan Password :");
                    string pass = Console.ReadLine();
                    Console.WriteLine("Masukkan  database tujuan:");
                    string db = Console.ReadLine();
                    Console.Write("\nKetik K untuk terhubung ke database:");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "Data Source = LAPTOP-8VUKFT0D\\DESTAKKA;" +
                                    "initial catalog = {0}; " +
                                    "User ID = {1}; password = {2}";
                                conn = new SqlConnection(string.Format(strKoneksi, db, user, pass));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Melihat Seluruh Data");
                                        Console.WriteLine("2. Tambah Data");
                                        Console.WriteLine("3. Keluar");
                                        Console.Write("\nEnter your choice (1-3): ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("DATA MAHASISWA\n");
                                                    Console.WriteLine();
                                                    pr.baca(conn);
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INPUT DATA PEMBELI\n");
                                                    Console.WriteLine("Masukkan id_pembeli :");
                                                    string pl = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Pembeli :");
                                                    string np = Console.ReadLine();
                                                    Console.WriteLine("Masukkan NO Telepon :");
                                                    string nt = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Alamat Pembeli :");
                                                    string ap = Console.ReadLine();


                                                }
                            }
                    }
                }
            }
        }
    }
}
