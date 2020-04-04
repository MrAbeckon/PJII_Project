using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PJII_Project
{
    class Healthy : Patients
    {
        public Healthy(int count = 6) : base(count)
        {
            this.xmlFilename = "C:\\Users\\marti\\source\\repos\\PJII_Project\\PJII_Project\\healthy.xml";
            this.xmlDoc = new XmlDocument();
        }
    }
}
