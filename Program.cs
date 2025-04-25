
String SenhaDigitada; 

 String SenhaCorreta = "1234abcd";

Console.Clear();

Console.Write(@" Que bom vê - lo de volta, Antes de tudo precisamos verificar se você é você mesmo.
    Para isso digite sua senha: ");
SenhaDigitada = Console.ReadLine();

//ACESSO ACEITO
if (SenhaDigitada == SenhaCorreta) 

{Console.ForegroundColor = ConsoleColor.Green; 
 
Console.WriteLine ("Senha correta, Agora que sabemos que você é você, podemos continuar....");}
  


// ACESSO NEGADO 
else
{Console.ForegroundColor = ConsoleColor.Red;
 
   Console.Write ("Senha incorreta, seu acesso foi negado você não é você:  ");}

 Console.ResetColor();
