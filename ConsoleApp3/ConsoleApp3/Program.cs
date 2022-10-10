class Program
{
    public static void Main(string[] args)
    {
        StreamReader sr = File.OpenText("C:/Users/akara/OneDrive/Рабочий стол/Mathematical statistics/StatisticsData.txt");
        List<string[]> allElements = new List<string[]>();
        List<int> data = new List<int>();
        List<int> new_data = new List<int>();

        
        var str = sr.ReadLine();
        var elements = str.Split(',');
        allElements.Add(elements);

        for (int i = 0; i < 501; i++)
        {
            data.Add(int.Parse(allElements[0][i]));
        }
        
        for (int i = 0; i < 501; i += 4)
        {
            new_data.Add(data[i]);
        }

        new_data.Sort();

        sr.Close();
        float sumOfElements = 0;
        float mathematicalExpectation = 0;
        double variance = 0;
        double sigma = 0;
        

        for (int i = 0; i < new_data.Count; i++)
        {
            sumOfElements += new_data[i];
            mathematicalExpectation += new_data[i] / data.Count;
        }

        var arithmeticMean = sumOfElements / 250;

        for (int i = 0; i < new_data.Count; i++)
        {
            variance = Math.Pow(data[i] - mathematicalExpectation, 2) / new_data.Count;
        }

        sigma = Math.Sqrt(variance);
        var correctVariance = variance * (new_data.Count / (new_data.Count - 1));
        var correctSigma = Math.Sqrt(correctVariance);
        
        Console.WriteLine("Массив данных:");
        
        for (int i = 0; i < 501; i++)
        {
            Console.Write(allElements[0][i] + ", ");
        }
        
        Console.WriteLine("\n" + "Отсортированный массив данных:");
        
        for (int i = 0; i < new_data.Count; i++)
        {
            Console.Write(new_data[i] + ", ");
        }
        
        
        Console.WriteLine("\n" + "Среднее значение: " + arithmeticMean);
        Console.WriteLine("\n" + "Дисперсия: " + variance);
        Console.WriteLine("\n" + "Среднее квадратичное: " + sigma);
        Console.WriteLine("\n" + "Корректная дисперсия: " + correctVariance);
        Console.WriteLine("\n" + "Корректная сигма: " + correctSigma);
    }
}