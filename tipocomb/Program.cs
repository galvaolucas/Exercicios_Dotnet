using System; 

class URI {

    static void Main(string[] args) { 

           int[] tipoCombustivel = new int[3];
           int input = 0;
           do
           {
               
              input  = Convert.ToInt32(Console.ReadLine());
               
               switch (input)
               {
                   case 1:
                    tipoCombustivel[0]++;
                    break;
                   case 2:
                     tipoCombustivel[1]++;
                     break;
                   case 3:
                     tipoCombustivel[2]++;
                     break;  
                   case 4:
                    break;
                    default:                        
                    continue;
               }
           }
       
        while (input != 4);
         
        System.Console.WriteLine("MUITO OBRIGADO");
        System.Console.WriteLine("Alcool: " + tipoCombustivel[0]);
        System.Console.WriteLine("Gasolina: " + tipoCombustivel[1]);
        System.Console.WriteLine("Diesel: " + tipoCombustivel[2]);

  }
}
