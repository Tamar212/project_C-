using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public partial class Kindergarten
    {
        public KindergartenCommon ConvertToCommon(Kindergarten kindergarten)
        {
            KindergartenCommon kindergartenCommon = new KindergartenCommon();
            kindergartenCommon.Institution_number = kindergarten.Institution_number;
            kindergartenCommon.Name_Kindergarten = kindergarten.Name_Kindergarten;
            kindergartenCommon.Adress_Kindergarten = kindergarten.Adress_Kindergarten;
            kindergartenCommon.type_Kindergarten = kindergarten.type_Kindergarten;

            return kindergartenCommon;
        }

        public Kindergarten ConvertFromCommon(KindergartenCommon kindergartenCommon)
        {
            Kindergarten kindergarten = new Kindergarten();
            kindergarten.Institution_number = kindergartenCommon.Institution_number;
            kindergarten.Name_Kindergarten = kindergartenCommon.Name_Kindergarten;
            kindergarten.Adress_Kindergarten = kindergartenCommon.Adress_Kindergarten;
            kindergarten.type_Kindergarten = kindergartenCommon.type_Kindergarten;

            return kindergarten;
        }
    }
}
