using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNM_DX_People_Counter
{
    public class MotionSensorDocument
    {
        public string id { get; set; }
        public int kiosk { get; set; }
        public List<string> visits { get; set; }
    }

    public class CameraSensorDocument
    {
        public string id { get; set; }
        public int kiosk { get; set; }
        public string description { get; set; }
        public string product { get; set; }
        public double unitPrice { get; set; }
        public int unitsRemaining { get; set; }
        public List<Visit> visits { get; set; }
    }

    public class Visit
    {
        public int ageOfPerson { get; set; }
        public DateTime date { get; set; }
        public string gender { get; set; }
    }
}
