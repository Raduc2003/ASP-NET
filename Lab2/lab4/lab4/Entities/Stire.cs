namespace lab4.Entities
{
    public class Stire
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Lead { get; set; }

        public string Continut { get; set; }
        public string Autor { get; set; }
        public int CategorieFK { get; set; }
        public Categorie? Categorie { get; set; }

    }
}
