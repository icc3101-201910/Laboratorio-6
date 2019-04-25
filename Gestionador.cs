using System;
using System.IO;
using System.Collections.Generic;

namespace laboratorio06
{
    public class Gestionador
    {
        private List<Serie> series;

        public Gestionador()
        {
            series = new List<Serie>();
        }

        public void AgregarSerie(Serie serie)
        {
            series.Add(serie);
        }

        public void MostrarSeries()
        {
            for (int i = 0; i < series.Count; i++) {
                Console.WriteLine($"[{i}] {series[i]}");
            }
        }

        public void GuardarSeries()
        {
            StreamWriter writer = new StreamWriter("series.txt");
            foreach(Serie miSerie in series) {
                writer.WriteLine(miSerie.ToString());
            }
            writer.Close();
        }

        public void CargarSeries() 
        {
        }
    }
}
