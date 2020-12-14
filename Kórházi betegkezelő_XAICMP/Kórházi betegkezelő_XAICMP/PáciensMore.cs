using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kórházi_betegkezelő_XAICMP
{
    class PáciensMore
    {
        public int betegid { get; set; }
        public string jelenség { get; set; }
        public string diagnózis { get; set; }
        public string gyógyszer { get; set; }
        public string kellműtét { get; set; }
        public string műtéttípus { get; set; }

        public PáciensMore(int betegid, string jelenség, string diagnózis, string gyógyszer, string kellműtét, string műtéttípus)
        {
            this.betegid = betegid;
            this.jelenség = jelenség;
            this.diagnózis = diagnózis;
            this.gyógyszer = gyógyszer;
            this.kellműtét = kellműtét;
            this.műtéttípus = műtéttípus;
        }


    }

    
}
