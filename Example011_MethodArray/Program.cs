﻿// задача с массивом на любое кол-во элементов
/*Допустим, у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий с
некоторым значением, который определяет пользователей.
1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому
что мы нашли позицию.
15
3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим
на предыдущий шаг.
4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
6. В результате если элемент находится, операция завершается успешно. А если этого
элемента так и нет, надо сообщить об этом.*/

/*Итак, реализуем теперь этот алгоритм кодом. Сначала определим новый массив. Дадим int
имя array. Далее определим какое-то количество чисел, например, 8. Технически их может
быть сколько угодно, потому сейчас мы реализовываем задачу для любого количества
элементов. Отформатируем написанное:*/

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };
//Далее по алгоритму требуется n элементов. Чтобы получить n, напишем:
int n = array.Length;
/*Внутри массива есть информация о том, сколько элементов в нём содержится. В частности,
array.Length возвращает длину или количество элементов массива. Определили.
Далее надо, чтобы пользователь мог ввести число. Выберем число 18:*/
int find = 18;
/*Теперь по нашему алгоритму требуется установить некоторый счётчик index, поэтому
определим его так же. Индекс, равный 0. Помним, что элементы в нашем массиве начинаются
с 0, то есть 1 стоит под нулевой позицией:*/
int index = 0;
/*Далее нам потребуется цикл while, в котором будем проверять: если index < n. Отмечаем, что
на каждом этапе надо увеличивать значение индекса, поэтому прописываем:*/
while (index < n)
{

    if (array[index] == find)  //если в конце этой строки поставить точку с запятой то в итоге показывает индексы чисел
    {
        Console.WriteLine(index); //если выполняется это условие if то пишем break
        break;//(прервать)
    }
    //index = index +1; или
    index++;
}