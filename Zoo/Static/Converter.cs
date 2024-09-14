namespace Zoo.Static;

public static class Converter
{
    public static string ConvertRuble(this string line, int num)
    {
        if (num % 10 == 1 && num % 100 != 11)
            return "рубль";
        else if (num % 10 >= 2 && num % 10 <= 4 && num % 100 < 12 && num % 100 > 14)
            return "рубля";
        else return "рублей";
    }
}
