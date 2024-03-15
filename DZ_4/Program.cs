using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    internal class Program
    {
        enum Digit 
        {
            zero,one,two,three,four,five,six,seven,eight,nine
        }

        class Passport
        {
            public string PassportNumber { get; set; }
            public string FullName { get; set; }
            public DateTime IssueDate { get; set; }

            public Passport(string passportNumber, string fullName, DateTime issueDate)
            {
                if (string.IsNullOrEmpty(passportNumber) || string.IsNullOrEmpty(fullName) || issueDate == DateTime.MinValue)
                {
                    throw new Exception("Неверные данные для создания паспорта.");
                }

                this.PassportNumber = passportNumber;
                this.FullName = fullName;
                this.IssueDate = issueDate;

                
            }
            public override string ToString() 
            {
                return $"Номер паспорта: {PassportNumber} \nФИО: {FullName} \nДата: {IssueDate}";
            }
        } 

        static void Main(string[] args)
        {

            //Console.WriteLine("1. Из десятичной в двоичную");
            //Console.WriteLine("2. Из двоичной в десятичную");
            //Console.Write("Выберите направление перевода: ");

            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    Console.Write("Введите число в десятичной системе: ");
            //    int decimalNumber = int.Parse(Console.ReadLine());
            //    string binaryNumber = Convert.ToString(decimalNumber, 2);
            //    Console.WriteLine($"Число {decimalNumber} в двоичной системе: {binaryNumber}");
            //}
            //else if (choice == 2)
            //{
            //    Console.Write("Введите число в двоичной системе: ");
            //    string binaryNumber = Console.ReadLine();
            //    int decimalNumber = Convert.ToInt32(binaryNumber, 2);
            //    Console.WriteLine($"Число {binaryNumber} в десятичной системе: {decimalNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Некорректный выбор.");
            //}
            //Console.Write("Введите цифры словом: ");
            //string str_num = Console.ReadLine();
            //int num = (int)Enum.Parse(typeof(Digit), str_num);
            //Console.WriteLine(num);
            //Console.Write("Введите номер паспорта: ");
            //string number_of_passport = Console.ReadLine();
            //Console.Write("Введите ФИО: ");
            //string FullName = Console.ReadLine();
            //Console.Write("Введите дату: ");
            //DateTime date;
            //DateTime.TryParse(Console.ReadLine(), out date);
            //try 
            //{
            //    Passport passport = new Passport(number_of_passport, FullName, date);
            //    Console.WriteLine("Заграничный паспорт успешно создан.");
            //    Console.WriteLine(passport);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Ошибка при создании паспорта: " + ex.Message);
            //}
            //Console.Write("Введите логическое выражение в формате 'число оператор число': ");
            //string input = Console.ReadLine();

            //try
            //{
            //    string[] parts = input.Split(' ');
            //    if (parts.Length != 3)
            //    {
            //        throw new ArgumentException("Некорректный формат ввода.");
            //    }

            //    int num1 = int.Parse(parts[0]);
            //    int num2 = int.Parse(parts[2]);
            //    string op = parts[1];

            //    bool result;
            //    switch (op)
            //    {
            //        case "<":
            //            result = num1 < num2;
            //            break;
            //        case ">":
            //            result = num1 > num2;
            //            break;
            //        case "<=":
            //            result = num1 <= num2;
            //            break;
            //        case ">=":
            //            result = num1 >= num2;
            //            break;
            //        case "==":
            //            result = num1 == num2;
            //            break;
            //        case "!=":
            //            result = num1 != num2;
            //            break;
            //        default:
            //            throw new ArgumentException("Некорректный оператор.");
            //            break;
            //    }

            //    Console.WriteLine($"Результат: {result}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Ошибка: {ex.Message}");
            //}
        }
    }
}
