
//1. Из слова информатика путем «вырезок» и «склеек» получить слова "форма" и "тик".

using System.Text;
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
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
var arr = userStr.ToCharArray();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
for (int i = 0; i < userStr.Length; i++)
{
    arr[i] = userStr[userStr.Length - 1 - i];
}
Console.WriteLine(arr);


//  - вывести на экран его X-й символ
arr = userStr.ToCharArray();
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
    Console.WriteLine("Ввели символ больше длинны, операция перемещения невозможна");
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

arr = userStr.ToArray();
var result = 0;
for(int i = 0; i < arr.Length - 1; i++)
{
    var ch1 = arr[i];
    var ch2 = arr[i + 1];
    if(ch1 == ch2)
    {
        result++;
    }
}
Console.WriteLine($"Количество одинаковых соседних букв {result}");

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
// второй вариант
arr = userStr.ToLower().ToCharArray();
for (int i = 0; i < userStr.Length; i++)
{
    arr[i] = userStr[userStr.Length - 1 - i];
}

total = arr.ToString() == userStr ? "Cлово является перевертышем!" :
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

var ContainsPhrase = satz.Split(phrase).Length - 1;
Console.WriteLine($"Словосочетание встречалось {ContainsPhrase} раз");

//  - определить количество слов в предложении

var satzSplit = satz.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"{satzSplit.Count()} слов в предложении");


//  - вывести текст, составленный из первых букв всех слов

var satzFirstChar = "";
foreach(var s in satzSplit)
{
    satzFirstChar += satzFirstChar + s.First();
}
Console.WriteLine(satzFirstChar);

//  - определить, сколько в нем гласных букв

var conVowel = 0;
for(var i = 0; i < satz.Length; i++)
{
    switch (satz.ToLower()[i])
    {
        case 'а':
            conVowel++;
            break;
        case 'о':
            conVowel++;
            break;
        case 'э':
            conVowel++;
            break;
        case 'е':
            conVowel++;
            break;
        case 'и':
            conVowel++;
            break;
        case 'ы':
            conVowel++;
            break;
        case 'у':
            conVowel++;
            break;
        case 'ё':
            conVowel++;
            break;
        case 'ю':
            conVowel++;
            break;
        case 'я':
            conVowel++;
            break;
    }
}

Console.WriteLine($"В предложении {conVowel} гласных букв");

//  - верно ли, что в нем есть пять идущих подряд одинаковых символов?

int identifierNum = 0;
bool isEqualsChar = false;
for (var i = 0; i < satz.Length - 4; i++)
{
    for(var j = 0; j < 4; j++)
    {
        if(satz[i + j] == satz[i + j + 1])
        {
            identifierNum++;
        }
    }
    if(identifierNum == 4)
    {
        isEqualsChar = true;
        break;
    }
    identifierNum = 0;
}
var messageAboutChar = isEqualsChar ? "Есть пять идущих подряд одинаковых символов" :
                                      "Нет пяти идущих подряд одинаковых символов";
Console.WriteLine(messageAboutChar);

//  - все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой Х(запрашивается у пользователя)
Console.WriteLine("Введите любую букву: ");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
char charForReplace = char.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
var ordinalNumber = 3;
arr = satz.ToArray();
while(ordinalNumber < satz.Length)
{
    arr[ordinalNumber] = charForReplace;
    ordinalNumber += 3;
}

//  - напечатать его в обратном порядке слов, например: Мама мыла раму. -> Раму мыла мама.

satzSplit = satz.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] satzSplitReverce = new string[satzSplit.Length];
for(var i = 0; i < satzSplit.Length; i++)
{
    satzSplitReverce[i] = satzSplit[satzSplit.Length - 1 - i];
}
foreach(var s in satzSplitReverce)
{
    Console.Write(s);
}
Console.WriteLine();

//  - составить программу, которая выводит все вхождения в предложение заданных слов

satzSplit = satz.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Сколько слов вы хотите задать, для определения количества вхождений?");
var isNumber = int.TryParse(Console.ReadLine(), out int countWordList);
var wordList = new List<string>();
var numberOfCoincidences = 0;
for (var i = 0; i < countWordList; i++)
{
    Console.Write("Введите слово");
    wordList.Add(Console.ReadLine());
}
foreach(string s1 in wordList)
{
    foreach (string s2 in satzSplit)
    {
        if (s1 == s2)
        {
            numberOfCoincidences++;
        }
    }
}
Console.WriteLine($"Число вхождений ваших слов в предложение: {numberOfCoincidences}");

//6.Дан текст

var text = "4389t98hqhgfufuhq2934thfq3htgf83gf3gf4f8324";

//  - напечатать все имеющиеся в нем цифры
var numList = new List<int>();
int defaultnum;
for (var i = 0; i < text.Length; i++)
{
    if(int.TryParse(text[i].ToString(), out defaultnum))
    {
        numList.Add(defaultnum);
    }
}

foreach(var s in numList)
{
    Console.Write($" {s},");
}
Console.WriteLine();

//  - определить количество цифр в нем

Console.WriteLine($"Количество цифр: {numList.Count}");

//  - найти порядковый номер максимальной цифры

var maxValue = 0;
foreach(var s in numList)
{
    if(s > maxValue)
    {
        maxValue = s;
    }
}
var indexOfMaxValue = text.IndexOf(maxValue.ToString());
Console.WriteLine($"Порядковый номер цифры {maxValue} - {indexOfMaxValue}");

var maxValueList = new List<int>();
for(var i = 0; i < text.Length; i++)
{
    if(text[i].ToString() == maxValue.ToString())
    {
        maxValueList.Add(i+1);
    }
}
Console.Write("Порядковые номера максималной цифры: ");
foreach(var s in maxValueList)
{
    Console.Write($" {s},");
}

//  - найти наибольшее количество идущих подряд цифр

var controlNum = -1;
var countNums = 0;
var resultCountNums = 0;
for (var i = 0; i < text.Length; i++)
{
    if (int.TryParse(text[i].ToString(), out defaultnum))
    {
        if (i - 1 == controlNum)
        {
            countNums++;
            controlNum = i;
        }
    }
    else
    {
        if (countNums > resultCountNums)
        {
            resultCountNums = countNums;
        }
        countNums = 0;
        controlNum = i;
    }
}
if (countNums > resultCountNums)
{
    resultCountNums = countNums;
}
Console.WriteLine($"Максимальное количество идущих подряд чисел = {resultCountNums}");

//  - найти наибольшее количество идущих подряд одинаковых символов

char lastChar = text[0];
var countChars = 1;
var resultCountChars = 0;

for (var i = 1; i < text.Length; i++)
{
    if (lastChar == text[i])
    {
        countChars++;
        lastChar = text[i];
    }
    else
    {
        if (countChars > resultCountChars)
        {
            resultCountChars = countChars;
        }
        lastChar = text[i];
        countChars = 1;
    }
}
if (countChars > resultCountChars)
{
    resultCountChars = countChars;
}
Console.WriteLine($"Макисмальное количество одинаковых, идущих подряд символов = {resultCountChars}");

// 7. Даны два слова

Console.WriteLine("Напишите два слова: ");
var word1 = Console.ReadLine();
var word2 = Console.ReadLine();

// - определить можно ли из букв первого получить второе

var missingСhars = word2.Except(word1).Count();
var answerMessage = missingСhars == 0 ? "Из букв второго слова можно получить первое" :
                                             "Из букв второго слова нельзя получить первое";
Console.WriteLine(answerMessage);

// - определить повторяющиеся(пересекающиеся буквы)

var overlappingChars = word1.Intersect(word2);
Console.Write("Все пересекающиеся буквы: ");
foreach(var ch in overlappingChars)
{
    Console.WriteLine(ch);
}


// 8. Дан текст. Проверить правильно ли в нем расставлены круглые скобочки
// (т.е. находится ли справа от каждой открывающей скобки соотвествующая ей закрывающая скобка,
// а слева от закрывающей - соотвествующая ей закрывающая). 
// Выдать сообщение с указанием позиции первой неправильной скобки.

var text1 = "(()";
var enumOpenChars = new List<int>();
var enumCloseChars = new List<int>();
for (var i = 0; i < text1.Length; i++)
{
    if(text1[i] == '(')
    {
        enumOpenChars.Add(i);
    }
    if(text1[i] == ')')
    {
        enumCloseChars.Add(i);
    }
}
if(enumOpenChars.Count == enumCloseChars.Count)
{
    for(var i = 0; i < enumOpenChars.Count; i++)
    {
        if(enumOpenChars[i] > enumCloseChars[i])
        {
            Console.WriteLine($"Ошибка скобок в символе{enumCloseChars[i]+1} - не хватае (");
            Console.WriteLine($"Ошибка скобок в символе{enumOpenChars[i] + 1} - не хватае )");
        }
    }
}
else if(enumOpenChars.Count > enumCloseChars.Count)
{
    for (var i = 0; i < enumOpenChars.Count; i++)
    {
        if (enumCloseChars.Count >= i)
        {
            if (enumOpenChars[i] > enumCloseChars[i])
            {
                Console.WriteLine($"Ошибка скобок в символе{enumCloseChars[i] + 1} - не хватае (");
                Console.WriteLine($"Ошибка скобок в символе{enumOpenChars[i] + 1} - не хватае )");
            }
        }
        else
        {
            Console.WriteLine($"Ошибка скобок в символе{enumOpenChars[i] + 1} - не хватае )");
        }
    }
}
else if(enumOpenChars.Count < enumCloseChars.Count)
{
    for (var i = 0; i < enumCloseChars.Count; i++)
    {
        if (enumOpenChars.Count >= i)
        {
            if (enumOpenChars[i] > enumCloseChars[i])
            {
                Console.WriteLine($"Ошибка скобок в символе{enumCloseChars[i] + 1} - не хватае (");
                Console.WriteLine($"Ошибка скобок в символе{enumOpenChars[i] + 1} - не хватае )");
            }
        }
        else
        {
            Console.WriteLine($"Ошибка скобок в символе{enumCloseChars[i] + 1} - не хватае (");
        }
    }
}
else
{
    Console.WriteLine("Ошибок в скобках нет");
}

// 9. Данна строка текста, в кторой нет начальных и конечных пробелов.
// Необходимо изменитб ее так, Чтобы длина строки стала равна заданой длине
// (препологается, что требуемая длина не меньше исходной).
// Это следует сделать путем вставки иежду словами дополнительных пробелов.
// Количество пробелов между отдельными словами должно отличаться не более чем на 1.

var st = "Давайте удленним строку до 60 симолов"; 
var countCharToJoin = 60 - st.Length; //23
var num = 60; 
var stList = st.Split(' ');
var countSpaces = stList.Length -1; //5
var newSt = new StringBuilder();
var countSpacesInOneBig = countCharToJoin % countSpaces;
var countSpacesInOne = countCharToJoin / countSpaces;
for(var i = 0; i < stList.Length; i++)
{
    if(i < countSpacesInOneBig)
    {
        newSt.Append(stList[i]);
        newSt.Append(String.Concat(Enumerable.Repeat(' ', countSpacesInOne + 2)));
    }
    else
    {
        newSt.Append(stList[i]);
        newSt.Append(String.Concat(Enumerable.Repeat(' ', countSpacesInOne + 1)));
    }
}
Console.WriteLine(newSt.ToString().TrimEnd());

// 10. Дано натуральное число Н (Н <= 1000). Напечатать это число русскими словами (тринадцать, сто пять, двести сорок один и т.д.).

var numToConvert = 876;

var nums_1_9 = new[] { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
var nums_10_19= new[] { "десять", "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", 
                        "шестнадцать", "семнадцать", "восемнадцатдь", "девятнадцать" };
var nums_20_90 = new[] { "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"};
var nums_100_900 = new[] { "сто", "двести", "триста", "четыресто", "пятьсот", "шестьсот", "восемьсот", "девятьсот" };

var razryadNum = numToConvert.ToString().Length;

switch(razryadNum)
{
    case 1:
        if(numToConvert == 0)
        {
            Console.WriteLine("ноль");
        }
        else
        {
            Console.WriteLine(nums_1_9[numToConvert]);
        }
        break;
    case 2:
        if (numToConvert < 20)
        {
            Console.WriteLine(nums_10_19[numToConvert - 10]);
        }
        else
        {
            Console.WriteLine(nums_20_90[numToConvert / 10 - 2] + " " + nums_1_9[numToConvert]);
        }
        break;
    case 3:
        if(numToConvert % 100 < 10)
        {
            Console.WriteLine(nums_100_900[numToConvert / 100 - 1] + " " +
                              nums_1_9[numToConvert]);
        }
        else if (numToConvert % 100 < 20)
        {
            Console.WriteLine(nums_100_900[numToConvert / 100 - 1] + " " +
                              nums_10_19[numToConvert - 10]);
        }
        else
        {
            Console.WriteLine(nums_100_900[numToConvert / 100 - 1] + " " +
                              nums_20_90[numToConvert / 10 - 2] + " " +
                              nums_1_9[numToConvert]);
        }
        break;
    case 4:
        Console.WriteLine("Тысяча");
        break;

}
