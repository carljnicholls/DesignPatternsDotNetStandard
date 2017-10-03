using BridgeExample.Implementation;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeExample
{
    public class JsonStringSerializationPreparer : IStringSerializationPreparer
    {
        public string PrepareToSerializeObject(IEnumerable<IEnumerable<KeyValuePair<string, string>>> values)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(ListToJsonArrayString(values.ToList()));

            return stringBuilder.ToString(); 
        }

        private string ListToJsonArrayString(List<IEnumerable<KeyValuePair<string, string>>> json)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < json.Count; i++)
            {
                if (i != json.Count - 1)
                    stringBuilder.Append(ListToJsonObjectString(json[i]))
                        .Append("}, ");
                else
                    stringBuilder.Append(ListToJsonObjectString(json[i]))
                        .Append("};");
            }

            return stringBuilder.ToString(); 
        }

        private string ListToJsonObjectString(IEnumerable<KeyValuePair<string, string>> jsonObject)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var valuesList = jsonObject.ToList();
            stringBuilder.Append("{");

            for (int j = 0; j < valuesList.Count; j++)
            {
                if (j != valuesList.Count - 1)
                    stringBuilder.Append(KeyValueToJsonString(valuesList[j]))
                        .Append(", ");
                else
                    stringBuilder.Append(KeyValueToJsonString(valuesList[j]));
            }

            return stringBuilder.ToString();
        }

        private string KeyValueToJsonString(KeyValuePair<string, string> item)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\"")
                    .Append(item.Key)
                    .Append("\" : \"")
                    .Append(item.Value)
                    .Append("\" ");

            return stringBuilder.ToString(); 
        }
    }
}
