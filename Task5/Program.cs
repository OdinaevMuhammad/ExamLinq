string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

var list = words.OrderByDescending(x=> x.Length);

System.Console.WriteLine(string.Join(",", list));