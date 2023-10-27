// See https://aka.ms/new-console-template for more information
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
                //SayHello();
                break;

            case 2:
                Console.WriteLine("add all numbers, please input as many numbers seperated by spaces");
                int Mnum1 = Convert.ToInt32(Console.ReadLine());
                //AddAllNumbers(nums[]);
                 break;

            case 3:
                Console.WriteLine("multiply all numbers, please input as many numbers seperated by spaces");
                int multiplyNums = Convert.ToInt32(Console.ReadLine());
                //MultiplyAllNumbers(nultiplyNums[]);
                break;

            case 4:
                Console.WriteLine("Find minimum number,  please input 2 numbers seperated by spaces");
                int minNums = Convert.ToInt32(Console.ReadLine());
                //FindMin(minNums[]);
                break;

            case 5:
                Console.WriteLine("Find maximum number,  please input 2 numbers seperated by spaces");
                int maxNums = Convert.ToInt32(Console.ReadLine());
                //FindMax(maxNums[]);
                break;

            case 6:
                Console.WriteLine("Check if num is odd, please input your number");
                int oddNum = int.Parse(Console.ReadLine()!);
                //isOdd(oddNum);
                break;

            case 7:
                Console.WriteLine("please input your desired word");
                string? word = Console.ReadLine();
                //PrintLetters(word);
                break;
}