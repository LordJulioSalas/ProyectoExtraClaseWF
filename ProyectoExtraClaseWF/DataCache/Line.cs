﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtraClaseWF.DataCache
{
    public class Line
    {
        private int NumeroLinea;
        private string ContenidoLinea;

        public static Line Create(int numeroLinea, string contenidoLinea)
        {
            Line line = new Line();
            line.SetNumeroLinea(numeroLinea);
            line.SetContenidoLinea(contenidoLinea);

            return line;
        }

        public void SetNumeroLinea(int numeroLinea)
        {
            NumeroLinea = numeroLinea;
        }

        public void SetContenidoLinea(string contenidoLinea)
        {
            ContenidoLinea = contenidoLinea;
        }

        public int GetNumeroLinea()
        {
            return NumeroLinea;
        }

        public string GetContenidoLinea()
        {
            return ContenidoLinea;
        }
    }
}
