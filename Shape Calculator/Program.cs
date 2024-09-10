/*
En este programa se nos pide lo siguiente:

Defina una clase abstracta Shape con el método abstracto CalculateSurface() y el ancho y alto de los campos.
Defina dos clases adicionales para un triangle y un rectangle, que implementan CalculateSurface(). Este método
tiene que devolver las áreas del rectángulo (alto*ancho) y del triángulo (alto*ancho/2).  
Defina una clase para un Circle con un constructor apropiado, que inicialice los dos campos (alto y ancho) 
con el mismo valor (el radio) e implemente el método abstracto para calcular el área. Crea una matriz de diferentes Shapes
y calcula el área de cada forma en otra matriz.

*/

using System;
using System.Drawing;

namespace Shape_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Rectangle(5, 2);
            shapes[1] = new Rectangle(12, 23);
            shapes[2] = new Triangle(9, 4);
            shapes[3] = new Circle(5);


            double[] shapesSurfaces = new double[shapes.Length];
           
            //Se Inicializará cada elemento del arreglo shapesSurfaces con el area de cada elemento del arreglo shapes
            //Y en cada iteración se estará mostrando en consola el detalle de la figura y su resultado
            for(int i = 0; i < shapes.Length; i++)
            {
                shapesSurfaces[i] = shapes[i].CalculateSurface();

                String typeName;
                typeName = shapes[i].GetType().Name;

                Console.Write($"Shape #{i + 1}: ");

                if (typeName != "Circle")
                {
                    Console.WriteLine($"{typeName}\n\tWidth = {shapes[i].width}\n\tHeight = {shapes[i].height}\n\tSurface = {shapesSurfaces[i]}\n");
                }
                else
                {
                    Console.WriteLine($"{typeName}\n\tRadius = {shapes[i].height}\n\tSurface = {shapesSurfaces[i]}\n");
                }
                
            }


        }
    }
}
