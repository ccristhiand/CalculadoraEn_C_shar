using examenCalculadora.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenCalculadora.controladores
{
    public  class operaciones
    {
        
        public double suma(datos operadores)
        {
            operadores.total=operadores.num1+operadores.num2;

            return operadores.total;
        }

        public double resta(datos operadores)
        {
            operadores.total = operadores.num1 - operadores.num2;

            return operadores.total;
        }

        public double multiplicacion(datos operadores)
        {
            operadores.total = operadores.num1 * operadores.num2;

            return operadores.total;
        }

        public double divicion(datos operadores)
        {
            operadores.total = operadores.num1 / operadores.num2;

            return operadores.total;
        }
    }
}
