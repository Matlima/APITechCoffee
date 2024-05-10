namespace APITechCoffee.Models
{
    public class Servico
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public int id_criador { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public bool ativo { get; set; }

    }
}
