using System;

namespace WindowsFormsApp1
{
    public class Procedimientos
    {

        public string Operar(string operandoA, string operandoB, string Operador)
        {
            string ResultadoConvertido;
            double operando1 = Convert.ToDouble(operandoA);
            double operando2 = Convert.ToDouble(operandoB);
            Enumerados OperadorEnumerado = ConvertirStringEnumeradoOperadores(Operador);
            double? Resultado = Operar(operando1, operando2, OperadorEnumerado);
            if (Resultado != null)
            {
                ResultadoConvertido = Resultado.ToString();
            }
            else
            {
                ResultadoConvertido = "Error";
            }
            return ResultadoConvertido;
        }

        private Enumerados ConvertirStringEnumeradoOperadores(string Operador)
        {
            Enumerados Resultado;
            switch (Operador)
            {
                case "Área":
                case "Area":
                    Resultado = Enumerados.Area;
                    break;
                case "Perímetro":
                case "Perimeter":
                    Resultado = Enumerados.Perimetro;
                    break;
                default:
                    Resultado = Enumerados.Desconcido;
                    break;
            }
            return Resultado;
        }
        private double? Operar(double operandoA, double operandoB,
                              Enumerados Operador)
        {
            double? Resultado = 0.0; //double? -> puede asignar valores null
            switch (Operador) 
            {
                case Enumerados.Area:
                    Resultado = operandoA * operandoB;
                    break;
                case Enumerados.Perimetro:
                    Resultado = operandoA*2+ operandoB*2;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "No se ha seleccionado ningún operador");
                    break;
            }
            return Resultado;
        }
    }
}
