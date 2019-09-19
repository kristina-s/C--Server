using System;
using System.Collections.Generic;
using System.Text;

namespace ServerInterfaces
{
    public class QueryCollection
    {
        private readonly Dictionary<string, string> data = new Dictionary<string, string>();

        public QueryCollection(Dictionary<string, string> initialData)
        {
            data = initialData;
        }

        public static QueryCollection Empty
        {
            get
            {
                return new QueryCollection(new Dictionary<string, string>());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in data)
            {
                sb.AppendLine($"{kvp.Key} = {kvp.Value}");
            }
            return sb.ToString();
        }
    }
}
