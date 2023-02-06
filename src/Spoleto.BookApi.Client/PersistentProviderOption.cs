namespace Spoleto.BookApi.Client
{
    public class PersistentProviderOption
    {
        ////todo: move option data to db like settings?
        //public static readonly Integration1COption ProductionOption =
        //    new()
        //    {
        //        ServiceUrl = "http://server-iis02:8865/",
        //    };

        //public static readonly Integration1COption DemoOption =
        //    new()
        //    {
        //        ServiceUrl = "http://localhost:47923/"
        //    };

        public string ServiceUrl { get; set; }
    }
}
