using System;
namespace materi;
class Program
{
    static void Main(string[] args)
    {
        Materi.TipeData();
        Console.WriteLine();

        Materi.AritmatikaDanLogika();
        Console.WriteLine();

        Materi.ArrayDanList();
        Console.WriteLine();

        Materi.KondisiDanPerulangan();
        Console.WriteLine();

        // jika menggunakan return maka bisa: 
        int fungsi = Materi.Contoh(); // nilai return dapat ditaruh ke variable lain
        Console.WriteLine(fungsi); 
        Console.WriteLine(Materi.Contoh()); // nilai return dapat langsung ditaruh ke Console.WriteLine()
    }


}
