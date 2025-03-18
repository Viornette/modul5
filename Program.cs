PemrosesData.DapatkanNilaiTerbesar<double>(10, 30, 22);
SimpleDataBase<double> db = new SimpleDataBase<double>();
db.AddNewData(10);
db.AddNewData(30);
db.AddNewData(22);
db.PrintAllData();
class PemrosesData
{
    public static void DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic max = a;

        if (max < b)
        {
            max = b;
        }

        if (max < c)
        {
            max = c;
        }

        Console.WriteLine("Nilai maksimum adalah: " + max);
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}
