using Demo.Modelos;

namespace Demo.RedefinirTamanhoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente(20);

            ContaCorrente contaParaRemover = new ContaCorrente(111, 1111111);
            lista.Adicionar(contaParaRemover);

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

            lista.EscreverListaNaTela();
            lista.Remover(contaParaRemover);
            Console.WriteLine("Após remover o item");
            lista.EscreverListaNaTela();
        }
    }
}
