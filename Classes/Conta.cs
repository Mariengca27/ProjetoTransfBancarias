using System;

namespace DigitalLocalizaFinal
{
    public class Conta
    {
        public string Nome{get;set;}

        public double Saldo{get;set;}

        private double Credito{get;set;}

        private TipoConta TipoConta{get;set;}

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
          {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito=credito;
            this.Nome=nome;
          }

          public bool Scar(double valorSaque){
           //Validação do saldo suficiente:

           if(this.Saldo - valorSaque <(this.Credito *-1)){
            Console.WriteLine("Saldo Insuficiente.");
            return false;

           }

           this.Saldo-=valorSaque;     //this.Saldo = this.Saldo - valorSaque;
           Console.WriteLine("Saldo atual da sua conta é {0} e {1}",this.Nome, this.Saldo);
           return true;    
       }

         public void Depositar(double valorDeposito){

         this.Saldo+=valorDeposito;   //this.Saldo = this.Saldo + valorDeposito;

         Console.WriteLine("Saldo atual é {0} e {1}",this.Nome,this.Saldo);
         }
         public void Transferir(double valorTransferencia, Conta contaDestino){

         if(this.Scar(valorTransferencia)){
           contaDestino.Depositar(valorTransferencia);
             }
        }

        public override string ToString()
        {
           string retorno = "";
           retorno+="TipoConta" + this.TipoConta + "|";
           retorno+="Nome" + this.Nome + "|";
           retorno+="Saldo" + this.Saldo + "|";
           retorno+="Crédito" + this.Credito; 
           return retorno;
        }     

    }
}