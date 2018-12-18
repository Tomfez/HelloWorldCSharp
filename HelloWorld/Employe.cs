using System;
using System.Runtime.Serialization;

namespace HelloWorld
{
    public class Employe : User, ISerializable, IDisposable
    {

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
