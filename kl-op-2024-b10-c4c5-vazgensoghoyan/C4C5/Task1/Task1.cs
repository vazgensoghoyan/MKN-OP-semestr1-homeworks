namespace Task1
{
    public class Task1
    {
        /*
         * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
         * где NN — длина заданной строки. Например, если задана строка "hello",
         * то результатом должна быть строка "Длина: 5".
         */
        internal static Int32 StringLength( String s )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
         * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
         */
        internal static Tuple<Int32?, Int32?> FirstLastCodes( String s )
        {
            throw new NotImplementedException();
        }

        private static Char? First( String s ) => throw new NotImplementedException();
        private static Char? Last( String s ) => throw new NotImplementedException();
        private static Int32? Code( Char? c ) => throw new NotImplementedException();

        /*
         * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
         * В решении необходимо воспользоваться циклом for.
         */
        internal static Int32 CountDigits( String s )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 1.4. Дана строка. Подсчитать количество содержащихся в ней цифр.
         * В решении необходимо воспользоваться методом Count:
         * https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.count?view=net-6.0#system-linq-enumerable-count-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-boolean)))
         * и функцией Char.IsDigit:
         * https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-6.0
         */
        internal static Int32 CountDigits2( String s )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
         * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
         * данного выражения (целое число).
         */
        internal static Int32 CalcDigits( String expr )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
         * Использовать стандартную функцию замены запрещено.
         */
        internal static String ReplaceWithString( String s, String s1, String s2 )
        {
            throw new NotImplementedException();
        }

        public static void Main( String[] args )
        {
            throw new NotImplementedException( "Вызовите здесь все перечисленные в классе функции, как это сделано в предыдущих заданиях" );
        }
    }
}
