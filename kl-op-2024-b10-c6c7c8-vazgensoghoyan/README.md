# Курс основ программирования на МКН СПбГУ
## Практика 4 и 5: Коллекции, Пул объектов и Многопоточность

Наша цель на этих занятиях - научиться создавать собственные энумераторы для коллекций,
разобраться с временем жизни объектов и на базовом уровне познакомиться с потоками
исполнения (Thread) и примитивами синхронизации.

### Темы заданий

1. Реализация собственной коллекции и энумератора к ней (IEnumerable, IEnumerator).
2. Реализация пула объектов.
3. Потоки и синхронизация на событиях (Thread, ManualResetEvent, AutoResetEvent).

### Начисление баллов за занятие

* (C6 в ведомости) = Task1 (4 балла)
* (C7 в ведомости) = Task2 (4 балла)
* (C8 в ведомости) = Task3 (4 балла)

### Полезные ссылки

* [Документация по интерфейсу `IEnumerable`](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerable?view=net-6.0)
* [Документация по интерфейсу `IEnumerator`](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=net-6.0)
* [Документация по классу `Thread`](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.thread?view=net-6.0)
* [Документация по классу `ManualResetEvent`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.manualresetevent?view=net-6.0)
* [Документация по классу `AutoResetEvent`](https://learn.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent?view=net-6.0)
