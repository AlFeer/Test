using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ninestars.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
    }
}
