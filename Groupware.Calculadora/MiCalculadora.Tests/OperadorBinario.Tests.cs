using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiCalculadora.Tests
{
    [TestClass]
    public class TestsSuma
    {

        string miOperador = "+";
        double miOperandoUno;
        double miOperandoDos;
        double miResultadoEsperado;
        double miResultadoReal;
        Groupware.Calculadora.MiCalculadora invocador = new Groupware.Calculadora.MiCalculadora();
        [TestMethod]
        public void SumarDosMasDos()
        {
        
            //realice la invocacion al metodo
            var invocador = new Groupware.Calculadora.MiCalculadora();
            miResultadoReal = invocador.OperadorBinario(miOperador, miOperandoUno, miOperandoDos);

            //Realcie la verificacion de si el calculos es correcto
            Assert.AreEqual(miResultadoEsperado, miResultadoReal);
        }

        public void SumarDiezMasDiez()
        {

            //realice la invocacion al metodo
            var invocador = new Groupware.Calculadora.MiCalculadora();
            miResultadoReal = invocador.OperadorBinario(miOperador, miOperandoUno, miOperandoDos);

            //Realcie la verificacion de si el calculos es correcto
            Assert.AreEqual(miResultadoEsperado, miResultadoReal);
        }
    }
}
