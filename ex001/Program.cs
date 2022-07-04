// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

// создаем функцию которая определяет строки длинной <= 3  символов, и выводит исходный и новый массив строк.

void Func(string[] array){
    int size = array.Length;                            // определяем длинну исходного массива
    int CountSize = 0;
    for(int i = 0; i<size; i++){
        if(array[i].Length <= 3){
            CountSize++;
        }
    }                                                   // определяем количество элементов необходимой длины (<=3) - размер нового массива
    string[] NewArray = new string[CountSize];
    
    int count = 0;                                      
    for(int i = 0; i<size; i++){                        // заполняем новый массив
        if(array[i].Length <= 3){
            NewArray[count] = array[i];
            count++;
        }
    }
    Console.Write($"Начальный массив: ");
    for(int i = 0; i < size; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    

    Console.Write($"Новый массив из строк длинной 3 или менее символов: ");
    for(int i = 0; i < CountSize; i++){
        Console.Write($"{NewArray[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine();
    

}

Func(array1);
Func(array2);
Func(array3);
