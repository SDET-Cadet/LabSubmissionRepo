namespace ClassTracker
{
    public class NonCreditCourse : Course
    {
        public override float CalculateAverage(float[] arrGrades)
        {
            float avg = 0;
            float sum = 0;
            int numGrades = arrGrades.Count();
            foreach (float grade in arrGrades)
            {
                sum = sum + grade;
            }
            avg = sum / numGrades;
            return avg;
        }

        public char CalculateGrade(float grade)
        {
            char letterGrade;
            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80 && grade <= 89)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70 && grade <= 79)
            {
                letterGrade = 'C';
            }
            else if (grade >= 66 && grade <= 69)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
            return letterGrade;
        }
    }
}
