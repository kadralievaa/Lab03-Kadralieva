// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500;
// Console.WriteLine($"После пополнения на 500: {balance}");

// balance -= 200;
// Console.WriteLine($"После пополнения на 200: {balance}");

// balance *= 1.05;
// Console.WriteLine($"После начисления 5%: {balance}");

// balance /= 2;
// Console.WriteLine($"После деления пополам: {balance}");

// //9
// Console.WriteLine();
// Console.WriteLine("Постфикс vs префикс");

// int lessonNumber = 1;
// Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
// Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

// int weekNumber = 1;
// Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
// Console.WriteLine($"После этого weekNumber = {weekNumber}");

// Console.WriteLine();
// Console.WriteLine("Практическая ловушка");

// int attempts = 0;
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Всего попыток: {attempts}");

// //11
// Console.WriteLine();
// Console.WriteLine("Операторы сравнения");

// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;

// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");

// Console.WriteLine();
// Console.WriteLine("Логические операторы");

// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetakeExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;
// Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");

// Console.WriteLine();
// Console.WriteLine("Короткое замыкание");

// bool CheckAndPrint(string label, bool value)
// {
//     Console.WriteLine($"  Вычисляется: {label}");
//     return value;
// }

// Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Результат: {resultAnd}");

// Console.WriteLine();
// Console.WriteLine("Проверяем || (первый операнд true):");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Результат: {resultOr}");


// //17
// Console.WriteLine();
// Console.WriteLine("Приоритет операций");

// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4         = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4       = {resultWithParens}");

// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5>3 && 2<4 || false        = {logicResult}");
// Console.WriteLine($"(5>3 && 2<4) || false      = {logicResultParens}");


//19
// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");

// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);

// bool hasGoodCertificate = averageGrade >= 4.0;
// bool hasGoodExam = examScore >= 60;
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// double totalScore = averageGrade * 10;
// totalScore += examScore;

// Console.WriteLine();
// Console.WriteLine("Результат");
// Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}"); 


//
// Console.WriteLine();
// Console.WriteLine("Чётное или нечётное");

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());
// bool isEven = (number % 2 == 0);
// Console.WriteLine($"Число чётное: {isEven}");


// Console.WriteLine();
// Console.WriteLine("Инкремент в выражении");

// // постфикс сначала отдаёт старое значение, потом увеличивает
// int a = 5;
// int b = a++;
// // a стало 6, b получило старое значение 5
// Console.WriteLine($"a = 5; b = a++;   a = {a}, b = {b}");

// //префикс сначала увеличивает, потом отдаёт новое значение
// int c = 5;
// int d = ++c;
// // c стало 6, d получило уже новое значение 6
// Console.WriteLine($"c = 5; d = ++c;   c = {c}, d = {d}");

// // смешанное в одном выражении
// int x = 10;
// int y = x++ + ++x;
// // x++ отдаёт 10 (x становится 11), ++x увеличивает до 12 и отдаёт 12
// // получается, y = 10 + 12 = 22, x = 12
// Console.WriteLine($"x = 10; y = x++ + ++x;   x = {x}, y = {y}");

//
Console.WriteLine();
Console.WriteLine("Калькулятор скидки");

Console.Write("Введите сумму покупки: ");
double purchaseSum = double.Parse(Console.ReadLine());

Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
int cardInput = int.Parse(Console.ReadLine());
bool hasCard = (cardInput == 1);

Console.Write("Введите количество товаров в чеке: ");
int itemsCount = int.Parse(Console.ReadLine());

bool enoughSum = purchaseSum >= 3000;
bool enoughItems = itemsCount >= 3;

bool eligibleForDiscount = (enoughSum && enoughItems) || hasCard;

Console.WriteLine();
Console.WriteLine($"Сумма >= 3000: {enoughSum}");
Console.WriteLine($"Товаров >= 3: {enoughItems}");
Console.WriteLine($"Есть карта: {hasCard}");
Console.WriteLine($"Скидка положена: {eligibleForDiscount}");






