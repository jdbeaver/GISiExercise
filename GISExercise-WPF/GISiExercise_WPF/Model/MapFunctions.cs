using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GISiExercise_WPF.Model
{
    class MapFunctions
    {
        /// <summary>
        /// Normalize a given longitude value if it is greater than 180 degrees or less than -180 degrees
        /// </summary>
        /// <param name="lon_value">Longitude value</param>
        /// <returns>Normalized longitude value</returns>
        public double normalizeLon(double lon_value)
        {
            double lon_mod, diff;
            // determine modulus of given longitude value when divided by 360 degrees
            lon_mod = lon_value % 360;
            // handle the cases where value is greater than 180 degrees and smaller than -180 degrees
            if(lon_mod > 180.0){
                diff = lon_mod - 180.0;
                lon_mod = -180.0 + diff;
            }
            else if(lon_mod < -180.0){
                diff = lon_mod + 180.0;
                lon_mod = 180.0 + diff;
            }
            return lon_mod;
        }
    }
}
