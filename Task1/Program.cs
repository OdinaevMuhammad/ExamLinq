int[] numbers = { 1, 5, 8, 12, 15, 20 };

var list = numbers.Where(x=> x > 10);

System.Console.WriteLine(string.Join(",", list));