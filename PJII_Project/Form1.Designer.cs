namespace PJII_Project
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_all = new System.Windows.Forms.Button();
            this.button_infected = new System.Windows.Forms.Button();
            this.button_healthy = new System.Windows.Forms.Button();
            this.main_table = new System.Windows.Forms.DataGridView();
            this.human_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_quarantine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_condition = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.checkBox_in_risk = new System.Windows.Forms.CheckBox();
            this.checkBox_in_quarantine = new System.Windows.Forms.CheckBox();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).BeginInit();
            this.SuspendLayout();
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(12, 12);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(100, 44);
            this.button_all.TabIndex = 0;
            this.button_all.Text = "All";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_infected
            // 
            this.button_infected.Location = new System.Drawing.Point(118, 12);
            this.button_infected.Name = "button_infected";
            this.button_infected.Size = new System.Drawing.Size(100, 44);
            this.button_infected.TabIndex = 1;
            this.button_infected.Text = "Infected";
            this.button_infected.UseVisualStyleBackColor = true;
            this.button_infected.Click += new System.EventHandler(this.button_infected_Click);
            // 
            // button_healthy
            // 
            this.button_healthy.Location = new System.Drawing.Point(224, 12);
            this.button_healthy.Name = "button_healthy";
            this.button_healthy.Size = new System.Drawing.Size(100, 44);
            this.button_healthy.TabIndex = 2;
            this.button_healthy.Text = "Healthy";
            this.button_healthy.UseVisualStyleBackColor = true;
            this.button_healthy.Click += new System.EventHandler(this.button_healthy_Click);
            // 
            // main_table
            // 
            this.main_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.human_name,
            this.age,
            this.weight,
            this.height,
            this.risk,
            this.in_quarantine,
            this.condition});
            this.main_table.Location = new System.Drawing.Point(12, 153);
            this.main_table.Name = "main_table";
            this.main_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.main_table.Size = new System.Drawing.Size(556, 391);
            this.main_table.TabIndex = 13;
            this.main_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_table_CellContentClick);
            // 
            // human_name
            // 
            this.human_name.HeaderText = "Name";
            this.human_name.Name = "human_name";
            this.human_name.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 50;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 50;
            // 
            // height
            // 
            this.height.HeaderText = "Height";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Width = 50;
            // 
            // risk
            // 
            this.risk.HeaderText = "in Risk";
            this.risk.Name = "risk";
            this.risk.ReadOnly = true;
            this.risk.Width = 70;
            // 
            // in_quarantine
            // 
            this.in_quarantine.HeaderText = "in Quarantine";
            this.in_quarantine.Name = "in_quarantine";
            this.in_quarantine.ReadOnly = true;
            this.in_quarantine.Width = 90;
            // 
            // condition
            // 
            this.condition.HeaderText = "Condition";
            this.condition.Name = "condition";
            this.condition.ReadOnly = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(13, 67);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(119, 67);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(26, 13);
            this.label_age.TabIndex = 5;
            this.label_age.Text = "Age";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(159, 67);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(41, 13);
            this.label_weight.TabIndex = 5;
            this.label_weight.Text = "Weight";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(199, 67);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(38, 13);
            this.label_height.TabIndex = 5;
            this.label_height.Text = "Height";
            // 
            // label_condition
            // 
            this.label_condition.AutoSize = true;
            this.label_condition.Location = new System.Drawing.Point(397, 67);
            this.label_condition.Name = "label_condition";
            this.label_condition.Size = new System.Drawing.Size(51, 13);
            this.label_condition.TabIndex = 5;
            this.label_condition.Text = "Condition";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(16, 85);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(122, 85);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(32, 20);
            this.textBox_age.TabIndex = 4;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(162, 85);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(32, 20);
            this.textBox_weight.TabIndex = 5;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(202, 85);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(32, 20);
            this.textBox_height.TabIndex = 6;
            // 
            // checkBox_in_risk
            // 
            this.checkBox_in_risk.AutoSize = true;
            this.checkBox_in_risk.Location = new System.Drawing.Point(245, 86);
            this.checkBox_in_risk.Name = "checkBox_in_risk";
            this.checkBox_in_risk.Size = new System.Drawing.Size(58, 17);
            this.checkBox_in_risk.TabIndex = 7;
            this.checkBox_in_risk.Text = "in Risk";
            this.checkBox_in_risk.UseVisualStyleBackColor = true;
            // 
            // checkBox_in_quarantine
            // 
            this.checkBox_in_quarantine.AutoSize = true;
            this.checkBox_in_quarantine.Location = new System.Drawing.Point(305, 86);
            this.checkBox_in_quarantine.Name = "checkBox_in_quarantine";
            this.checkBox_in_quarantine.Size = new System.Drawing.Size(89, 17);
            this.checkBox_in_quarantine.TabIndex = 8;
            this.checkBox_in_quarantine.Text = "in Quarantine";
            this.checkBox_in_quarantine.UseVisualStyleBackColor = true;
            // 
            // textBox_condition
            // 
            this.textBox_condition.Location = new System.Drawing.Point(400, 85);
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.Size = new System.Drawing.Size(166, 20);
            this.textBox_condition.TabIndex = 9;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(16, 116);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 26);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(122, 116);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 26);
            this.button_edit.TabIndex = 11;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(228, 116);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(100, 26);
            this.button_remove.TabIndex = 12;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(580, 556);
            this.Controls.Add(this.checkBox_in_quarantine);
            this.Controls.Add(this.checkBox_in_risk);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_condition);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_condition);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_healthy);
            this.Controls.Add(this.button_infected);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.main_table);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_infected;
        private System.Windows.Forms.Button button_healthy;
        private System.Windows.Forms.DataGridView main_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn human_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_quarantine;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_condition;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.CheckBox checkBox_in_risk;
        private System.Windows.Forms.CheckBox checkBox_in_quarantine;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
    }
}

