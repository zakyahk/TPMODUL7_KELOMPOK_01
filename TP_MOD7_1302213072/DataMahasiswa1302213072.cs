using System;
using System.Text.Json;
namespace TP_MOD7_1302213072;

public class DataMahasiswa1302213072
{
	Mahasiswa mahasiswa = new Mahasiswa();
	public DataMahasiswa1302213072()
	{

	}

	string text = File.ReadAllText("C:\\Users\\zaida\\OneDrive\\Documents\\TP KPL\\TP_MOD7_1302213072\\tp7_1_1302213072.json");

	public void readJson()
	{
		mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(text);
		Console.WriteLine($"Nama : {mahasiswa.nama.depan}{ mahasiswa.nama.belakang}");
		Console.WriteLine($"NIM : {mahasiswa.nim}");
		Console.WriteLine($"Fakultas : {mahasiswa.fakultas}");
	}
}
