using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pore_Pressure_Prediction
{
   public  class Pressure_call
    {
       private double Vs;
      private double Vp;
      private double gamma;
      private double V;
      private double G;
      private double Pf;
      private double porePress;


       public Pressure_call (){

          

       }


       public double getVs(double o)
       {
           Vs = 0.224 + 0.889 * o;
           return Vs;

       }

       public double getVp(double Vs)
       {
           Vp = 1.30 * Vs + 1.52;
           return Vp;

       }


       public double getV(double D)
       {
           V = 0.0645 * Math.Log(D) - 0.0673;
           return V;

       }



       public double getGamma(double den,double Vs, double Vp)
       {
           gamma = (den * Vp * Vp) - (2 * den * Vs * Vs);
           return gamma;

       }



       public double getG(double v, double gamma)
       {
           G = ((1 - 2 * v) / (2 * v)) * gamma;
           return G;
       }

       public double getPf(double g, double vs)
       {

           Pf = Math.Sqrt(g) / vs;

           return Pf;
       }


       public double getPorePress(double Pf, double h)
       {
           porePress = 0.052 * Pf * h;
           return porePress;

       }

    }
}
