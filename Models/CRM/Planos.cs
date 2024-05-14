namespace APITechCoffee.Models.CRM
{
    public class Planos
    {
        public int id { get; set; }
        public int id_user_cadastro { get; set; }
        public DateTime data_cadastro { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public float preco { get; set; }
        public string status { get; set; }


    }
}
