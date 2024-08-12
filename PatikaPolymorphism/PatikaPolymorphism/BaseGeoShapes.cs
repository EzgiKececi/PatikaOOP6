using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatikaPolymorphism
{
    public abstract class BaseGeoShapes
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public virtual double AreaCalculation()
        {
            return Width * Heigth;
    
        }
        
    }

    //Türetilmiş kares sınıfı
    public class Square : BaseGeoShapes
    {
        public override double AreaCalculation()
        {
            return Width * Heigth;
        } 

    }

    //Türetilmiş dikdörtgen sınıfı
    public class Rectangle : BaseGeoShapes
    {
        public override double AreaCalculation()
        {
            return Width * Heigth;
        }

    }
    //Türetilmiş üçgen sınıfı
    public class RightTriangle : BaseGeoShapes
    {
        public override double AreaCalculation()
        {
            return (Width * Heigth)/2 ;
        }

    }

}
 
  
        
         
    


