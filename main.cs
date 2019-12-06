using System;
using System.Collections.Generic;
using System.IO;
namespace LendoTxtArmazenandoList
{
  class MainClass {
    public static void Main (string[] args) {

      List<Cliente> lista = new List<Cliente>();
      Console.WriteLine("deseja Doar ou buscar pelo livro? \n");
              
      Console.WriteLine("Digite :");
      Console.WriteLine("DOAR -> 1");
      Console.WriteLine("BUSCAR -> 2 \n");
      int ChecarCadastro = int.Parse(Console.ReadLine());
      while(true)
      {
        try
        {
          switch(ChecarCadastro){
            case 1:
            livros.doarLivros();
            break;

            case 2:
            buscar.buscarTitulo();
            break;



          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);

        }


      }
    }
  }
}