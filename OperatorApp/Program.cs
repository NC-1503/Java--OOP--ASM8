using System;

class Program
{
    static void Main()
    {
        TestVector2D();
        Console.WriteLine();
        TestMoney();
    }

    static void TestVector2D()
    {
        Console.WriteLine("=== BÀI TẬP 1: Vector2D ===");

        Vector2D v1 = new Vector2D(3, 4);
        Vector2D v2 = new Vector2D(1, 2);

        Console.WriteLine($"v1 = {v1}");            
        Console.WriteLine($"v2 = {v2}");             
        Console.WriteLine($"v1 + v2 = {v1 + v2}");  
        Console.WriteLine($"v1 - v2 = {v1 - v2}");  
        Console.WriteLine($"v1 * 2  = {v1 * 2}");  
        Console.WriteLine($"3 * v2  = {3 * v2}");  
        Console.WriteLine($"-v1     = {-v1}");      
        Console.WriteLine($"|v1|    = {v1.DoDai:F4}");

        Console.WriteLine($"v1 == v1: {v1 == new Vector2D(3, 4)}"); 
        Console.WriteLine($"v1 != v2: {v1 != v2}");                
        Console.WriteLine($"v1 · v2 = {v1 * v2:F2}");        

        Vector2D v3 = (5.0, 6.0); 
        Console.WriteLine($"Tuple -> Vector: {v3}");               
    }

    static void TestMoney()
    {
        Console.WriteLine("=== BÀI TẬP 2: Money ===");

        Money luong      = new Money(15_000_000, "VND");
        Money thuong     = new Money( 3_000_000, "VND");
        Money lamThemGio = luong * 1.5m;

        Console.WriteLine($"Luong co ban:   {luong}");
        Console.WriteLine($"Thuong thang:   {thuong}");
        Console.WriteLine($"Luong lam them: {lamThemGio}");
        Console.WriteLine($"Tong thu nhap:  {luong + thuong}");
        Console.WriteLine($"Luong > Thuong: {luong > thuong}");

        try
        {
            Money usd  = new Money(100, "USD");
            Money tong = luong + usd; 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Loi: {ex.Message}");
        }
    
        Money usd100 = new Money(100, "USD");
        Money vnd    = Money.QuyDoi(usd100, "VND", 25_500);
        Console.WriteLine($"100 USD -> {vnd}"); 

        Money hoaDon = new Money(600_000, "VND");
        Console.WriteLine($"Chia 4 nguoi: {hoaDon / 4}"); 
    }
}
