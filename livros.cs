using System;
using System.Collections.Generic;
using System.IO;

namespace LendoTxtArmazenandoList
{
  class livros : Cliente{

    public  static void doarLivros(){
      acessarRegistros();
      Contadorr();
          
      dataUser CadUser = new dataUser("nome", "telefone","localidade","titulo","edicao" , "conta");
      StreamWriter DataSet;

      DataSet = File.AppendText("usuarios.txt");
          
      
      Console.WriteLine("Digite seu Nome: \n");
      string nnome = Console.ReadLine().ToUpper();
      int checkTel = 0;
      Console.WriteLine("Telefone para contato: \n");
      try
      {
        checkTel = int.Parse(Console.ReadLine());   
      }
      catch (FormatException e)
      {
        Console.WriteLine("Os campos devem ser preenchidos apenas por NUMEROS!");
      }
      catch (OverflowException e)
      {
        Console.WriteLine("Numero Errado, Digite apenas os numeros do telefone");
      }
           
      string ttelefone = Convert.ToString(checkTel).ToUpper();

      Console.WriteLine("Digite sua localidade: \n");
      string llocalidade = Console.ReadLine().ToUpper();

      Console.WriteLine("Digite o Nome do Livro que deseja Doar: \n");
      string ttitulo = Console.ReadLine().ToUpper();
              
      Console.WriteLine("Qual a Edição do livro: \n");
      string eedicao = Console.ReadLine().ToUpper();

      string ccontador = Convert.ToString(cont);
            
      CadUser.CadastroLivro = nnome  + " | " + ttelefone + " | " + llocalidade + " | " + ttitulo  + " | " + eedicao + " | " + ccontador;
              
      DataSet.WriteLine(CadUser.CadastroLivro);//grava os dados digitados
      Console.WriteLine("Obrigado por Doar! ");
      DataSet.Close();

    }
  }
}