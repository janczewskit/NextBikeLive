using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace NextBikeLive.Extensions
{
    static class NextBikeDaoExtensions
    {
        public static TModel Deserialize<TModel>(this NextBikeDao nextBikeDao, string data)
        {
            return JsonConvert.DeserializeObject<TModel>(data);
        }

        public static IEnumerable<TModel> GetByPath<TModel>(this NextBikeDao nextBikeDao, string data, string path)
        {
            foreach (JToken token in JObject.Parse(data).SelectTokens(path))
                yield return token.ToObject<TModel>();
        }
    }
}
