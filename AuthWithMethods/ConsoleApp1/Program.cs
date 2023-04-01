using System.IO.Pipes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to employee adder system");
            Console.WriteLine();

            Console.Write("Please enter the name:");
            string name = Console.ReadLine();

            Console.Write("Please enter the surname:");
            string surname = Console.ReadLine();

            Console.Write("Please enter the father's name:");
            string fatherName = Console.ReadLine();

            Console.Write("Please enter the age:");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Please enter the PIN-code:");
            string pinCode = Console.ReadLine();

            Console.Write("Please enter the phone number:");
            string phoneNum = Console.ReadLine();


            Console.WriteLine("Please Select the position");
            PositionChoicer();

            Console.WriteLine("Please Select the salary");
            int salary=int.Parse(Console.ReadLine());


            if (NameChecker(ref name) is true 
                && SurnameChecker(ref surname) is true 
                && FatherNameChecker(ref fatherName) is true 
                && AgeChecker(ref age) is true 
                && PinChecker(ref pinCode) is true 
                && PhoneNumChecker(ref phoneNum) is true 
                && SalaryChecker(ref salary) is true)
            {
                Console.WriteLine($"{name},{surname} has been added");
            }
            else
            {
                Console.WriteLine("smth went wrong");
            }

        }

        static bool NameChecker(ref string name)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            bool firstLetterChecker = false;
            if (name.Length < 2 || name.Length > 20) { return false; }

            for (int i = 0; i < uppercaseLetters.Length; i++)
            {
                if (name[0] == uppercaseLetters[i])
                {
                    firstLetterChecker = true;
                    break;
                }
            }

            if (firstLetterChecker is true)
            {
                firstLetterChecker = false;

                for (int i = 1; i <= name.Length - 1; i++)
                {
                    for (int j = 0; j < lowerLetters.Length; j++)
                    {
                        if (name[i] == lowerLetters[j])
                        {
                            firstLetterChecker = true;
                            break;

                        }
                        else if (j == lowerLetters.Length - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

            if (firstLetterChecker is true) { return true; }
            else { return false; }





        }
        static bool SurnameChecker(ref string surname)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            bool firstLetterChecker = false;
            if (surname.Length < 2 || surname.Length > 35) { return false; }

            for (int i = 0; i < uppercaseLetters.Length; i++)
            {
                if (surname[0] == uppercaseLetters[i])
                {
                    firstLetterChecker = true;
                    break;
                }
            }

            if (firstLetterChecker is true)
            {
                firstLetterChecker = false;

                for (int i = 1; i <= surname.Length - 1; i++)
                {
                    for (int j = 0; j < lowerLetters.Length; j++)
                    {
                        if (surname[i] == lowerLetters[j])
                        {
                            firstLetterChecker = true;
                            break;

                        }
                        else if (j == lowerLetters.Length - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

            if (firstLetterChecker is true) { return true; }
            else { return false; }





        }
        static bool FatherNameChecker(ref string fatherName)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            bool firstLetterChecker = false;

            if (fatherName.Length < 2 || fatherName.Length > 20) { return false; }

            for (int i = 0; i < uppercaseLetters.Length; i++)
            {
                if (fatherName[0] == uppercaseLetters[i])
                {
                    firstLetterChecker = true;
                    break;
                }
            }

            if (firstLetterChecker is true)
            {
                firstLetterChecker = false;

                for (int i = 1; i <= fatherName.Length - 1; i++)
                {
                    for (int j = 0; j < lowerLetters.Length; j++)
                    {
                        if (fatherName[i] == lowerLetters[j])
                        {
                            firstLetterChecker = true;
                            break;

                        }
                        else if (j == lowerLetters.Length - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

            if (firstLetterChecker is true) { return true; }
            else { return false; }





        }
        static bool AgeChecker(ref byte age)
        {
            if (age < 18 || age > 65)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool PinChecker(ref string pinCode)
        {
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool pinChecker = false;

            if (pinCode.Length != 7)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < pinCode.Length; i++)
                {
                    for (int j = 0; j < uppercaseLetters.Length; j++)
                    {
                        if (pinCode[i] == uppercaseLetters[j])
                        {
                            pinChecker = true;
                            break;

                        }
                        else if (j == uppercaseLetters.Length - 1)
                        {
                            for (int n = 0; n < numbers.Length; n++)
                            {
                                if (pinCode[i] == numbers[n])
                                {
                                    pinChecker = true;
                                    break;
                                }
                                else if (n == numbers.Length - 1)
                                {
                                    return false;
                                }
                            }
                        }
                    }

                }
            }


            if (pinChecker is true) { return true; }
            else { return false; }



        }
        static bool PhoneNumChecker(ref string phoneNum)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool phoneChecker = false;

            if (phoneNum.Length != 13 || phoneNum[0] != '+' || phoneNum[1] != '9' || phoneNum[2] != '9' || phoneNum[3] != '4')
            {
                return false;
            }

            for (int i = 1; i < phoneNum.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (phoneNum[i] == numbers[j])
                    {
                        phoneChecker = true;
                        break;
                    }
                    else if (j == numbers.Length - 1)
                    {
                        return false;
                    }
                }
            }
            return true;    
        }
        static bool SalaryChecker(ref int salary)
        {
            if(salary > 1500 && salary < 5000)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static string PositionChoicer()
        {
            string[] positions = { "HR", "Audit", "Engineer" };


            for (int i = 0; i < positions.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{positions[i]}");
            }
            string profChoice = Console.ReadLine();
            if (profChoice == "1")
            {
                Console.WriteLine($"You have chosen {positions[0]}");
                return positions[0];

            }
            if (profChoice == "2")
            {
                Console.WriteLine($"You have chosen {positions[1]}");
                return positions[1];


            }
            if (profChoice == "3")
            {
                Console.WriteLine($"You have chosen {positions[2]}");
                return positions[2];

            }
            else
            {
                return positions[0];
            }


        }
    }
}