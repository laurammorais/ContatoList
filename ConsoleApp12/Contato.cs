using System.Collections.Generic;

namespace ConsoleApp12
{
    public class Contato
    {
        public Contato(string nome, string email, List<Telefone> telefones)
        {
            Nome = nome;
            Email = email;
            Telefones = telefones;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Telefone> Telefones { get; set; }

        public override string ToString()
        {
            return $"nome: {Nome}\nemail: {Email}\n";
        }
       
    }
}