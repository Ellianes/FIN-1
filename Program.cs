/* Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше или равно 3
*/

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)

{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    
    void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
   
    // тут должен закончится 3 коммит (но это не точно)



    // думали это конец коммита? Нет, это я, Дио!

    //А вот тут уже точно конец