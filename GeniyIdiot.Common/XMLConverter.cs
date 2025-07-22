using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeniyIdiot.Common
{
    public class XMLConverter : IConvert
    {
        public string Serialize<T>(T item)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, item);
                return textWriter.ToString();
            }
        }
        public T Deserialize<T>(string data)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using(var textReader = new StringReader(data))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }

    }
}
