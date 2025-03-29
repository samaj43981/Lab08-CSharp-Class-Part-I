MyClass mc = new MyClass();
mc.CheckEvenOdd(5);
mc.CheckEvenOdd(10);

public class MyClass
{
    public void CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            System.Console.WriteLine($"{number} เป็นเลขคู่");
        }
        else
        {
            System.Console.WriteLine($"{number} เป็นเลขคี่");
        }
    }
}