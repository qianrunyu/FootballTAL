using FootballTAL.Data;
using System;

namespace FootballTAL.BusinessLogic
{
    public class CreateFootballClub
    {
        public FootballClubExtenions CreateClub(string[] fields)
        {
            try
            {
                return new FootballClubExtenions()
                {
                    ClubRank = int.Parse(fields[0].Split('.')[0]),
                    ClubName = fields[0].Split('.')[1].Trim(),
                    P = int.Parse(fields[1]),
                    W = int.Parse(fields[2]),
                    L = int.Parse(fields[3]),
                    D = int.Parse(fields[4]),
                    F = int.Parse(fields[5]),
                    //field[6] is "-"
                    A = int.Parse(fields[7]),
                    Pts = int.Parse(fields[8])
                };
            }
            catch(Exception)
            {
                return new FootballClubExtenions { ErrorFound = true };
               
            }
        }
    }
}
