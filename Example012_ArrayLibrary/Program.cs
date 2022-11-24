void FillArray(int[] collection)
{
   int length = collection.Length;
   int index = 0;
   while (index < length)
   {
     collection[index] = new Random().Next(1, 10);
     //index = index +1;
     index++;
   }
}
   //Итак, первый метод готов. Пока тестировать его не будем.

/*Теперь сделаем метод void, который будет печатать массив. Аналогичным образом в качестве
аргумента здесь будет приходить массив. Обратите внимание, что здесь мы специально не
даём одинаковые имена, чтобы привыкнуть называть разные аргументы различными
именами. То есть в первом случае будет collection, а во втором, например, col:*/

void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while(position < count)
  { 
    Console.WriteLine(col[position]);
    position++;
  }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //добавили оператор чтоб найти первое число из нескольки одинаковых
        }
        index++;
       
    }
    return position;
}

int[] array = new int[10]; //дословно создай новый массив

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);