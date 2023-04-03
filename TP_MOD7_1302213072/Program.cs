// See https://aka.ms/new-console-template for more information
namespace TP_MOD7_1302213072;

class program
{
    public static void Main(string[] args)
    {
        DataMahasiswa1302213072 data = new DataMahasiswa1302213072();
        data.readJson();
        KuliahMahasiswa1302213072 Kuliahazza = new KuliahMahasiswa1302213072();
        Kuliahazza.readJSON();
    }
}
