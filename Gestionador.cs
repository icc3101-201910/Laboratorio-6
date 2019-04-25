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

        public Serie GetSerie(int posicion)
        {
            return series[posicion];
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
            if (File.Exists("series.txt")) {
                StreamReader reader = new StreamReader("series.txt");
                string linea = reader.ReadLine();
                while(linea != null)
                {
                    // Si revisas ToString de Serie.cs, cada atributo lo separo con "|" y siempre
                    // tiene el mismo formato: nombre | temporada | año | estado
                    // entonces si divido el string en |, me va a dar un "array" donde:
                    //  elemento 0 = nombre
                    //  elemento 1 = temporada
                    //  elemento 2 = año
                    //  elemento 3 = estado
                    string[] partes = linea.Split('|');

                    // Datos de la serie (nota: Trim() remueve los espacios en blanco al comienzo y al final)
                    string nombre = partes[0].Trim();
                    string temporada = partes[1].Trim();
                    int anio = int.Parse(partes[2].Trim());
                    string estado = partes[3].Trim();

                    // Crear serie y agregarla a la lista
                    Serie miSerie = new Serie(nombre, temporada, anio, estado);
                    AgregarSerie(miSerie);

                    // Siguiente linea!
                    linea = reader.ReadLine();
                }
                reader.Close(); // <--- no lo habia agregado en el commit anterior jaja...
            }
        }
    }
}
