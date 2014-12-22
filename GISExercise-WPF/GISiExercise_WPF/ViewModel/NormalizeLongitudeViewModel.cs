using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using GISiExercise_WPF.Model;

namespace GISiExercise_WPF.ViewModel
{
    class NormalizeLongitudeViewModel
    {
        private MapFunctions mapfunc;
        private double input_lonval;
        private NormalizeLongitudeModel normlon;
        public NormalizeLongitudeViewModel()
        {
            mapfunc = new MapFunctions();
            normlon = new NormalizeLongitudeModel();
        }

        public NormalizeLongitudeModel LonValue
        {
            get { return normlon; }
            set { normlon = value; }
        }

        public ICommand NormalizeButtonClickCommand
        {
            get { return new DelegateCommand<object>(NormalizeLon, isValidNumber); }
        }

        private void NormalizeLon(object context)
        {
            // find the normalized longitude value
            double norm_lonvalue = mapfunc.normalizeLon(input_lonval);
            // write normalized longitude value to UI label
            this.LonValue.OutputLon = "The normalized longitude is: " + norm_lonvalue.ToString();
        }

        private bool isValidNumber(object context)
        {
            string inputlon = this.LonValue.InputLon;
            // make sure value entered is a valid number
            if (!double.TryParse(inputlon, out input_lonval) && inputlon != null)
            {
                this.LonValue.OutputLon = "Enter a valid number...";
                return false;
            }
            return true; 
        }
    }
}
