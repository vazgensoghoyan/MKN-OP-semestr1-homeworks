using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;
using System.Data;

namespace Task1
{
    public class Task1
    {
        /*
         * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
         * где NN — длина заданной строки. Например, если задана строка "hello",
         * то результатом должна быть строка "Длина: 5".
         */
        internal static Int32 StringLength( String s ) => s.Length;

        /*
         * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
         * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
         */
        internal static Tuple<Int32?, Int32?> FirstLastCodes( String s ) => 
            Tuple.Create( Code( First(s) ), Code( Last(s) ) );

        private static Char? First( String s ) => (s == "") ? null : s[0];
        private static Char? Last( String s ) => (s == "") ? null : s[ s.Length - 1 ];
        private static Int32? Code( Char? c ) => c;

        /*
         * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
         * В решении необходимо воспользоваться циклом for.
         */
        internal static Int32 CountDigits( String s )
        {
            int c = 0;

            for (int i = 0; i < s.Length; i++)
                c += ( 47 < s[i] && s[i] < 59 ) ? 1 : 0;

            return c;
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
            return s.Count( char.IsDigit );
        }

        /*
         * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
         * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
         * данного выражения (целое число).
         */
        internal static Int32 CalcDigits( String expr )
        {
            var value = 0;
            char op = '+';

            for (int i = 0; i < expr.Length; i++)
            {
                if ( char.IsDigit( expr[i] ) )
                    value += ( (op == '+') ? 1 : -1 ) * (expr[i] - 0);
                else
                    op = expr[i];
            }

            return value;
        }

        /*
         * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
         * Использовать стандартную функцию замены запрещено.
         */
        internal static String ReplaceWithString( String s, String s1, String s2 )
        {
            var i = s.IndexOf( s1 );

            if ( i == -1 ) return s;

            var before = s.Substring( 0, i );
            var after = s.Substring( i + s1.Length, s.Length - i - s1.Length );

            return before + s2 + after;
        }

        public static void Main( String[] args )
        {
            Console.WriteLine( StringLength( "1234j" ) );
            Console.WriteLine( FirstLastCodes( "a----b" ) );
            Console.WriteLine( CountDigits( "abab72b2h4b4h" ) );
            Console.WriteLine( CountDigits2( "abab72b2h4b4h" ) );
            Console.WriteLine( CalcDigits( "4+7-2-8" ) );
            Console.WriteLine( ReplaceWithString( "abcdab", "bcd", "" ) );
        }
    }
}
