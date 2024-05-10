namespace APITechCoffee.Models
{
    public class Atividade
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string tipo { get; set; }
        public DateTime data_criacao { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }


    }
}
