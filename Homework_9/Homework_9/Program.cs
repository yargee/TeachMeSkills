﻿var client = new HttpClient();
var path = "https://ru.wikipedia.org/wiki/%D0%97%D0%B0%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D1%81%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0";

var result = await client.GetAsync(path);
var text = await result.Content.ReadAsStringAsync();

Console.WriteLine(text);
