using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculo_inversion
{
    class inversion
    {

        static void Main(string[] args)
        {
            

            int capital;
            double interes=0.7;
            int meses;
            int contMeses = 1;           
            double valorInteres = 0;
            double totalcapital =0;

            
            Console.WriteLine("Ingrese el valor del capital");
            capital = int.Parse(Console.ReadLine());
            Console.WriteLine("tu inversion es de " + capital);
            
            Console.WriteLine("El porcentaje de Inversion es " + interes + "%");

            Console.WriteLine("Ingrese el numero de meses");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero de meses es de " + meses);


            valorInteres = capital * (interes / 100);
            totalcapital = capital;

            while (contMeses <= meses)
            {             
                totalcapital += valorInteres;                            
                Console.WriteLine("En el Mes " + contMeses + " " + totalcapital);                
                contMeses++;
            }

            Console.ReadKey();
        }
    }
}