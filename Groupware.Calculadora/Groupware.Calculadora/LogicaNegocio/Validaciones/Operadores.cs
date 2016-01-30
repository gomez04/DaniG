using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupware.Calculadora.LogicaNegocio.Validaciones
{
    class Operadores
    {
        public Enumerados.Operadores ObtenerOperador (string elOperador)
        {
            Enumerados.Operadores resultado;
            resultado = Enumerados.Operadores.Desconocido;

            switch (elOperador)
                {
                case "+": resultado = Enumerados.Operadores.Suma;
                    break;
            }

            return (resultado);
        }
    }
}
