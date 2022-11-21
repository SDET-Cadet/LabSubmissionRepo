using System;

namespace ClassTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            CreditCourse creditCourse = new CreditCourse();
            creditCourse.CourseTitle = "CS101";
            creditCourse.CreditHours = 6;
            creditCourse.Program = "Computer Science";
            creditCourse.EnrollStudent("Tom Thumb");

            float GPA = creditCourse.CalculateGPA(98.5F);
            Console.WriteLine("Tom Thumb has a GPA of {0} in course {1}.", GPA, creditCourse.CourseTitle);

            NonCreditCourse nonCreditCourse = new NonCreditCourse();
            nonCreditCourse.CourseTitle = "Introduction to Excel";
            char grade = nonCreditCourse.CalculateGrade(87.0F);
            Console.WriteLine("Tom also received a {0} in {1}", grade, nonCreditCourse.CourseTitle);

            CreditCourse newCreditCourse = new CreditCourse();
            Console.WriteLine(newCreditCourse.CourseTitle);
            CreditCourse newCreditCourseTwo = new CreditCourse("CS102", 6, "Computer Science");
            Console.WriteLine(newCreditCourseTwo.CourseTitle);



        }
    }
}
