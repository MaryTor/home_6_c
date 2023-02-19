// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write($"Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNam = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrayNam[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] arrayNam)
{
  int count = 0;
  for (int i = 0; i < arrayNam.Length; i++)
  {
    if(arrayNam[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(arrayNam)} ");
