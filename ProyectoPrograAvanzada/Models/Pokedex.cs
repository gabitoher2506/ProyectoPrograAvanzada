﻿namespace ProyectoPrograAvanzada.Models
{
    public class Pokedex
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public string? Debilidad { get; set; }
        public string? Evoluciones { get; set; }
        public decimal Peso { get; set; }
        public int Numero { get; set; }

        public Pokedex()
        {
        }
    }
}
