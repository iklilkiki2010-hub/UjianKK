# Soal 18: Pemesanan Restoran

## Ketentuan
- Platform: C# .NET 8 Windows Forms, Visual Studio 2022 atau lebih baru.
- Selesaikan semua komentar `TODO` pada Model, Service, dan Form1.
- Tambahkan kontrol yang dibutuhkan (ComboBox, NumericUpDown, DateTimePicker, dan sebagainya).
- Gunakan enkapsulasi, constructor, object, collection `List<T>`, validasi, dan OOP yang relevan.
- Data boleh disimpan sementara di memori menggunakan `List<T>`; database tidak diwajibkan.
- Jangan menghapus validasi dan jangan menaruh seluruh logika bisnis di Form1.

## Cara menjalankan
1. Buka `Soal18.csproj` di Visual Studio 2022.
2. Build project.
3. Lengkapi TODO dan jalankan dengan F5.

## Identitas siswa
Nama: Muh. Iklil Mutawakkil
NIS: 544251149
Nomor soal: 18
Tanggal: 11/17/2026

## Bukti pengumpulan
- Source code lengkap. 
- Screenshot aplikasi berjalan.
- README berisi penjelasan class, aturan bisnis, dan minimal 5 skenario pengujian.

penjelasan class : 
menuitem.cs = t4 utk inisialisasi object, dipake sebagai penyimpan data sementara.
menuitemservice.cs = isinya aturan bisnis yang mencangkup:
1. tambah data = menggunakan if ,else statement, dan messagebox jika salah satu dari textbox tidak diisi.
2. hapus data = mengambil data dari method cari() utk digunakan memilih data kemudian menghapusnya (menggunakan messagebox dan if statement)
3. cari data = menggunakan FirstOrDefault() function untuk mencari data sesuai id di dalam koleksi data.

skenario pengujian:
1. jika user tidak memasukkan nilai apapun ke dalam textbox = akan muncul dialog peringatan bahwa textbox1 atau textbox2 belum diisi.
2. jika 

