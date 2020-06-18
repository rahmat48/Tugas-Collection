using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasMix.Kelas_Induk;

namespace TugasMix.Kelas_Anak
{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get;set; }
        public int Komisi { get;set; }
        public override string Nama { get;set; }
        public override string Nik { get;set; }

        public override double gaji()
        {
            return Komisi*JumlahPenjualan;
        }
    }
}
