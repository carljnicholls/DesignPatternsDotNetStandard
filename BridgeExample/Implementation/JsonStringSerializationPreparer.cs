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
            var jsonObjects = values.ToList();
            for (int i = 0; i < jsonObjects.Count; i++)
            {
                if(i != jsonObjects.Count -1)
                    stringBuilder.Append(ListToJsonArrayString(jsonObjects[i]))
                        .Append("}, "); 
                else
                    stringBuilder.Append(ListToJsonArrayString(jsonObjects[i]))
                        .Append("};");
            }

            return stringBuilder.ToString(); 
        }

        private string ListToJsonArrayString(IEnumerable<KeyValuePair<string, string>> jsonObject)
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
