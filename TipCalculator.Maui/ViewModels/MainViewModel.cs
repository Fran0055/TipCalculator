using CommunityToolkit.Mvvm.ComponentModel;
using TipCalculator.Maui.Models;


namespace TipCalculator.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        //variables de instancia para la solucion de la IU
        [ObservableProperty]
        private string _importeDelConsumo;
        [ObservableProperty]
        private string _numeroDePersonas;
        [ObservableProperty]
        private string _porcentajeDePropinas;

        //variables de instancia para resultados de la IU
        [ObservableProperty]
        public string _importeDelConsumoPorPersona;
        [ObservableProperty]
        public string _importeDeLaPropina;
        [ObservableProperty]
        public string _importeDeLaPropinaPorPersona;
        [ObservableProperty]
        public string _importeTotalConPropina;
        [ObservableProperty]
        public string _importeTotalConPropinaPorPersona;

        public MainViewModel()
        {
        }
        public void CalcularPropina()
        {

            decimal importeDelConsumo;
            int numeroDePersonas;
            decimal porcentajeDePropina;

            bool importeDelConsumoEsValido = decimal.TryParse(ImporteDelConsumo, out importeDelConsumo);
            bool numeroDePersonasEsValido = int.TryParse(NumeroDePersonas, out numeroDePersonas);
            bool porcentajeDePropinasEsValido = decimal.TryParse(PorcentajeDePropinas, out porcentajeDePropina);
            if (importeDelConsumoEsValido && numeroDePersonasEsValido && porcentajeDePropinasEsValido)
            {
                var consumo =
                    new ConsumoCompartido(
                        importeDelConsumo,
                        numeroDePersonas,
                        porcentajeDePropina); ImporteDelConsumoPorPersona = consumo.ImporteDelConsumoPorPersona.ToString("C2");
                ImporteDeLaPropina =
                    consumo.ImporteDeLaPropina.ToString("C2");
                ImporteDeLaPropinaPorPersona =
                    consumo.ImporteDeLaPropinaPorPersona.ToString("C2");
                ImporteTotalConPropina =
                    consumo.ImporteTotalConPropina.ToString("C2");
                ImporteTotalConPropinaPorPersona =
                    consumo.ImporteTotalConPropinaPorPersona.ToString("C2");
            }
        }
            public void Limpiar()
        {
            ImporteDelConsumo = string.Empty;
            NumeroDePersonas = string.Empty;
            PorcentajeDePropinas = string.Empty;
                ImporteDelConsumoPorPersona = string.Empty;
            ImporteDeLaPropina = string.Empty;

            ImporteDeLaPropinaPorPersona = string.Empty;

            ImporteTotalConPropina = string.Empty;

            ImporteTotalConPropinaPorPersona = string.Empty;
                
        }
            }
        }

    