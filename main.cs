using System;
using System.Collections.Generic;
using System.IO;
 
namespace LendoTxtArmazenandoList
{
  class Program
  {
        
 
    static void Main(string[] args)
    {
     //Instância da lista que será preenchida
      List<Cliente> lista = new List<Cliente>();
 
      string buscaid;// para buscar pelo titulo
      string contid;//contador p busca pelo id
      int cont=0;
            

      Console.WriteLine("deseja Doar ou buscar pelo livro? \n");
            
      Console.WriteLine("Digite :");
      Console.WriteLine("DOAR -> 1");
      Console.WriteLine("BUSCAR -> 2 \n");
      int ChecarCadastro = int.Parse(Console.ReadLine());

      //Console.WriteLine("deseja buscar pelo id");
       //      buscaid = Convert.ToInt32(Console.ReadLine());


//para ler o contador

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
Console.WriteLine(cont);/////////checagem ok


      switch(ChecarCadastro){
        case 1:
        
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
        break;

        case 2:
          Console.WriteLine("Digite o titulo do livro que deseja procurar: \n");
          buscaid = Console.ReadLine().ToUpper();

          //Retorna todas as linhas do arquivo em um array de string, onde cada linha será um índice do array
          array = File.ReadAllLines("usuarios.txt");
 
          //percorro o array e para cada linha
          for (int i = 0; i < array.Length; i++)
          {
           //crio um objeto do tipo Cliente
            Cliente c = new Cliente();

            //Uso o método Split e quebro cada linha em um novo array auxiliar, ou seja, cada conteúdo do arquivo txt separado por '|' será um nova linha neste array auxiliar. Assim sei que cada índice representa uma propriedade
            string[] auxiliar = array[i].Split('|');

            //Aqui recupero os itens, atribuindo
            //aos mesmos as propriedade da classe
            //Cliente correspondentes, ou seja,
            //o índice zero será corresponde ao telefone
            //o um ao nome e o dois ao titulo do livro
            c.Nome = auxiliar[0];
            c.Telefone = Convert.ToInt32(auxiliar[1]);
            c.Localidade = auxiliar[2];
            c.Titulo = auxiliar[3];
            c.Edicao = Convert.ToInt32(auxiliar[4]);
            c.Contador = Convert.ToInt32(auxiliar[5]);

            //Adiciono o objeto a lista
            lista.Add(c);

            cont = c.Contador;
            
            
            if (auxiliar[3].Contains(buscaid)) // Aqui eu checo se na célula[x] têm a string que é procurada.
            {

              Console.WriteLine("Titulo: {0}; Edição: {1};", c.Titulo, c.Edicao);
              Console.WriteLine("Numero do livro para maiores detalhes: {0}",cont);
              Console.WriteLine("");
              //Console.WriteLine(contid);
            }
          }
            ////////////////////////////////////
            //...............................//
            ////////////////////////////////////
            // segunda checagem pelo numero do livro para mostrar os dados detalhados

            Console.WriteLine("Digite o numero de busca do livro desejado: \n");
            contid = Console.ReadLine().ToUpper();

          //Retorna todas as linhas do arquivo em um array de string, onde cada linha será um índice do array
          array = File.ReadAllLines("usuarios.txt");
 
          //percorro o array e para cada linha
          for (int j = 0; j < array.Length; j++)
          {
           //crio um objeto do tipo Cliente
            Cliente ccc = new Cliente();

            //Uso o método Split e quebro cada linha em um novo array auxiliar, ou seja, cada conteúdo do arquivo txt separado por '|' será um nova linha neste array auxiliar. Assim sei que cada índice representa uma propriedade
            string[] auxiliar = array[j].Split('|');

            //Aqui recupero os itens, atribuindo
            //aos mesmos as propriedade da classe
            //Cliente correspondentes, ou seja,
            //o índice zero será corresponde ao telefone
            //o um ao nome e o dois ao titulo do livro
            ccc.Nome = auxiliar[0];
            ccc.Telefone = Convert.ToInt32(auxiliar[1]);
            ccc.Localidade = auxiliar[2];
            ccc.Titulo = auxiliar[3];
            ccc.Edicao = Convert.ToInt32(auxiliar[4]);
            ccc.Contador = Convert.ToInt32(auxiliar[5]);

            //Adiciono o objeto a lista
            lista.Add(ccc);

            cont = ccc.Contador;
            Console.WriteLine(cont);/////////////////

            if (auxiliar[5].Contains(contid)) // Aqui eu checo se na célula[x] têm a string que é procurada.
            {

              Console.WriteLine("Nome do Doador: {0}; Telefone: {1}; Localidade: {2}; Titulo: {3}; Edição: {4};", ccc.Nome, ccc.Telefone, ccc.Localidade, ccc.Titulo, ccc.Edicao);
              Console.WriteLine("");
              
              //Console.WriteLine(contid);
            }




                
          }
        break;
 
          //Para verificar o resultado percorro a lista
          //e exibo os valores recuparados pelo List<Cliente>
         /*   
        foreach (var item in lista)
        { 
          Console.WriteLine("Nome do Doador: {0}; Telefone: {1}; Localidade: {2}; Titulo: {3}; Edição: {4};", item.Nome, item.Telefone, item.Localidade, item.Titulo, item.Edicao);             
        }
           */ 
        Console.ReadKey();
      }
    }
  }
}