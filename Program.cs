using System;
using System.Collections.Generic;

namespace DigitalLocalizaFinal
{
    class Program
    {
      static List<Conta> listContas = new List<Conta>();
         
        static void Main(string[] args)
        {
         string opcaoUsario=ObterOpcaoUsuario();

       while(opcaoUsario.ToUpper() != "X"){
          switch(opcaoUsario){
            
        case "1":
                ListarContas();
            break;
        case "2": 
                 InserirConta();
            break;
        case "3":
                 Transferir();
            break;
        case "4":
                Sacar();
            break;
        case "5":
                Depositar(); 
            break;
        case "C":
                 Console.Clear();
            break;

            default:
                 throw new ArgumentOutOfRangeException();                
          }
          opcaoUsario= ObterOpcaoUsuario();
       }

    Console.WriteLine("Obrigada por utilizar nossos serviços.");
    Console.ReadLine(); 
        }

     private static void Sacar(){
      Console.Write("Digite o número da conta:");
      int indiceConta = int.Parse(Console.ReadLine());
         
      Console.Write("Digite o valor a ser sacado:");
      double valorSaque = double.Parse(Console.ReadLine());

      listContas[indiceConta].Scar(valorSaque);
     }

 private static void Depositar(){

        Console.Write("Digite o número da conta:");
        int indiceConta = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor a ser depositado:");
        double valorDeposito = double.Parse(Console.ReadLine());
    
        listContas[indiceConta].Depositar(valorDeposito);
 }

 private static void Transferir(){

     Console.Write("Digite o número da conta de origem");
     int indiceContaOrigem = int.Parse(Console.ReadLine());

     Console.Write("Digite o número da conta de destino:");
     int indiceContaDestino = int.Parse(Console.ReadLine());

     Console.Write("Digite o valor a ser transferido:");
     double valorTransferencia = double.Parse(Console.ReadLine());

     listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);

 }





      private static void InserirConta(){

          Console.WriteLine("Inserir Nova Conta.");

          Console.WriteLine("Digite 1 para conta física ou 2 para Juridica e 3 para autônomo"); 
          int entradaTipoConta = int.Parse(Console.ReadLine());
        
          Console.WriteLine("Digitar o nome do Cliente.");
           string entradaNome = Console.ReadLine();  
 
          Console.WriteLine("Digite o saldo inicial:");
          double entradaSaldo = double.Parse(Console.ReadLine());
     
          Console.Write("Digite o crédito:");
          double entradaCredito = double.Parse(Console.ReadLine());

         Conta novaConta = new Conta((TipoConta)entradaTipoConta,
         saldo:entradaSaldo,
         credito: entradaCredito,
         nome: entradaNome);

         listContas.Add(novaConta);
      }

      private static void ListarContas(){
        Console.WriteLine("Listar Contas.");

         if(listContas.Count == 0){
            Console.WriteLine("Nenhuma Conta cadastrada.");
            return;
         }
        for(int i=0; i<listContas.Count;i++){
       
         Conta conta = listContas[i];
         Console.Write("#{0}",i);
         Console.WriteLine(conta);
        }
      }

     private static string ObterOpcaoUsuario(){
         Console.WriteLine();
         Console.WriteLine("BANCO DA MARIANA AO SEU DISPOR.");
         Console.WriteLine("Informe a opção desejada:");

         Console.WriteLine("1-Listar Contas.");
         Console.WriteLine("2-Inserir nova conta.");
         Console.WriteLine("3-Transferir."); 
         Console.WriteLine("4-Sacar");
         Console.WriteLine("C-Limpar a Tela.");
         Console.WriteLine("X-Sair"); 
         Console.WriteLine();

         string opcaoUsario = Console.ReadLine().ToUpper();
         Console.WriteLine();
         return opcaoUsario;
        }
    }
}
