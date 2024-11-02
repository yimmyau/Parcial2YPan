using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Parcial2YPan
{
    internal class Ecuacion
    {
        private double a, b, c;
        private Validaciones validar = new Validaciones();
        public void set(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string calcularRaiz()
        {
            double discriminante = b * b - 4 * a * c;
            double x1, x2, raiz, parteReal, parteImaginaria;
            string resultado;

            if (a == 0)
            {
                if (b == 0)
                {
                    resultado = c == 0 ? "La ecuación tiene infinitas soluciones." : "La ecuación no tiene solución.";
                }

                raiz = Math.Round(-c / b, 5);
                resultado = $"Raíz de la ecuación lineal: x = {raiz}";
            }
            else
            {
                if (discriminante > 0)
                {
                    x1 = Math.Round((-b + Math.Sqrt(discriminante)) / (2 * a), 5);
                    x2 = Math.Round((-b - Math.Sqrt(discriminante)) / (2 * a), 5);
                    resultado = $"Raíces Reales: \nx1 = {x1}, \nx2 = {x2}";
                }
                else if (discriminante == 0)
                {
                    raiz = Math.Round(-b / (2 * a), 5);
                    resultado = $"Raíz Doble: x = {raiz}";
                }
                else
                {
                    parteReal = Math.Round(-b / (2 * a), 5);
                    parteImaginaria = Math.Round(Math.Sqrt(-discriminante) / (2 * a), 5);
                    resultado = $"Raíces Complejas: \nx1 = {parteReal} + {parteImaginaria}i, \nx2 = {parteReal} - {parteImaginaria}i";
                }
            }
            return resultado;
        }

        public void graficar(Chart grafico)
        {
            grafico.Series.Clear();
            double discriminante = b * b - 4 * a * c;
            var serie = new Series("Ecuación") { ChartType = SeriesChartType.Line };

            if (a == 0 && b == 0 && c == 0)
            {
                validar.mandarMensaje("a, b y c son 0. No se puede graficar.", 1);
                return;
            }

            grafico.ChartAreas[0].AxisX.Minimum = -20;
            grafico.ChartAreas[0].AxisX.Maximum = 20;

            if (a == 0)
            {
                graficarLineal(serie);
            }
            else
            {
                if (discriminante < 0)
                {
                    validar.mandarMensaje("La ecuación tiene raíces imaginarias. No se puede graficar.", 1);
                    return;
                }
                graficarCuadratica(serie, discriminante, grafico);
            }

            grafico.Series.Add(serie);
            grafico.ChartAreas[0].AxisX.Title = "X";
            grafico.ChartAreas[0].AxisY.Title = "Y";
        }

        private void graficarLineal(Series serie)
        {
            double x, y;
            for (x = -20; x <= 20; x += 0.1)
            {
                y = b * x + c;
                serie.Points.AddXY(x, y);
            }
        }

        private void graficarCuadratica(Series serie, double discriminante, Chart grafico)
        {
            double x, y, x1, x2, xVertice, yVertice;
            for (x = -20; x <= 20; x += 0.1)
            {
                y = a * x * x + b * x + c;
                serie.Points.AddXY(x, y);
            }

            xVertice = -b / (2 * a);
            yVertice = a * xVertice * xVertice + b * xVertice + c;
            marcarVertice(xVertice, yVertice, grafico);

            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            marcarRaices(x1, x2, grafico);
        }

        private void marcarVertice(double x, double y, Chart grafico)
        {
            var serieVertice = new Series("Vértice")
            {
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Diamond,
                MarkerSize = 10,
                Color = System.Drawing.Color.Red
            };
            serieVertice.Points.AddXY(x, y);
            grafico.Series.Add(serieVertice);
        }

        private void marcarRaices(double x1, double x2, Chart grafico)
        {
            var serieRaices = new Series("Raíces")
            {
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10,
                Color = System.Drawing.Color.Blue
            };
            serieRaices.Points.AddXY(x1, 0);
            serieRaices.Points.AddXY(x2, 0);
            serieRaices.Points[0].Label = Math.Round(x1, 2).ToString();
            serieRaices.Points[1].Label = Math.Round(x2, 2).ToString();
            grafico.Series.Add(serieRaices);
        }
    }
}
