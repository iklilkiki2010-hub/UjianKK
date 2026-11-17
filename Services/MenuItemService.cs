using System.Collections.Generic;
using System.Reflection.Metadata;
using Soal18.Models;
using System.Linq;

namespace Soal18.Services;

/// <summary>Tempatkan logika aplikasi di service, jangan menumpuk semua logika di Form1.</summary>
public class MenuItemService
{
    private readonly List<MenuItem> data = new();

    public IReadOnlyList<MenuItem> SemuaData => data.AsReadOnly();

    public void Tambah(MenuItem item)
    {
        // TODO 4: Validasi item dan tambahkan ke koleksi.
        if (string.IsNullOrWhiteSpace(item.Nama) || string.IsNullOrWhiteSpace(item.Kode))
        {
            MessageBox.Show("Nama dan kode belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (string.IsNullOrWhiteSpace(item.Nama))
        {
            MessageBox.Show("Nama belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (string.IsNullOrWhiteSpace(item.Kode))
        {
            MessageBox.Show("Kode belum diisi", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            MessageBox.Show("Berhasil Add data", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Add(item);
        }
    }

    public bool Hapus(string id)
    {
        var item = Cari(id);
        if (item != null)
        {
            MessageBox.Show("berhasil menghapus data", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Remove(item);
            return true;
        }
        return false;
    }

    public MenuItem? Cari(string id)
    {
        // TODO 6: Cari dan kembalikan data; null jika tidak ditemukan.
        return data.FirstOrDefault(x => x.Kode == id);
        
    }
}
