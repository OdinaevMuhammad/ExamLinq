int[] numbers = { 5, 8, 12, 15, 20, 25, 30 };

var list = numbers.OrderByDescending(x=> x).Take(3);

System.Console.WriteLine(string.Join(",", list));