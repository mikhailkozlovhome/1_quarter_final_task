using static ArrayLib;

int arrSize = InputOutputLib.inputInt("Введите размер массива");

if (arrSize > 0)
{
    string[] inpArray = arrSize.CreateStringArray();
    FillStrArray(inpArray);

    string[] outpArray = inpArray.GetArrThreeChElements();
    

    if (outpArray.Length > 0)
    {
        System.Console.WriteLine($"Исходный массив -> {inpArray.ConvertArrToStr()}");
        System.Console.WriteLine($"Полученный массив -> {outpArray.ConvertArrToStr()}");
    }
    else
    {
        System.Console.WriteLine($"В массиве {inpArray.ConvertArrToStr()}");
        System.Console.WriteLine(" отсутствуют элементы длина которых меньше либо равна 3 символа.");
    }
}
else
{
    System.Console.WriteLine("Вы ввели отрицательный размер массива, такого быть не может!");
}

