using System;
using System.Collections.Generic;
using System.IO;

//classe Cliente e suas propriedades
class Cliente //classe pai
{
  public int Telefone { get; set; }
  public string Nome { get; set; }
  public string Localidade { get; set; }
  public string Titulo {get;set;}
  public int Edicao {get;set;}
  public int Contador {get;set;}

  public static int conta=0;
  public static int cont=0;
  public static string checar;
  public static string nom;
  public static string loc;
  public static string titu;
  public static int edic;
  public static int telef;

  public static string id;
  public static string tit;
  public static bool tituu = false;
  public static bool dados = false;
  public static bool contatt = false;
  public static bool verif = false;
  
  public static void acessarRegistros(){

    int conttt=0;        
    string[] array = System.IO.File.ReadAllLines("usuarios.txt");//le as linhas do arquivo txt

    Cliente cc = new Cliente();
    List<Cliente> lista = new List<Cliente>();//crio a lista

    //percorro o array e para cada linha      
    for (int i = 0; i < array.Length; i++)
    {
      //crio um objeto do tipo auxiliar para salvar os dados em sequencia espaçados pelo | e depois ser salvo na mesma linha
      string[] auxiliar = array[i].Split('|');
          
      cc.Nome = auxiliar[0];
      cc.Telefone = Convert.ToInt32(auxiliar[1]);     
      cc.Localidade = auxiliar[2];
      cc.Titulo = auxiliar[3];
      cc.Edicao = Convert.ToInt32(auxiliar[4]);
      cc.Contador = Convert.ToInt32(auxiliar[5]);

        
      conta = cc.Contador;
      titu=cc.Titulo;
      telef=cc.Telefone;
      nom=cc.Nome;
      loc=cc.Localidade;
      edic=cc.Edicao;
      checar=Convert.ToString(cc.Contador);
      
      if (tituu == true)
      {
        if (titu.Contains(tit)) // Aqui eu checo se na célula[x] têm a string que é procurada.
        {
          conttt=1;
          Console.WriteLine("");
          Console.WriteLine("Titulo: {0};   Edição: {1};\nLocalidade:{2}", titu, edic, loc);
          Console.WriteLine("Numero para maiores detalhes: {0}",checar);
            
        }
      }
      
      if (dados == true)
      {
        if (checar.Contains(id)) // Aqui eu checo se na célula[x] têm a string que é procurada.
        {
          
          //Console.WriteLine("DADOS DETALHADOS DO DOADOR:\n");
          Console.WriteLine("");
          Console.WriteLine("Titulo do Livro: {3}  Edição: {4};\nNome do Doador: {0}    Localidade: {2};   Telefone de Contato: {1}", nom, telef, loc, titu, edic);
          Console.WriteLine("");
            
        }
        if (conttt<=0){
          throw new Exception("Nenhum livro encontrado");
        }   
      }       
    }
         
  } 

  public static void Contadorr(){
            
    cont = conta + 1; //salva um numero sequencial na linha dos dados salvos para posterior identificação e pesqueisa por linha
          
  }
}