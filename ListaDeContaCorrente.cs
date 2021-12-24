namespace Demo.RedefinirTamanhoArray
{
    /*
        Esta é uma implementação de lista que custa bastante processamento
        na medida em que toda vez que uma nova posição precisar ser adicionada ao array,
        será necessário percorrer todo o tamanho do array

        Ou seja, para adicionar +1 item numa lista de 1000 itens
        será necessário percorrer os 1000 itens.
        Para adicionar +1 será necessário percorrer 1001 itens.
    */
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        // ctor: codesnippet para gerar construtores automaticamente
        public ListaDeContaCorrente()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0; // já é por default mas para explicitar...
        }

        public void Adicionar(ContaCorrente item)
        {
            // se verificado que a _proximaPosicao for a última do array
            // "Redefine" a capacidade
            VerificarCapacidade(_proximaPosicao + 1);
            
            _itens[_proximaPosicao] = item;

            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            _itens = CopiaArray(tamanhoNecessario);
        }

        private ContaCorrente[] CopiaArray(int tamanhoNecessario)
        {
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }

            return novoArray;
        }
    }
}
