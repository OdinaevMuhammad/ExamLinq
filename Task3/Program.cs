string[] names = { "Alice", "Anny", "Amy", "Dav", "Alex" };

var list = names.Where(x=> x.ToLower().StartsWith("a") && x.ToLower().EndsWith("a"));

System.Console.WriteLine(string.Join(",", list));