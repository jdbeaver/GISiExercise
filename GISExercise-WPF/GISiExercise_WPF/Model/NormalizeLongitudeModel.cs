using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GISiExercise_WPF.Model
{
    class NormalizeLongitudeModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Longitude Value
        /// </summary>
        private string inputLon;
        public string InputLon
        { 
            get { return inputLon; }
            set
            {
                inputLon = value;
                NotifyPropertyChanged("InputLon");
            } 
        }

        /// <summary>
        /// Normalized Longitude Value
        /// </summary>
        private string outputLon;
        public string OutputLon
        {
            get { return outputLon; }
            set
            {
                outputLon = value;
                NotifyPropertyChanged("OutputLon");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
