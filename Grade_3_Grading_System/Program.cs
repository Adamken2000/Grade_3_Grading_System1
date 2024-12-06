using System;
class Program
{
    static void Main(string[] args)
    {

        int totalPupil = 30;
        for (int numOfPupil = 0; numOfPupil < totalPupil; numOfPupil++)
        {
            Console.Write("Enter Name of Student:");
            string nameOfStundent = Console.ReadLine();
            Console.WriteLine("Input grade within 0 - 100 for following subjects in order of opener , mid-term , end term assessment:");
            //math
            Console.WriteLine("Mathmatical activity:");
            Console.Write("Opener:");
            double openerMath = Convert.ToDouble(Console.ReadLine());
            while ( openerMath < 0 || openerMath > 100 )
            {
                Console.Write("Invalid input. Try again:");
                openerMath = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Mid-term:");
            double midtermMath = Convert.ToDouble(Console.ReadLine());
            while (midtermMath < 0 || midtermMath > 100)
            {
                Console.Write("Invalid input. Try again:");
                midtermMath = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("End-term:");
            double endtermMath = Convert.ToDouble(Console.ReadLine());
            while (endtermMath < 0 || endtermMath > 100)
            {
                Console.Write("Invalid input. Try again:");
                endtermMath = Convert.ToDouble(Console.ReadLine());
            }
            double averageForMath = (openerMath + midtermMath + endtermMath) / 3;
            //language
            Console.WriteLine("Language:");
            Console.Write("Opener:");
            double openerLang = Convert.ToDouble(Console.ReadLine());
            while (openerLang < 0 || openerLang > 100)
            {
                Console.Write("Invalid input. Try again:");
                openerLang = Convert.ToDouble(Console.ReadLine());
            }
                Console.Write("Mid-term:");
            double midtermLang = Convert.ToDouble(Console.ReadLine());
            while (midtermLang < 0 || midtermLang > 100)
            {
                Console.Write("Invalid input. Try again:");
                midtermLang = Convert.ToDouble(Console.ReadLine());
            }
                    Console.Write("End-term:");
            double endtermLang = Convert.ToDouble(Console.ReadLine());
            while (endtermLang < 0 || endtermLang > 100)
            {
                Console.Write("Invalid input. Try again:");
                endtermLang = Convert.ToDouble(Console.ReadLine());
            }
            double averageForLang = (openerLang + midtermLang + endtermLang) / 3;
            //Kiswahili
            Console.WriteLine("Kiswahili activity:");
            Console.Write("Opener:");
            double openerKisw = Convert.ToDouble(Console.ReadLine());
            while (openerKisw < 0 || openerKisw > 100)
            {
                Console.Write("Invalid input. Try again:");
                openerKisw = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Mid-term:");
            double midtermKisw = Convert.ToDouble(Console.ReadLine());
            while (midtermKisw < 0 || midtermKisw > 100)
            {
                Console.Write("Invalid input. Try again:");
                midtermKisw = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("End-term:");
            double endtermKisw = Convert.ToDouble(Console.ReadLine());
            while (endtermKisw < 0 || endtermKisw > 100)
            {
                Console.Write("Invalid input. Try again:");
                endtermKisw = Convert.ToDouble(Console.ReadLine());
            }
            double averageForKisw = (openerKisw + midtermKisw + endtermKisw) / 3;
            //Environment
            Console.WriteLine("Environmental activity:");
            Console.Write("Opener:");
            double openerEnvi = Convert.ToDouble(Console.ReadLine());
            while (openerEnvi < 0 || openerEnvi > 100)
            {
                Console.Write("Invalid input. Try again:");
                openerEnvi = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Mid-term:");
            double midtermEnvi = Convert.ToDouble(Console.ReadLine());
            while (midtermEnvi < 0 || midtermEnvi > 100)
            {
                Console.Write("Invalid input. Try again:");
                midtermEnvi = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("End-term:");
            double endtermEnvi = Convert.ToDouble(Console.ReadLine());
            while (endtermEnvi < 0 || endtermEnvi > 100)
            {
                Console.Write("Invalid input. Try again:");
                endtermEnvi = Convert.ToDouble(Console.ReadLine());
            }
            double averageForEnvi = (openerEnvi + midtermEnvi + endtermEnvi) / 3;
            //Creative
            Console.WriteLine("Creative activity:");
            Console.Write("Opener:");
            double openerCreat = Convert.ToDouble(Console.ReadLine());
            while (openerCreat < 0 || openerCreat > 100)
            {
                Console.Write("Invalid input. Try again:");
                openerCreat = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Mid-term:");
            double midtermCreat = Convert.ToDouble(Console.ReadLine());
            while (midtermCreat < 0 || midtermCreat > 100)
            {
                Console.Write("Invalid input. Try again:");
                midtermCreat = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("End-term:");
            double endtermCreat = Convert.ToDouble(Console.ReadLine());
            while (endtermCreat < 0 || endtermCreat > 100)
            {
                Console.Write("Invalid input. Try again:");
                endtermCreat = Convert.ToDouble(Console.ReadLine());
            }
            double averageForCreat = (openerCreat + midtermCreat + endtermCreat) / 3;
            //average of all subjects
            double aveOfSubjects = (averageForMath + averageForLang + averageForKisw + averageForEnvi + averageForCreat) / 5;
            aveOfSubjects = Math.Round(aveOfSubjects, 1);
            Console.WriteLine($"End term average score for {nameOfStundent}:{aveOfSubjects}");
            if (aveOfSubjects <=39)
            {
                Console.WriteLine("Below Expectation");
            }
            else if (aveOfSubjects <=49)
            {
                Console.WriteLine("Approaches Expectation");
            }
            else if (aveOfSubjects <=69)
            {
                Console.WriteLine("Meets Expectation");
            }
            else if (aveOfSubjects <= 100)
            {
                Console.WriteLine("Exceeds Expectation");
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}