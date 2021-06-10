
namespace AnketWinForm
{
    partial class Form1
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Language = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Russaincheckbox = new System.Windows.Forms.CheckBox();
            this.Englushcheckbx = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.OtherRadiButton = new System.Windows.Forms.RadioButton();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.fathernametextbox = new System.Windows.Forms.TextBox();
            this.Fathernamelabel = new System.Windows.Forms.Label();
            this.adresstextbox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BirthDatelabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Language.SuspendLayout();
            this.Gender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(147, 53);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(129, 30);
            this.NameTextBox.TabIndex = 0;
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Location = new System.Drawing.Point(147, 104);
            this.SurnametextBox.Multiline = true;
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(129, 24);
            this.SurnametextBox.TabIndex = 1;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(147, 157);
            this.agetextBox.Multiline = true;
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(129, 26);
            this.agetextBox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Language
            // 
            this.Language.Controls.Add(this.checkBox1);
            this.Language.Controls.Add(this.Russaincheckbox);
            this.Language.Controls.Add(this.Englushcheckbx);
            this.Language.Location = new System.Drawing.Point(357, 13);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(240, 134);
            this.Language.TabIndex = 6;
            this.Language.TabStop = false;
            this.Language.Text = "Language";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Turkey";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Russaincheckbox
            // 
            this.Russaincheckbox.AutoSize = true;
            this.Russaincheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Russaincheckbox.Location = new System.Drawing.Point(18, 55);
            this.Russaincheckbox.Name = "Russaincheckbox";
            this.Russaincheckbox.Size = new System.Drawing.Size(86, 24);
            this.Russaincheckbox.TabIndex = 1;
            this.Russaincheckbox.Text = "Russain";
            this.Russaincheckbox.UseVisualStyleBackColor = true;
            // 
            // Englushcheckbx
            // 
            this.Englushcheckbx.AutoSize = true;
            this.Englushcheckbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Englushcheckbx.Location = new System.Drawing.Point(18, 19);
            this.Englushcheckbx.Name = "Englushcheckbx";
            this.Englushcheckbx.Size = new System.Drawing.Size(80, 24);
            this.Englushcheckbx.TabIndex = 0;
            this.Englushcheckbx.Text = "English";
            this.Englushcheckbx.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.OtherRadiButton);
            this.Gender.Controls.Add(this.FemaleradioButton);
            this.Gender.Controls.Add(this.MaleRadioButton);
            this.Gender.Location = new System.Drawing.Point(357, 224);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(200, 100);
            this.Gender.TabIndex = 7;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // OtherRadiButton
            // 
            this.OtherRadiButton.AutoSize = true;
            this.OtherRadiButton.Location = new System.Drawing.Point(106, 34);
            this.OtherRadiButton.Name = "OtherRadiButton";
            this.OtherRadiButton.Size = new System.Drawing.Size(51, 17);
            this.OtherRadiButton.TabIndex = 2;
            this.OtherRadiButton.TabStop = true;
            this.OtherRadiButton.Text = "Other";
            this.OtherRadiButton.UseVisualStyleBackColor = true;
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(6, 53);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleradioButton.TabIndex = 1;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(7, 20);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(462, 170);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 32);
            this.textBox6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Other Language";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(79, 63);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(56, 108);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(74, 20);
            this.SurnameLabel.TabIndex = 11;
            this.SurnameLabel.Text = "Surname";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(92, 163);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 20);
            this.AgeLabel.TabIndex = 12;
            this.AgeLabel.Text = "Age";
            // 
            // fathernametextbox
            // 
            this.fathernametextbox.Location = new System.Drawing.Point(147, 211);
            this.fathernametextbox.Multiline = true;
            this.fathernametextbox.Name = "fathernametextbox";
            this.fathernametextbox.Size = new System.Drawing.Size(129, 26);
            this.fathernametextbox.TabIndex = 13;
            // 
            // Fathernamelabel
            // 
            this.Fathernamelabel.AutoSize = true;
            this.Fathernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fathernamelabel.Location = new System.Drawing.Point(30, 217);
            this.Fathernamelabel.Name = "Fathernamelabel";
            this.Fathernamelabel.Size = new System.Drawing.Size(111, 20);
            this.Fathernamelabel.TabIndex = 14;
            this.Fathernamelabel.Text = "Father\'s name";
            // 
            // adresstextbox
            // 
            this.adresstextbox.Location = new System.Drawing.Point(147, 257);
            this.adresstextbox.Multiline = true;
            this.adresstextbox.Name = "adresstextbox";
            this.adresstextbox.Size = new System.Drawing.Size(129, 26);
            this.adresstextbox.TabIndex = 15;
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.Location = new System.Drawing.Point(71, 255);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(59, 20);
            this.AdressLabel.TabIndex = 16;
            this.AdressLabel.Text = "Adress";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BirthDatelabel);
            this.groupBox1.Controls.Add(this.agetextBox);
            this.groupBox1.Controls.Add(this.AdressLabel);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.adresstextbox);
            this.groupBox1.Controls.Add(this.SurnametextBox);
            this.groupBox1.Controls.Add(this.Fathernamelabel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.fathernametextbox);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.AgeLabel);
            this.groupBox1.Controls.Add(this.SurnameLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 414);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BirthDatelabel
            // 
            this.BirthDatelabel.AutoSize = true;
            this.BirthDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDatelabel.Location = new System.Drawing.Point(6, 326);
            this.BirthDatelabel.Name = "BirthDatelabel";
            this.BirthDatelabel.Size = new System.Drawing.Size(77, 20);
            this.BirthDatelabel.TabIndex = 17;
            this.BirthDatelabel.Text = "BirthDate";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(551, 377);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 46);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(426, 385);
            this.FileNameBox.Multiline = true;
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(112, 26);
            this.FileNameBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Language);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Language.ResumeLayout(false);
            this.Language.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SurnametextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Language;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox Russaincheckbox;
        private System.Windows.Forms.CheckBox Englushcheckbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton OtherRadiButton;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox fathernametextbox;
        private System.Windows.Forms.Label Fathernamelabel;
        private System.Windows.Forms.TextBox adresstextbox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BirthDatelabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox agetextBox;
    }
}

