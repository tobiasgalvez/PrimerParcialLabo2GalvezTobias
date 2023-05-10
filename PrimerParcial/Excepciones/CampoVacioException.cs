using System.Runtime.Serialization;

namespace BibliotecaDeClases.Excepciones
{
    [Serializable]
    internal class CampoVacioException : Exception
    {
        public CampoVacioException()
        {
        }

        public CampoVacioException(string? message) : base(message)
        {
        }

        public CampoVacioException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CampoVacioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}