using Newtonsoft.Json;

namespace StockPriceApp;
public static class ControllerAPI
{
    public async static Task<IEnumerable<StockPrice>> GetData(string URL)
    {
        IEnumerable<StockPrice> data = null!;
        using (HttpClient client = new HttpClient())
        {
            try
            {
                var response = await client.GetAsync(URL);
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<IEnumerable<StockPrice>>(content)!;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        return data;
    }
}

