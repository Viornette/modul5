PemrosesData.DapatkanNilaiTerbesar<double>(10, 30, 22);
class PemrosesData
{
    public static void DapatkanNilaiTerbesar<T> (T a, T b, T c)
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

        Console.WriteLine ("Nilai maksimum adalah: " + max);
    }
}
