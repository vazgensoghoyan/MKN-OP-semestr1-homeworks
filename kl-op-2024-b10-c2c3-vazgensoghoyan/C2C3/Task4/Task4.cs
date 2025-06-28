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
            throw new NotImplementedException();
        }

        /*
         * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
         */
        internal static void PrintFrame2( Int32 width, Int32 height, Char frameChar = '*' )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
         * используя алгоритм Евклида:
         * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
         * где «mod» обозначает операцию взятия остатка от деления.
         */
        internal static Int64 Gcd( Int64 a, Int64 b )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
         * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
         * Полученное число является приближенным значением функции exp в точке X.
         */
        internal static Double ExpTaylor( Double x, Int32 n )
        {
            throw new NotImplementedException();
        }

        public static void Main( String[] args )
        {
            PrintFrame( 5, 3, '+' );
            throw new NotImplementedException( "Вызовите здесь все перечисленные в классе функции, как это сделано в предыдущих заданиях" );
        }
    }
}
