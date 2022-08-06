// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).



Console.WriteLine("Введите номер четверти");
string num = Console.ReadLine();
string Quarte (string q)
{   

if (q == "1") return"xc >0  && yc >0";
if (q == "2") return "xc < 0  && yc > 0";
if (q == "3") return "xc < 0  && yc < 0";
if (q == "4") return "xc > 0  && yc < 0";
return "введены некорректные короодинвты";

}

string result = Quarte (num);
Console.WriteLine (result);
