using System.Text;

namespace Spoleto.BookApi.Client
{
    public static class DefaultSettings
    {
        public const string ContentType = Spoleto.Common.ContentTypes.ApplicationJson;
        public const string Charset = "utf-8";
        public static readonly Encoding Encoding = Encoding.GetEncoding(Charset);
    }
}
