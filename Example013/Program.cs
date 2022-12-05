﻿void Metod2(string msg)
{
Console.WriteLine(msg);//— оператор, в скобках указан принятый аргумент
}
Metod2("Текст сообщения");/*— где Metod2 является идентификатором, а в скобках
указан текст, выводимый в консоли.*/

//Именованные аргументы
void Metod21(string msg, int count)
{
int i = 0;
while (i < count)
{

Console.WriteLine(msg); /*- где переменная count отображает на экране
определённое количество сообщений msg.*/
count++; /*- а надо i++;*/
}
}
Metod21(count: 4, msg:"Текст");/* - метод вызывает Текст, после запятой указано количество
вызовов, в нашем случае 4.*/

//Третья группа методов
/*Эти методы, которые что-то возвращают, но ничего не принимают. Если метод что-то
возвращает, мы в обязательном порядке должны указать тип данных, значение которого
ожидаем. Для нас это будет Metod3.*/

int Metod3() //- не принимает никакие аргументы
{
   return DateTime.Now.Year; //- обязательное использование оператора return,
}
int year = Metod3( );/* - вызываем метод, в левой части используем идентификатор
переменной (year) и через оператор присваивания (=) кладём нужное значение*/
Console.WriteLine(year);

//Четвёртая группа методов
//Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.
string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);

//Цикл for
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) //- вначале ключевое слово, затем инициализация
                                    //счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);

//Цикл в цикле
//Классической демонстрацией использования циклов в цикле я предлагаю рассмотреть задачу
//вывода таблицы умножения на экран. Итак, идея следующая.
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


//Тренировочная задача

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
/*В нашем случае требуется небольшое пояснение, если будет какая-то строка, то для этой
строки есть некоторое количество вспомогательного функционала.*/

// string s = “qwerty”
// 012345

/*В частности, если требуется обратиться к конкретному символу строки, мы можем это делать,
начиная отсчитывать позицию символов с 0. То есть «q» — это 0, «w» — 1, «e» — 2 и так далее.
Чтобы получить конкретный символ, мы можем через квадратные скобки обратиться, указать
идентификатор строки. Например:
// s[3] // r
9
В этом случае будьте, пожалуйста, внимательны нулевой символ «w» это 1 символ, дальше 2
символ это будет у нас 3. То есть, буква r будет именно s[3]. Теперь приступим к написанию
кода.
Итак, метод у нас будет принимать строку и символы, которые нужно будет менять.
Соответственно, старый символ и на который нужно будет заменить. Возвращаться точно так
же будет строка, поэтому сразу можно сделать вывод о том, что это условно четвёртый вид
методов. Назовём его Replace. Далее string и какой-то входной текст. Затем указываем
конкретный символ oldValue и конкретный символ, на который мы будем менять, newValue.*/
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);


//Упорядочить массивы

//1. Найти позицию минимального элемента в неотсортированной части массива.
//2. Произвести обмен этого значения со значением первой неотсортированной позиции.
//3. Повторять пока есть неотсортированные элементы.
//Напишем код
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
           
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);