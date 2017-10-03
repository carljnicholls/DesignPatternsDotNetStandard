using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeExample.Implementation
{
    public class CsvStringSerializationPreparer : IStringSerializationPreparer
    {
        public string PrepareToSerializeObject(IEnumerable<IEnumerable<KeyValuePair<string, string>>> values)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(ListToCsvArrayString(values.ToList()));

            return stringBuilder.ToString();
        }

        private string ListToCsvArrayString(List<IEnumerable<KeyValuePair<string, string>>> json)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < json.Count; i++)
            {
                if (i == 0)
                    stringBuilder.Append(ListToCsvCollumsString(json[i]));

                if (i != json.Count - 1)
                    stringBuilder.Append(ListToCsvContentString(json[i]));
                else
                    stringBuilder.Append(ListToCsvContentString(json[i]));
            }

            return stringBuilder.ToString().Substring(0,stringBuilder.Length - 2);
        }

        private string ListToCsvCollumsString(IEnumerable<KeyValuePair<string, string>> jsonObject)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var valuesList = jsonObject.ToList();

            for (int j = 0; j < valuesList.Count; j++)
            {
                if (j != valuesList.Count - 1)
                    stringBuilder.Append(KeyValueToCsvRowString(valuesList[j], true))
                        .Append(",");
                else
                    stringBuilder.Append(KeyValueToCsvRowString(valuesList[j], true))
                        .Append("\r\n");
            }

            return stringBuilder.ToString();
        }

        private string ListToCsvContentString(IEnumerable<KeyValuePair<string, string>> jsonObject)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var valuesList = jsonObject.ToList();

            for (int j = 0; j < valuesList.Count; j++)
            {
                if (j != valuesList.Count - 1)
                    stringBuilder.Append(KeyValueToCsvRowString(valuesList[j]))
                        .Append(",");
                else
                    stringBuilder.Append(KeyValueToCsvRowString(valuesList[j]))
                        .Append("\r\n");
            }

            return stringBuilder.ToString();
        }

        private string KeyValueToCsvRowString(KeyValuePair<string, string> item, bool collumsOnly = false)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (collumsOnly)
                stringBuilder.Append(item.Key);
            else
                stringBuilder.Append(item.Value);

            return stringBuilder.ToString();
        }
    }
}