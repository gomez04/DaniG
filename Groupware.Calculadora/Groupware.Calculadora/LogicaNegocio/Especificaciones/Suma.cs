using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    public class Suma
    {
        public double Calculo (double operandoUno, double operandoDos)
        {
            double resultado;
            // invoque a la acción correspondiente
            Acciones.Sumar operacion = new Acciones.Sumar();
            resultado = operacion.Calcular(operandoUno, operandoDos);

            return (resultado);

        }
    }
}