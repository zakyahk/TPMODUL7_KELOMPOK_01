using System;
using System.Text.Json;
namespace TPMODUL7_KELOMPOK_01;

public class DataMahasiswa1302210135
{
    Mahasiswa mahasiswa = new Mahasiswa();
    public DataMahasiswa1302210135()
    {

    }

    string text = File.ReadAllText("C:\\Users\\zakyahk\\Documents\\GitHub\\TPMODUL7_KELOMPOK_01\\tp7_1_1302210135.json");

    public void readJson()
    {
        mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(text);
        Console.WriteLine($"Nama : {mahasiswa.nama.depan}{mahasiswa.nama.belakang}");
        Console.WriteLine($"NIM : {mahasiswa.nim}");
        Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
    }
}