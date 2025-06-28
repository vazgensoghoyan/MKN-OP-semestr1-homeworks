using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    /*
     * Задача: Реализовать коллекцию и энумератор к ней при итерировании которой мы увидем
     * _headCharCount раз повторенный символ _headChar, затем все символы строки _middle по
     * порядку, после чего _tailCharCount раз повторенный символ _tailChar.
     *
     * Допишите проверки входных данных конструктора так, чтобы при отрицательном количестве
     * символов выбрасывалось исключение - текст любой.
     * Строка middle может быть пустой или null'евой. В этом случае энумератор должен вернуть
     * только нужное количество символов из головы и из хвоста.
     *
     * Пример:
     *   foreach( Char c in new CrezyCollection('<', 3, "Hello", '>', 2))
     *       Console.Write( c );
     *   Выведет в консоль строку "<<<Hello>>"
     *
     * FYI: ключевое слово readonly запрещает изменение значения переменной после
     *      ее инициализации в конструкторе
     */
    public class CrazyCollection : IEnumerable<Char>
    {
        private readonly Char _headChar;
        private readonly Int32 _headCharCount;
        private readonly String _middle;
        private readonly Char _tailChar;
        private readonly Int32 _tailCharCount;

        public CrazyCollection( Char headChar, Int32 headCharCount, String middle, Char tailChar, Int32 tailCharCount )
        {
            _headChar = headChar;
            _headCharCount = headCharCount;
            _middle = middle;
            _tailChar = tailChar;
            _tailCharCount = tailCharCount;
        }

        #region IEnumerable<Char>

        public IEnumerator<Char> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }

    public class CrazyEnumerator : IEnumerator<Char>
    {

        #region IEnumerator<Char>

        public Boolean MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public Char Current { get; }

        Object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
