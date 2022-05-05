using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.III
{
    public class ConvertFacade : IJsonConverter, IXmlConverter, IByteArrayConverter
    {
        private IJsonConverter jsonConverter;
        private IXmlConverter xmlConverter;
        private IByteArrayConverter byteArrayConverter;

        public ConvertFacade(IJsonConverter jsonConverter, IXmlConverter xmlConverter, IByteArrayConverter byteArrayConverter)
        {
            this.jsonConverter = jsonConverter;
            this.xmlConverter = xmlConverter;
            this.byteArrayConverter = byteArrayConverter;
        }

        public byte[] ToByteArray(object item)
        {
            return byteArrayConverter.ToByteArray(item);
        }

        public string ToJson(object item)
        {
            return jsonConverter.ToJson(item);
        }

        public string ToXml(object item)
        {
            return xmlConverter.ToXml(item);
        }
    }
}
