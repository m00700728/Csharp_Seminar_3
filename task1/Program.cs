// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


int[] array = new int[10];
int count = 0;

for (int i = 0; i < 10;  i++) {
    array[i] = new Random().Next(1, 101);
}

Console.Write($"В одномерном массиве из {array.Length} чисел от 1 до 100 [");

for (int i = 0; i < 10; i++) {
    if (i != array.Length - 1) {
        Console.Write($"{array[i]}, ");
    } else {
        Console.Write($"{array[i]}]");
    }
    if (array[i] >= 20 && array[i] <= 90) {
        count++;
    }
}

Console.WriteLine($" количество элементов, которые лежат в отрезке [20, 90] равно {count}");
