using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasMix.Kelas_Induk;

namespace TugasMix.Kelas_Anak
{
    public class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; set; }
        public override string Nama { get; set; }
        public override string Nik { get; set; }

        public override double gaji()
        {
            return this.GajiBulanan;
        }
    }
}
