# Итоговая работа по первому блоку

## Задание:
1. Создать репозиторий на GitHub;
2. Нарисовать блок-схему алгоритма;
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md);
4. Написать программу, решающую поставленную задачу;
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах).

## Текст задачи:
"Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами".

## Решение
* Просим пользователя ввести с клавиатуры строки через пробел (элементы массива):
1. string stroka = ReadStr("enter an array of strings separated by a space: ");
2. string[] array1 = GenerateFirstArray(stroka);
3. ResultArray(array1);
* Преобразуем введенные строки в массив строк:
13. string[] GenerateFirstArray(string str) 
14. {
15.    string[] arr = stroka.Split(' ');
16.    return arr;
17. }
* Задаем цикл через for и проверяем каждый элемент (строку) массива по условию "длина строки меньше либо равна 3 символа". Строки, отвечающие условию, записываются в новый финальный массив, который выводится в терминале:
19. void ResultArray(string[] arr) 
20. {
21.   string[] newArr = new string[arr.Length];
22.   int count = 0;
23.   for (int i = 0; i < arr.Length; i++)
24.    {
25.       if (arr[i].Length <= 3)
26.       {
27.          newArr[count] = array1[i];
28.          count++;
29.        }
30.    }
31.    System.Console.WriteLine("[" + string.Join(",", newArr) + "]");
32. }
