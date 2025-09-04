using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CHƯƠNG TRÌNH TỔNG HỢP 16 BÀI TẬP ===");

        // Nhóm 1: Bài 1.1 → 1.5
        Bai1_1_EvenOdd();
        Bai1_2_MaxOfThree();
        Bai1_3_Quadrant();
        Bai1_4_LeapYear();
        Bai1_5_SimpleInterest();

        // Nhóm 2: Bài 2.1 → 2.3
        Bai2_1_TriangleType();
        Bai2_2_AverageOfTen();
        Bai2_3_MultiplicationTable();

        // Nhóm 3: Bài 3.1 → 3.8
        Bai3_1_TrianglePattern();
        Bai3_2_IncreasingPattern();
        Bai3_3_HarmonicSeries();
        Bai3_4_PerfectNumbers();
        Bai3_5_PrimeCheck();
        Bai3_6_SphereVolume();
        Bai3_7_CharacterCheck();
        Bai3_8_SimpleCalculator();
    }

    // Nhóm 1
    static void Bai1_1_EvenOdd()
    {
        Console.WriteLine("\nBài 1.1: Kiểm tra số chẵn/lẻ");
        Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "Số chẵn" : "Số lẻ");
    }

    static void Bai1_2_MaxOfThree()
    {
        Console.WriteLine("\nBài 1.2: Tìm số lớn nhất trong 3 số");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"Số lớn nhất: {max}");
    }

    static void Bai1_3_Quadrant()
    {
        Console.WriteLine("\nBài 1.3: Xác định góc phần tư");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x > 0 && y > 0) Console.WriteLine("Góc phần tư thứ nhất");
        else if (x < 0 && y > 0) Console.WriteLine("Góc phần tư thứ hai");
        else if (x < 0 && y < 0) Console.WriteLine("Góc phần tư thứ ba");
        else if (x > 0 && y < 0) Console.WriteLine("Góc phần tư thứ tư");
        else Console.WriteLine("Trên trục hoặc gốc tọa độ");
    }

    static void Bai1_4_LeapYear()
    {
        Console.WriteLine("\nBài 1.4: Kiểm tra năm nhuận");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(isLeap ? "Năm nhuận" : "Không phải năm nhuận");
    }

    static void Bai1_5_SimpleInterest()
    {
        Console.WriteLine("\nBài 1.5: Tính lãi đơn");
        double p = double.Parse(Console.ReadLine());
        double r = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double interest = (p * r * t) / 100;
        Console.WriteLine($"Lãi: {interest:F2}");
    }

    // Nhóm 2
    static void Bai2_1_TriangleType()
    {
        Console.WriteLine("\nBài 2.1: Kiểm tra loại tam giác");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a == b && b == c) Console.WriteLine("Tam giác đều");
        else if (a == b || b == c || a == c) Console.WriteLine("Tam giác cân");
        else Console.WriteLine("Tam giác thường");
    }

    static void Bai2_2_AverageOfTen()
    {
        Console.WriteLine("\nBài 2.2: Tính tổng và trung bình của 10 số");
        int sum = 0;
        for (int i = 0; i < 10; i++) sum += int.Parse(Console.ReadLine());
        Console.WriteLine($"Tổng: {sum}, Trung bình: {sum / 10.0}");
    }

    static void Bai2_3_MultiplicationTable()
    {
        Console.WriteLine("\nBài 2.3: Bảng cửu chương");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++) Console.WriteLine($"{n} x {i} = {n * i}");
    }

    // Nhóm 3
    static void Bai3_1_TrianglePattern()
    {
        Console.WriteLine("\nBài 3.1: Pattern tam giác số");
        int rows = int.Parse(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++) Console.Write(j + " ");
            Console.WriteLine();
        }
    }

    static void Bai3_2_IncreasingPattern()
    {
        Console.WriteLine("\nBài 3.2: Pattern số tăng dần");
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++) Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }

    static void Bai3_3_HarmonicSeries()
    {
        Console.WriteLine("\nBài 3.3: Dãy điều hòa");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"1/{i} ");
            sum += 1.0 / i;
        }
        Console.WriteLine($"\nTổng: {sum:F4}");
    }

    static void Bai3_4_PerfectNumbers()
    {
        Console.WriteLine("\nBài 3.4: Số hoàn hảo");
        int limit = int.Parse(Console.ReadLine());
        for (int i = 1; i <= limit; i++)
        {
            int s = 0;
            for (int j = 1; j < i; j++) if (i % j == 0) s += j;
            if (s == i) Console.WriteLine(i);
        }
    }

    static void Bai3_5_PrimeCheck()
    {
        Console.WriteLine("\nBài 3.5: Kiểm tra số nguyên tố");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) isPrime = false;
        Console.WriteLine(isPrime ? "Nguyên tố" : "Không nguyên tố");
    }

    static void Bai3_6_SphereVolume()
    {
        Console.WriteLine("\nBài 3.6: Thể tích hình cầu");
        double r = double.Parse(Console.ReadLine());
        double volume = (4.0 / 3) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Thể tích: {volume:F2}");
    }

    static void Bai3_7_CharacterCheck()
    {
        Console.WriteLine("\nBài 3.7: Kiểm tra ký tự");
        char ch = char.Parse(Console.ReadLine());
        if (char.IsLetter(ch)) Console.WriteLine("Chữ cái");
        else if (char.IsDigit(ch)) Console.WriteLine("Chữ số");
        else Console.WriteLine("Ký tự đặc biệt");
    }

    static void Bai3_8_SimpleCalculator()
    {
        Console.WriteLine("\nBài 3.8: Máy tính đơn giản");
        double a = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        double b = double.Parse(Console.ReadLine());
        switch (op)
        {
            case "+": Console.WriteLine(a + b); break;
            case "-": Console.WriteLine(a - b); break;
            case "*": Console.WriteLine(a * b); break;
            case "/": Console.WriteLine(b != 0 ? a / b : "Không chia được"); break;
            default: Console.WriteLine("Phép toán không hợp lệ"); break;
        }
    }
}
