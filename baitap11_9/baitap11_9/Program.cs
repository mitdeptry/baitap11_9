using System;

class Program
{
    // Doan so ngau nhien tu 1 den 6
    public void DoanSo()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 7); // So ngau nhien tu 1 den 6

        Console.Write("Nhap vao so ban doan (1-6): ");
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess == randomNumber)
        {
            Console.WriteLine("Ban da doan dung");
        }
        else
        {
            Console.WriteLine($"Ban da sai ! So duoc hien thi la {randomNumber}");
        }
    }

    // Tim phan tu lon nhat trong mang so nguyen
    public void TimPhanTuLonNhat()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }

    // Main
    static void Main(string[] args)
    {
        // Tao doi tuong class Program
        Program program = new Program();

        // Phuong thuc doan so
        Console.WriteLine("BT1 : Doan so tu 1 den 6");
        program.DoanSo();

        Console.WriteLine(); 

        // Phuong thuc tim phan tu lon nhat
        Console.WriteLine("BT2 : Tim phan tu lon nhat trong mang ");
        program.TimPhanTuLonNhat();
    }
}
