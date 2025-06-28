using NUnit.Framework.Internal;

namespace Task4
{
    public class Task4
    {
        /*
         * В решениях следующих заданий предполагается использование циклов.
         */

        /*
         * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
         * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
         * Например, вызов printFrame(5,3,'+') должен напечатать следующее:
         *
         * +++++
         * +   +
         * +++++
         *
         */
        internal static void PrintFrame( Int32 width, Int32 height, Char frameChar = '*' )
        {
            for (int i = 0; i < width; i++)
                Console.Write(frameChar);

            Console.WriteLine();

            for (int i = 0; i < height - 2; i++)
            {
                Console.Write(frameChar);
                for (int j = 0; j < width - 2; j++)
                    Console.Write(' ');
                Console.Write("{0}\n", frameChar);
            }

            for (int i = 0; i < width; i++)
                Console.Write(frameChar);

            Console.WriteLine();
        }

        /*
         * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
         */
        internal static void PrintFrame2( Int32 width, Int32 height, Char frameChar = '*' )
        {
            string F( string y, int x )
            {
                var res = string.Empty;
                while (x-- > 0)
                    res += y;
                return res;
            }

            var line1 = F( frameChar.ToString(), width ) + '\n';
            var line2 = frameChar + F( " ", width - 2 ) + frameChar + '\n';
            var middle = F( line2, height - 2 );

            Console.Write( "{0}{1}{2}", line1, middle, line1 );
        }

        /*
         * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
         * используя алгоритм Евклида:
         * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
         * где «mod» обозначает операцию взятия остатка от деления.
         */
        internal static Int64 Gcd( Int64 a, Int64 b )
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }

        /*
         * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
         * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
         * Полученное число является приближенным значением функции exp в точке X.
         */
        internal static Double ExpTaylor( Double x, Int32 n )
        {
            var z = 1d;
            var res = 0d;

            for (int i = 1; i <= n; i++)
            {
                res += z;
                z *= x / i;
            }

            return res;
        }

        public static void Main( String[] args )
        {
            PrintFrame( 5, 3, '+' );
            PrintFrame2( 4, 4, 'p' );
            Console.WriteLine( Gcd( 10, 15 ) );
            Console.WriteLine( ExpTaylor( 1, 1000 ) );
        }
    }
}
