using Demo.Modelos;

namespace Demo.RedefinirTamanhoArray
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            // se verificado que a _proximaPosicao for a última do array
            // "Redefine" a capacidade
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            
            // se alguém chamar o método pedindo um tamanho maior que o dobro
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            _itens = CopiaArray(novoTamanho);
        }

        private ContaCorrente[] CopiaArray(int novoTamanho)
        {
            Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                // Console.WriteLine("."); // ilustra número de iterações
            }

            return novoArray;
        }
    }
}
