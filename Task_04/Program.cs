// Показать кубы чисел, заканчивающихся на четную цифру
string KubNum(int[] array)
{
    string result = string.Empty;
    int kv = 3;
    int tmp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        tmp = Convert.ToInt32(Math.Pow(array[i], kv));

        if (tmp % 2 == 0) result += tmp + " ";
    }


    return result;
}

int[] KubArray = TableOfSquares(12);
Console.WriteLine(KubNum(KubArray));