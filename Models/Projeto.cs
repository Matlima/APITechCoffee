namespace APITechCoffee.Models
{
    public class Projeto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime prazo { get; set; }
        public double valor { get; set; }
        public int id_responsavel { get; set; }
        public string status { get; set; }


    }
}
