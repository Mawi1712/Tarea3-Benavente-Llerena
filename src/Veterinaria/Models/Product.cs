namespace Veterinaria.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty; // alimento, higiene, etc.
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
