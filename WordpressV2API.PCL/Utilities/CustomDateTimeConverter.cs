using Newtonsoft.Json.Converters;

namespace WordpressV2API.PCL.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}