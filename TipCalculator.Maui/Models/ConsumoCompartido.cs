using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Maui.Models
{
    public class ConsumoCompartido
    {
        
        public decimal ImporteDelConsumo { get; set; }
        public int NumeroDePersonas { get; set; }
        public decimal PorcentajeDePropina {  get; set; }

        //Propiedades que guardan los cálculos resultantes
        public decimal ImporteDelConsumoPorPersona
            => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDeLaPropina
            => ImporteDelConsumo * PorcentajeDePropina / 100.0m;
        public decimal ImporteDeLaPropinaPorPersona
            => ImporteDeLaPropina / NumeroDePersonas;
        public decimal ImporteTotalConPropina
            => ImporteDelConsumo + ImporteDeLaPropina;
        public decimal ImporteTotalConPropinaPorPersona
            => ImporteTotalConPropina / NumeroDePersonas;

        public ConsumoCompartido(
            decimal importeDeConsumo,
            int numeroDePersonas,
            decimal porcentajeDePropina)
        {
            ImporteDelConsumo = importeDeConsumo;
            NumeroDePersonas = numeroDePersonas;
            PorcentajeDePropina = porcentajeDePropina;
        }
    }
}
