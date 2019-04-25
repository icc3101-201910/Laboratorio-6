﻿using System;
namespace laboratorio06
{
    public class Serie
    {
	    private string nombre, temporada, estado, anio;

        public Serie(string nombreSerie, string temporadaSerie, int anioTemporada, string estadoSerie)
        {
			nombre = nombreSerie;
			temporada = temporadaSerie;
			estado = estadoSerie;
			anio = anioTemporada;
        }

		public override string ToString() {
			return $"{nombre} | {temporada} | {anio} | {estado}";
		}
    }
}