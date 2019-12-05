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
          
          int chekNome = 0;
      Console.WriteLine("Digite seu Nome: \n");
      string nnome = Console.ReadLine().ToUpper();
      if(nnome == string.Empty){
            try
            {
                chekNome = int.Parse(Console.ReadLine());   
            }
            catch (Exception e)
            {
                throw new Exception("Os campos não podem ser vazios.");
            }
      }
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
      int chekLocal = 0;
      string llocalidade = Console.ReadLine().ToUpper();
      if(llocalidade == string.Empty){
            try
            {
                chekLocal = int.Parse(Console.ReadLine());   
            }
            catch (Exception e)
            {
                throw new Exception("Os campos não podem ser vazios.");
            }
      }

      Console.WriteLine("Digite o Nome do Livro que deseja Doar: \n");
      int chektitulo = 0;
      string ttitulo = Console.ReadLine().ToUpper();
      if(ttitulo == string.Empty){
            try
            {
                chektitulo = int.Parse(Console.ReadLine());   
            }
            catch (Exception e)
            {
                throw new Exception("Os campos não podem ser vazios.");
            }
      }
              
      int chekedicao = 0;
      Console.WriteLine("Qual a Edição do livro: \n");
      string eedicao = Console.ReadLine().ToUpper();
      if(eedicao == string.Empty){
            try
            {
                chekedicao = int.Parse(Console.ReadLine());   
            }
            catch (Exception e)
            {
                throw new Exception("Os campos não podem ser vazios.");
            }
      }

      string ccontador = Convert.ToString(cont);
            
      CadUser.CadastroLivro = nnome  + " | " + ttelefone + " | " + llocalidade + " | " + ttitulo  + " | " + eedicao + " | " + ccontador;
              
      DataSet.WriteLine(CadUser.CadastroLivro);//grava os dados digitados
      Console.WriteLine("Obrigado por Doar! ");
      DataSet.Close();

    }
  }
}