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
          
      try {

        Console.WriteLine("Digite seu Nome: \n");
        string nnome = Console.ReadLine().ToUpper();
      
        Console.WriteLine("Telefone para contato: \n");
        string ttelefone = Console.ReadLine().ToUpper();

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
      catch (FormatException e) {
        Console.WriteLine(e.Message);
      } 
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }         
  }
}