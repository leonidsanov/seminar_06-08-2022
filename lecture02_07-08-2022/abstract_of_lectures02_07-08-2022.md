# 07-08-2022 Урок 2. Знакомство с функциями и массивами
## Функции
Функция - это часть программного кода, который создаёт разработчик.
* функция имеет идентификатор (имя)
* может иметь входные аргументы
* может возвращать значение

Общий вид функции на языке C#

``` bash
ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
{
    Тело Метода
    return ЗначениеСоответствующееВозвращаемомуТипуДанных;
}
```
## Массивы
Общий вид массива

``` bash
тип_данных[] имя = {Значение1, Значение2, ...}
```
или
``` bash
int[] array = {1, 2, 3, 4, 5}
int[] array = new int[5];
int[] array = new int[]{0, 0, 0, 0, 0}
int[] array = new int[5]{1, 0, 7, 8}
```

`void` - это метод, который ничего не возвращает