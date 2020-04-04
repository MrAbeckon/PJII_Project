using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PJII_Project
{
    abstract class Patients
    {
        protected enum State
        {
            Empty = 1,
            HalfEmpty = 2,
            Full = 3
        }
        protected State state
        {
            get { return State.Empty; }
        }
        protected Human[] patients;
        protected XmlDocument xmlDoc;
        protected String xmlFilename;
        protected int Length
        {
            get { return this.patients.Length; }
            set
            {
                if (value < this.patients.Length)
                {
                    throw new System.InvalidOperationException("Array can't be reduced.");
                }
                else
                {
                    resize(value);
                }
            }
        }

        public Patients(int count = 6)
        {
            this.patients = new Human[count];
        }
        public Human this[int i]
        {
            get { return this.patients[i]; }
            set {
                this.patients[i] = value;
                value.generate_xml(this.xmlDoc);
                xmlDoc.DocumentElement.AppendChild(value.Human_xml);
                xmlDoc.Save(this.xmlFilename);
            }
        }
        protected void resize(int newLength)
        {
            Human[] patients = new Human[newLength];
            Array.Copy(this.patients, patients, this.patients.Length);
            this.patients = patients;
        }
        public void checkLength()
        {
            if (this.Length >= this.patients.Length) this.Length *= 2;
        }
        public bool remove(Human patient)
        {
            try
            {
                patient.generate_xml(this.xmlDoc);

                int i = 0;
                foreach (Human human in this.patients)
                {
                    if (human != null && human.Equals(patient))
                    {
                        this.patients[i] = null;
                        break;
                    }
                    i++;
                }

                if (i == this.Length) return false;

                foreach (XmlNode node in this.xmlDoc.DocumentElement.ChildNodes)
                {
                    if (patient.Human_xml.InnerXml.Equals(node.InnerXml))
                    {
                        this.xmlDoc.DocumentElement.RemoveChild(node);
                        this.xmlDoc.Save(this.xmlFilename);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Patient removed not successfully. Message: " + ex.Message + ", " + ex.Source);
            }

            return false;
        }
        public bool edit(Human old_patient, Human patient)
        {
            try
            {
                old_patient.generate_xml(this.xmlDoc);
                patient.generate_xml(this.xmlDoc);

                int i = 0;
                foreach (Human human in this.patients)
                {
                    if (human != null && human.Equals(old_patient))
                    {
                        this.patients[i] = patient;
                        break;
                    }
                    i++;
                }

                if (i == this.Length) return false;

                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    if (old_patient.Human_xml.InnerXml.Equals(node.InnerXml))
                    {
                        xmlDoc.DocumentElement.ReplaceChild(patient.Human_xml, node);
                        xmlDoc.Save(this.xmlFilename);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Patient edited not successfully. Message: " + ex.Message + ", " + ex.Source);
            }

            return false;
        }
        public object[] getRows()
        {
            object[] rows = null;
            
            try
            {
                int count = 0;
                foreach (Human human in this.patients)
                {
                    if (human != null) count++;
                }
                rows = new object[count];

                int i = 0;
                foreach (Human human in this.patients)
                {
                    if (human != null)
                    {
                        rows[i] = human.getRow();
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Rows not extracted successfully. Message: " + ex.Message + ", " + ex.Source);
            }
            
            return rows;
        }
        public void populate() 
        {
            try
            {
                this.xmlDoc.Load(this.xmlFilename);
                if (xmlDoc.DocumentElement.ChildNodes.Count >= this.Length)
                    this.Length = xmlDoc.DocumentElement.ChildNodes.Count;
                Array.Clear(this.patients, 0, this.Length);

                int i = 0;
                foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                {
                    this.patients[i] = new Human()
                    {
                        First_name = node.Attributes["first_name"].Value,
                        Last_name = node.Attributes["last_name"].Value,
                        Age = Int32.Parse(node.Attributes["age"].Value),
                        Weight = Int32.Parse(node.Attributes["weight"].Value),
                        Height = Int32.Parse(node.Attributes["height"].Value),
                        High_risk = bool.Parse(node.Attributes["high_risk"].Value),
                        In_quarantine = bool.Parse(node.Attributes["in_quarantine"].Value),
                        Condition = node.Attributes["condition"].Value,
                        Human_xml = node
                    };
                    i++;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Cell not extracted successfully. Message: " + ex.Message + ", " + ex.Source);
            }
        }

        public IEnumerator<Human> GetEnumerator()
        {
            for (int i = 0; i < this.patients.Length; i++)
                yield return this.patients[i];
        }

    }
}
