using System;
namespace materi;

class Materi {
    public static void TipeData() { // function void artinya tanpa kembalian(return)
        int num = 10; // deklarasi variable dengan menggunanakan tipe data int (angka)
        float num1 = 5.67f; // deklarasi variable dengan menggunakan tipe data float (7 digit desimal)
        double num2 = 5.67; // deklarasi variable dengan menggunakan tipe data double (15 digit desimal)
        decimal num3 = 3.67m; // deklarasi variable dengan menggunakan tipe data decimal (28 digit desimal)
        string kata = "halo"; // deklarasi variable dengan menggunakan tipe data string (kalimat)
        string num4 = "5"; // deklarasi variable dengan menggunakan tipe data string (angka)
        bool kebenaran = true; // deklarasi variable dengan menggunakan tipe data bool (true/false)
        var rand = 4; // deklarasi variable dengan menggunakan tipe data var (akan otomatis di konversi ke tipe data sesungguhnya)
        const float phi = 3.14f; // deklarasi variable menggunakan const, artinya nilai phi tidak dapat diubah

        string newLine = "\n"; // akan membuat baris baru
        string tab = "\t"; // akan memberikan tab
        string namaDepan = "michael";
        string namaBelakang = "kurniawan";
        string namaLengkap = namaDepan + " " + namaBelakang; // melakukan concatenate(penggabungan kata)

        int berubah = (int)num1; // casting tipe data float menjadi int
        string berubah1 = num.ToString(); // casting tipe data int menjadi string
        int berubah2 = int.Parse(num4); // casting tipe data string(angka) menjadi int

        // string interpolation $" ", dapat mengambil isi variable dalam Console.WriteLine ataupun dalam string;
        Console.Write($"{num}, {num1}, {num2}, {num3}, {kata}, {num4}, {kebenaran}, {rand}, {phi}, {tab}, {newLine}");
        Console.WriteLine($"nama: {namaLengkap.ToUpper()}"); // mengubah dari lowercase menjadi uppercase
        Console.WriteLine($"sebelum: {num1.GetType()}, menjadi: {berubah.GetType()}"); // megambil tipe data
        Console.WriteLine($"sebelum: {num.GetType()}, menjadi: {berubah1.GetType()}"); // megambil tipe data
        Console.WriteLine($"sebelum: {num4.GetType()}, menjadi: {berubah2.GetType()}"); // megambil tipe data
    }

    public static void AritmatikaDanLogika() { // function void artinya tanpa kembalian(return)
        int hasil = 1 + 1; // operator penjumlahan
        int hasil1 = 2 - 1; // operator pengurangan
        int hasil2 = -1; // angka minus
        int hasil3 = 1 * 2; // operator perkalian
        int hasil4 = 2 / 2; // operator pembagian
        int hasil5 = 3 % 2; // operator modulus (sisa bagi)
        hasil += hasil1; // seperti hasil = hasil + hasil1 

        Console.WriteLine($"{hasil}, {hasil1}, {hasil2}, {hasil3}, {hasil4}, {hasil5}");
        Console.WriteLine($"kebenaran: {hasil1 > hasil2}"); // operasi lebih besar
        Console.WriteLine($"kebenaran: {hasil1 < hasil2}"); // operasi lebih kecil
        Console.WriteLine($"kebenaran: {hasil1 >= hasil2}"); // operasi lebih besar atau sebanding
        Console.WriteLine($"kebenaran: {hasil1 <= hasil2}"); // operasi lebih kecil atau sebanding
        Console.WriteLine($"kebenaran: {hasil1 == hasil2}"); // operasi sebanding
        Console.WriteLine($"kebenaran: {hasil1 >= hasil2 && hasil1 < hasil2}"); // operasi and (semua harus true maka hasilnya akan true)
        Console.WriteLine($"kebenaran: {hasil1 == hasil2 || hasil1 > hasil2}"); // operasi (salah satu true maka hasilnya akan true)
        Console.WriteLine($"kebenaran: {!(hasil1 == hasil2)}"); // operasi negasi (akan dibalik)
    }

    public static void ArrayDanList() { // function void artinya tanpa kembalian(return)
        string[] divisi = {"web", "mobile", "game", "mulmed", "jaringan"}; // deklarasi array dengan value
        Console.WriteLine(divisi[0]); // mengakses array divisi dengan menggunakan index
        
        string[] names = new string[5]; // deklarasi array tanpa value
        names[0] = "michael"; // mengisi array names, index ke 0 dengan michael
        Console.WriteLine(names[0]);

        int[,] num = new int[1,2]; // deklarasi array multidimensi tanpa value
        num[0, 0] = 0; // mengisi array num, baris ke 0, kolom ke 0 dengan 0
        Console.WriteLine(num[0, 0]); // mengakses array divisi dengan menggunakan index num[baris, kolom]
        int[,] number = {{1,2,3}, {4,5,6}}; // deklarasi array multidimensi dengan value
        Console.WriteLine(number[0, 0]);
        Console.WriteLine();

        var nama1 = new List<string> (); // deklarasi list tanpa value
        var nama = new List<string> {"ucup", "dadang", "tono"}; // deklarasi list dengan value
        Console.WriteLine(nama[0]); // mengakses list nama dengan menggunakan index
        nama.Add("tini"); // menambah data kedalam list nama
        Console.WriteLine(nama[3]);
        nama.AddRange(new string[2] {"ujang", "asep"}); // menambah banyak data sekaligus
        Console.WriteLine($"{nama[4]}, {nama[5]}");
        nama.Remove("ucup"); // menghapus data bedasarkan value
        Console.WriteLine(nama[0]);
        nama.RemoveAt(0); // menghapus data bedasarkan index
        Console.WriteLine(nama[0]);
    }

    public static void KondisiDanPerulangan() { // function void artinya tanpa kembalian(return)
        int i = 80;
        if (i >= 85) { // kondisi harus memenuhi true
            Console.WriteLine($"nilai anda: {i}, maka mendapatkan A");
        } else if (i >= 80 && i < 85) { // kondisi harus memenuhi true
            Console.WriteLine($"nilai anda: {i}, maka mendapatkan AB");
        } else if (i >= 70 && i < 80) { // kondisi harus memenuhi true
            Console.WriteLine($"nilai anda: {i}, maka mendapatkan B");
        } else { // jika semua kondisi tidak terpenuhi maka akan ke else
            Console.WriteLine($"nilai anda: {i}, maka mendapatkan C");
        }

        switch(i) { // mirip seperti if else, namun ini lebih simple
            case 100: // jika i sebanding dengan 100 maka:
                Console.WriteLine("nilai anda 100");
                break;
            case 90:
                Console.WriteLine("nilai anda 90");
                break;
            case 80:
                Console.WriteLine("nilai anda 80");
                break;
        }

        // tenarary operator, mirip if else namun hanya sedikit baris
        string hasil = (i % 2 == 0) ? "genap": "ganjil"; // (angka % 2 == 0) ? kondisi true: kondisi false
        Console.WriteLine(hasil);

        for(int j = 0; j < 1; j++) { // inisiasi j = 0 jika j < 1 maka akan terus looping, setelah tugasnya selesai makan j+=1
            Console.WriteLine(j); 
        }

        int a = 1;
        while(a < 10) { // operasi perulangan while
            Console.WriteLine(a);
            a++;
            if(a == 7) {
                break; // akan menghentikan operasi while jika a sebanding dengan 7
            } else if(a % 2 == 0) {
                continue; // akan mengabaikan nilai genap
            }
        }

        do { // setidaknya satu kali menjalankan perulangan while
            Console.WriteLine("halo");
        } while(a == 1);

        // foreach operator, mirip seperti for nya python
        string[] divisi = {"web", "mobile", "game", "mulmed", "jaringan"};
        foreach(var nam in divisi) { // mengambil semua value nama
            Console.WriteLine(nam);
        }  
    }

    public static int Contoh() { // function int artinya dengan kembalian(return)
        return 5;
    }
}