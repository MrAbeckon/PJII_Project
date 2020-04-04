using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PJII_Project
{
    class Infected : Patients
    {
        public Infected(int count = 6) : base(count)
        {
            this.xmlFilename = "C:\\Users\\marti\\source\\repos\\PJII_Project\\PJII_Project\\infected.xml";
            this.xmlDoc = new XmlDocument();
        }
    }
}
