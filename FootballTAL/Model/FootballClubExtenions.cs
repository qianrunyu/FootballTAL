using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTAL.Data
{
    public class FootballClubExtenions : FootballClub
    {
        private int differenceFA;
        private bool errorFound = false;
        public int DifferenceFA { get => differenceFA; set => differenceFA = value; }
        public bool ErrorFound { get => errorFound; set => errorFound = value; }


    }
}
