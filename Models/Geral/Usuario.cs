namespace APITechCoffee.Models.Geral
{
    public class Usuario
    {
        public int id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string tipo { get; set; }
        public string email { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }


    }
}
