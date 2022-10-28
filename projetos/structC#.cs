using System;
namespace contStruct

{

  class contStruct
 {
    static void start()// metodo Principal( onde o programa sera escrito)
    {
      especies elfo;
      elfo.Raca="Elfo";
      elfo.Arma="Arco";
      elfo.Habil="Guerreiro";
      Console.WriteLine(elfo.Raca);
      Console.WriteLine(elfo.Arma);
      Console.WriteLine(elfo.Habil); 
       Console.WriteLine
      ("----------------------------------------------------------------------------------------------------");
      especies anao;
      anao.Raca="Anão";
      anao.Arma="Machado";
      anao.Habil="minerador";
      Console.WriteLine(anao.Raca);
      Console.WriteLine(anao.Arma);
      Console.WriteLine(anao.Habil); 
      Console.WriteLine("----------------------------------------------------------------------------------------------------");
      especies bruxo = new especies ("bruxo","Cajado","Magia");
      Console.WriteLine("Raça: "+bruxo.Raca);
      Console.WriteLine(bruxo.Arma);
      Console.WriteLine(bruxo.Habil);

    }
 }


}

public struct especies
{
  public string Raca;// declarando os parametros que seram usados na struc ( ex: Raca,Arma e Habilidade)
  public string Arma; // declarar Propriedades com inicial maiuscula
  public string Habil;//

  // metodo construtor
  public especies(string raca, string arma, string habil)// adiciono os parametros e atribuo aa propriedades 
  {
   this.Raca=raca;
   this.Arma=arma; // atribuição dos parametros as Propriedades
   this.Habil=habil;
  }


}









  
