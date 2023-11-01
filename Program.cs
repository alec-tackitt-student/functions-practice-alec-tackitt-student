// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Random randNum = new Random(); // random number generator
Console.WriteLine("Hello, please select what you would like to do");
Console.WriteLine("1 ---------- Say Hello");
Console.WriteLine("2 ---------- add all numbers");
Console.WriteLine("3 ---------- multiply all numbers");
Console.WriteLine("4 ---------- Find minimum number");
Console.WriteLine("5 ---------- Find maximum number");
Console.WriteLine("6 ---------- is number odd?");
Console.WriteLine("7 ---------- Print letters in word");
Console.WriteLine("----------------------------------------------");
int select = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------");

switch (select) {
            case 1:
                SayHello();
                break;

            case 2:
                Console.WriteLine("add all numbers, random numbers generating");
                Wait();
                int[] addArrayNums = new int[10];
                Console.WriteLine("----------------------------------------------");
                for (int i = 0; i < addArrayNums.Length; i++)
                {
                    addArrayNums[i] = randNum.Next(0, 10);
                }
                AddAllNumbers(addArrayNums);
                 break;

            case 3:
                Console.WriteLine("multiply all numbers, random numbers generating");
                Wait();
                int[] multiplyArrayNums = new int[5];
                Console.WriteLine("----------------------------------------------");
                for (int i = 0; i < multiplyArrayNums.Length; i++)
                {
                    multiplyArrayNums[i] = randNum.Next(0, 10);
                }
                MultiplyAllNumbers(multiplyArrayNums);
                break;

            case 4:
                Console.WriteLine("Find minimum number,  please the first number");
                int num1 = int.Parse(Console.ReadLine()!);
                System.Console.WriteLine("input the second number");
                int num2 = int.Parse(Console.ReadLine()!);
                Console.WriteLine("----------------------------------------------");
                FindMin(num1, num2);
                break;

            case 5:
                Console.WriteLine("Find maximum number,  please input 2 numbers seperated by spaces");
                int maxNums = Convert.ToInt32(Console.ReadLine());
                //FindMax(maxNums[]);
                break;

            case 6:
                Console.WriteLine("Check if num is odd, please input your number");
                int oddNum = int.Parse(Console.ReadLine()!);
                isOdd(oddNum);
                break;

            case 7:
                Console.WriteLine("please input your desired word");
                string? word = Console.ReadLine();
                //PrintLetters(word);
                break;
}
//waiting function 
static void Wait() {
    Thread.Sleep(1000);
    System.Console.Write(".");
    Thread.Sleep(1000);
    System.Console.Write(".");
    Thread.Sleep(1000);
    System.Console.Write(".");
    System.Console.WriteLine("");
}
// functions to preform based of selection
static void SayHello() {
    Console.WriteLine("Hello, World!");
}
static void AddAllNumbers(int[] nums) {
    int sum = 0;
    foreach (int num in nums) {
        sum += num;
    }
    System.Console.WriteLine("the random numbers are:");
    foreach(var item in nums)
    {
        Console.Write(item.ToString() + " ");
    }
    System.Console.WriteLine(", the sum of the numbers is " + sum);

}
static void MultiplyAllNumbers(int[]nums) {
     int product = 1;
    foreach (int num in nums) {
        product *= num;
    }
    System.Console.WriteLine("the random numbers are:");
    foreach(var item in nums)
    {
        Console.Write(item.ToString() + " ");
    }
    System.Console.WriteLine(", the product of the numbers is " + product);
}
static void FindMin(int num1, int num2) {
    bool numsAreEqual = num1 == num2;
    if (numsAreEqual){
        System.Console.WriteLine("-1");
    }
}

static void isOdd(int num) {
    bool isNumEven = Math.IEEERemainder(num, 2) == 0;

    if (isNumEven) {
        System.Console.WriteLine("the number is even");
    }
    else {
        System.Console.WriteLine("the number is odd");
    }
}