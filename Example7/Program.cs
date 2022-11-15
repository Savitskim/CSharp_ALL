int[] array = { 12, 43, 12, 45, 2, 4, 7, 12 };
Console.WriteLine("Введите число");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;
int size = array.Length;
while (index < size)
{
    if (array[index] == find) Console.WriteLine($"Значение элемента массива с индексом - {index} , соответствует числу {find}");
    index++;
}
// break; - прервать