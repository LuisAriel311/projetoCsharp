namespace Mecanica;
public class Açoes(){
    public static void escolhas(string escolhas){
        
        switch (escolhas)
        {
            case "1":
                System.Console.WriteLine("Guedeslovisk decidiu seguir pela estrada de pedra.");
                Thread.Sleep(5000);
                break;
            case "2":
            System.Console.WriteLine("Guedeslovisk decidiu vasculhar pela florestar e encontrar algo pra sobreviver na florestar");
                Thread.Sleep(5000);
                break;
        }
    }
}