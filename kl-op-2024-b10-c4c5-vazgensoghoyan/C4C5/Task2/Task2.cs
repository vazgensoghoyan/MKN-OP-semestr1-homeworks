using System.Diagnostics.SymbolStore;
using System.Text;

namespace Task2
{
    public class Task2
    {

        /*
         * В этих заданиях рекомендуется всюду использовать класс StringBuilder.
         * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
         */

        /*
         * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
         * строки S, между которыми вставлено по N символов «*» (звездочка).
         */
        internal static String FillWithAsterisks( String s, Int32 n )
        {
            var sb2 = new StringBuilder( n * s.Length );

            for (int i = 0; i < n; i++)
            {
                sb2.Append('*');
            }

            var sb = new StringBuilder( n + n * s.Length );
            sb.Append( s[0] );

            for (int i = 1; i < s.Length; i++)
            {
                sb.Append( sb2 );
                sb.Append( s[i] );
            }

            return sb.ToString();
        }

        /*
         * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
         * Например, для N=4 должна получиться следующая строка:
        
        1  1
        2  4
        3  9
        4 16
        
         * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
         * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
         * пробел. В решении можно использовать функции Pad*.
         */
        internal static String TabulateSquares( Int32 n )
        {
            var lineLength = IntsLength( n, n * n ) + 1;
            var sb = new StringBuilder( n + n * lineLength );

            for (int i = 1; i <= n; i++)
            {
                sb.Append( i );
                AppendSpaces( SpacesCount( i ) );
                sb.Append( i * i );
                sb.Append('\n');
            }

            return sb.ToString();

            int SpacesCount( int x ) => lineLength - IntsLength( x, x * x );

            void AppendSpaces( int x )
            {
                for (int i = 0; i < x; i++) sb.Append(' ');
            }
        }

        private static int IntsLength( int x, int y ) => IntLength(x) + IntLength(y);
        private static int IntLength( int n ) => n.ToString().Length;

        public static void Main( String[] args )
        {
            Console.WriteLine( FillWithAsterisks( "abc", 2 ) );
            Console.WriteLine( TabulateSquares( 4 ) );
        }
    }
}
