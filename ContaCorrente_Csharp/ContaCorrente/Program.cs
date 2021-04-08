using System;

namespace ContaCorrente
{
    class Program
    {
        /*Escreva uma classe que represente uma conta corrente. 

        Atributos

        - titular: string    //esse '-' significa que é atributo privado; consequentemente o '+' é público 
        - saldo: float
        - numero: int

        Métodos

        + getters/setters para os atributos titular e número,validando cada um deles;
        + getSaldo para o atributo saldo, mas não implemente o setSaldo;
        + depositar – Recebe um valor em Reais e soma ao saldo da conta. Não permitindo valores negativos;
        + retirar – Recebe um valor em Reais e subtrai do saldo da conta Não permitindo valores negativos.

        Construtores

         1) Construtor que recebe nome e número da conta;
         2) Construtor que recebe nome, número da conta e saldo;
        
        Atenção: 

         1) Crie objetos da classe desenvolvida e demonstre suas funcionalidades. Utilize o Main da classe principal para isso. 
         2) Lembre-se de utilizar os modificadores de acesso para esconder os atributos da classe.*/
        static void Main(string[] args)
        {
            string nome;
            int numero;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o número da sua conta: ");
            numero = int.Parse(Console.ReadLine());
            ContaCorrente c1 = new ContaCorrente(nome,numero);
            Console.WriteLine("Nome: {0}\nNúmero: {1}\nSaldo:{2}",c1.getTitular(),c1.getNumero(),c1.getSaldo());
            c1.depositar(50);
            Console.WriteLine("Nome: {0}\nNúmero: {1}\nSaldo:{2}",c1.getTitular(),c1.getNumero(),c1.getSaldo());
            c1.retirar(30);
            Console.WriteLine("Nome: {0}\nNúmero: {1}\nSaldo:{2}",c1.getTitular(),c1.getNumero(),c1.getSaldo());

            /*
            ContaCorrente c1 = new ContaCorrente("Joca",99);
            c1.depositar(20);
            c1.retirar(10);
            Console.WriteLine("Nome: {0}\nNúmero: {1}\nSaldo: {2}",c1.getTitular(),c1.getNumero(),c1.getSaldo());
            */
            /*
            ContaCorrente c1 = new ContaCorrente("Jotape",100,30);
            Console.WriteLine("Nome: {0}\nNúmero: {1}\nSaldo: {2}",c1.getTitular(),c1.getNumero(),c1.getSaldo());
            c1.depositar(70);
            c1.retirar(10);
            Console.WriteLine("Nome: {0}\nNúmero: {1}\nSaldo: {2}",c1.getTitular(),c1.getNumero(),c1.getSaldo());
            */
        }
    }
}
