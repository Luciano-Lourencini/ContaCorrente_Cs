using System;
namespace ContaCorrente
{
    public class ContaCorrente
    {
        //atributos
        private string titular;
        private int numero;
        private float saldo;
        //metodos construtores
        public ContaCorrente(string t,int n)
        {
            setTitular(t);
            setNumero(n);
        }
        public ContaCorrente(string tit,int num,float sal)
        {
            setTitular(tit);
            setNumero(num);
            depositar(sal);
        }
        //métodos
        public string getTitular()
        {
            return this.titular;
        }
        public int getNumero()
        {
            return this.numero;
        }
        public float getSaldo()
        {
            return this.saldo;
        }
        public void setTitular(string titular)
        {
            if(titular==null||titular.Trim().Length==0)
                throw new Exception("NOME INVÁLIDO");
            this.titular = titular;
        }
        public void setNumero(int numero)
        {
            if(numero<0)
                throw new Exception("NÚMERO INVÁLIDO");
            this.numero = numero;
        }
        public void depositar(float deposito)
        {
            if(deposito<0)
                throw new Exception("IMPOSSÍVEL DEPOSITAR VALOR NEGATIVO");
            this.saldo = this.saldo + deposito;
        }
        public void retirar(float tirar)
        {
            if(tirar<0)
                throw new Exception("IMPOSSÍVEL RETIRAR VALOR NEGATIVO");
            this.saldo = this.saldo - tirar;
        }
    }
}