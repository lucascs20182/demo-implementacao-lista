namespace Demo.RedefinirTamanhoArray
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(T item)
        {
            // se verificado que a _proximaPosicao for a última do array
            // "Redefine" a capacidade
            VerificarCapacidade(_proximaPosicao + 1);

            // Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item);
            }
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

        private T[] CopiaArray(int novoTamanho)
        {
            // Console.WriteLine("Aumentando capacidade da lista!");

            T[] novoArray = new T[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                // Console.WriteLine("."); // ilustra número de iterações
            }

            return novoArray;
        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];
                
                #pragma warning disable CS8602
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
        }

        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
