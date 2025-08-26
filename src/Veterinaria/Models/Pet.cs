namespace Veterinaria.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Especie { get; set; } = string.Empty; // perro, gato, etc.
        public int Edad { get; set; } // en años
        public string Propietario { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Observaciones { get; set; } = string.Empty;
    }
}
