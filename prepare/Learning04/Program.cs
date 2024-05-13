using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Roberto Rodriguez", "Multiplication");
        string summaryAssignment = assignment.GetSummary();
        Console.WriteLine(summaryAssignment);


        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string mathAssignmentSummary = mathAssignment.GetSummary();
        string homeWorkListMathAssignment = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeWorkListMathAssignment);
        Console.WriteLine(mathAssignmentSummary);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string getStudentInformation = writingAssignment.GetSummary();
        string getTitleInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine(getTitleInformation);
        Console.WriteLine(getStudentInformation);
    }
}