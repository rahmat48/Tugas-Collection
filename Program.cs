using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasMix.Kelas_Anak;
using TugasMix.Kelas_Induk;

namespace TugasMix
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "123-3221-245";
            karyawantetap.Nama = "Bejo ";
            karyawantetap.GajiBulanan = 5000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "19-11-2863";
            karyawanharian.Nama = "Rahmat Dwi";
            karyawanharian.JumlahJamKerja = 12;
            karyawanharian.UpahPerJam = 150000;

            Sales seles = new Sales();
            seles.Nik = "123-0804-202";
            seles.Nama = "Budi Mulyadi";
            seles.JumlahPenjualan = 12;
            seles.Komisi = 500000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(seles);

            int no = 1;
            foreach(Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}",
                no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                no++;
            }
            Console.ReadKey();
        }
    }
}
