namespace Demo.RedefinirTamanhoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(874, 5678392));
            lista.Adicionar(new ContaCorrente(874, 3218392));
            lista.Adicionar(new ContaCorrente(874, 5672312));
            lista.Adicionar(new ContaCorrente(874, 5612312));
            lista.Adicionar(new ContaCorrente(874, 5671412));
            lista.Adicionar(new ContaCorrente(874, 5152312));
            lista.Adicionar(new ContaCorrente(874, 5972312));
            lista.Adicionar(new ContaCorrente(874, 5679312));
            lista.Adicionar(new ContaCorrente(874, 5672319));
        }
    }
}
