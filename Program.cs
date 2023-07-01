using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    public class Program
    {
        static void Main(string[] args) 
        {
            // Membuat array untuk menampung objek Mahasiswa
            Mahasiswa[] mahasiswas = new Mahasiswa[3];

            // Membuat objek Mahasiswa dan menambahkannya ke array
            Mahasiswa mahasiswa1 = new Mahasiswa(1, "1234", "Erik", 75);
            mahasiswas[0] = mahasiswa1;

            Mahasiswa mahasiswa2 = new Mahasiswa(2,  "1235", "Wely", 80);
            mahasiswas[1] = mahasiswa2;

            Mahasiswa mahasiswa3 = new Mahasiswa(3, "1235", "Sony", 95);
            mahasiswas[2] = mahasiswa3;

            // Menampilkan data mahasiswa dalam bentuk tabel
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-10}", "No", "NIM", "Nama", "Nilai");
            Console.WriteLine("-----------------------------------------------------");
            foreach (Mahasiswa mahasiswa in mahasiswas)
            {
                Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-10}", mahasiswa.No, mahasiswa.Nim, mahasiswa.Nama, mahasiswa.Nilai);
            }
        }
    }
}
