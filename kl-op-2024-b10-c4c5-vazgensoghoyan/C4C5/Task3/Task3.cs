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
        internal static Boolean AllDigits( String s ) => new Regex( "^[0-9]+$" ).IsMatch( s );

        /*
         * Задание 3.2. Проверить, содержит ли заданная строка подстроку, состоящую
         * из букв abc в указанном порядке, но в произвольном регистре.
         */
        internal static Boolean ContainsABC( String s ) => 
            new Regex( "(a|A)(b|B)(c|C)", RegexOptions.None ).IsMatch( s );

        /*
         * Задание 3.3. Найти первое вхождение подстроки, состоящей только из цифр,
         * и вернуть её в качестве результата. Вернуть пустую строку, если вхождения нет.
         */
        internal static String FindDigitalSubstring( String s ) =>
            ( new Regex( "[0-9]+" ).Match( s ) ).ToString();

        /*
         * Задание 3.4. Заменить все вхождения подстрок строки S, состоящих только из цифр,
         * на заданную строку S1.
         */
        internal static String HideDigits( String s, String s1 ) => Regex.Replace( s, "[0-9]+", s1 );

        public static void Main( String[] args )
        {
            Console.WriteLine( AllDigits( "1783678" ) );
            Console.WriteLine( ContainsABC( "01aBC" ) );
            Console.WriteLine( FindDigitalSubstring( "abc123def456" ) );
            Console.WriteLine( HideDigits( "abc00def", "xxx" ) );
        }
    }
}
