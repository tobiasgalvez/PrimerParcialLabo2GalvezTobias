using System.Runtime.Serialization;

namespace BibliotecaDeClases.Excepciones
{
    [Serializable]
    internal class StringNumeroException : Exception
    {
        public StringNumeroException()
        {
        }

        public StringNumeroException(string? message) : base(message)
        {
        }

        public StringNumeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StringNumeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}