using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    public class Mahasiswa
    {
        public int No { get; set; }
        public string Nama { get; set; }
        public string Nim { get; set; }
        public int Nilai { get; set; }

        public Mahasiswa(int no, string nama, string nim, int nilai)
        {
            No = no;
            Nama = nama;
            Nim = nim;
            Nilai = nilai;
        }
    }
}
