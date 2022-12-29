using System.Collections.Generic;

namespace Polymorphism_Method_Overiding
{
    public class Canvas 
    {
        public void DrawShapes(List<Shape> shapes) 
        {
            foreach (var shape in shapes)
            {

                shape.Draw();

            } 
           
        
        }
              
        }
    
    
    }

