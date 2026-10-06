using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _3_practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите целое число: ");

            //int number = int.Parse(Console.ReadLine());
            //if (number > 0) Console.WriteLine("Число положительное");
            //else Console.WriteLine("Число отрицательное");



            //Console.Write("Введите целое число: ");

            //int Number = int.Parse(Console.ReadLine());
            //if (Number % 2 == 0) Console.WriteLine("Число четное");
            //else Console.WriteLine("Число нечетное");



            //Console.Write("Введите первое число: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int number2 = int.Parse(Console.ReadLine());

            //if (number1 > number2)
            //{
            //    Console.WriteLine($"наибольшее число: {number1}");
            //}

            //else
            //{
            //    Console.WriteLine($"наибольшее число: {number2}");
            //}


            //Даны два числа с плавающей точкой. Вывести наименьшее.


            //Console.Write("Введите первое число: ");
            //decimal Number1 = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //decimal Number2 = decimal.Parse(Console.ReadLine());

            //if (number1 < number2)
            //{
            //    Console.WriteLine($"Наименьшее число: {number1}");
            //}

            //else
            //{
            //    Console.WriteLine($"Наименьшее число: {number2}");
            //}


            //Проверить, делится ли введенное число нацело на 5


            Console.Write("Введите число: ");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 5 == 0)
            {
                Console.WriteLine($"Число {number1} делится на 5");
            }

            else
            {
                Console.WriteLine($"Число {number1} не делится на 5");
            }


            //Проверить, оканчивается ли введенное целое число нулем.


            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0)
            {
                Console.WriteLine($"Число {number} заканчивается нулем");
            }

            else
            {
                Console.WriteLine($"Число {number} не заканчивается нулем");
            }


            //Пользователь вводит температуру воздуха. Если она ниже нуля, вывести: «На улице мороз, наденьте шапку».


            Console.Write("Введите температуру воздуха: ");
            int t = int.Parse(Console.ReadLine());

            if (t < 0)
            {
                Console.WriteLine($"Температура воздуха {t}, на улице мороз, наденьте шапку");
            }

            else
            {
                Console.WriteLine($"Температура воздуха {t}, надевать шапку необязательно");
            }


            //Дано число. Если оно больше 100, уменьшить его на 20, иначе увеличить на 10.


            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine($"Результат: {number -= 20}");
            }

            else
            {
                Console.WriteLine($"Результат: {number += 10}");
            }


            //Ввести два числа. Если они равны, вывести «Числа равны», иначе вывести их произведение.


            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"Числа равны");
            }

            else
            {
                Console.WriteLine($"{number1 + number2}");
            }


            //Пользователь вводит свой возраст. Если возраст от 18 и старше, вывести «Доступ разрешен», иначе «Доступ запрещен».


            Console.Write("Введите свой возраст: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Доступ разрешен");
            }

            else
            {
                Console.WriteLine("Доступ запрещен");
            }


            //Ввести число. Если оно трехзначное, вывести «Да», иначе «Нет».


            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 999)
            {
                Console.WriteLine($"Число {number} является трехзначным");
            }

            else
            {
                Console.WriteLine($"Число {number} не является трехзначным");
            }


            //Проверить, делится ли число на 3 без остатка.


            Console.Write("Введите число: ");
            int Тumber = int.Parse(Console.ReadLine());

            if (Тumber % 3 == 0)
            {
                Console.WriteLine($"Число {number} делится на 3 без остатка");
            }

            else
            {
                Console.WriteLine($"Число {number} не делится на 3 без остатка");
            }


            //Даны координаты точки на числовой прямой X. Определить, лежит ли точка правее нуля.


            Console.Write("Введите координату точки на числовой прямой X: ");
            int point = int.Parse(Console.ReadLine());

            if (point > 0)
            {
                Console.WriteLine($"Координата {point} лежит правее нуля");
            }

            else
            {
                Console.WriteLine($"Координата {point} лежит левее нуля");
            }


            //Ввести баланс счета. Если баланс отрицательный, вывести «Задолженность!».


            Console.Write("Введите баланс счета: ");
            int balance = int.Parse(Console.ReadLine());

            if (balance > 0)
            {
                Console.WriteLine($"На баласе {balance} рублей");
            }

            else
            {
                Console.WriteLine("Задолженность!");
            }


            //Пользователь вводит пароль (целое число). Если введен 1234, вывести «Вход выполнен», иначе «Неверный пароль».


            Console.Write("Введите пароль: ");
            int password = int.Parse(Console.ReadLine());

            if (password == 1234)
            {
                Console.WriteLine("Вход выполнен");
            }

            else
            {
                Console.WriteLine("Неверный пароль");
            }


            //Проверить, является ли введенное число отрицательным.


            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine($"Число {number} отрицательное");
            }

            else
            {
                Console.WriteLine($"Число {number} положительное");
            }


            //Даны два числа. Вывести разность большего и меньшего числа.


            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            int res = (Math.Abs(number1 - number2));

            Console.WriteLine($"Разность равна: {res}");


            //Ввести сумму покупки. Если сумма превышает 1000 рублей, предоставить скидку 5% и вывести итоговую цену.


            Console.Write("Введите сумму покупки: ");
            int price = int.Parse(Console.ReadLine());

            if (price > 1000)
            {
                int priceiskidka = price * 5 / 100;
                int result = price - priceiskidka;
                Console.WriteLine($"Сумма покупки превышает 1000 рублей, вам пологается скидка в размере 5%. К оплате: {result}");
            }

            else
            {
                Console.WriteLine($"К оплате {price}");
            }


            //Ввести число. Если оно четное, разделить его на 2, если нечетное — умножить на 3.


            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                int numberdelit = number / 2;
                Console.WriteLine($"Число четное, следовательно делим на 2. Ответ: {numberdelit}");
            }

            else
            {
                int numberumnojit = number * 3;
                Console.WriteLine($"Число нечетное, следовательно умножаем на 3. Ответ: {numberumnojit}");
            }


            //Пользователь вводит скорость движения. Если скорость выше 90 км/ч, вывести сообщение о нарушении.


            Console.Write("Введите скорость движения: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed > 90)
            {
                Console.WriteLine("Вы превысили скорость, вам выписан штраф");
            }

            else
            {
                Console.WriteLine("Вы ничего не превысили");
            }


            //Дано целое число. Проверить, равно ли оно нулю.


            Console.Write("Введите число: ");
            int Number = int.Parse(Console.ReadLine());

            if (Number == 0)
            {
                Console.WriteLine("Число равно нулю");
            }

            else
            {
                Console.WriteLine("Число не равно нулю");
            }


            //Ввести два вещественных числа. Проверить, равны ли они с точностью до 0.001.


            Console.Write("Введите первое число: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите первое число: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"Числа {number1:F3} и {number2:F3} равны");
            }

            else
            {
                Console.WriteLine($"Числа {number1:F3} и {number2:F3} не равны");
            }


            //Проверить, делится ли число A на число B без остатка.


            Console.Write("Введите первое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0)
            {
                Console.WriteLine($"Число {A} делится на {B} без остатка");
            }

            else
            {
                Console.WriteLine($"Число {A} делится на {B} с остатком");
            }


            //Даны два угла треугольника в градусах. Проверить, существует ли такой треугольник (сумма меньше 180).


            Console.Write("Введите величину первого угла: ");
            int corner1 = int.Parse(Console.ReadLine());

            Console.Write("Введите величину второго угла: ");
            int corner2 = int.Parse(Console.ReadLine());

            if (corner1 + corner2 >= 180)
            {
                Console.WriteLine("Такой треугольник не существует");
            }

            else
            {
                Console.WriteLine("Такой треугольник существует");
            }


            //Ввести радиус круга и сторону квадрата. Определить, у какой фигуры площадь больше.


            Console.Write("Введите радиус круга: ");
            decimal r = decimal.Parse(Console.ReadLine());

            Console.Write("Введите сторону квадрата: ");
            decimal side = decimal.Parse(Console.ReadLine());

            const decimal Pi = 3.14m;
            decimal S1 = Pi * (r * r);
            decimal S2 = side * side;

            if (S1 > S2)
            {
                Console.WriteLine($"Площадь круга больше {S1}");
            }

            else
            {
                Console.WriteLine($"Площадь квадрата больше {S2}");
            }


            //Ввести два числа. Вывести частное большего на меньшее (предусмотреть проверку деления на 0).


            Console.Write("Введите первое число: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("Деление на 0 невозможно");
            }

            else if (number1 > number2)
            {
                Console.WriteLine($"Результат {number1 / number2}");
            }

            else if (number2 > number1)
            {
                Console.WriteLine($"Результат {number2 / number1}");
            }

            else
            {
                Console.WriteLine($"Числа равны");
            }


            //Проверить, является ли последняя цифра числа семеркой.


            Console.Write("Введите число: ");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 10 == 7)
            {
                Console.WriteLine($"Последняя цифра чила {Number} равна 7");
            }


            //Дано число. Если оно нечетное и положительное, вывести «Да»


            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0 && number > 0)
            {
                Console.WriteLine($"Число {number} нечетное и положительное ");
            }

            else
            {
                Console.WriteLine("Число четное или отрицательное");
            }


            //Ввести объем свободного места на диске (в ГБ). Если места меньше 5 ГБ, вывести предупреждение.


            Console.Write("Введите объем свободного места на диске: ");
            int freeGB = int.Parse(Console.ReadLine());

            if (freeGB < 5)
            {
                Console.WriteLine($"На диске мало места");
            }

            else
            {
                Console.WriteLine($"На диске еще есть место");
            }


            //Пользователь вводит оценку (2, 3, 4, 5). Если оценка 4 или 5, вывести «Молодец», иначе «Нужно подтянуться».


            Console.Write("Оценка: ");
            int mark = int.Parse(Console.ReadLine());

            if (mark == 5 || mark == 4)
            {
                Console.WriteLine("Молодец");
            }

            else if (mark == 2 || mark == 3)
            {
                Console.WriteLine("Нужно подтянуться");
            }

            else
            {
                Console.WriteLine("таких оценок нет");
            }


            //Даны два символа. Проверить, совпадают ли они.


            Console.Write("Введите символ: ");
            string symbol1 = (Console.ReadLine());

            Console.Write("Введите символ: ");
            string symbol2 = (Console.ReadLine());

            if (symbol1 == symbol2)
            {
                Console.WriteLine("Символы совпадают");
            }

            else
            {
                Console.WriteLine("Символы не совпадают");
            }


            //Ввести число. Если оно кратно и 2, и 7, вывести «Кратно 14».


            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 && number % 7 == 0)
            {
                Console.Write("Кратно 14");
            }


            //Ввести массу груза. Если масса превышает допустимые 3.5 тонны, вывести «Перегруз!».


            Console.Write("Введите массу груза: ");
            decimal tonn = decimal.Parse(Console.ReadLine());

            if (tonn > 3.5m)
            {
                Console.WriteLine("Перегруз!");
            }

            else
            {
                Console.WriteLine("Еще место есть");
            }


            //Ввести текущее время (часы от 0 до 23). Если время от 6 до 12, вывести «Доброе утро».


            Console.Write("Введите время: ");
            int time = int.Parse(Console.ReadLine());

            if (time > 6 && time <= 12)
            {
                Console.WriteLine("Доброе утро");
            }

            else if (time > 12 && time <= 16)
            {
                Console.WriteLine("Добрый день");
            }

            else if (time > 16 && time < 23)
            {
                Console.WriteLine("Добрый Вечер");
            }

            else
            {
                Console.WriteLine("Ошибка");
            }


            //Ввести рост человека в см. Если рост больше 200 см, вывести «Очень высокий».


            Console.Write("Введите рост: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 200)
            {
                Console.WriteLine("Очень высокий");
            }

            else
            {
                Console.WriteLine("есть куда расти");
            }


            //Дано двузначное число. Определить, какая из его цифр больше.


            Console.Write("Введите число: ");
            int Number = int.Parse(Console.ReadLine());

            int number1 = Number / 10;
            int number2 = Number % 10;

            if (number1 > number2)
            {
                Console.WriteLine($"Первая цифра числа {Number} больше");
            }

            else if (number2 > number1)
            {
                Console.WriteLine($"Вторая цифра числа {Number} больше");
            }

            else
            {
                Console.WriteLine("Числа равны");
            }


            //Ввести стоимость товара. Если товар бесплатный(цена 0), вывести «Акция!».


            Console.Write("Введите цену товара: ");
            int price = int.Parse(Console.ReadLine());

            if (price == 0)
            {
                Console.WriteLine("Акция!");
            }


            //Проверить, содержит ли введенное двузначное число одинаковые цифры.


            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            int number1 = number / 10;
            int number2 = number % 10;

            if (number1 == number2)
            {
                Console.WriteLine("число содержит одинаковые цифры");
            }

            else
            {
                Console.WriteLine("не содержит");
            }


            //Ввести уровень громкости (0–100). Если громкость превышает 80, вывести «Слишком громко для слуха».


            Console.Write("Введите уровень громкости: ");
            int gromkost = int.Parse(Console.ReadLine());

            if (gromkost > 80)
            {
                Console.WriteLine("Слишком громко для слуха");
            }

            else
            {
                Console.WriteLine("Нормально");
            }


            //Даны два числа. Если их сумма четная, вывести сумму, иначе вывести их разность.


            Console.Write("Введите первое Число: ");
            int Number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе Число: ");
            int Number2 = int.Parse(Console.ReadLine());

            int summ = Number1 + Number2;
            int diff = Number1 - Number2;

            if (summ % 2 == 0)
            {
                Console.WriteLine($"Четная: {summ}");
            }

            else
            {
                Console.WriteLine($"Не четная: {diff}");
            }


            //Ввести количество страниц в документе. Если страниц больше 100, включить двухстороннюю печать.


            Console.Write("Введите количество страниц в документе: ");
            int paper = int.Parse(Console.ReadLine());

            if (paper > 100)
            {
                Console.WriteLine("Двухсторонняя печать включена");
            }


            //Проверить, является ли введенное целое число полным квадратом (для проверки использовать Math.Sqrt).


            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            int res = (int)Math.Sqrt(number);

            if (res * res == number)
            {
                Console.WriteLine($"Введенное целое число {number} является полным квадратом");
            }

            else
            {
                Console.WriteLine("Число не является полным квадратом");
            }


            //Ввести атмосферное давление. Если давление ниже 740 мм рт. ст., вывести «Пониженное давление».


            Console.Write("Введите атмосферное давление: ");
            int Number = int.Parse(Console.ReadLine());

            if (Number < 740)
            {
                Console.WriteLine("Пониженное даление");
            }

            else
            {
                Console.WriteLine("Повышенное даление");
            }


            //Ввести количество забитых мячей командами А и Б. Вывести победителя или сообщить о ничьей.


            Console.Write("Введите количество забитых мячей команды A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите количество забитых мячей команды B: ");
            int B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine($"Команда A выйграла со счетом {A}:{B}");
            }

            else if (B > A)
            {
                Console.WriteLine($"Команда B выйграла со счетом {B}:{A}");
            }

            else
            {
                Console.WriteLine("Ничья");
            }


            //Дано число. Заменить его на абсолютную величину (модуль) без использования Math.Abs


            Console.Write("Введите отрицательное число: ");
            int number1 = int.Parse(Console.ReadLine());

            int res1 = number1 * -1;

            Console.WriteLine($"Ответ {res1}");


            //Ввести показатель уровня сахара в крови. Если показатель выше 6.1 ммоль/л, вывести «Выше нормы».


            Console.Write("Введите показатель уровня сахара в крови: ");
            decimal number = decimal.Parse(Console.ReadLine());

            if (number > 6.1m)
            {
                Console.WriteLine("Выше нормы");
            }

            else
            {
                Console.WriteLine("Норма");
            }


            //Проверить, хватит ли пользователю средств на счете для оплаты проезда стоимостью 35 рублей.


            Console.Write("Введите, сколько средств на счете: ");
            int rub = int.Parse(Console.ReadLine());

            if (rub >= 35)
            {
                Console.WriteLine("Денег на оплату проезда хватит");
            }

            else
            {
                Console.WriteLine("Денег не хватит");
            }


            //Ввести номер текущего этажа. Если этаж выше 10, вывести «Высотный этаж».


            Console.Write("Введите этаж: ");
            int etaj = int.Parse(Console.ReadLine());

            if (etaj > 10)
            {
                Console.WriteLine("Высокий этаж");
            }


            //Ввести два слова. Проверить, одинаковы ли они по длине.


            Console.Write("Введите первое слово: ");
            string word1 = (Console.ReadLine());
            int length1 = word1.Length;

            Console.Write("Введите второе слово: ");
            string word2 = (Console.ReadLine());
            int length2 = word2.Length;

            if (length1 > length2)
            {
                Console.WriteLine("Первое слово длиннее");
            }

            else if (length2 > length1)
            {
                Console.WriteLine("Второе слово длиннее");
            }
            else
            {
                Console.WriteLine("Все слова одинаковые по длинне");
            }


            //Пользователь вводит целое число. Вывести строковое сообщение: «Число четное» либо «Число нечетное».


            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }

            else
            {
                Console.WriteLine("Число нечетное");
            }

        }
    }
}