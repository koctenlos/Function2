// Задача 19

// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.


Console.Write("Введите число: ");
string? znach = Console.ReadLine();

if (znach!.Length == 5){
  CheckingNumber(znach);
}
else Console.WriteLine($"Введи правильное число");

void CheckingNumber(string znach){
  if (znach[0]==znach[4] & znach[1]==znach[3]){
    Console.WriteLine($"Число: {znach} - палиндром.");
  }
  else Console.WriteLine($"Число: {znach} - не палиндром.");
}

