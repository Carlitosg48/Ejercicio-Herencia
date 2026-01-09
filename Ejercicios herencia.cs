using System;

namespace EjemploHerencia
{

    class Persona
    {
       
        private string nombre;
        private int edad;

      
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        
        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }

    
    class Empleado : Persona
    {
       
        private double sueldo;

        
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

       
        public void ImprimirSueldo()
        {
            Console.WriteLine("Sueldo: $" + sueldo);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona1 = new Persona();
            persona1.Nombre = "Carlos";
            persona1.Edad = 30;

            Console.WriteLine("Datos de la Persona:");
            persona1.Imprimir();

            Console.WriteLine();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Ana";
            empleado1.Edad = 25;
            empleado1.Sueldo = 850.50;

            Console.WriteLine("Datos del Empleado:");
            empleado1.Imprimir();      
            empleado1.ImprimirSueldo();  

            Console.ReadLine();
        }
    }
}