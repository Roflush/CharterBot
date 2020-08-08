using Newtonsoft.Json;

namespace chaterbot
{
    struct configjson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}