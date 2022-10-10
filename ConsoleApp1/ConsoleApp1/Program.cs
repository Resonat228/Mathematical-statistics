class Program
{
    public static void Main(string[] args)
    {
        StreamReader sr = File.OpenText("C:/Users/akara/OneDrive/Рабочий стол/Mathematical statistics/StatisticsData.txt");
        List<string[]> allElements = new List<string[]>();
        List<int> data = new List<int>();

        var str = sr.ReadLine();
        var elements = str.Split(',');
        allElements.Add(elements);

        for (int i = 0; i < 501; i++)
        {
            data.Add(int.Parse(allElements[0][i]));
        }
        data.Sort();

        sr.Close();
        float sumOfElements = 0;
        float mathematicalExpectation = 0;
        double variance = 0;
        double sigma = 0;
        

        for (int i = 0; i < data.Count; i++)
        {
            sumOfElements += data[i];
            mathematicalExpectation += data[i] / data.Count;
        }

        var arithmeticMean = sumOfElements / 500;

        for (int i = 0; i < data.Count; i++)
        {
            variance = Math.Pow(data[i] - mathematicalExpectation, 2) / data.Count;
        }

        sigma = Math.Sqrt(variance);
        
        Console.WriteLine("Массив данных:");
        
        for (int i = 0; i < 501; i++)
        {
            Console.Write(allElements[0][i] + ", ");
        }
        
        Console.WriteLine("\n" + "Отсортированный массив данных:");
        
        for (int i = 0; i < 501; i++)
        {
            Console.Write(data[i] + ", ");
        }
        
        
        Console.WriteLine("\n" + "Среднее значение: " + arithmeticMean);
        Console.WriteLine("\n" + "Дисперсия: " + variance);
        Console.WriteLine("\n" + "Среднее квадратичное: " + sigma);
     }
}