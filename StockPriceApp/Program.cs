using StockPriceApp;

//----------------- For MSFT -----------------//
string URL_1 = "https://ps-async.fekberg.com/api/stocks/MSFT";
var data_1 = await ControllerAPI.GetData(URL_1);
if (data_1.Any())
{
    decimal max = data_1.Max(item => item.Change);
    Console.WriteLine("MSFT Max change is: " + max);
}

//----------------- For Googl -----------------//
string URL_2 = "https://ps-async.fekberg.com/api/stocks/Googl";
var data_2 = await ControllerAPI.GetData(URL_2);
if (data_2.Any())
{
    decimal min = data_2.Min(item => item.ChangePercent);
    Console.WriteLine("Googl Min changePercent is: " + min);
}

//----------------- For Voya -----------------//
string URL_3 = "https://ps-async.fekberg.com/api/stocks/Voya";
var data_3 = await ControllerAPI.GetData(URL_3);
if (data_3.Any())
{
    double average = data_3.Average(item => item.Volume);
    Console.WriteLine("Voya average volume is: " + Math.Round(average, 2));
}

//----------------- For Hbi -----------------//
string URL_4 = "https://ps-async.fekberg.com/api/stocks/Hbi";
var data_4 = await ControllerAPI.GetData(URL_4);
if (data_4.Any())
{
    int count = 0;
    foreach (var item in data_4)
    {
        if (item != null)
        {
            count++;
        }
    }
    Console.WriteLine("Hbi number of records is: " + count);
}

//----------------- For Foxf -----------------//
string URL_5 = "https://ps-async.fekberg.com/api/stocks/Foxf";
var data_5 = await ControllerAPI.GetData(URL_5);
if (data_5.Any())
{
    decimal min = data_5.Min(item => item.Change);
    Console.WriteLine("Foxf Min change is: " + min);
}
