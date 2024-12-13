namespace Opcao;
using Intro;
using Mecanica;
public class Opções(){
public static void Configuracoes(string Config){

    switch (Config)
    {
        case "1":
            Intro.Introducao.Introduçâo();
            Mecanica.Açoes.escolhas(Console.ReadLine()!);
            Thread.Sleep(5000);
        break;
        case "2":
            System.Console.WriteLine("Voce esta nas Configuraçôes");
            Thread.Sleep(5000);
        break;
        case "3":
            System.Console.WriteLine("Você está Saindo...");
            Thread.Sleep(3000);
        break;
    }
}
}
// opçoes selecionaveis para o usuario 
// conversao do int com parse no transform.