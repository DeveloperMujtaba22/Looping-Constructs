//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


////string name = "ABC";
////float num = 5;
////float num1 = 12.5f;
////Console.WriteLine(name);
////Console.WriteLine(num);
////Console.WriteLine(num1);

////const float pi = 3.14f;
////float radius = 5;
////float area = pi * radius * radius;
////Console.WriteLine("Area of circle is:" + area);


////Console.Write("Enter your name: ");
////name = Console.ReadLine();
////Console.WriteLine(name);


//const double totalMarks = 500;
//Console.Write("Enter Obtained Marks:");
//double obtMarks = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("obtained Marks: " + obtMarks);
//Console.WriteLine("Total Marks: " + totalMarks);
//double percent = (obtMarks / totalMarks) * 100;
//Console.WriteLine("Percentage: " + percent);


//if (percent >= 80)
//{
//  Console.WriteLine("A");
//}
//else if(percent >= 70 && percent < 80 )
//{
//  Console.WriteLine("B");
//}
//else if (percent >= 60 && percent < 70)
//{
//  Console.WriteLine("C");
//}
//else if (percent >= 50 && percent < 60)
//{
//  Console.WriteLine("D");
//}
//else
//{
//  Console.WriteLine("F");
//}



//int day = 4;
//switch (day)
//{
//  case 1:
//    Console.WriteLine("Sunday");
//    break;

//  case 2:
//    Console.WriteLine("Monday");
//    break;

//  case 3:
//    Console.WriteLine("Tuesday");
//    break;

//  default:
//    Console.WriteLine("Enter a vaild number between 1 to 7");
//    break;
//}



//while loop


int n = 1;
//while (n<= 10)
//{
//  if(n%2 == 0 )
//  {
//    Console.WriteLine(n);

//  }
//  n++;
//}



//do-while
//do
//{
//  if (n % 2 == 0)
//  {
//    Console.WriteLine(n);
//  }
//  n++;
//}
//while (n <= 10);


//for-loop
//for(int i = 0; i<=10; i++)
//{
//  if (i % 2 == 0)
//  {
//    Console.WriteLine(i);
//  }
//}



//nested-loop

//Console.WriteLine("Enter rows value: ");
//int rows = int.Parse(Console.ReadLine());
//Console.Write("Enter column value: ");
//int col = int.Parse(Console.ReadLine());

//for(int i=0; i< rows; i++)
//{
//  for(int j=0; j<col; j++)
//  {
//    Console.Write("*");
//  }
//  Console.WriteLine();
//}






//for (int i = 0; i < 10; i++)
//{
//  if (i == 3) continue;  // Skip 3
//  if (i == 8) break;     // Exit at 8
//  Console.WriteLine(i);
//}


//foreach loop

//string[] fruits = { "Apple", "Banana", "Orange", "Mango" };

//foreach (string fruit in fruits)
//{
//  Console.WriteLine(fruit);
//}


//List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

//foreach (int num in numbers)
//{
//  Console.WriteLine(num * 2);
//}


//var colors = new List<string> { "Red", "Green", "Blue" };

//foreach (var color in colors)
//{
//  Console.WriteLine(color.ToUpper());
//}


//Dictionary<int, string> students = new Dictionary<int, string>()
//{
//    { 1, "Alice" },
//    { 2, "Bob" },
//    { 3, "Charlie" }
//};

//foreach (KeyValuePair<int, string> kvp in students)
//{
//  Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
//}














