using System;
namespace laboratorio06
{
    public class Serie
    {
	    private string nombre, temporada, estado;
		private int anio;

		public Serie(string nombreSerie, string temporadaSerie, int anioTemporada, string estadoSerie)
        {
			nombre = nombreSerie;
			temporada = temporadaSerie;
			estado = estadoSerie;
			anio = anioTemporada;
        }

		public void SetEstado(string nuevoEstado) {
			estado = nuevoEstado;
		}

		public override string ToString() {
			return $"{nombre} | {temporada} | {anio} | {estado}";
		}
    }
}
