using FootballTAL.Data;
using FootballTAL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballTAL.BusinessLogic;

namespace FootballTAL.BusinessLogic
{
    public class FootballClubArray
    {
        private IList<FootballClubExtenions> FootballClubList { get; set; }
        public IList<FootballClubExtenions> GetFootballClubList(IFileReading FileRead)
        {
            FootballClubList = new List<FootballClubExtenions>();
            //fileRead.readFile will return each line from the raw file
            FileRead.ReadFile().ToList().ForEach(i => FootballClubList.Add(new CreateFootballClub().CreateClub(i)));
            return FootballClubList;
        }

        public bool GetContainsError()
        {
            if (FootballClubList != null)
                return FootballClubList.Any(i => i.ErrorFound) ;
            else
                return false;
        }

    }
}
