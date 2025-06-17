using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSanJuan2025.Model;

namespace AppSanJuan2025.ViewModel
{
    public class NovenarioViewModel
    {
       public ObservableCollection<Modelo> Novenario { get; set; }

        public NovenarioViewModel()
        {
            Novenario = new ObservableCollection<Modelo>
            {
                new Modelo{ Icon = "📿", Title = "Gran Reseña", Description = "Entrada triunfal de la imagen del patron San Juan Bautista desde el fundo Tuctuhuasi", Date = "13/06" },
                new Modelo { Icon = "🎶", Title = "Primer Día de Novena", Description = "Comunidades campesinas,Distritos, Participaciones artisticas", Date = "13/06" },
                new Modelo { Icon = "🎤", Title = "Segundo Día de Novena", Description = "Comunidades campesinas,Distritos, Participaciones artisticas", Date = "14/06" },
                new Modelo{ Icon = "🎆", Title="Tercer Dia de novena", Description= " Comunidades campesinas,Distritos, Participaciones artisticas", Date="15/06"},
                new Modelo{ Icon = "🎸", Title="Cuarto Dia de novena", Description= " Comunidades campesinas,Distritos, Participaciones artisticas", Date="16/06"},
                new Modelo{ Icon = "🎙️", Title="Quinto Dia de novena", Description= " Comunidades campesinas, Distritos, Participaciones artisticas", Date="17/06"},
                new Modelo{ Icon = "🎵", Title="Sexto Dia de novena", Description= " Comunidades campesinas, Distritos,Participaciones artisticas", Date="18/06"},
                new Modelo{ Icon = "🎼", Title="Sétimo Dia de novena", Description= " Comunidades campesinas,Distritos, Participaciones artisticas", Date="19/06"},
                new Modelo{ Icon = "🎧", Title="Octavo Dia de novena", Description= " Comunidades campesinas,Distritos, Participaciones artisticas", Date="20/06"},
                new Modelo{ Icon = "🎹", Title="Noveno Dia de novena", Description= " Comunidades campesinas,Distritos, Participaciones artisticas", Date="21/06"},
                // Agrega más días aquí igual
            };
        }
    }
}

