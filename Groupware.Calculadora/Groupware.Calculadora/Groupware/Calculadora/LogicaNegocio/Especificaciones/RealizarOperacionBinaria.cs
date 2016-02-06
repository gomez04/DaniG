using Groupware.Calculadora.LogicaNegocio.Enumerados;

namespace Groupware.Calculadora.LogicaNegocio.Especificaciones
{
    internal class RealizarOperacionBinaria
    {


        public double RealizarLaOperacionBinaria(Operadores miOperador, double operandoUno, double operandoDos)
        {
            double resultado = 0.0;
            switch (miOperador)
            {
                case Enumerados.Operadores.Suma:
                    var laSuma = new LogicaNegocio.Especificaciones.Suma();
                    resultado = laSuma.Calculo(operandoUno, operandoDos);
                    break;

            }
            return (resultado);

        }
    }
}