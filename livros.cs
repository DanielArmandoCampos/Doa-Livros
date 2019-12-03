using System;
using System.Collections.Generic;
using System.IO;

namespace LendoTxtArmazenandoList
{
class livros : Cliente{

public static int cont=0;
  public  static void doarLivros(){
    
   
          string[] array = File.ReadAllLines("usuarios.txt");
 
          //percorro o array e para cada linha
          for (int i = 0; i < array.Length; i++)
          {
           //crio um objeto do tipo Cliente
            Cliente cc = new Cliente();

            string[] auxiliar = array[i].Split('|');
          
            cc.Nome = auxiliar[0];
            cc.Telefone = Convert.ToInt32(auxiliar[1]);
            cc.Localidade = auxiliar[2];
            cc.Titulo = auxiliar[3];
            cc.Edicao = Convert.ToInt32(auxiliar[4]);
            cc.Contador = Convert.ToInt32(auxiliar[5]);

            cont = cc.Contador+1;

           } // fim ler contador

      //Console.WriteLine("deseja buscar pelo id");
       //      buscaid = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine(cont);/////////checagem ok


        
          dataUser CadUser = new dataUser("nome", "telefone","localidade","titulo","edicao" , "conta");
          StreamWriter DataSet;

          DataSet = File.AppendText("usuarios.txt");

          

          //string ccontador = Convert.ToString(cont);

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
          ///////////////////////int ccontador = cont++;


          CadUser.CadastroLivro = nnome  + " | " + ttelefone + " | " + llocalidade + " | " + ttitulo  + " | " + eedicao + " | " + ccontador;
            
          DataSet.WriteLine(CadUser.CadastroLivro);//grava os dados digitados
          Console.WriteLine("Obrigado por Doar! ");
          DataSet.Close();

  }

}}