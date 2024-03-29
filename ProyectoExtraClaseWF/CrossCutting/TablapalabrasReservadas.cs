﻿using ProyectoExtraClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtraClaseWF.CrossCutting
{
    public class TablaPalabrasReservadas : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaPalabrasReservadas();
        private static Dictionary<string, Category> PALABRAS_RESERVADAS = new Dictionary<string, Category>();

        static TablaPalabrasReservadas()
        {
            PALABRAS_RESERVADAS.Add("INICIO", Category.PALABRA_RESERVADA_INICIO);
            PALABRAS_RESERVADAS.Add("PALABRA_RESERVADA_FINSI", Category.PALABRA_RESERVADA_FIN);
            PALABRAS_RESERVADAS.Add("PALABRA_RESERVADA_SI", Category.PALABRA_RESERVADA_SI);
            PALABRAS_RESERVADAS.Add("PALABRA_RESERVADA_SINO", Category.PALABRA_RESERVADA_SINO);
            PALABRAS_RESERVADAS.Add("FINSI", Category.PALABRA_RESERVADA_FINSI);
        }

        private TablaPalabrasReservadas()
        {

        }

        public static TablaComponentes GetTablaPalabrasReservadas()
        {
            return INSTANCE;
        }

        public static LexicalComponent ComprobarComponente(LexicalComponent component)
        {
            if (component != null && PALABRAS_RESERVADAS.ContainsKey(component.GetLexeme()))
            {
                return LexicalComponent.CreatePalabraReservadaComponent(component.GetLineNumber(), component.GetInitialPosition(), component.GetFinalPosition(), PALABRAS_RESERVADAS[component.GetLexeme()], component.GetLexeme());
            }
            else
            {
                return component;
            }
        }

        public static void Inicializar()
        {
            INSTANCE.Initialize();
        }

        public static void Add(LexicalComponent component)
        {
            INSTANCE.Add(component);
        }

        public static List<LexicalComponent> GetComponetsAsList()
        {
            return INSTANCE.GetComponentsAsList();
        }

        public static Dictionary<string, List<LexicalComponent>> GetComponets()
        {
            return INSTANCE.GetComponents();
        }
    }
}
