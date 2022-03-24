using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200140003_Tugas2_B
{
    class Program
    {
        public void InBarang()
        {
            string id, nama, jenis;
            int stok, harga;

            Console.WriteLine("Input Data Obat/Barang");
            Console.WriteLine("----------------------");

            Console.Write("Masukkan ID Barang (OBxxxx) \t: ");
            id = Console.ReadLine();

            Console.Write("Masukkan nama Barang \t\t: ");
            nama = Console.ReadLine();

            Console.Write("Masukkan kategori barang \t: ");
            jenis = Console.ReadLine();

            Console.Write("Masukkan jumlah stok barang \t: ");
            stok = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Harga barang \t: Rp. ");
            harga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MKB157K;database=PABD_Tugas2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Obat (idBarang, namaBarang, jenisBarang, stokBarang, hargaBarang)" +
                    "values( '" + id + "' , '" + nama + "', '" + jenis + "'," + stok + ", " + harga + ")", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InApoteker()
        {
            string id, nama, jk, Alamat;
            long noTelp;

            Console.WriteLine("Input Data Pegawai Apoteker");
            Console.WriteLine("---------------------------");

            Console.Write("Masukkan ID Pegawai (APxxxx) \t: ");
            id = Console.ReadLine();

            Console.Write("Masukkan Nama Pegawai \t\t: ");
            nama = Console.ReadLine();

            Console.Write("Masukkan Jenis Kelamin (L/P) \t: ");
            jk = Console.ReadLine();

            Console.Write("Masukkan Nomor Telepon \t\t: ");
            noTelp = Convert.ToInt64(Console.ReadLine());

            Console.Write("Masukkan Alamat \t\t: ");
            Alamat = Console.ReadLine();

            Console.WriteLine("---------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MKB157K;database=PABD_Tugas2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Apoteker (idPegawai, Nama, Jenis_Kelamin, noTelp, Alamat)" +
                    "values( '" + id + "' , '" + nama + "', '" + jk + "'," + noTelp + ", '" + Alamat + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InPelanggan()
        {
            string id, nama, jk, Alamat;
            long noTelp;

            Console.WriteLine("Input Data Pelanggan Apotek");
            Console.WriteLine("---------------------------");

            Console.Write("Masukkan ID Pelanggan (CTxxxx) \t: ");
            id = Console.ReadLine();

            Console.Write("Masukkan Nama Pelanggan \t: ");
            nama = Console.ReadLine();

            Console.Write("Masukkan Jenis Kelamin (L/P) \t: ");
            jk = Console.ReadLine();

            Console.Write("Masukkan Nomor Telepon \t\t: ");
            noTelp = Convert.ToInt64(Console.ReadLine());

            Console.Write("Masukkan Alamat \t\t: ");
            Alamat = Console.ReadLine();

            Console.WriteLine("---------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MKB157K;database=PABD_Tugas2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Pelanggan (idPelanggan, Nama, Jenis_Kelamin, noTelp, Alamat)" +
                    "values( '" + id + "' , '" + nama + "', '" + jk + "'," + noTelp + ", '" + Alamat + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InSupplier()
        {
            string id, nama, Alamat;
            long noTelp;

            Console.WriteLine("Input Data Supplier Apotek");
            Console.WriteLine("--------------------------");

            Console.Write("Masukkan ID Supplier (SPxxxx) \t: ");
            id = Console.ReadLine();

            Console.Write("Masukkan Nama Perusahaan \t: ");
            nama = Console.ReadLine();

            Console.Write("Masukkan Nomor Telepon \t\t: ");
            noTelp = Convert.ToInt64(Console.ReadLine());

            Console.Write("Masukkan Alamat \t\t: ");
            Alamat = Console.ReadLine();

            Console.WriteLine("--------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MKB157K;database=PABD_Tugas2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Supplier (idSupplier, namaSupplier, noTelp, Alamat)" +
                    "values( '" + id + "' , '" + nama + "', " + noTelp + ", '" + Alamat + "')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InJual()
        {
            string idJual, idPegawai, idPelanggan, idBarang, date;
            int qty, total;

            Console.WriteLine("Input Data Transaksi Penjualan");
            Console.WriteLine("------------------------------");

            Console.Write("Masukkan ID Penjualan (TJxxxx) \t: ");
            idJual = Console.ReadLine();

            Console.Write("Masukkan ID Pegawai (APxxxx) \t: ");
            idPegawai = Console.ReadLine();

            Console.Write("Masukkan ID Pelanggan (CTxxxx) \t: ");
            idPelanggan = Console.ReadLine();

            Console.Write("Masukkan ID Barang (OBxxxx) \t: ");
            idBarang = Console.ReadLine();

            Console.Write("Masukkan Banyak Barang \t\t: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Tanggal Transaksi (YYYY/MM/DD) : ");
            date = Console.ReadLine();

            Console.Write("Masukkan Total Harga \t\t: Rp.  ");
            total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MKB157K;database=PABD_Tugas2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Trx_Jual (idJual, idPegawai, idPelanggan, idBarang, qtyBarang, tanggal_trx, total_trx)" +
                    "values( '" + idJual + "' , '" + idPegawai + "' ,  '" + idPelanggan + "' , '" + idBarang + "' , " + qty + " , '" + date + "', " + total + ")", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InBeli()
        {
            string idBeli, idPegawai, idSupplier, namaBarang, date;
            int qty, total;

            Console.WriteLine("Input Data Transaksi Pembelian");
            Console.WriteLine("------------------------------");

            Console.Write("Masukkan ID Pembelian (TBxxxx) \t: ");
            idBeli = Console.ReadLine();

            Console.Write("Masukkan ID Pegawai (APxxxx) \t: ");
            idPegawai = Console.ReadLine();

            Console.Write("Masukkan ID Supplier (SPxxxx) \t: ");
            idSupplier = Console.ReadLine();

            Console.Write("Masukkan nama barang \t\t: ");
            namaBarang = Console.ReadLine();

            Console.Write("Masukkan Banyak Barang \t\t: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Tanggal Transaksi (YYYY/MM/DD) : ");
            date = Console.ReadLine();

            Console.Write("Masukkan Total Harga \t\t: Rp.  ");
            total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------\n");

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MKB157K;database=PABD_Tugas2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Trx_Beli (idBeli, idSupplier, idPegawai, namaBarang, qtyBarang, tanggal_trx, total_trx)" +
                    "values( '" + idBeli + "' , '" + idSupplier + "' ,  '" + idPegawai + "' , '" + namaBarang + "' , " + qty + " , '" + date + "', " + total + ")", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            int ch;
            Program p = new Program();

            Console.WriteLine("Aplikasi Pendataan Apotek ini.");
            Console.WriteLine("------------------------------");

            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Input Data Obat/Barang.");
                Console.WriteLine("2. Input Data Pegawai/Apoteker");
                Console.WriteLine("3. Input Data Pelanggan");
                Console.WriteLine("4. Input Data Supplier");
                Console.WriteLine("5. Input Data Transaksi Penjualan");
                Console.WriteLine("6. Input Data Transaksi Pembelian");
                Console.WriteLine("7. Exit");
                Console.Write("\nEnter your choice (1-7): ");
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        {
                            p.InBarang();
                        }
                        break;
                    case 2:
                        {
                            p.InApoteker();
                        }
                        break;
                    case 3:
                        {
                            p.InPelanggan();
                        }
                        break;
                    case 4:
                        {
                            p.InSupplier();
                        }
                        break;
                    case 5:
                        {
                            p.InJual();
                        }
                        break;
                    case 6:
                        {
                            p.InBeli();
                        }
                        break;
                    case 7:
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }

            }
        }
    }
}
