using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace FP.Spartakiade2016.ProcessChain.Processes
{
    public static class JsonHelper
    {
        private static ConcurrentDictionary<string, JSchema> schemas = new ConcurrentDictionary<string, JSchema>();

        public static bool IsValid<T>(string json) where T : class
        {
            var schema = schemas.GetOrAdd(typeof(T).FullName, s =>
            {
                var generator = new JSchemaGenerator();
                JSchema createSchema = generator.Generate(typeof(T));
                var ps = createSchema.Properties.ToArray();
                createSchema.Properties.Clear();
                foreach (KeyValuePair<string, JSchema> p in ps)
                {
                    createSchema.Properties.Add(p.Key.ToLowerInvariant(), p.Value);
                }
                return createSchema;
            });
            return JObject.Parse(json).IsValid(schema);
        }
    }
}
