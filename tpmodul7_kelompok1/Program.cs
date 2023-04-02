namespace TPMODUL7_KELOMPOK_01;

class program
{
    public static void Main(string[] args)
    {
        DataMahasiswa1302210135 dataMhs = new DataMahasiswa1302210135();
        dataMhs.readJson();

        KuliahMahasiswa1302210135 matkul = new KuliahMahasiswa1302210135();
        matkul.ReadJSON();
    }
}
