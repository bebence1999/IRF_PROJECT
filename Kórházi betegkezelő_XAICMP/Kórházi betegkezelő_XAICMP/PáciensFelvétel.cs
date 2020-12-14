using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kórházi_betegkezelő_XAICMP
{
    class PáciensFelvétel
    {
        public string név { get; set; }
        public string cím { get; set; }
        public string kontakt { get; set; }
        public string kor { get; set; }
        public string nem { get; set; }
        public string vércsoport { get; set; }
        public string korábbibetegség { get; set; }
        public int betegid { get; set; }

        public PáciensFelvétel(string név, string cím, string kontakt, string kor, string nem, string vércsoport, string korábbibetegség, int betegid)
        {


            this.név = név;
            this.cím = cím;
            this.kontakt = kontakt;
            this.kor = kor;
            this.nem = nem;
            this.vércsoport = vércsoport;
            this.korábbibetegség = korábbibetegség;
            this.betegid = betegid;
        }




    }
}
