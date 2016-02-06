﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Groupware.Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MiCalculadora : IMiCalculadora
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double OperadorBinario(string operador, double operandoUno, double operandoDos)
        {
            double resultado = 0.0;
            var elOperador = new LogicaNegocio.Especificaciones.ObtenerOperador();

            LogicaNegocio.Enumerados.Operadores miOperador = elOperador.ObtenerElOperador(operador);
            var laOperacion = new
                            LogicaNegocio.Especificaciones.RealizarOperacionBinaria();
                           resultado = laOperacion.RealizarLaOperacionBinaria(miOperador, operandoUno, operandoDos);

            return (resultado);

        }

        public double OperadorUnario(string operador, double operando)
        {
            double resultado = 0.0;

            return (resultado);

        }
    }
}
