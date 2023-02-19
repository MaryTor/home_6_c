// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

double[,] values = new double[2, 2];
double[] crossPoint = new double[2];

void InputValues(){
  for (int i = 0; i < values.GetLength(0); i++)
  {
    Console.WriteLine($"Введите значения {i+1}-ой прямой");
    for (int j = 0; j < values.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значения k: ");
      else Console.Write($"Введите значения b: ");
      values[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] values)
{
  crossPoint[0] = (values[1,1] - values[0,1]) / (values[0,0] - values[1,0]);
  crossPoint[1] = crossPoint[0] * values[0,0] + values[0,1];
  return crossPoint;
}

void OutputResponse(double[,] values)
{
  if (values[0,0] == values[1,0] && values[0,1] == values[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (values[0,0] == values[1,0] && values[0,1] != values[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Decision(values);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}; {crossPoint[1]})");
  }
}

InputValues();
OutputResponse(values);