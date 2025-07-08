//string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

//DisplayStudents(students);
//DisplayStudents(new string[] { "Robert", "Vanya" });

//void DisplayStudents(string[] students)
//{
//    foreach (string student in students)
//    {
//        Console.Write($"{student}, ");
//    }
//    Console.WriteLine();
//}

//PrintCircleInfo(12);

//void PrintCircleArea(int radius)
//{
//    double pi = 3.14159;
//    double area = pi * (radius * radius);
//    Console.WriteLine($"Area = {area}");
//}

//void PrintCircleCircumference(int radius)
//{
//    double pi = 3.14159;
//    double circumference = 2 * pi * radius;
//    Console.WriteLine($"Circumference = {circumference}");
//}

//void PrintCircleInfo(int radius)
//{
//    Console.WriteLine($"Circle with radius {radius}");
//    PrintCircleArea(radius);
//    PrintCircleCircumference(radius);
//}


int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

//int[] array = { 1, 2, 3, 4, 5 };

//PrintArray(array);
//Clear(array);
//PrintArray(array);

//void PrintArray(int[] array)
//{
//    foreach (int a in array)
//    {
//        Console.Write($"{a} ");
//    }
//    Console.WriteLine();
//}

//void Clear(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = 0;
//    }
//}

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}