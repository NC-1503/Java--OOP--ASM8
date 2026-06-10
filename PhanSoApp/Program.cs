// Bai tap 1 - Kiem tra class PhanSo co ban
Console.WriteLine("--- Bai 1 ---");
Console.WriteLine(new PhanSo(2, 4));    // 1/2
Console.WriteLine(new PhanSo(1, -3));   // -1/3
 
try { var x = new PhanSo(1, 0); }
catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
 
// Bai tap 2 - Kiem tra toan tu so hoc
Console.WriteLine("\n--- Bai 2 ---");
PhanSo ps1 = new PhanSo(1, 2);
PhanSo ps2 = new PhanSo(1, 3);
 
Console.WriteLine($"ps1 = {ps1}");
Console.WriteLine($"ps2 = {ps2}");
Console.WriteLine($"ps1 + ps2 = {ps1 + ps2}");   // 5/6
Console.WriteLine($"ps1 - ps2 = {ps1 - ps2}");   // 1/6
Console.WriteLine($"ps1 * ps2 = {ps1 * ps2}");   // 1/6
Console.WriteLine($"ps1 / ps2 = {ps1 / ps2}");   // 3/2
Console.WriteLine($"ps1 + 2   = {ps1 + 2}");     // 5/2
 
// Bai tap 3 - Kiem tra toan tu so sanh
Console.WriteLine("\n--- Bai 3 ---");
PhanSo cmp1 = new PhanSo(1, 2);
PhanSo cmp2 = new PhanSo(2, 4);
PhanSo cmp3 = new PhanSo(1, 3);
 
Console.WriteLine(cmp1 == cmp2);   // True
Console.WriteLine(cmp1 != cmp3);   // True
Console.WriteLine(cmp3 < cmp1);    // True
Console.WriteLine(cmp1 > cmp3);    // True
