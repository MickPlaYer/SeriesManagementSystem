using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.UI.ViewModel
{
    class SeriesDetailFormPresentationModel
    {
        Series _series;

        public SeriesDetailFormPresentationModel(Series series)
        {
            _series = series;
            
        }
    }
}
