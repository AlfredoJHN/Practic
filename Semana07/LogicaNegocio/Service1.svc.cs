﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LogicaNegocio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EjemploCalculos : IEjemploCalculos,IEjemploCalculosDos
    {
        string IEjemploCalculos.Show()
        {
            var Resultado = "Implementando EJCalculo1 ";
            return Resultado;
        }
        string IEjemploCalculos.Show(string Mensaje)
        {
            var Resultado = "Implementando EJCalculo1 "+ Mensaje;
            return Resultado;
        }
        string IEjemploCalculosDos.Show()
        {
            var Resultado = "Implementando EJCalculo1 ";
            return Resultado;
        }
        string IEjemploCalculosDos.Show(string Menaje)
        {
            var Resultado = "Implementando EJCalculo2 "+Mensaje;
            return Resultado;
        }
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
    }
}
