using System;
using System.Text.Json;
using System.IO;
namespace TPMODUL7_KELOMPOK_01;

public class KuliahMahasiswa1302210135
{
    ListCourse mataKuliah = new ListCourse();

    public void ReadJSON()
    {
        string text2 = File.ReadAllText("C:\\Users\\zaida\\OneDrive\\Documents\\TP KPL\\TPMODUL7_KELOMPOK_01\\tpmodul7_kelompok1\\tp7_2_1302210135.json");

        mataKuliah = JsonSerializer.Deserialize<ListCourse>(text2);

        for(int i = 0; i < mataKuliah.courses.Count; i++)
        {
            Console.WriteLine("MK " + (i+1) + " <" + mataKuliah.courses[i].code + "> - <" + mataKuliah.courses[i].name + ">");
        }
    }
    public KuliahMahasiswa1302210135() { }

}
