using FootballTAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTAL.BusinessLogic
{
    public class FindDifference
    {
        public IList<FootballClubExtenions> FindSmallestForAgainst(IList<FootballClubExtenions> clubs)
        {
            var clubsNoError= clubs.Where(s=>s.ErrorFound==false).Select(i=>i).ToList();
            clubsNoError.ForEach(i => i.DifferenceFA = Math.Abs(i.F - i.A));
            //please be noted there could be more than one team with the same min difference
            return clubsNoError.Where(entry => entry.DifferenceFA == clubsNoError.Min(i => i.DifferenceFA)).ToArray();
        }
        //we can also implement other arregation methods in this class such as Find largest difference or clubs of relegation 

    }
}
