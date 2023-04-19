namespace PrimerParcial
{
    public class Producto
    {
        private string _nombre;
        private int _cantidad;
        private float _precio;

        public Producto(string nombre, int cantidad, float precio)
        {
            _nombre = nombre;
            _cantidad = cantidad;
            _precio = precio;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public float Precio { get => _precio; set => _precio = value; }
    }
}