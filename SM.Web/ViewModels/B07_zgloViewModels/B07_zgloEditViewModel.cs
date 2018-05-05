using Microsoft.AspNetCore.Mvc.Rendering;
using SM.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM.Web.ViewModels.B07_zgloViewModels
{
    public class B07_zgloEditViewModel
    {
        public B07_zgloDTO B07_ZgloDTO { get; set; }
        public SelectList Administracje { get; set; }
        public SelectList Branze { get; set; }
        public SelectList Pracownicy { get; set; }
    }
}
