using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSanJuan2025.Model;

namespace AppSanJuan2025.ViewModel
{
    public class ActividadesViewModel
    {
        public ObservableCollection<Modelo> Actividades { get; set; }

        public ActividadesViewModel()
        {
            Actividades = new ObservableCollection<Modelo>
            {
                new Modelo{ Icon = "🫔", Title = "I Festival del tamal",Date = "21/06" },
                new Modelo{ Icon = "💃", Title = "Estampas Constrombristas",Date = "21/06" },
                new Modelo{ Icon = "🏍️", Title = "Competencias de Motocross",Date = "21/06" },
               
                // Agrega más días aquí igual
            };
        }
    }
}

