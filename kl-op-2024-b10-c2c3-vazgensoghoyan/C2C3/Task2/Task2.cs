﻿namespace Task2
{
    public class Task2
    {
        /*
         * Задание 2.0. Прочтите задания 2.1-2.4, затем посмотрите, как тестируются реализации этих функций
         * в файле `Task2/Task2Test.cs`, и добавьте по аналогии собственные тестовые случаи
         * вместо выкидывания исключения.
         * Постарайтесь покрыть тестами как можно больше различных вариантов значений входных параметров.
         */
        
        /*
         * Задание 2.1. Напишите функцию `min3`, которая вычисляет наименьшее из трёх заданных чисел.
         * В решении необходимо воспользоваться изменяемой переменной (var) для результата,
         * последовательно сравнивая её с заданными числами.
         */
        internal static Int32 Min3( Int32 a, Int32 b, Int32 c )
        {
            var res = a;
            if (res > b) res = b;
            if (res > c) res = c;
            return res;
        }

        /*
         * Задание 2.2. Напишите функцию `max3`, которая вычисляет наибольшее из трёх заданных чисел.
         * Функция должна иметь вид одного выражения (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members#methods).
         * Использование функций стандартной библиотеки в решении не допускается.
         */
        internal static Int32 Max3(Int32 a, Int32 b, Int32 c) => -Min3(-a, -b, -c);

        /*
         * Задание 2.3. Дано значение угла α (типа Double) в градусах. Определите значение этого же угла в радианах,
         * учитывая, что 180° = π радианов (константа Math.PI).
         */
        internal static Double Deg2Rad( Double aDeg ) => aDeg / 180 * Math.PI;

        /*
         * Задание 2.4. Дано значение угла α в радианах. Определить значение этого же угла в градусах,
         * учитывая, что 180° = π радианов.
         */
        internal static Double Rad2Deg( Double aRad ) => aRad * 180 / Math.PI;

        public static void Main( String[] args )
        {
            Console.WriteLine( Min3( 2, 0, 3 ) );
            Console.WriteLine( Max3( 2, 0, 3 ) );
            Console.WriteLine( Deg2Rad( 180.0 ) );
            Console.WriteLine( Rad2Deg( Math.PI ) );
        }
    }
}
