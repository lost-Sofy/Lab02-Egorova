// // // // // // Console.WriteLine("Границы целочисленных типов");
// // // // // // Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// // // // // // Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// // // // // // Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// // // // // // Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// // // // // // Console.WriteLine();
// // // // // // Console.WriteLine("Граница дробных типов");
// // // // // // Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// // // // // // Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");

// // // // // // Console.WriteLine();
// // // // // // Console.WriteLine("Переполнение byte");

// // // // // // byte maxByte = 255;
// // // // // // byte overFlowed = (byte)(maxByte + 1);
// // // // // // Console.WriteLine($"255 + 1 для byte = {overFlowed}");

// // // // // // Console.WriteLine();
// // // // // // Console.WriteLine("char");

// // // // // // char firstLetter = 'A';
// // // // // // char separator = '-';
// // // // // // int charAsNumber = firstLetter;

// // // // // // Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// // // // // // Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
// // // // // // Console.WriteLine($"Табуляция:\tпосле таба");
// // // // // // Console.WriteLine($"Перенос:\nпосле переноса");

// // // // // // Console.WriteLine();
// // // // // // Console.WriteLine("decimal против double");

// // // // // // double priceDouble = 0.1 + 0.2;
// // // // // // decimal priceDecimal = 0.1m + 0.2m;

// // // // // // Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// // // // // // Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// // // // // Console.WriteLine();
// // // // // Console.WriteLine("var");

// // // // // var studentAge = 20;
// // // // // var gpa = 4.75;
// // // // // var fullName = "Смирнова А. С.";

// // // // // Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// // // // Console.WriteLine();
// // // // Console.WriteLine("Ввод текста");

// // // // Console.Write("Введите ваше имя: ");
// // // // string enteredName = Console.ReadLine();

// // // // Console.Write("Введите название вашей группы: ");
// // // // string enteredGroup = Console.ReadLine();

// // // // Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// // // Console.WriteLine();
// // // Console.WriteLine("Ввод чисел: Convert и Parse");

// // // Console.Write("Введите ваш год рождения: ");
// // // string birthYearInput = Console.ReadLine();

// // // int birthYearConvert = Convert.ToInt32(birthYearInput);
// // // int birthYearParse = int.Parse(birthYearInput);

// // // Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// // // Console.WriteLine($"int.Parse: {birthYearParse}");
// // // Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

// // using System.Diagnostics.Contracts;

// // Console.WriteLine();
// // Console.WriteLine("Ввод чисел: TryParse");

// // Console.Write("Введите количество прочитанных книг за семестр: ");
// // string booksInput = Console.ReadLine();

// // bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// // Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// // Console.WriteLine($"Значение переменной booksCount: {booksCount}");

// Console.Write("введите ваше имя и фамилию: ");
// string fullName = Console.ReadLine();

// Console.Write("введите ваше группу: ");
// string numGroup = Console.ReadLine();

// Console.Write("Введите год вашего рождения: ");
// string yearsBorn = Console.ReadLine();
// int yearsBornConvert = Convert.ToInt32(yearsBorn);

// Console.Write("Введите средний балл за прошлый семестр: ");
// string mediumMark = Console.ReadLine();
// 

// Console.Write("Введите вашу любимую букву алфавита: ");
// string favoriteLetter = Console.ReadLine();
// char favoriteLetterParse = char.Parse(favoriteLetter);



// Console.WriteLine("Анкета студента");
// Console.WriteLine($"{fullName}, группа {numGroup}");
// Console.WriteLine($"Год рождения: {yearsBorn}");
// Console.WriteLine($"Ваш возраст в 2030 году: {2030 - yearsBornConvert}");
// Console.WriteLine($"Средний балл: {mediumMark}");
// Console.WriteLine($"Средний балл >= 4.0: {mediumMarkParse >= 4.0}");
// Console.WriteLine($"Любимая буква: {favoriteLetterParse} ");

Console.Write("Введите ваш рост метрах: ");
string height = Console.ReadLine();
double heightParse = double.Parse(height);

Console.WriteLine("Введите ваш вес в кг: ");
string weight = Console.ReadLine();
double weightParse = double.Parse(weight);

double imt = weightParse / (heightParse * heightParse);

Console.WriteLine($"Ваш ИМТ: {imt:F2}");
