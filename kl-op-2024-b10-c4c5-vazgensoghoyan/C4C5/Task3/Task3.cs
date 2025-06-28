using System.Text.RegularExpressions;

namespace Task3
{
    public class Task3
    {
        /*
         * Перед выполнением заданий рекомендуется просмотреть туториал по регулярным выражениям:
         * https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/regular-expression-language-quick-reference
         */

        /*
         * Задание 3.1. Проверить, содержит ли заданная строка только цифры.
         */
        internal static Boolean AllDigits( String s ) => new Regex( "WRITE_ME" ).IsMatch( s );

        /*
         * Задание 3.2. Проверить, содержит ли заданная строка подстроку, состоящую
         * из букв abc в указанном порядке, но в произвольном регистре.
         */
        internal static Boolean ContainsABC( String s ) => new Regex( "WRITE_ME", RegexOptions.None ).IsMatch( s );

        /*
         * Задание 3.3. Найти первое вхождение подстроки, состоящей только из цифр,
         * и вернуть её в качестве результата. Вернуть пустую строку, если вхождения нет.
         */
        internal static String FindDigitalSubstring( String s )
        {
            throw new NotImplementedException();
        }

        /*
         * Задание 3.4. Заменить все вхождения подстрок строки S, состоящих только из цифр,
         * на заданную строку S1.
         */
        internal static String HideDigits( String s, String s1 )
        {
            throw new NotImplementedException();
        }

        public static void Main( String[] args )
        {
            throw new NotImplementedException( "Вызовите здесь все перечисленные в классе функции, как это сделано в предыдущих заданиях" );
        }
    }
}
