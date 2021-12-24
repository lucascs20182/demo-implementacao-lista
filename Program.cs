using Demo.Modelos;

namespace Demo.RedefinirTamanhoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaParaRemover = new ContaCorrente(111, 1111111);
            
            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaParaRemover,
                new ContaCorrente(874, 5758492),
                new ContaCorrente(847, 2738271)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(new ContaCorrente(874, 2112758492), new ContaCorrente(874, 1231328492));
            lista.AdicionarVarios(new ContaCorrente(874, 1215148492));
            lista.AdicionarVarios(new ContaCorrente[]{new ContaCorrente(874, 32148492)});

            lista.Adicionar(new ContaCorrente(874, 5678392));
            lista.Adicionar(new ContaCorrente(874, 3218392));
            lista.Adicionar(new ContaCorrente(874, 5672312));
            lista.Adicionar(new ContaCorrente(874, 5679312));
            lista.Adicionar(new ContaCorrente(874, 5992312));
            lista.Adicionar(new ContaCorrente(874, 5672992));
            lista.Adicionar(new ContaCorrente(874, 5111312));
            lista.Adicionar(new ContaCorrente(874, 5672212));
            lista.Adicionar(new ContaCorrente(874, 5676662));
            lista.Adicionar(new ContaCorrente(874, 5688882));
            lista.Adicionar(new ContaCorrente(874, 5682312));
            lista.Adicionar(new ContaCorrente(874, 5672777));
            lista.Adicionar(new ContaCorrente(874, 5772312));
            lista.Adicionar(new ContaCorrente(874, 7772312));
            lista.Adicionar(new ContaCorrente(874, 5772312));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];

                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero} / {itemAtual.Agencia}");
            }
        }
    }
}
