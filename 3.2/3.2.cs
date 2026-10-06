using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_practic__3._2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 51. Ввести балл за тест (0–100). Вывести оценку по шкале ECTS: A (90-100), B (80-89), C (70-79), D (60-69), F (менее 60).



            Console.Write("Введите баллы за тест (0-100): ");
            int mark = int.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
            {
                Console.WriteLine("Оценка: A");
            }

            else if (mark >= 80 && mark <= 89)
            {
                Console.WriteLine("Оценка: B");
            }

            else if (mark >= 70 && mark <= 79)
            {
                Console.WriteLine("Оценка: C");
            }

            else if (mark >= 60 && mark <= 69)
            {
                Console.WriteLine("Оценка: D");
            }

            else if (mark < 60)
            {
                Console.WriteLine("Оценка: F");
            }



            // 52. Ввести возраст человека. Определить категорию: ребенок (0-12), подросток (13-17), взрослый (18-64), пожилой (65+).



            Console.Write("Введите возраст человека: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 12)
            {
                Console.WriteLine("Ребенок");
            }

            else if (age >= 13 && age <= 17)
            {
                Console.WriteLine("Подросток");
            }

            else if (age >= 18 && age <= 64)
            {
                Console.WriteLine("Взрослый");
            }

            else if (age >= 65)
            {
                Console.WriteLine("Пожилой");
            }



            // 53. Ввести температуру воды. Вывести ее агрегатное состояние: «Лед» ( ≤ 0 ), «Жидкость» ( 0 < t < 100 ), «Пар» ( ≥ 100 ).



            Console.Write("Введите температуру воды: ");
            int t = int.Parse(Console.ReadLine());

            if (t == 0)
            {
                Console.WriteLine("Лед");
            }

            else if (t > 0 && t < 100)
            {
                Console.WriteLine("Жидкость");
            }

            else if (t >= 100)
            {
                Console.WriteLine("Пар");
            }



            // 54. Ввести уровень заряда аккумулятора смартфона (в %). Вывести: «Критический» ( < 10 ), «Низкий» (10-20), «Нормальный» (21-80), «Полный» (81-100).



            Console.Write("Введите уровень заряда аккумулятора: ");
            int zaryad = int.Parse(Console.ReadLine());

            if (zaryad < 10)
            {
                Console.WriteLine("Критический");
            }

            else if (zaryad >= 10 && zaryad <= 20)
            {
                Console.WriteLine("Низкий");
            }

            else if (zaryad >= 21 && zaryad <= 80)
            {
                Console.WriteLine("Нормальный");
            }

            else if (zaryad >= 81 && zaryad <= 100)
            {
                Console.WriteLine("Полный");
            }



            // 55. Ввести число оборотов двигателя в минуту (RPM). Вывести режим: «Заглушен» (0), «Холостой ход» (1-900), «Рабочий» (901-3500), «Красная зона» (3501+).

            Console.Write("Введите число оборотов в минуту: ");
            int RPM = int.Parse(Console.ReadLine());

            if (RPM == 0)
            {
                Console.WriteLine("Заглушен");
            }

            else if (RPM >= 1 && RPM <= 900)
            {
                Console.WriteLine("Холостой ход");
            }

            else if (RPM >= 901 && RPM <= 3500)
            {
                Console.WriteLine("Рабочий");
            }

            else if (RPM >= 3501)
            {
                Console.WriteLine("Красная зона");
            }



            // 56. Ввести сумму дохода за год. Рассчитать подоходный налог: до 2.4 млн — 13%, до 5 млн — 15%, выше 5 млн — 18%.

            Console.Write("Введите сумму дохода за год: ");
            decimal money = decimal.Parse(Console.ReadLine());

            int percent13 = 13;
            int percent15 = 15;
            int percent18 = 18;

            if (money <= 2400000m)
            {
                Console.WriteLine($"Подоходный налог составит 13%. К оплате: {(money * percent13) / 100}");
            }

            else if (money > 2400000 && money <= 5000000)
            {
                Console.WriteLine($"Подоходный налог составит 15%. К оплате: {(money * percent15) / 100}");
            }

            else if (money > 5000000)
            {
                Console.WriteLine($"Подоходный налог составит 18%. К оплате: {(money * percent18) / 100}");
            }



            // 57. По введенной координате X точки на плоскости (при Y = 0 ) определить ее положение: на нуле, в положительной или отрицательной полуоси.

            Console.Write("Введите координату точки X: ");
            int X = int.Parse(Console.ReadLine());

            if (X == 0)
            {
                Console.WriteLine("Точка X лежит на нуле");
            }

            else if (X > 0)
            {
                Console.WriteLine("Точка X лежит на положительной полуоси");
            }

            else if (X < 0)
            {
                Console.WriteLine("Точка X лежит на отрицательной полуоси");
            }



            // 58. Ввести индекс массы тела (ИМТ). Вывести категорию: дефицит веса ( < 18.5 ), норма (18.5-24.9), избыток (25-29.9), ожирение ( 30 + ).

            Console.Write("Введите индекс массы тела (ИМТ): ");
            decimal imt = decimal.Parse(Console.ReadLine());

            if (imt < 18.5m)
            {
                Console.WriteLine("Дефицит веса");
            }

            else if (imt >= 18.5m && imt <= 24.9m)
            {
                Console.WriteLine("Норма");
            }

            else if (imt >= 25 && imt < 29.9m)
            {
                Console.WriteLine("Избыток");
            }

            else if (imt > 30)
            {
                Console.WriteLine("Ожирение");
            }



            // 59. Ввести скорость ветра (м/с). Вывести категорию по шкале: штиль ( < 0.2 ), легкий ветерок (0.2-5), умеренный (5.1-14), шторм (14.1-24), ураган ( > 24 ).

            Console.Write("Введите скорость ветра: ");
            decimal v = decimal.Parse(Console.ReadLine());

            if (v < 0.2m)
            {
                Console.WriteLine("Штиль");
            }

            else if (v >= 0.2m && v <= 5)
            {
                Console.WriteLine("Легкий ветерок");
            }

            else if (v >= 5.1m && v <= 14)
            {
                Console.WriteLine("Умеренный");
            }

            else if (v >= 14.1m && v < 24)
            {
                Console.WriteLine("Шторм");
            }

            else if (v >= 24)
            {
                Console.WriteLine("Ураган");
            }



            // 60. Ввести стаж работы сотрудника (в годах). Вывести размер надбавки: < 1 года — 0%, 1-5 лет — 5%, 6-10 лет — 10%, > 10 лет — 15%.

            Console.Write("Введите стаж работы сотрудника в годах: ");
            int year = int.Parse(Console.ReadLine());

            if (year < 1)
            {
                Console.WriteLine("Надбавка 0%");
            }

            else if (year >= 1 && year <= 5)
            {
                Console.WriteLine("Надбавка 5%");
            }

            else if (year >= 6 && year <= 10)
            {
                Console.WriteLine("Надбавка 10%");
            }

            else if (year > 10)
            {
                Console.WriteLine("Надбавка 15%");
            }



            // 61. Пользователь вводит текущий час (0–23). Вывести: «Ночь» (0-5), «Утро» (6-11), «День» (12-17), «Вечер» (18-23).

            Console.Write("Введите текущий час (0-23): ");
            int hour = int.Parse(Console.ReadLine());

            if (hour >= 0 && hour <= 5)
            {
                Console.WriteLine("Ночь");
            }

            else if (hour >= 6 && hour <= 11)
            {
                Console.WriteLine("Утро");
            }

            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("День");
            }

            else if (hour >= 18 && hour <= 23)
            {
                Console.WriteLine("Вечер");
            }



            // 62. Ввести толщину льда на водоеме (см). Вывести: «Выход запрещен» ( < 7 ), «Одиночный пешеход» (7-12), «Группа людей» (13-20), «Транспорт» ( > 20 ).



            Console.Write("Введите толщину льда на водоеме (см): ");
            int ice = int.Parse(Console.ReadLine());

            if (ice < 7)
            {
                Console.WriteLine("Вход запрещен");
            }

            else if (ice >= 7 && ice <= 12)
            {
                Console.WriteLine("Одиночный пешеход");
            }

            else if (ice >= 13 && ice <= 20)
            {
                Console.WriteLine("Группа людей");
            }

            else if (ice > 20)
            {
                Console.WriteLine("транспорт");
            }



            // 63. Даны три целых числа A , B , C . Найти максимальное из них, используя каскадное условие.

            Console.Write("Введите первое целое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int C = int.Parse(Console.ReadLine());

            if (A >= B && A >= C)
            {
                Console.WriteLine($"max: {A}");
            }

            else if (B >= A && B >= C)
            {
                Console.WriteLine($"max: {B}");
            }

            else
            {
                Console.WriteLine($"max: {C}");
            }



            // 64. Даны три числа. Найти минимальное из них.

            Console.Write("Введите первое целое число: ");
            int Q = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int W = int.Parse(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int E = int.Parse(Console.ReadLine());

            if (Q <= W && E <= E)
            {
                Console.WriteLine($"min: {Q}");
            }

            else if (W <= Q && W <= E)
            {
                Console.WriteLine($"min: {W}");
            }

            else
            {
                Console.WriteLine($"min: {E}");
            }



            // 65. Даны три числа. Определить, сколько из них положительных (0, 1, 2 или 3).

            Console.Write("Введите первое целое число: ");
            int Z = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int V = int.Parse(Console.ReadLine());

            int score = 0;

            if (Z > 0)
            {
                score++;
            }

            if (X > 0)
            {
                score++;
            }

            if (V > 0)
            {
                score++;
            }

            Console.WriteLine($"Количество положительных чисел: {score}");



            // 66. Ввести средний балл диплома. Вывести: «Без отличия» ( < 4.5 ), «Претендент на красный диплом» (4.5-4.74), «Красный диплом» ( ≥ 4.75 ).

            Console.Write("Введите средный балл диплома: ");
            decimal ball = decimal.Parse(Console.ReadLine());

            if (ball < 4.5m)
            {
                Console.WriteLine("Без отличия");
            }

            else if (ball >= 4.5m && ball <= 4.74m)
            {
                Console.WriteLine("Претендент на красный диплом");
            }

            else if (ball >= 4.75m)
            {
                Console.WriteLine("Красный диплом");
            }



            // 67. Ввести значение артериального давления (систолическое). Вывести: гипотония ( < 90 ), норма (90-120), предгипертензия (121-139), гипертензия ( ≥ 140 ).

            Console.Write("Введите значение артериального давления: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 90)
            {
                Console.WriteLine("Гипотония");
            }

            else if (number >= 90 && number <= 120)
            {
                Console.WriteLine("Норма");
            }

            else if (number >= 121 && number <= 139)
            {
                Console.WriteLine("Предгипертензия");
            }

            else if (number >= 140)
            {
                Console.WriteLine("Гипертензия");
            }



            // 68. Ввести рейтинг шахматиста (Эло). Вывести ранг: любитель ( < 1400 ), разрядник (1400-1999), мастер (2000-2399), гроссмейстер ( ≥ 2400 ).

            Console.Write("Введите рейтинг шахматиста: ");
            int elo = int.Parse(Console.ReadLine());

            if (elo < 1400)
            {
                Console.WriteLine("Любитель");
            }

            else if (elo >= 1400 && elo <= 1999)
            {
                Console.WriteLine("Разрядник");
            }

            else if (elo >= 2000 && elo <= 2399)
            {
                Console.WriteLine("Мастер");
            }

            else if (elo >= 2400)
            {
                Console.WriteLine("Гроссмейстер");
            }



            // 69. Ввести число и определить, сколькизначным оно является (однозначное, двузначное, трехзначное или более).

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 9)
            {
                Console.WriteLine("Число однозначное");
            }

            else if (number >= 10 && number <= 99)
            {
                Console.WriteLine("Число двузначное");
            }

            else if (number >= 100 && number <= 999)
            {
                Console.WriteLine("Число Трехзначное");
            }

            else
            {
                Console.WriteLine("другое");
            }



            // 70. Ввести дальность поездки на такси (км). Рассчитать тариф: до 5 км — 200 руб, от 5 до 15 км — 200 + 25 руб/км, свыше 15 км — 200 + 20 руб/км.

            Console.Write("Ввести дальность поездки на такси: ");
            int km = int.Parse(Console.ReadLine());

            if (km <= 5)
            {
                Console.WriteLine("Сумма поездки: 200 рублей");
            }

            else if (km >= 5 && km <= 15)
            {
                Console.WriteLine($"Сумма поездки: {200 + (km - 5) * 25} рублей");
            }

            else if (km > 15)
            {
                Console.WriteLine($"Сумма поездки: {200 + (15 - 5) * 25 + (km - 15) * 20} рублей");
            }



            // 71. Ввести количество осадков за сутки (мм). Определить: без осадков (0), слабый дождь (0.1-4), умеренный (4.1-15), сильный ливень ( > 15 ).

            Console.Write("Введите количество осадков за сутки: ");
            decimal mm = decimal.Parse(Console.ReadLine());

            if (mm == 0)
            {
                Console.WriteLine("Без осадков");
            }

            else if (mm >= 0.1m && mm <= 4)
            {
                Console.WriteLine("Слабый дождь");
            }

            else if (mm >= 4.1m && mm <= 15)
            {
                Console.WriteLine("Умеренный");
            }

            else if (mm > 15)
            {
                Console.WriteLine("Сильный Ливень");
            }



            // 72. Ввести процент выполнения плана продаж. Вывести статус: план сорван ( < 70 ), удовлетворительно (70-99%), выполнен (100-119%), перевыполнен ( ≥ 120 ).

            Console.Write("Введите процент выполнения плана продаж: ");
            int plan = int.Parse(Console.ReadLine());

            if (plan < 70)
            {
                Console.WriteLine("План сорван");
            }

            else if (plan >= 70 && plan <= 99)
            {
                Console.WriteLine("Удовлетворительно");
            }

            else if (plan >= 100 && plan <= 119)
            {
                Console.WriteLine("Выполнен");
            }

            else if (plan >= 120)
            {
                Console.WriteLine("Перевыполнен");
            }



            // 73. Даны три числа. Упорядочить их по возрастанию и вывести на консоль.

            Console.Write("Введите первое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int C = int.Parse(Console.ReadLine());

            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }

            if (A > C)
            {
                int temp = A;
                A = C;
                C = temp;
            }

            if (B > C)
            {
                int temp = B;
                B = C;
                C = temp;
            }

            Console.WriteLine($"{A} {B} {C}");



            // 74. Дано число X . Вычислить значение кусочно-заданной функции: f ( x ) = x 2 , если x > 0 ; f ( x ) = 0 , если x = 0 ; f ( x ) = − x , если x < 0 .

            Console.Write("Введите число: ");
            int X = int.Parse(Console.ReadLine());

            int f;

            if (X > 0)
            {
                f = X * X;
            }

            else if (X == 0)
            {
                f = 0;
            }

            else
            {
                f = -X;
            }

            Console.WriteLine($"f(x) = {f}");



            // 75. Ввести октановое число бензина. Классифицировать: < 92 — несоответствие стандарту, 92 — АИ-92, 95 — АИ-95, 98-100 — АИ-98/100, > 100 — спорт/авиатопливо.

            Console.Write("Введите октановое число бензина: ");
            int okt = int.Parse(Console.ReadLine());

            if (okt < 92)
            {
                Console.WriteLine("Несоответствие стандарту");
            }

            else if (okt == 92)
            {
                Console.WriteLine("АИ-92");
            }

            else if (okt == 95)
            {
                Console.WriteLine("АИ-95");
            }

            else if (okt == 98 && okt == 100)
            {
                Console.WriteLine("АИ-98/100");
            }

            else if (okt > 100)
            {
                Console.WriteLine("Спорт/Авиатопливо");
            }



            // 76. Ввести сумму покупок за месяц для начисления кешбэка: до 10 000 руб — 1%, до 50 000 руб — 3%, свыше 50 000 руб — 5%. Вывести сумму кешбэка.

            Console.Write("Введите сумму покупок за месяц для начисления кешбэка: ");
            decimal cb = decimal.Parse(Console.ReadLine());

            if (cb < 10000)
            {
                Console.WriteLine($"Кешбек 1%: {cb * 1 / 100}");
            }

            else if (cb >= 10000 && cb <= 50000)
            {
                Console.WriteLine($"Кешбек 3%: {cb * 3 / 100}");
            }

            else if (cb > 50000)
            {
                Console.WriteLine($"Кешбек 5%: {cb * 5 / 100}");
            }



            // 77. Ввести глубину погружения аквалангиста (метры). Вывести зону: рекреационная ( < 40 ), техническая (40-100), глубоководная ( > 100 ).

            Console.Write("Введите глубину погружения аквалангиста: ");
            int m = int.Parse(Console.ReadLine());

            if (m < 40)
            {
                Console.WriteLine("Рекреационная");
            }

            else if (m >= 40 && m <= 100)
            {
                Console.WriteLine("Техническая");
            }

            else if (m >= 100)
            {
                Console.WriteLine("Глубоководная");
            }



            // 78. Ввести количество штрафных баллов водителя. Вывести: «Предупреждение» (1-5), «Временное ограничение» (6-10), «Лишение прав» ( > 10 ).

            Console.Write("Введите количество штрафных баллов водителя: ");
            int straf = int.Parse(Console.ReadLine());

            if (straf >= 1 && straf <= 5)
            {
                Console.WriteLine("Предупреждение");
            }

            else if (straf >= 6 && straf <= 10)
            {
                Console.WriteLine("Предупреждение");
            }

            else if (straf > 10)
            {
                Console.WriteLine("Предупреждение");
            }



            // 79. Ввести уровень кислотности почвы (pH). Определить: кислая ( < 6.0 ), нейтральная (6.0-7.2), щелочная ( > 7.2 ).

            Console.Write("Введите уровень кислотности почвы: ");
            decimal pH = decimal.Parse(Console.ReadLine());

            if (pH < 6.0m)
            {
                Console.WriteLine("Кислая");
            }

            else if (pH >= 6.0m && pH <= 7.2m)
            {
                Console.WriteLine("Нейтральная");
            }

            else if (pH > 7.2m)
            {
                Console.WriteLine("Щелочная");
            }



            // 80. Ввести количество набранных очков в компьютерной игре. Присвоить медаль: Бронзовая (1000-2499), Серебряная (2500-4999), Золотая (5000+), иначе без медали.

            Console.Write("Введите количество набранных очков в компьютерной игре: ");
            int point = int.Parse(Console.ReadLine());

            if (point >= 1000 && point <= 2499)
            {
                Console.WriteLine("Бронзовая медаль");
            }

            else if (point >= 2500 && point <= 4999)
            {
                Console.WriteLine("Серебрянная медаль");
            }

            else if (point >= 5000)
            {
                Console.WriteLine("Золотая медаль");
            }

            else
            {
                Console.WriteLine("Без медали");
            }



            // 81. Ввести крепость напитка в градусах. Классифицировать: безалкогольный (0), слабоалкогольный (0.1-8), среднеалкогольный (8.1-25), крепкий ( > 25 ).

            Console.Write("Введите крепость напитка в градусах: ");
            decimal gradus = decimal.Parse(Console.ReadLine());

            if (gradus == 0)
            {
                Console.WriteLine("Безалкогольный");
            }

            else if (gradus >= 0.1m && gradus <= 8)
            {
                Console.WriteLine("Слабоалкогольный");
            }

            else if (gradus >= 8.1m && gradus <= 25)
            {
                Console.WriteLine("Среднеалкогольный");
            }

            else if (gradus > 25)
            {
                Console.WriteLine("Крепкий");
            }



            // 82. Ввести показатель уровня шума в децибелах (дБ). Вывести вердикт: тихо ( < 40 ), норма (40-60), шумно (61-80), вредно для здоровья ( > 80 ).

            Console.Write("Введите показатель уровня шума в децибелах: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 40)
            {
                Console.WriteLine("Тихо");
            }

            else if (number >= 40 && number <= 60)
            {
                Console.WriteLine("Норма");
            }

            else if (number >= 61 && number <= 80)
            {
                Console.WriteLine("Шумно");
            }
            else if (number > 80)
            {
                Console.WriteLine("Вредно для здоровья");
            }



            // 83. Ввести вес почтовой посылки (кг). Рассчитать категорию отправления: мелкий пакет ( < 2 ), стандартная (2-10), тяжеловесная (10.1-31.5), крупногабарит ( > 31.5 ).

            Console.Write("вес почтовой посылки: ");
            decimal kg = decimal.Parse(Console.ReadLine());

            if (kg < 2)
            {
                Console.WriteLine("Мелкий пакет");
            }

            else if (kg >= 2 && kg <= 10)
            {
                Console.WriteLine("Стандартная");
            }

            else if (kg >= 10.1m && kg <= 31.5m)
            {
                Console.WriteLine("Тяжеловесная");
            }

            else if (kg > 31.5m)
            {
                Console.WriteLine("Крупногабарит");
            }



            // 84. Ввести количество комнат в квартире. Вывести: студия/однокомнатная (1), двухкомнатная (2), трехкомнатная (3), многокомнатная (4+).

            Console.Write("Введите количество комнат в квартире: ");
            int room = int.Parse(Console.ReadLine());

            if (room == 1)
            {
                Console.WriteLine("Студия/однокомнатная");
            }

            else if (room == 2)
            {
                Console.WriteLine("Двухкомнатная");
            }

            else if (room == 3)
            {
                Console.WriteLine("Трехкомнатная");
            }

            else if (room >= 4)
            {
                Console.WriteLine("Многокомнатная");
            }



            // 85. Ввести процент заряда повербанка. Вывести количество светящихся светодиодов на корпусе (1, 2, 3 или 4).

            Console.Write("Введите процент заряда повербанка: ");
            int zaryad = int.Parse(Console.ReadLine());

            if (zaryad > 0 && zaryad <= 25)
            {
                Console.WriteLine("1");
            }

            else if (zaryad > 25 && zaryad <= 50)
            {
                Console.WriteLine("2");
            }

            else if (zaryad > 50 && zaryad <= 75)
            {
                Console.WriteLine("3");
            }

            else if (zaryad > 75 && zaryad <= 100)
            {
                Console.WriteLine("4");
            }



            // 86. Ввести выслугу лет военнослужащего. Вывести процент пенсионной надбавки.

            Console.Write("Введите выслугу лет военнослужащего: ");
            int year = int.Parse(Console.ReadLine());

            if (year > 0 && year < 10)
            {
                Console.WriteLine("10%");
            }

            else if (year >= 10 && year < 15)
            {
                Console.WriteLine("20%");
            }

            else if (year >= 15 && year < 20)
            {
                Console.WriteLine("30%");
            }



            // 87. Ввести время отклика сервера (пинг в мс). Вывести: идеальный ( < 20 ), хороший (20-60), посредственный (61-120), плохой ( > 120 ).

            Console.Write("Введите время отклика сервера: ");
            int ms = int.Parse(Console.ReadLine());

            if (ms < 20)
            {
                Console.WriteLine("Идеалный");
            }

            else if (ms >= 20 && ms <= 60)
            {
                Console.WriteLine("Хороший");
            }

            else if (ms >= 61 && ms <= 120)
            {
                Console.WriteLine("Посредственный");
            }

            else if (ms > 120)
            {
                Console.WriteLine("Высокий пинг");
            }



            // 88. Ввести концентрацию CO2 в помещении (ppm). Вывести вердикт: норма ( < 800 ), душно (800-1200), проветрить немедленно ( > 1200 ).

            Console.Write("Введите концентрацию CO2 в помещении: ");
            int CO2 = int.Parse(Console.ReadLine());

            if (CO2 < 800)
            {
                Console.WriteLine("Норма");
            }

            else if (CO2 >= 800 && CO2 <= 1200)
            {
                Console.WriteLine("Душно");
            }

            else if (CO2 > 1200)
            {
                Console.WriteLine("Проветрить немедленно");
            }



            // 89. Ввести количество пройденных шагов за день. Вывести: гиподинамия ( < 5000 ), норма (5000-9999), активный день (10000-14999), рекорд ( > 15000 ).

            Console.Write("Введите количество пройденных шагов за день: ");
            int step = int.Parse(Console.ReadLine());

            if (step < 5000)
            {
                Console.WriteLine("Гиподинамия");
            }

            else if (step >= 5000 && step <= 9999)
            {
                Console.WriteLine("Норма");
            }

            else if (step >= 10000 && step <= 14999)
            {
                Console.WriteLine("Активный день");
            }

            else if (step > 15000)
            {
                Console.WriteLine("Рекорд");
            }



            // 90. Ввести диаметр автомобильного колесного диска в дюймах. Определить класс: малолитражки (13-14), компактные авто (15-16), кроссоверы/бизнес (17-19), внедорожники/спорт ( 20 + ).

            Console.Write("Введите диаметр автомобильного колесного диска: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 13 && number <= 14)
            {
                Console.WriteLine("Малолитражки");
            }

            else if (number >= 15 && number <= 16)
            {
                Console.WriteLine("Компактные авто");
            }

            else if (number >= 17 && number <= 19)
            {
                Console.WriteLine("Кроссоверы/бизнес");
            }

            else if (number > 20)
            {
                Console.WriteLine("Внедорожники/спорт");
            }



            // 91. Ввести значение влажности воздуха (%). Вывести: сухой воздух ( < 30 ), комфорт (30-60), повышенная влажность ( > 60 ).

            Console.Write("Введите значение влажности воздуха: ");
            int Number = int.Parse(Console.ReadLine());

            if (Number < 30)
            {
                Console.WriteLine("Сухой воздух");
            }

            else if (Number >= 30 && Number <= 60)
            {
                Console.WriteLine("Комфорт");
            }

            else if (Number > 60)
            {
                Console.WriteLine("Повышенная влажность");
            }



            // 92. Даны три числа. Проверить, сколько из них равны между собой (все разные, два равны, все три равны).

            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int number3 = int.Parse(Console.ReadLine());

            int score = 0;

            if (number1 == number2)
            {
                score++;
            }

            if (number1 == number3)
            {
                score++;
            }

            if (number2 == number3)
            {
                score++;
            }



            if (score == 0)
            {
                Console.WriteLine("Все разные");
            }

            if (score == 1)
            {
                Console.WriteLine("два равны");
            }

            if (score == 3)
            {
                Console.WriteLine("Все равны");
            }



            // 93. Ввести номер четверти координатной плоскости (1–4) и вывести диапазоны знаков для координат X и Y .

            Console.Write("Введите первое число: ");
            int number = int.Parse(Console.ReadLine());


            if (number == 1)
            {
                Console.WriteLine("X < 0 ; Y > 0");
            }

            if (number == 2)
            {
                Console.WriteLine("X > 0 ; Y > 0");
            }

            if (number == 3)
            {
                Console.WriteLine("X > 0 ; Y < 0");
            }

            if (number == 4)
            {
                Console.WriteLine("X < 0 ; Y < 0");
            }



            // 94. Ввести температуру процессора компьютера. Вывести: холодный ( < 45 ), нормальная нагрузка (45-75), троттлинг/перегрев ( > 75 ).

            Console.Write("Введите температуру процессора компьютера: ");
            int t = int.Parse(Console.ReadLine());

            if (t < 45)
            {
                Console.WriteLine("Холодный");
            }

            else if (t >= 45 && t <= 75)
            {
                Console.WriteLine("Нормальная нагрузка");
            }

            else if (t > 75)
            {
                Console.WriteLine("Тротлинг/перегрев");
            }



            // 95. Ввести остаток срока годности продукта в днях. Вывести: «Срочно употребить» ( ≤ 2 ), «Нормально» (3-30), «Длительное хранение» ( > 30 ).

            Console.Write("Введите остаток срока годности продукта в днях: ");
            int T = int.Parse(Console.ReadLine());

            if (T <= 2)
            {
                Console.WriteLine("Срочно употребить");
            }

            else if (t >= 3 && t <= 30)
            {
                Console.WriteLine("Нормально");
            }

            else if (t > 30)
            {
                Console.WriteLine("Длительное хранение");
            }



            // 96. Ввести сумму кредита и срок. Рассчитать процентную ставку в зависимости от срока (до года, до трех лет, свыше трех лет).

            Console.Write("Введите сумму кредита: ");
            decimal credit = decimal.Parse(Console.ReadLine());

            Console.Write("Введите срок кредита: ");
            decimal year = decimal.Parse(Console.ReadLine());

            decimal procstavka;

            if (year < 1)
            {
                procstavka = 10;
            }

            else if (year >= 1 && year <= 3)
            {
                procstavka = 15;
            }

            else
            {
                procstavka = 20;
            }

            decimal procenti = credit * (procstavka / 100) * year;
            decimal itog = credit + procenti;

            Console.WriteLine($"Сумма кредита: {credit} рублей");
            Console.WriteLine($"Срок кредита: {year} лет");
            Console.WriteLine($"Процентная ставка по кредиту: {procstavka}%");
            Console.WriteLine($"Нужно будет вернуть банку {itog}");



            // 97. Ввести частоту обновления монитора (Гц). Определить: офис (60-75), базовый игровой (120-144), киберспорт ( 165 + ).

            Console.Write("Введите частоту обновления монитора: ");
            int Gz = int.Parse(Console.ReadLine());

            if (Gz >= 60 && Gz <= 75)
            {
                Console.WriteLine("Офис");
            }

            else if (Gz >= 120 && Gz <= 144)
            {
                Console.WriteLine("Игровой");
            }

            else if (Gz >= 165)
            {
                Console.WriteLine("Игровой");
            }



            // 98. Ввести расход топлива автомобиля на 100 км пути. Вывести вердикт: экономичный ( < 6 л), средний (6-10 л), прожорливый ( > 10 л).

            Console.Write("Введите расход топлива автомобиля на 100 км пути: ");
            int L = int.Parse(Console.ReadLine());

            if (L < 6)
            {
                Console.WriteLine("Экономичный");
            }

            else if (L >= 6 && L <= 10)
            {
                Console.WriteLine("Средний");
            }

            else if (L > 10)
            {
                Console.WriteLine("Прожорливый");
            }



            // 99. Ввести количество страниц книги. Классифицировать: брошюра ( < 48 ), повесть (48-150), роман (151-600), фолиант ( > 600 ).

            Console.Write("Введите количество страниц книги: ");
            int list = int.Parse(Console.ReadLine());

            if (list < 48)
            {
                Console.WriteLine("Брошюра");
            }

            else if (list >= 48 && list <= 150)
            {
                Console.WriteLine("Повесть");
            }

            else if (list >= 151 && list <= 600)
            {
                Console.WriteLine("Повесть");
            }

            else if (list > 600)
            {
                Console.WriteLine("Фолиант");
            }



            // 100. Ввести число и проверить, попадает ли оно в интервалы [ 0 ; 10 ] , [ 20 ; 30 ] или [ 50 ; 100 ] .

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if ((number >= 0 && number <= 10) || (number >= 20 && number <= 30) || (number >= 50 && number <= 100))
            {
                Console.WriteLine("Число попадает в один из интервалов");
            }

            else
            {
                Console.WriteLine("Число не попадает ни в один из интервалов");
            }
        }
    }
}