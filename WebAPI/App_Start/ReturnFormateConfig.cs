using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Channels;
using System.Web;

namespace WebAPI.App_Start
{
    public class ReturnFormateConfig : IContentNegotiator
    {
        private readonly JsonMediaTypeFormatter _jsoinFormatter;

        public ReturnFormateConfig(JsonMediaTypeFormatter formatter)
        {
            _jsoinFormatter = formatter;
        }
        public ContentNegotiationResult Negotiate(Type type, System.Net.Http.HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        {
            var result = new ContentNegotiationResult(_jsoinFormatter, new MediaTypeHeaderValue("application/json"));
            return result;
        }
    }
}