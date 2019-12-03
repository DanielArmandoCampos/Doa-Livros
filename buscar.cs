using System;
using System.Collections.Generic;
using System.IO;
namespace LendoTxtArmazenandoList
{
class buscar : Cliente{


  public static string buscaid;// para buscar pelo titulo
  public static string contid;//contador p busca pelo id
  public static int cont=0;
            
    public  static void contador(){
      //para ler o contador

      string[] array = File.ReadAllLines("usuarios.txt");
 
      //percorro o array e para cada linha
      for (int i = 0; i < array.Length; i++)
      {
        //crio um objeto do tipo Cliente
        buscar cc = new buscar();

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

    }
    public  static void buscarTitulo(){

    
      List<Cliente> lista = new List<Cliente>();
      Console.WriteLine("Digite o titulo do livro que deseja procurar: \n");
      buscaid = Console.ReadLine().ToUpper();

      //Retorna todas as linhas do arquivo em um array e string, onde cada linha será um índice do array
      string[] array = System.IO.File.ReadAllLines("usuarios.txt");
 
      //percorro o array e para cada linha
      for (int i = 0; i < array.Length; i++)
      {
       //crio um objeto do tipo Cliente
        buscar c = new buscar();

        //Uso o método Split e quebro cada linha em um novo array auxiliar, ou seja, cada conteúdo do arquivo txt separado por '|' será um nova linha neste array auxiliar. Assim sei que cada índice representa uma propriedade
        string[] auxiliar = array[i].Split('|');

        //Aqui recupero os itens, atribuindo aos mesmos as propriedade da classe Cliente correspondentes, ou seja, o índice zero será corresponde ao telefone o um ao nome e o dois ao titulo do livro
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
        //Console.WriteLine(cont);/////////////////

        if (auxiliar[5].Contains(contid)) // Aqui eu checo se na célula[x] têm a string que é procurada.
        {

          Console.WriteLine("Nome do Doador: {0}; Telefone: {1}; Localidade: {2}; Titulo: {3}; Edição: {4};", ccc.Nome, ccc.Telefone, ccc.Localidade, ccc.Titulo, ccc.Edicao);
          Console.WriteLine("");
              
          //Console.WriteLine(contid);
        }

      }
    }
  }
}