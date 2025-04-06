namespace HospitalOPD
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            var font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            // 
            // labelName
            // 
            this.labelName.Text = "Patient Name:";
            this.labelName.Location = new System.Drawing.Point(40, 30);
            this.labelName.Size = new System.Drawing.Size(120, 30);
            this.labelName.Font = font;

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(180, 30);
            this.textBoxName.Size = new System.Drawing.Size(250, 30);
            this.textBoxName.Font = font;
            this.textBoxName.TabIndex = 0;

            // 
            // labelAge
            // 
            this.labelAge.Text = "Age:";
            this.labelAge.Location = new System.Drawing.Point(40, 80);
            this.labelAge.Size = new System.Drawing.Size(120, 30);
            this.labelAge.Font = font;

            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(180, 80);
            this.textBoxAge.Size = new System.Drawing.Size(250, 30);
            this.textBoxAge.Font = font;
            this.textBoxAge.TabIndex = 1;

            // 
            // labelGender
            // 
            this.labelGender.Text = "Gender:";
            this.labelGender.Location = new System.Drawing.Point(40, 130);
            this.labelGender.Size = new System.Drawing.Size(120, 30);
            this.labelGender.Font = font;

            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Location = new System.Drawing.Point(180, 130);
            this.comboBoxGender.Size = new System.Drawing.Size(250, 30);
            this.comboBoxGender.Font = font;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            this.comboBoxGender.SelectedIndex = 0;
            this.comboBoxGender.TabIndex = 2;

            // 
            // labelContact
            // 
            this.labelContact.Text = "Contact No:";
            this.labelContact.Location = new System.Drawing.Point(40, 180);
            this.labelContact.Size = new System.Drawing.Size(120, 30);
            this.labelContact.Font = font;

            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(180, 180);
            this.textBoxContact.Size = new System.Drawing.Size(250, 30);
            this.textBoxContact.Font = font;
            this.textBoxContact.TabIndex = 3;

            // 
            // labelDepartment
            // 
            this.labelDepartment.Text = "Department:";
            this.labelDepartment.Location = new System.Drawing.Point(40, 230);
            this.labelDepartment.Size = new System.Drawing.Size(120, 30);
            this.labelDepartment.Font = font;

            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Location = new System.Drawing.Point(180, 230);
            this.comboBoxDepartment.Size = new System.Drawing.Size(250, 30);
            this.comboBoxDepartment.Font = font;
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.Items.AddRange(new string[] { "General", "Cardiology", "Neurology", "Orthopedics" });
            this.comboBoxDepartment.SelectedIndex = 0;
            this.comboBoxDepartment.TabIndex = 4;

            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Location = new System.Drawing.Point(180, 290);
            this.buttonSubmit.Size = new System.Drawing.Size(100, 40);
            this.buttonSubmit.Font = font;
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);

            // 
            // buttonClear
            // 
            this.buttonClear.Text = "Clear";
            this.buttonClear.Location = new System.Drawing.Point(330, 290);
            this.buttonClear.Size = new System.Drawing.Size(100, 40);
            this.buttonClear.Font = font;
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClear);
            this.Font = font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital OPD Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
    }
}
