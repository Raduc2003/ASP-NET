namespace lab4.Entities
{
    public class StireDto
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Lead { get; set; }

        public string Continut { get; set; }
        public string Autor { get; set; }
        public int CategorieFK { get; set; }
    }

}
