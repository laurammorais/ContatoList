namespace ConsoleApp12
{
    public class Telefone
    {
        public Telefone(string tipo, string ddd, string numero)
        {
            Tipo = tipo;
            DDD = ddd;
            Numero = numero;
        }

        public string Tipo { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return $"tipo: {Tipo}\nDDD: {DDD}\nnumero: {Numero}";
        }

    }
}