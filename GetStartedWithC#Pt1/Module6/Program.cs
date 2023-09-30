// Module 6: Guided Project: Calculate final GPA

/*
Sample Course Information + GPA

Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// 1. Exercise: Store the numeric grade values for each course

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// 2. Exercise - Calculate the sums of credit hours and grade points
/*
Course          Credit  Credit Hours    Grade Points
English 101     4		3               12
*/

int totalCreditHours = 0;
int totalGradePoints = 0;

totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// 3. Exercise - Calculate the final GPA and format the decimal output

decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

// 4. Exercise - Format the output using escaped character sequences

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{trailingDigits}");


