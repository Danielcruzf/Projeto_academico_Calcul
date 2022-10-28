using System;
namespace contEnum
{
  enum Diasem{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado}

  class contEnum
  {
    //enum Diasem{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado}
    static void start02()
    {
      
      Diasem ds;
      ds=Diasem.Sabado;
      Console.WriteLine(ds); // Sexta feira
      Console.WriteLine((Diasem) 2); // terça feira
      Console.WriteLine((int)ds); // valor 6
      
    }
  }
}