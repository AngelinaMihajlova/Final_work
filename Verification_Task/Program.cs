/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа */

string[] initialArray = new string[6] {"Russia", "524", "World", "123", "-5", "Pos"};
string[] resultArray = new string[initialArray.Length];

void FormationArray (string[]initialArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            resultArray[count] = initialArray[i];
            count ++;
        }
    }
}
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FormationArray (initialArray, resultArray);
PrintArray (resultArray);
