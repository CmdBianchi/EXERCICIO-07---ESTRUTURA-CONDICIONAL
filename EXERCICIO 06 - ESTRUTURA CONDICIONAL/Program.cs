using System;
class Program{
    /// -------> START / MAIN 
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Main(string[] args){
        Msg();
        Conditional();
    }
    /// -------> FUNCTIONS
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Msg(){
        Console.WriteLine("Qual dos seguintes intervalos([0, 25], (25, 50], (50, 75], (75, 100]) este a coordenada se encontra.");
    }
    //------------------------------------------------------------------------------------------//
    static void Conditional(){
        double coordinate;

        Console.Write("DIGITE A COORDENADA: ");
        coordinate = int.Parse(Console.ReadLine());
        
        if( coordinate >= 0.25 && coordinate < 25.50){
            Console.WriteLine("INTERVALO [0,25]");
        }
        else if(coordinate >= 25.50 && coordinate < 50.75){
            Console.WriteLine("INTERVALO [25,25]");
        }
        else if(coordinate >= 25.50 && coordinate < 50.75) {
            Console.WriteLine("INTERVALO [50,75]");
        }
        else if (coordinate >= 50.75 && coordinate < 75.1){
            Console.WriteLine("INTERVALO [75,100]");
        }
        else { 
            Console.WriteLine("FORA DO INTERVALO"); 
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////
    /// -------> END
}
