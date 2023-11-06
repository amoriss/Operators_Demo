using Operators_Demo;

#region Arithmetic Operators

int x = 10;
int y = 5;

//x += y;
//x = x + y;
//x -= y;
//x *= y;
//Console.WriteLine(x);

//double y = ++x;
//Console.WriteLine("y's value: ");
//Console.WriteLine(y);
//Console.WriteLine("x's value: ");
//Console.WriteLine(x);




//int test = ++y - x++;
//Console.WriteLine(test);

//int a = 1;
//int b = 2;

//int answer = a-- + ++b;
//Console.WriteLine(a);
//Console.WriteLine(answer);
//Console.WriteLine(a);

//int num1 = 7;
////int answer = num1++;
//////Console.WriteLine(answer);
////Console.WriteLine(num1);
//Console.WriteLine(num1);

//int answer = --num1;
//Console.WriteLine(num1);
//Console.WriteLine(answer);

#endregion

#region Relational and Logical Operators
//int number1 = 10;
//int number2 = 8;
////bool isTall = true;
////string str1 = "1st choice";
////string str2 = "2nd choice";


//if (number1 == 10)
//{
//    Console.WriteLine("1st line will execute");
//}
//else
//{
//    Console.WriteLine("2nd line will execute");
//}

//string theValue = number1 > 0 || !z ? str1 : str2;
//Console.WriteLine(theValue);

//int? myVariable1 = null;
//bool answer = myVariable1 >= 0;

//List<int> myList = null;
//List<int> myList2 = new List<int>() { 1, 2, 3 };

//foreach (var item in myList)
//{
//    Console.WriteLine(item);
//}

//foreach (var item in myList2)
//{
//    Console.WriteLine(item);
//}

#endregion

#region NULL COALESCING OPERATOR
//Gives default value

//string string1 = null;
//string outcome = string1 ?? "Hello, guest";
//Console.WriteLine(outcome);
//List<int> list = null;
//Methods.NullCoalesc(list);
//Methods.NullConditional(list);


#endregion

#region NULL CONDITIONAL OPERATOR
//Operates only if something is non-null

//what to do if we have a nullreference exception: 
//NULL CONDITIONAL OPERATOR


//List<string> thirdList = null;
////thirdList.Add("myString"); // will get error

//thirdList?.Add("myString");

//foreach (var item in thirdList)
//{
//    Console.WriteLine(item);
//}

#endregion

#region TERNARY OPERATOR

int var1 = 100;
int var2 = 200;

//if ((var1 >= var2) || var2 == 200)
//{
//    Console.WriteLine("1st choice");
//}
//else
//{
//    Console.WriteLine("second choice");
//}

//string stringAnswer = ((var1 >= var2) || var2 == 200 ) ? "1st choice" : "2nd choice";
//Console.WriteLine(stringAnswer);

//if (var1 % 2 == 0)
//{
//    Console.WriteLine($"{var1} is even");
//}
//else
//{
//    Console.WriteLine($"{var1} is odd");
//}


//var checkEvenOrOdd = (var1 % 2 == 0 && var1 > 100) ? $"{var1} is even" : $"{var1} is odd";
//Console.WriteLine(checkEvenOrOdd);

#endregion