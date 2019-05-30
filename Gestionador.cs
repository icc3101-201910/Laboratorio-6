using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

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
            Stream SaveFileStream = File.Create("series.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, series);
            SaveFileStream.Close();
        }

        public void CargarSeries() 
        {
            if (File.Exists("series.bin"))
            {
                Stream openFileStream = File.OpenRead("series.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                series = (List<Serie>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }   
        }
    }
}
