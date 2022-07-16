namespace HackerRank.Algorithms;

public static class GradingStudents
{
    public static List<int> gradingStudents(List<int> grades)
    {
        return  grades.Select(x => roundGrade(x)).ToList();
    }

    public static int roundGrade(int grade)
    {
        var nearFive = grade + (  5  - grade % 5 ) ;
        if (grade > (40-3) && nearFive  - grade < 3)
        {
            grade = nearFive;
        }
        return grade;
    }
}