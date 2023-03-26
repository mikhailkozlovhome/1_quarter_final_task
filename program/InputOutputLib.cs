/// <summary>
/// Класс, отвечающий за ввод вывод информации в консоле
/// </summary>
public static class InputOutputLib
{
    /// <summary>
    /// Метод ввода целого числа
    /// </summary>
    /// <param name="msg">Приглашение для ввода в консоли</param>
    /// <returns>Целое число или ошибку 999 если ввели не целое число</returns>
    public static int inputInt(string msg)
    {
        int value;
        System.Console.Write($"{msg} -> ");
        if (int.TryParse(Console.ReadLine(), out value))
        {
            return value;
        }
        System.Console.WriteLine("Введенно неверное значение!");
        Environment.Exit(999);
        return 0;
    }
}