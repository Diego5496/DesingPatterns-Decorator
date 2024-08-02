namespace Cafetaria1
{
    public class Espresso : ICafe
    {
        public string Descricao()
        {
            return "Café Espresso";
        }

        public decimal Preco()
        {
            return 5.00M;
        }
    }
}
