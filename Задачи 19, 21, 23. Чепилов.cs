// Задача 19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// НАЧАЛО КОДА ЗАДАЧИ 19


int Perevjortish(int chislo) // переворачиваем число. необязательно, но очень захотелось :)
{
    int tsifra5 = chislo %10;
    int tsifra4 = chislo /10 %10;
    int tsifra3 = chislo /100 %10;
    int tsifra2 = chislo /1000 %10;
    int tsifra1 = chislo /10000;
    int result = tsifra5*10000 + tsifra4*1000 + tsifra3*100 + tsifra2*10 + tsifra1;
    return result;
}

void ProverkaPalindroma(int a)
{
    int aTsifra5 = a %10;
    int atsifra4 = a /10 %10;
    int atsifra3 = a /100 %10;
    int atsifra2 = a /1000 %10;
    int atsifra1 = a /10000;

    if (aTsifra5 == atsifra1 && atsifra4 == atsifra2) Console.Write($"число {a} палиндром.");
    else Console.Write($"число {a} НЕ ЯВЛЯЕТСЯ палиндромом.");
}

Console.Clear();

Console.Write("наше число -> ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("его версия задом наперёд -> ");
int MUN = Perevjortish(num);
Console.Write(MUN);

Console.WriteLine();
ProverkaPalindroma(num);


// КОНЕЦ КОДА ЗАДАЧИ 19

//-------------------------------------------------------------

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// НАЧАЛО КОДА ЗАДАЧИ 21
/*

double DlinaV3D(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double dlina = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
    return dlina;
}

Console.Clear();

Console.Write("введи координату xA -> ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.Write("введи координату xB -> ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.Write("введи координату yA -> ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.Write("введи координату yB -> ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.Write("введи координату yC -> ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.Write("введи координату yC -> ");
int zCoordB = Convert.ToInt32(Console.ReadLine());


double dist = DlinaV3D(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Расстояние между A ({xCoordA},{yCoordA},{zCoordA}) и B ({yCoordB},{yCoordB},{zCoordB}) В ТРИДЭ -> {dist:f2}");

*/
// КОНЕЦ КОДА ЗАДАЧИ 21

//-------------------------------------------------------------

// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// НАЧАЛО КОДА ЗАДАЧИ 23

/*

void KuBbl_ot_1_do_N(int N)
{
    int curr = 0;
    while (curr <= N)
    {
        int result = curr*curr*curr; // или Math.Pow(curr, 3)
        Console.Write($"{result}, ");
        curr++;
    }
    Console.WriteLine("\b\b."); // удаляем 2 знака и ставим точку в конце
}
void Proverka(int a)
{
    while (a <= 0)
    {
        Console.Write("сказано же - ПОЛОЖИТЕЛЬНОЕ. давай по новой -> ");
        a = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Clear();
Console.Write("введи положительное число -> ");
int num = Convert.ToInt32(Console.ReadLine());

Proverka(num);
KuBbl_ot_1_do_N(num);

*/

// КОНЕЦ КОДА ЗАДАЧИ 23

//-------------------------------------------------------------