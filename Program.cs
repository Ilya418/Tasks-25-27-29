// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Задача 25. Возведене числа A в натуральную степень B");

//double Exponentiation(int numberA, int numberB){
//  double result = Math.Pow(numberA, numberB);
//  return result;
//}

// for (int j=1; j < 3; j++){

//   Console.WriteLine($"\n Шаг № {j} ");

//  Console.Write("Введите число A: ");
//  int numberA = Convert.ToInt32(Console.ReadLine());

//  Console.Write("Введите число B: ");
//  int numberB = Convert.ToInt32(Console.ReadLine());

//  double exponentiation = Exponentiation(numberA, numberB);

//  Console.WriteLine("Ответ: " + exponentiation);
// }




//Console.WriteLine("Задача 27. Выдаёт сумму цифр в числе");
//Console.Write("Введите число N: ");
//int numberN = Convert.ToInt32(Console.ReadLine());

//  int SumNumber(int numberN){

//    int counter = Convert.ToString(numberN).Length;
//    int advance = 0;
//    int result = 0;

//    for (int i = 0; i < counter; i++){
//      advance = numberN - numberN % 10;
//     result = result + (numberN - advance);
//      numberN = numberN / 10;
//    }
//   return result;
//  }

//int sumNumber = SumNumber(numberN);
//Console.WriteLine("Сумма цифр в числе: " + sumNumber);




//Console.WriteLine("Задача 29");
//int [] numbers = new int[8];
//Console.Write("[");

//for (int i = 0; i < numbers.Length; i++)
// {
//    numbers [i] = new Random().Next(0, 11);
//    Console.Write(" " + Method (i) + " ");
// }
//Console.Write("]");
//
//int Method (int a)
//{
//    return numbers[a];
//}...