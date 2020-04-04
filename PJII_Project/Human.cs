using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PJII_Project
{
    class Human
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public bool? High_risk { get; set; }
        public bool? In_quarantine { get; set; }
        public string Condition { get; set; }
        public XmlNode Human_xml { get; set; }

        public string[] getRow()
        {
            string[] row = new string[7];
            try
            {
                row[0] = First_name + " " + Last_name;
                row[1] = Age.ToString();
                row[2] = Weight.ToString();
                row[3] = Height.ToString();
                row[4] = High_risk.ToString();
                row[5] = In_quarantine.ToString();
                row[6] = Condition.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Row not extracted successfully. Message: " + ex.Message + ", " + ex.Source);
            }

            return row;
        }
        public override string ToString() => $"{First_name} {Last_name}";
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Human human = (Human)obj;
                if (this.First_name.Equals(human.First_name) &&
                    this.Last_name.Equals(human.Last_name) &&
                    this.Age.Equals(human.Age) &&
                    this.Weight.Equals(human.Weight) &&
                    this.Height.Equals(human.Height) &&
                    this.High_risk.Equals(human.High_risk) &&
                    this.In_quarantine.Equals(human.In_quarantine) &&
                    this.Condition.Equals(human.Condition))
                {
                    return true;
                }
            }
            return false;
        }
        public void generate_xml(XmlDocument xmlDoc)
        {
            this.Human_xml = xmlDoc.CreateElement("human");

            XmlAttribute attribute = xmlDoc.CreateAttribute("first_name");
            attribute.Value = this.First_name;
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("last_name");
            attribute.Value = this.Last_name;
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = this.Age.ToString();
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("weight");
            attribute.Value = this.Weight.ToString();
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("height");
            attribute.Value = this.Height.ToString();
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("high_risk");
            attribute.Value = this.High_risk.ToString();
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("in_quarantine");
            attribute.Value = this.In_quarantine.ToString();
            this.Human_xml.Attributes.Append(attribute);

            attribute = xmlDoc.CreateAttribute("condition");
            attribute.Value = this.Condition.ToString();
            this.Human_xml.Attributes.Append(attribute);

        }
    }
}
