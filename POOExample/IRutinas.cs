using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExample
{
    public interface IRutinas
    {
        int horasSueno(int[] horaDormir, int[] horaDespertar );

        int horasEjercicio(bool practica, int horaInicio, int horaSalida);

        string[] hobbies(string[] hobbies);
    }
}
