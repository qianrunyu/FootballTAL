using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTAL.Data
{
   public abstract class FootballClub
    {
        private int clubRank;
        private string clubName;
        private int p;
        private int w;
        private int l;
        private int d;
        private int f;
        private int a;
        private int pts;

        public int ClubRank { get => clubRank; set => clubRank = value; }
        public string ClubName { get => clubName; set => clubName = value; }
        public int P { get => p; set => p = value; }
        public int W { get => w; set => w = value; }
        public int L { get => l; set => l = value; }
        public int D { get => d; set => d = value; }
        public int F { get => f; set => f = value; }
        public int A { get => a; set => a = value; }
        public int Pts { get => pts; set => pts = value; }
    }
}
