/// <summary>
/// Класс, отвечающий за работу с массивами
/// </summary>
public static class ArrayLib
{
    /// <summary>
    /// Метод создания массива строк
    /// </summary>
    /// <param name="arrSize">Количество элементов массива</param>
    /// <returns>Новый массив</returns>
    public static string[] CreateStringArray(this int arrSize)
    {
        return new string[arrSize];
    }
    /// <summary>
    /// Метод заполнения из консоли массива строк
    /// </summary>
    /// <param name="array">Массив, который необходимо заполнить</param>
    public static void FillStrArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"Введите {i + 1}-й элемент массива -> ");
            array[i] = Console.ReadLine();
        }
    }

    /// <summary>
    /// Метод, формирующий из имеющегося массива строк
    /// массив из строк, длина которых меньше либо равна 3 символа
    /// </summary>
    /// <param name="sourceArray">Исходный массив</param>
    /// <returns>Новый массив с элементами из 3 символов</returns>
    public static string[] GetArrThreeChElements(this string[] sourceArray)
    {
        string[] resultArr = sourceArray.Length.CreateStringArray();
        int j = 0;
        for (int i = 0; i < sourceArray.Length; i++)
        {
            if (sourceArray[i].Length <= 3)
            {   
                resultArr[j] = sourceArray[i];
                j++;
            }
        }
        Array.Resize(ref resultArr, j);
        return resultArr;
    }
    
    /// <summary>
    /// Создает из элементов массива строку
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Строка из элементов массива</returns>
    public static string ConvertArrToStr(this string[] array)
    {
        return $"[{String.Join(',', array)}]";
    }
}