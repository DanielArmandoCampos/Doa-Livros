using System;
using System.Collections.Generic;
using System.IO;
namespace LendoTxtArmazenandoList
{
  class buscar : Cliente{
    
    Cliente buscaid =new Cliente();

    public  static void contador(){
      //para ler o contador

      acessarRegistros(); 

      Contadorr();

      // fim ler contador
      Console.WriteLine(cont);/////////checagem ok

    }
    public  static void buscarTitulo(){
      tituu = true;
      Console.WriteLine("Digite o titulo do livro que deseja procurar: \n");
      tit = Console.ReadLine().ToUpper();     
      
      /// SÓ ESTA PEGANDO O ULTIMO VALOR
      acessarRegistros();       
      tituu = false;
      
      //buscador pelo numero de listagem
      Console.WriteLine("");
      Console.WriteLine("Digite o numero de busca do livro desejado: \n");
      dados = true;
        id = Console.ReadLine();
        
        acessarRegistros();
        dados = false;
    }

    
  }
}