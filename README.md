### Задача: 
*написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

### Решение:
1. Создаем метод `CreateStringArray` который с клавиатуры задает размер массива `n`, создает пустой массив затем с помощью цикла `for` заполняет строковые значения с индексами от `0` до `n` и возвращает массив.
2. Создаем метод `PrintArray` который с помощью цикла выводит массив в консоль. Выводим с его помощью созадный массив.
3. Создаем метод `SelectionArrayToArray2` который на вход принимает массив со строковыми значениями, создает второй пустой массив и с помощью цикла `for` заполняет его значениями соответствующим условию: "длина строки меньше или равна трём символам". После возвращает массив 2.
4. Для наглядности выводим результирующий массив в консоль с помощью метода  `PrintArray` 