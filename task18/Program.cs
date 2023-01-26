Console.WriteLine("Ввеите номер четверти:  ");
int a=Convert.ToInt32(Console.ReadLine());

//проверки
if (a<0 || a>4) Console.WriteLine("Ошибка ввода. Число должно быть от 1 до 4");

else if (a==1) Console.WriteLine("Диапазон координат: x>0;y>0");
else if (a==2) Console.WriteLine("Диапазон координат: x<0;y>0");
else if (a==3) Console.WriteLine("Диапазон координат: x<0;y<0");
else if (a==4) Console.WriteLine("Диапазон координат: x>0;y<0");