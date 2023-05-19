using System.Runtime.Serialization;

namespace Vista
{
    [Serializable]
    public class SinEquiposCargadosException : Exception
    {
        public SinEquiposCargadosException()
        {
        }

        public SinEquiposCargadosException(string? message) : base(message)
        {
        }

        public SinEquiposCargadosException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SinEquiposCargadosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}