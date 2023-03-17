string stroka = ReadStr("enter an array of strings separated by a space: ");
string[] array1 = GenerateFirstArray(stroka);
ResultArray(array1);


string ReadStr(string text) 

  {
    Console.WriteLine(text);
    return Console.ReadLine();
  }

string[] GenerateFirstArray(string str) 
{
    string[] arr = stroka.Split(' ');
    return arr;
}

void ResultArray(string[] arr) 
{
    string[] newArr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = array1[i];
            count++;
        }
    }
    System.Console.WriteLine("[" + string.Join(",", newArr) + "]");
}