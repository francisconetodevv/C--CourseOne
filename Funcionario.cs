namespace RH
{
    public class Funcionario
    {
        private string nome;
        // Atributo - privado
        private string cpf; 
        // Propriedade - publico
        public string CPF
        {
            // Processamento de dado
            get{ return cpf.Replace(".", "").Replace("-", ""); }
            
            // Setar o valor
            set
            {
                if (value.Length == 0)
                {
                    return;
                }
                cpf = value;
            }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }  
        }

        // Construct
        public Funcionario(string nome, string _cpf)
        {
            Nome = nome;
            cpf = _cpf;
        }

    }
}