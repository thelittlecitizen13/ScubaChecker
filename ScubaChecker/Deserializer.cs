using MamasChecker.Abstract;
using System.IO;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class Deserializer<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            XmlSerializer ser = new XmlSerializer(typeof(T[]));
            T[] newTs = (T[])ser.Deserialize(stream);
            return newTs;
        }
    }
}