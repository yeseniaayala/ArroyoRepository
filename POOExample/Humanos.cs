using System;
using System.Collections.Generic;

namespace POOExample
{
    // Se implementa la interfaz IRutinas donde tenemos una rutinas que podriamos aplicar 
    // para los humanos pero también para una clase animales, y en cada clase se define la 
    // funcionalidad que tendría el método horasSueño por ejemplo, donde el humano por lo 
    // general duerme 1 vez al día pero los animales pueden tener varias siestas.
    public class Humano: IRutinas
    {
        public string Nombre { get; set; }

        public int NumeroIdentificacon { get; set; }

        public string Raza { get; set; }

        public string ColorOjos { get; set; }

        public double Estatura { get; set; }

        public double Peso { get; set; }

        public string TipoSangre { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public int horasSueno(int[] hora, int[] horaDespertar)
        {
            int horasSueño = horaDespertar[0] - hora[0];
            return horasSueño;
        }

        public int horasEjercicio(bool practica, int horaInicio, int horaSalida)
        {
            if (practica)
            {
                int horasEjercicio = horaInicio - horaSalida;
                return horasEjercicio;
            }
            return 0;
        }

        public string[] hobbies(string[] hobbies)
        {
            string[] arregloHobbies = new string[] { "Montar bicicleta", "Caminar" };
            return arregloHobbies;
        }
    }

    public class Humanos
    {
        // Aqui estamos creando una instancia de la clase humano
        // es decir tenemos el objeto Paola y el objeto Walter cada uno con sus 
        // propios atributos o características.
        // La clase me permite definir cuales serán los atributos y métodos que tendrá mi objeto
        public Humano paola = new Humano()
        {
            ColorOjos = "Café",
            Ciudad = "Chía",
            Estatura = 1.60,
            Nombre = "Paola",
            NumeroIdentificacon = 111,
            Pais = "Colombia",
            Peso = 60,
            Raza = "Meztizo",
            TipoSangre = "O+",
        };

        Humano walter = new Humano()
        {
            ColorOjos = "Café",
            Ciudad = "Bogotá",
            Estatura = 1.80,
            Nombre = "Walter",
            NumeroIdentificacon = 886556,
            Pais = "Colombia",
            Peso = 80,
            Raza = "Blanco",
            TipoSangre = "O-",
        };
                
        public List<Humano> ListHumanos()
        {
            List<Humano> listHumanos = new List<Humano>();

            listHumanos.Add(paola);
            listHumanos.Add(walter);

            return listHumanos;
        }
    }

}
