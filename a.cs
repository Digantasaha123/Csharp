using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
   
// int age = 20;
// if (age > 10)
// {
//     Console.WriteLine("Hello");
//     Console.WriteLine(age); // Changed to WriteLine so it formats neatly
// }

// char grade = 'A';
// bool isPassed = true;
// string name = "Diganta Saha";
// // for (int i=0; i<10; i++)
// // {
// //     Console.WriteLine(i);
// // }
// int[] numbers = [1,2,3,4];
// Console.WriteLine(numbers); 
//Switch Case 
int age = 50;
switch (age)
{
    case 10:
        Console.Write("Hello");
        break;
    case 20:
        Console.Write("Hello");
        break;
    default:
        Console.WriteLine("Faulty");
        break;
}
// while (age != 45)
// {
//     Console.WriteLine("Hello " + age);
//     age--;
// }
// Console.WriteLine(age);
// For each loop
// int[] nums = {1,2,3,3,4,5};
// foreach(int num in nums)
// {
//     Console.WriteLine(num);
// }
// Console.WriteLine("Enter First Number : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Second Number : ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a+b);
// for(int i=0; i<a; i++)  Console.WriteLine(i%2==0? i  + " is Even": i +  " is Odd") ;

// int[] arr = [59,1265,132,15,58,6,9,451,5,62];
// foreach(int i in arr)
// {
//     Console.WriteLine(i);
// }
// Array.Sort(arr);
// Console.WriteLine("After Sorting");
// foreach(int i in arr)
// {
//     Console.WriteLine(i);
// }

// int [,] grid = {
//     {1,2,3},
//     {4,5,6},
//     {7,8,9},
// };
// string name = "John";
// string name2 = "john";
// char [] chars = name.ToCharArray();
// bool isEqual = name.Equals(name2);
// Console.WriteLine(name);
// Console.WriteLine(name2);
// Console.WriteLine(isEqual);

List<int> numbers = new List<int> ();
numbers.Add(35);
numbers.Add(40);
numbers.Add(45);
numbers.Add(50);
numbers.Add(55);
numbers.Add(60);

foreach(int i in numbers)
{
    Console.WriteLine(i);
}
numbers.Remove(55);
foreach(int i in numbers)
{
    Console.WriteLine(i);
}

 Dictionary<string,int> marks = new Dictionary<string,int>();
        marks.Add("Math",40);
        marks.Add("English",40);
        marks.Add("Bangla",80);
        Console.WriteLine(marks["Bangla"]);
        marks["Bangla"] = 90;
        marks.Remove("Math");
        if(marks.ContainsKey("Bangla")){
            Console.WriteLine(marks["Bangla"]);
        } else {
            Console.WriteLine("Key not found");
        } 