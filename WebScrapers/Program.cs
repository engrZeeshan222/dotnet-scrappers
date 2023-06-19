// See https://aka.ms/new-console-template for more information


// HtmlAgilityPack is an HTML parser written in C# to read/write DOM.
// CsvHelper is a package that’s used to read and write CSV files.

/**
Performing Calls:
    .NET HttpClient
    RestSharp
Parsing HTML:
    Html Agility Pack (HAP)
    CSQuery
    AngleSharp
Virtual Browser:
    Headless Chrome
    Selenium WebDriver
    Puppeteer Sharp
*/

using HtmlAgilityPack;
//  Console.WriteLine("Welcome to Web Scraping!");

public class Program {
        static async Task Main(string[] args)
        {
            var html = await GetHtml();
            var data = ParseHtmlUsingHtmlAgilityPack(html);
        }

        // get html
        private static async Task<string> GetHtml()
        {
        try{
            var client = new HttpClient();
            var domReponse =  await client.GetStringAsync("https://github.com/AhmedTarekHasan");
            
            
            if(domReponse == null){
                throw new CustomException("No Dom Data was found!!!");
            }
            
            return domReponse;

        }
        catch (Exception e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                Console.WriteLine("StackTrace :{0} ", e.StackTrace);
                Console.WriteLine("Source :{0}", e.Source);
                Console.WriteLine("Get Type -{0}", e.GetType());
                Console.WriteLine("String Type Error -{0}", e.ToString());

                return "";
            }
        }


        private static List<ScrappedData> ParseHtmlUsingHtmlAgilityPack(string html)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var repositories =
                htmlDoc
                    .DocumentNode
                    .SelectNodes("//div[@class='js-pinned-items-reorder-container']/ol/li/div/div");

            // Console.WriteLine("repositories : {0}",repositories);
            // List<(string RepositoryName, string Description)> data = new();
            List<ScrappedData> data = new List<ScrappedData>();

            // foreach (var repo in repositories)
            // {
            //     var name = repo.SelectSingleNode("div/div/span/a").InnerText;
            //     var description = repo.SelectSingleNode("p").InnerText;
            //     Console.WriteLine(name,description);
            //     data.Add((name, description));
            data.Add(new ScrappedData("Zeeshan","This is a boy"));
            foreach(var d in data){
                Console.WriteLine("Data");
                Console.WriteLine(d.Name);
                Console.WriteLine(d.Description);
            }
            // }

            return data;
        }
}


public  class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }

    public static CustomException NotFound(string resourceName)
    {
        return new CustomException($"Resource '{resourceName}' not found.");
    }

    public static CustomException AlreadyExists(string resourceName)
    {
        return new CustomException($"Resource '{resourceName}' already exists.");
    }

    public static CustomException BadRequest(string errorMessage)
    {
        return new CustomException($"Bad request: {errorMessage}");
    }

    public static CustomException Conflict(string resourceName)
    {
        return new CustomException($"Conflict occurred for resource '{resourceName}'.");
    }

}