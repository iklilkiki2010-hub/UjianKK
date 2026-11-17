namespace Soal18.Models;

/// <summary>
/// Soal 18: Pemesanan Restoran
/// Lengkapi seluruh bagian TODO sesuai instruksi soal.
/// </summary>
public class MenuItem
{
    public string Kode { get; set; } = string.Empty;
    public string Nama { get; set; } = string.Empty;
    public decimal Harga { get; set; }

    public MenuItem()
    {
        // TODO 1: Lengkapi inisialisasi objek jika diperlukan
        //apa();
        Kode = string.Empty;
        Nama = string.Empty;
        Harga = 100;
    }

    // TODO 2: Buat/implementasikan aturan bisnis untuk soal ini.
    // Petunjuk fungsi yang wajib dibuat: HitungHarga(int jumlah); turunan Makanan dan Minuman
    public int HitungHarga(int jumlah)
    {
       
        return jumlah ;
    }

    public virtual string TampilkanInfo()
    {
        // TODO 3: Kembalikan informasi objek dalam format yang mudah dibaca.
        return string.Empty;
        
    }
}
