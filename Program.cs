// See https://aka.ms/new-console-template for more information
using modul4_103022330096;

class Program 
{
    static void Main()
    {
        //table-driven
        Console.Write("Masukkan nama produk: ");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, out KodeProduk.Produk produk)){ //memeriksa apakah ada enum yang sesuai dengan input, jika ada masukkan value enum ke variable produk
            string kode = KodeProduk.getKodeProduk(produk); //menginisialisasi value kode dengan getKodeProduk berdasarkan produk
            Console.WriteLine($"Kode Produk untuk {produk}: {kode}"); //output produk dan kode produknya
        } else {
            Console.WriteLine($"Produk {input} tidak ditemukan"); //output jika tidak ditemukan enum dengan produk yang diinput
        }
        

    }
}

