public class MyProgram
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int multiply(int a, int b)
    {
        return a * b;
    }

    public void GenerateMultiplicationTables(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            System.Console.WriteLine($"สูตรคูณแม่ {i}:");
            for (int j = 1; j <= 12; j++)
            {
                int result = multiply(i, j);
                System.Console.WriteLine($"{i} x {j} = {result}");
            }
            System.Console.WriteLine(); // เพิ่มบรรทัดว่างเพื่อคั่นระหว่างแม่สูตรคูณ
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyProgram myProgram = new MyProgram();
        myProgram.GenerateMultiplicationTables(2, 12); // สร้างสูตรคูณแม่ 2-12
    }
}