var client = new HttpClient();
var url = "https://ru.wikipedia.org/wiki/";

for(var i = 'a'; i <= 'z'; i++)
{
    for(var j = 'a'; j <= 'z'; j++)
    {
        var path = url + "." + i + j;

        HttpResponseMessage responce = await client.GetAsync(path);

        if(responce.IsSuccessStatusCode)
        {
            Console.WriteLine("success");

            var text = await responce.Content.ReadAsStringAsync();
            var filepath = $"..\\..\\..\\HTMLs\\{i}{j}.html";

            File.Create(filepath).Close();
            File.WriteAllText(filepath, text);
        }
    }
}

