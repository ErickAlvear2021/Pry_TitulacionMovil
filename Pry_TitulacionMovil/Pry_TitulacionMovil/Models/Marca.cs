namespace Pry_TitulacionMovil.Models
{
    using SQLite;
    public class Marca
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string CodigoParametro { get; set; }
        public string NombreParametro { get; set; }
    }
}
