namespace Cafetaria1
{
    public class ChocolateDecorator : OpcionalDecorator
    {
        public ChocolateDecorator(ICafe cafe) : base(cafe)
        {
            _opcional = " mais generosa porcão de Chocolate";
            _preco = 3.00M;
        }
    }
}
