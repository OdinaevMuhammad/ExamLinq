int[] numbers = { 1, 5, 8, 12, 15, 20 };

var list = numbers.Where(x=> x % 2 == 1).Sum();

System.Console.WriteLine(string.Join(",", list));