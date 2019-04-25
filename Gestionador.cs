using System;
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
            // TODO
        }

        public void CargarSeries() 
        {
            // TODO
        }
    }
}
