using System;
using System.Text.Json;
using System.IO;
namespace TP_MOD7_1302213072;
public class KuliahMahasiswa1302213072
{
	ListMataKuliah matakuliah = new ListMataKuliah();
	public void readJSON()
	{
		string text2 = File.ReadAllText("C:\\Users\\zaida\\OneDrive\\Documents\\TP KPL\\TP_MOD7_1302213072\\tp7_2_1302213072.json");

		matakuliah = JsonSerializer.Deserialize<ListMataKuliah>(text2);

		for(int i = 0; i < matakuliah.courses.Count; i++)
		{
			Console.WriteLine($"MK {i + 1}: <{matakuliah.courses[i].code}> - < {matakuliah.courses[i].name}>");
		}
	}
	public KuliahMahasiswa1302213072()
	{

	}
}
