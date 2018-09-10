using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejemplo1
            string message = "Hello World!!";
            Console.WriteLine(message);
            Console.ReadKey();
            #endregion Ejemplo1
            #region EjemploConstructores
            Estudiante estudiante1 = new Estudiante();
            var estudiante2 = new Estudiante();
            var estudiante3 = new Estudiante
            {
                 Apellido="aaa",
                 Nombre="aa",
                 Id=1
            };
            var estudiante4 = new Estudiante(1, "XXX", "YYY", 10);
            var estudiante5 = new Estudiante(2, "XXX", "YYY");
            
            Console.WriteLine(estudiante5.NombreApellido);
            Console.ReadKey();
            #endregion EjemploConstructores

            #region EjemploListas
            List<Estudiante> estudiantes = new List<Estudiante>();
            var estudiantes1 = new List<Estudiante>();
            var estudiantes2 = new List<Estudiante>() {
                new Estudiante (1, "a", "b", 5),
                new Estudiante (2, "a2", "b2", 4)
            };
            var estudiant1 = new Estudiante();
            estudiantes1.Add(estudiant1);
            #endregion
            List<Docente> docentes = new List<Docente>();
            docentes.Add(new Docente() { Id=1, Nombre="aaa", Apellido="33" });
            var personas = new List<Persona>();
            personas.AddRange(estudiantes2);
            personas.AddRange(docentes);

            foreach (Persona item in personas)
            {
                Console.WriteLine(item.Saludo());
            }
        }
    }
    abstract class Persona {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreApellido
        {
            get
            {
                return Nombre.Trim() + " " + Apellido.Trim();
            }
        }

        public abstract string Saludo();
    }
    class Estudiante: Persona
    {
        public Estudiante()
        {

        }
        public Estudiante(int id, string nombre, string apellido, float nota=0)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Nota = nota;
        }

        internal float Nota { get; private set; }

        public override string Saludo()
        {
            return $"Buenos días Estimado Estudiante {NombreApellido}";
        }
    }

    class Docente : Persona
    {
        public override string Saludo()
        {
            return $"Buenos días Estimado Docente {NombreApellido}";
        }
    }
}
