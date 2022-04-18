
//1. Из слова информатика путем «вырезок» и «склеек» получить слова "форма" и "тик".

using System.Text.RegularExpressions;

var informaticStr = "информатика";
var formaStr = informaticStr.Substring(2, 5);
var ticStr = informaticStr.Substring(7, 3);
Console.WriteLine($"{formaStr} {ticStr}");

//2. Из слова "вирус" путем замены его букв получить слово "фокус".

var virusStr = "вирус";
var focusStr = virusStr.Replace("вир", "фок");
Console.WriteLine(focusStr);

//3. Дано ошибочно написанное слово "рпроцессо". Путем перемещения его букв получить слово "процессор".

var failStr = "рпроцессо";
var charFirst = failStr.First();
var SuccessStr = failStr.TrimStart(charFirst) + charFirst;
Console.WriteLine(SuccessStr);

// 4.Программа, запрашивает название государства и его столицы,
//      а затем выводит сообщение: «Столица государства … — город …»
//      (на месте многоточий должны быть выведены соответствующие значения).
//      Реализовать 2мя способами: через string.Format и интерполяцию.

Console.Write("Введите государcтво: ");
var state = Console.ReadLine();
Console.Write("Введите его столицу: ");
var capital = Console.ReadLine();
Console.WriteLine("Столица государства {0} — город {1}.", state, capital);
Console.WriteLine($"Столица государства {state} — город {capital}.");

//5.Пользователь вводит слово

// -вывести слово наоборот("abc" -> "cba")
Console.WriteLine("Введите слово для обработки: ");
var userStr = Console.ReadLine();
var arr = userStr.ToCharArray();
Array.Reverse(arr);
Console.WriteLine(arr);
Array.Reverse(arr);

//  - вывести на экран его X-й символ
var randomNumX = new Random().Next(0 ,userStr.Length);
var randomNumY = new Random().Next(0 ,userStr.Length);
Console.WriteLine($"{arr[randomNumX]} - {randomNumX + 1} символ");

//  - определить, одинаковы ли X-й и Y-й символы в нем
var total = arr[randomNumX] == arr[randomNumY] ? $"{randomNumX + 1} символ и {randomNumY + 1} символ одинаковые" :
                                                 $"{randomNumX + 1} символ и {randomNumY + 1} символ разные";
Console.WriteLine(total);

//  - поменять местами буквы номера которых вычисляются как степень X. Пример: если пользователь ввел 2, то номерами симолов будут: 1, 2, 4, 8...

Console.WriteLine("Введите число любое кроме 1, 0 и не было длинне введеной строки: ");
int.TryParse(Console.ReadLine(), out var number);
if (number > arr.Length)
{
    Console.WriteLine("Ввели симло больше длинны, операция перемещения невозможна");
}
var length = arr.Length;
for (int i = 1; i * number < arr.Length; i *= number)
{
    char a = arr[i - 1];
    char b = arr[i * number - 1];
    arr[i - 1] = b;
    arr[i * number - 1] = a;
}
Console.WriteLine(arr);
arr = userStr.ToLower().ToCharArray();

//  - определить, сколько различных букв в слове

var group = arr.GroupBy(x => x);
Console.WriteLine($"В вашем слове {group.Count()} букв"); //group.Key ошибка?

//  - определить, сколько одинаковых соседних букв
//  - без использования оператора цикла и с использованием(2 версии метода):

//??

//  - вывести на экран его первую половину

var halfUserStr = userStr.Substring(0, userStr.Length / 2);
Console.WriteLine(halfUserStr);

//  - поменять местами его половины

var secondHalfUserStr = userStr.Substring(userStr.Length / 2);
Console.WriteLine(secondHalfUserStr + halfUserStr);


//  - переставить первые Х и последние Х буквы, сохранив порядок их следования

var randomNum = new Random().Next(1, userStr.Length / 2);
var firstX = userStr.Substring(0, randomNum);
var mediumX = userStr.Substring(randomNum, userStr.Length - randomNum * 2);
var lastX = userStr.Substring(userStr.Length - randomNum, randomNum);
Console.WriteLine(lastX + mediumX + firstX);

//  - проверить, является ли оно «перевертышем» (перевертышем называется слово, читаемое одинаково как с начала, так и с конца)

total = Enumerable.SequenceEqual(arr.Reverse(), userStr.ToLower().ToArray()) ? "Cлово является перевертышем!" :
                                                                               "Слово не является перевертышем";
Console.WriteLine(total);

//6.Пользователь вводит предложение
//  - определить долю (в %) букв Х в нем(запрашивается у пользователя)

Console.WriteLine("Введите предложение");
var satz = Console.ReadLine();
Console.WriteLine("Введите букву: ");
var c = Console.ReadLine();
var amount = new Regex(c).Matches(satz).Count;
var precent = (double)amount / (double)satz.Length * 100d;
Console.WriteLine($"{precent} состовляет ваша буква.");

//  - число вхождений в него некоторого буквосочетания(запрашивается у пользователя)

Console.WriteLine("Введите словосочетание: ");
var phrase = Console.ReadLine();
var amount1 = new Regex(phrase).Matches(satz).Count;
Console.WriteLine($"Словосочетание встречалось {amount1} раз");

//  - определить количество слов в предложении

var satzSplit = satz.Split(' ');
Console.WriteLine($"{satzSplit.Count()} слов в предложении");

//  - вывести текст, составленный из первых букв всех слов

var satzFirstChar = "";
foreach(var s in satzSplit)
{
    satzFirstChar += satzFirstChar + s.First();
}
Console.WriteLine(satzFirstChar);

//  - определить, сколько в нем гласных букв
//  - верно ли, что в нем есть пять идущих подряд одинаковых символов?
//  - все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой Х(запрашивается у пользователя)
//  - напечатать его в обратном порядке слов, например: Мама мыла раму. -> Раму мыла мама.
//  - составить программу, которая выводит все вхождения в предложение заданных слов

//6.Дан текст
//  - напечатать все имеющиеся в нем цифры
//  - определить количество цифр в нем
//  - найти порядковый номер максимальной цифры
//  - найти наибольшее количество идущих подряд цифр
//  - найти наибольшее количество идущих подряд одинаковых символов
