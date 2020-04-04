using System;
using System.Windows.Forms;

namespace PJII_Project
{
    public partial class Form : System.Windows.Forms.Form
    {
        Healthy patients_h;
        Infected patients_i;
        Human human_current;
        string state;
        int lenght;
        int lenght_i, lenght_h;

        public Form()
        {
            patients_h = new Healthy();
            patients_i = new Infected();
            state = "all";

            InitializeComponent();
        }
        private void populateRows()
        {
            try
            {
                patients_h.populate();
                patients_i.populate();
                main_table.Rows.Clear();

                if (this.state == "all")
                {
                    foreach (string[] row in patients_i.getRows())
                    {
                        main_table.Rows.Add(row);
                        this.lenght_i++;
                    }

                    foreach (string[] row in patients_h.getRows())
                    {
                        main_table.Rows.Add(row);
                        this.lenght_h++;
                    }

                    this.lenght = main_table.Rows.Count;
                }
                else
                {
                    if (this.state == "infected")
                    {
                        foreach (string[] row in patients_i.getRows())
                        {
                            main_table.Rows.Add(row);
                        }

                        this.lenght = main_table.Rows.Count;
                        this.lenght_i = this.lenght;
                    }
                    else
                    {
                        foreach (string[] row in patients_h.getRows())
                        {
                            main_table.Rows.Add(row);
                        }

                        this.lenght = main_table.Rows.Count;
                        this.lenght_h = this.lenght;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rows not populated successfully. Message: " + ex.Message + ", " + ex.Source);
            }
        }
        private void Form_Load(object sender, EventArgs e)
        {
            populateRows();
        }
        private void button_infected_Click(object sender, EventArgs e)
        {
            state = "infected";
            populateRows();
        }
        private void button_healthy_Click(object sender, EventArgs e)
        {
            state = "healthy";
            populateRows();
        }
        private void button_all_Click(object sender, EventArgs e)
        {
            state = "all";
            populateRows();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string[] name = textBox_name.Text.Split(' ');
                Human newHuman = new Human()
                {
                    First_name = name[0],
                    Last_name = name[1],
                    Age = Int32.Parse(textBox_age.Text),
                    Height = Int32.Parse(textBox_height.Text),
                    Weight = Int32.Parse(textBox_weight.Text),
                    High_risk = checkBox_in_risk.Checked,
                    In_quarantine = checkBox_in_quarantine.Checked,
                    Condition = textBox_condition.Text
                };

                this.patients_h.checkLength();
                this.patients_i.checkLength();
                
                if (newHuman.Condition == "healthy") patients_h[this.lenght_h] = newHuman;
                else patients_i[this.lenght_i] = newHuman;

                main_table.Rows.Add(newHuman.getRow());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cell not added successfully. Message: " + ex.Message + ", " + ex.Source);
            }
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] name = textBox_name.Text.Split(' ');
                Human newHuman = new Human()
                {
                    First_name = name[0],
                    Last_name = name[1],
                    Age = Int32.Parse(textBox_age.Text),
                    Height = Int32.Parse(textBox_height.Text),
                    Weight = Int32.Parse(textBox_weight.Text),
                    High_risk = checkBox_in_risk.Checked,
                    In_quarantine = checkBox_in_quarantine.Checked,
                    Condition = textBox_condition.Text
                };

                if (!patients_i.edit(this.human_current, newHuman)) patients_h.edit(this.human_current, newHuman);

                var selectedRow = main_table.SelectedRows[0].Cells;
                selectedRow[0].Value = textBox_name.Text;
                selectedRow[1].Value = textBox_age.Text;
                selectedRow[2].Value = textBox_weight.Text;
                selectedRow[3].Value = textBox_height.Text;
                selectedRow[4].Value = checkBox_in_risk.Checked;
                selectedRow[5].Value = checkBox_in_quarantine.Checked;
                selectedRow[6].Value = textBox_condition.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cell not edited successfully. Message: " + ex.Message + ", " + ex.Source);
            }
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in main_table.SelectedRows)
                {
                    string[] name = row.Cells[0].Value.ToString().Split(' ');
                    Human selectedHuman = new Human()
                    {
                        First_name = name[0],
                        Last_name = name[1],
                        Age = Int32.Parse(row.Cells[1].Value.ToString()),
                        Weight = Int32.Parse(row.Cells[2].Value.ToString()),
                        Height = Int32.Parse(row.Cells[3].Value.ToString()),
                        High_risk = bool.Parse(row.Cells[4].Value.ToString()),
                        In_quarantine = bool.Parse(row.Cells[5].Value.ToString()),
                        Condition = row.Cells[6].Value.ToString()
                    };

                    if (!patients_i.remove(selectedHuman)) patients_h.remove(selectedHuman);

                    main_table.Rows.RemoveAt(row.Index);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cell not removed successfully. Message: " + ex.Message + ", " + ex.Source);
            }
        }

        private void main_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = main_table.SelectedRows[0].Cells;
                textBox_name.Text = selectedRow[0].Value.ToString();
                textBox_age.Text = selectedRow[1].Value.ToString();
                textBox_weight.Text = selectedRow[2].Value.ToString();
                textBox_height.Text = selectedRow[3].Value.ToString();
                checkBox_in_risk.Checked = bool.Parse(selectedRow[4].Value.ToString());
                checkBox_in_quarantine.Checked = bool.Parse(selectedRow[5].Value.ToString());
                textBox_condition.Text = selectedRow[6].Value.ToString();

                string[] name = textBox_name.Text.Split(' ');
                this.human_current = new Human()
                {
                    First_name = name[0],
                    Last_name = name[1],
                    Age = Int32.Parse(textBox_age.Text),
                    Height = Int32.Parse(textBox_height.Text),
                    Weight = Int32.Parse(textBox_weight.Text),
                    High_risk = checkBox_in_risk.Checked,
                    In_quarantine = checkBox_in_quarantine.Checked,
                    Condition = textBox_condition.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cell not extracted successfully. Message: " + ex.Message + ", " + ex.Source);
            }
        }
    }
}
