// задача с массивом на любое кол-во элементов

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if (array[index] == find)  //если в конце этой строки поставить точку с запятой то в итоге показывает индексы чисел
    {
        Console.WriteLine(index); //если выполняется это условие if то пишем break
        break;
    }
    //index = index +1; или
    index++;
}