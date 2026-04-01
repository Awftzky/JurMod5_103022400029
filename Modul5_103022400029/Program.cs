// See https://aka.ms/new-console-template for more information
using System.Globalization;

public class PemrosesData {
    public void DapatkanNilaiTerbesar<T>(T satu ,T dua , T tiga) {
        dynamic a = satu;

        dynamic b = dua;

        dynamic c = tiga;

        Console.WriteLine("IMPLEMENTASI GENERIC METHOD!");

        if (a > b && a > c) {
            Console.WriteLine($"Nilai terbesar adalah {a}");
        } else if (b > a && b > c) {
            Console.WriteLine($"Nilai terbesar adalah {b}");
        } else {
            Console.WriteLine($"Nilai terbesar adalah {c}");
        }
    }
}

public class SimpleDataBase<T>
{
    private List<T> data;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        data = new List<T>();
        inputDates = new List<DateTime>();
    }

   
    public void AddNewData(T newData)
    {
        data.Add(newData);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < data.Count; i++)
        {
            Console.WriteLine($"Data{data.Count} berisi: {data[i]}, yang disimpan pada waktu {inputDates[i]}");
        }
    }
}

class Program {
    static void Main(string[] args)
    {
        PemrosesData data1 = new PemrosesData();
        data1.DapatkanNilaiTerbesar<long>(10 , 30 , 22);


        SimpleDataBase<int> database1 = new SimpleDataBase<int>();
        database1.AddNewData(12);
        database1.AddNewData(34);
        database1.AddNewData(56);

        database1.printAllData();


    }
}