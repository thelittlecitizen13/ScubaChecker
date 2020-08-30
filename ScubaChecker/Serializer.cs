using System;
using System.Collections.Generic;
using MamasChecker.Abstract;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace ScubaChecker
{
    public class Serializer<T> : ISerializer<T>
    {
        public Stream Serialize(T[] testsToSerialize)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T[]));
            
            MemoryStream stream = new MemoryStream();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stream, Encoding.UTF8);
            ser.Serialize(stream, testsToSerialize);
            return stream;
        }
    }
}