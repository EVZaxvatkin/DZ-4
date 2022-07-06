// See https://aka.ms/new-console-template for more information

// Задача 25. Напишите цикл, который принимает на вход два натуральных числа (А иВ)
// и возводит число в степень В.

void Zadacha25()
{
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());

int DegreeA = Degree(A, B);
Console.WriteLine($"{A} в степени {B} равно {DegreeA}");

int Degree(int A,int B)
{
int result = 1;
for (int i =1; i<=B; i++)
{
    result = result * A;
}
return result;
}
}
Zadacha25();


// Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.

void Zadacha27()
{
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumbersN = SumNumbers(numberN);
Console.WriteLine($"Сумма цифр числа {numberN} равно {SumNumbersN}");


int SumNumbers(int numberN)
{
int count = Convert.ToString(numberN).Length;
int currentnumberN = 0;
int result = 0;

for (int i = 0; i < count;i++)
{
    currentnumberN = numberN - numberN%10;
    result = result + (numberN -currentnumberN);
    numberN = numberN/10; 
}
    return result;
}    
}
Zadacha27();



//Задача 29: Напишите программу, которая задаёт массив 
//из 8 случайных целых чисел и выводит отсортированный
//по модулю массив



void Array(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[8];
            for (int i = 0; i < 8; i++)
            {
                array[i] = rand.Next(-50, 50);
                Console.WriteLine("[" + i + "] " + array[i]);
            }
 
            Console.WriteLine("После сортировки:");
            SortArray(array);
            for (int i = 0; i < 8; i++)
                Console.WriteLine("[" + i + "] " + array[i]);
        }

void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
        }


Array(args);


  