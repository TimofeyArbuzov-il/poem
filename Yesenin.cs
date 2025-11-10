using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\Student\Desktop\Тимофей\example.txt";

        string text = 
            "\nНе ругайтесь. Такое дело!\n" +
            "Не торговец я на слова.\n" +
            "Запрокинулась и отяжелела\n" +
            "Золотая моя голова.\n\n" +

            "Нет любви ни к деревне, ни к городу,\n" +
            "Как же смог я ее донести?\n" +
            "Брошу все. Отпущу себе бороду\n" +
            "И бродягой пойду по Руси.\n\n" +

            "Позабуду поэмы и книги,\n" +
            "Перекину за плечи суму,\n" +
            "Оттого что в полях забулдыге\n" +
            "Ветер больше поет, чем кому.\n\n" +

            "Провоняю я редькой и луком\n" +
            "И, тревожа вечернюю гладь,\n" +
            "Буду громко сморкаться в руку\n" +
            "И во всем дурака валять.\n\n" +

            "И не нужно мне лучшей удачи,\n" +
            "Лишь забыться и слушать пургу,\n" +
            "Оттого что без этих чудачеств\n" +
            "Я прожить на земле не могу.\n";

        using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            fs.Write(data, 0, data.Length);
        }

        Console.WriteLine("Стихотворение записано в файл одной строкой с переносами.");
    }
}

using System;
using System.IO;
using System.Text;


class Program
{
    static void Main()
    {
        Console.Write("Вводите размер масива N: ");
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(0, 10);
        }
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;

                }
            }
        }
        int min = numbers[0];
        int max = numbers[N - 1];
        string cmin = Convert.ToString(min);
        using (FileStream fs = new FileStream("result.txt", FileMode.Append, FileAccess.Write))
        {
            byte[] data = Encoding.UTF8.GetBytes(cmin);
            fs.Write(data, 0, data.Length);
         }

     }
 }
