namespace APITechCoffee.Models.Geral
{
    public class Cliente
    {
        public int id { get; set; }
        public int id_user_created { get; set; }
        public string nome_fantasia { get; set; }
        public string razao_social { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public string inscricao_estadual { get; set; }
        public string inscricao_municipal { get; set; }
        public bool iss_retido { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public DateTime data_cadastro { get; set; }
        public string endereco { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string pais { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string ramo_atuacao { get; set; }



    }
}
