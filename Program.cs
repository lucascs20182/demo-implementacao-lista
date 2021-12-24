using Demo.Modelos;

namespace Demo.RedefinirTamanhoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(2, 3, 4);
        }
    }
}
