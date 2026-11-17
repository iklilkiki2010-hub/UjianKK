using Soal18.Models;
using Soal18.Services;
using System.Collections;


namespace Soal18;

public class Form1 : Form
{
    private readonly MenuItemService service = new();
    private readonly DataGridView grid = new();
    private readonly TextBox txtIdentitas = new();
    private readonly TextBox txtNama = new();
    private readonly Button btnTambah = new();
    private readonly Button btnHapus = new();
    private DataGridView dataGridView1;
    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private readonly Button btnMuat = new();

    public Form1()
    {
        Text = "Soal 18 - Pemesanan Restoran";
        Width = 900;
        Height = 600;
        StartPosition = FormStartPosition.CenterScreen;

        var lblId = new Label { Text = "Kode/Identitas", Left = 20, Top = 20, Width = 120 };
        txtIdentitas.SetBounds(150, 18, 220, 28);
        var lblNama = new Label { Text = "Nama/Judul", Left = 20, Top = 60, Width = 120 };
        txtNama.SetBounds(150, 58, 220, 28);

        btnTambah.Text = "Tambah";
        btnTambah.SetBounds(390, 18, 100, 32);
        btnHapus.Text = "Hapus";
        btnHapus.SetBounds(500, 18, 100, 32);
        btnMuat.Text = "Muat Data";
        btnMuat.SetBounds(610, 18, 110, 32);

        grid.SetBounds(20, 110, 840, 410);
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        Controls.AddRange(new Control[] { lblId, txtIdentitas, lblNama, txtNama,
            btnTambah, btnHapus, btnMuat, grid });

        btnTambah.Click += (_, _) => TambahData();
        btnHapus.Click += (_, _) => HapusData();
        btnMuat.Click += (_, _) => TampilkanData();
        
        
    }

    private void TambahData()
    {
        MenuItem item = new()
        { 
        Nama = txtNama.Text,
        Kode = txtIdentitas.Text
        };
        service.Tambah(item);
        // TODO 7: Ambil nilai dari TextBox dan NumericUpDown/ComboBox tambahan.
        // TODO 8: Buat objek MenuItem, validasi, lalu panggil service.Tambah().
        //MessageBox.Show("Lengkapi event TambahData().");
    }

    private void HapusData()
    {
        // TODO 9: Pastikan baris dipilih, ambil identitas, lalu panggil service.Hapus().
        //https://stackoverflow.com/questions/56153056/how-to-remove-selected-row-when-datagridview-is-bound-to-a-listt;
        foreach (DataGridViewRow row in grid.SelectedRows)
        {
            if (row.DataBoundItem is MenuItem menuItem)
            {
                service.Hapus(menuItem.Kode);
            }
        }
        TampilkanData();
       
    }

    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        button1 = new Button();
        button2 = new Button();
        textBox1 = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Bottom;
        dataGridView1.Location = new Point(0, 156);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(1000, 220);
        dataGridView1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(9, 121);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(894, 121);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 2;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(0, 1);
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Cari makanan";
        textBox1.Size = new Size(344, 31);
        textBox1.TabIndex = 3;
        // 
        // Form1
        // 
        ClientSize = new Size(1000, 376);
        Controls.Add(textBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Name = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

 
    private void TampilkanData()
    {
        // TODO 10: Tampilkan service.SemuaData pada DataGridView.
        //grid.DataSource = null;
        grid.DataSource = service.SemuaData.ToList();
    }
}
