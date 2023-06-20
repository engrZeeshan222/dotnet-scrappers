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
            var urls = ScrapUrls(html);
        }

        // get html
        private static async Task<string> GetHtml()
        {
        try{
            var client = new HttpClient();
            var domReponse =  await client.GetStringAsync("https://www.junaidjamshed.com/online-edition/woman/stitched-collection.html");
            
            
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


        private static List<ScrappedData> ScrapUrls(string html)
        {
            try
            {var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var scrappedProducts =
                htmlDoc
                    .DocumentNode
                    .SelectNodes("//a[@class='product-item-link']");


            List<ScrappedData> finalProductsList = new List<ScrappedData>();
            var internalProductArray = new object[]{
                new object(),
                new object(),
                new object()
            };
           
            foreach (var product  in scrappedProducts)
            {
                string url = product.GetAttributeValue("href", "");
                url = url.Length > 0 ? url.Trim() : "";
                
                if(url != null){
                    
                    // Practise Array Also here 
                    for(int i=0; i<internalProductArray.Length; i++){
                        Console.WriteLine(internalProductArray[i]);
                    }
                }
                Console.WriteLine(url);
            }


        return finalProductsList;
        }catch(Exception e){
            Console.WriteLine(new {
                status = false,
                message = e.Message,
                stackTrace = e.StackTrace,
                source = e.Source
            });
        }
        return null;
        }

        // private static List<object> ScrapProductDescription(Array urls){
        //     try{
            // Practise List Here

        //         return new List<object>();
        //     }catch(Exception e){
        //     var exceptionData = new
        //             {
        //                 Message = e.Message,
        //                 StackTrace = e.StackTrace,
        //                 Source = e.Source,
        //                 GetType = e.GetType().ToString(),
        //                 ToString = e.ToString()
        //             };
                
                                        
        //     }

        // }
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