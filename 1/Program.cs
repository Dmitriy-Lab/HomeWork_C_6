
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  // Задача свелась к написанию этой строки. Как говорится, гугл в помощь:)
int sum = 0;

for( int i = 0; i < array.Length ; i++)
{
    if ( array[i] > 0)
      {
        sum++;
      }
}
Console.WriteLine("Чисел больше нуля: "+sum);