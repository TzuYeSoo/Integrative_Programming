namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstName = new TextBox();
            MiddleName = new TextBox();
            LastName = new TextBox();
            Female = new RadioButton();
            Male = new RadioButton();
            Day = new ComboBox();
            Month = new ComboBox();
            Year = new ComboBox();
            Register = new Button();
            Student_Register = new Label();
            label1 = new Label();
            Date_Of_Birth = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Course = new ComboBox();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.Location = new Point(48, 128);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(367, 29);
            FirstName.TabIndex = 2;
            // 
            // MiddleName
            // 
            MiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MiddleName.Location = new Point(48, 181);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(367, 29);
            MiddleName.TabIndex = 3;
            // 
            // LastName
            // 
            LastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.Location = new Point(48, 234);
            LastName.Name = "LastName";
            LastName.Size = new Size(367, 29);
            LastName.TabIndex = 4;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.BackColor = Color.Transparent;
            Female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Female.Location = new Point(319, 280);
            Female.Name = "Female";
            Female.Size = new Size(78, 25);
            Female.TabIndex = 5;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = false;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.BackColor = Color.Transparent;
            Male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Male.Location = new Point(182, 280);
            Male.Name = "Male";
            Male.Size = new Size(62, 25);
            Male.TabIndex = 6;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = false;
            // 
            // Day
            // 
            Day.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Day.FormattingEnabled = true;
            Day.Location = new Point(48, 346);
            Day.Name = "Day";
            Day.Size = new Size(96, 28);
            Day.TabIndex = 7;
            Day.Text = "Day";
            // 
            // Month
            // 
            Month.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Month.FormattingEnabled = true;
            Month.Location = new Point(182, 346);
            Month.Name = "Month";
            Month.Size = new Size(96, 28);
            Month.TabIndex = 8;
            Month.Text = "Month";
            // 
            // Year
            // 
            Year.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Year.FormattingEnabled = true;
            Year.Location = new Point(319, 346);
            Year.Name = "Year";
            Year.Size = new Size(96, 28);
            Year.TabIndex = 9;
            Year.Text = "Year";
            // 
            // Register
            // 
            Register.BackColor = Color.Crimson;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register.ForeColor = SystemColors.ButtonHighlight;
            Register.Location = new Point(48, 487);
            Register.Name = "Register";
            Register.Size = new Size(167, 38);
            Register.TabIndex = 10;
            Register.Text = "Regiter Student";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // Student_Register
            // 
            Student_Register.AutoSize = true;
            Student_Register.BackColor = Color.Transparent;
            Student_Register.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Student_Register.Location = new Point(112, 60);
            Student_Register.Name = "Student_Register";
            Student_Register.Size = new Size(222, 20);
            Student_Register.TabIndex = 11;
            Student_Register.Text = "Student Registration Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 287);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 12;
            label1.Text = "Gender*";
            // 
            // Date_Of_Birth
            // 
            Date_Of_Birth.AutoSize = true;
            Date_Of_Birth.BackColor = Color.Transparent;
            Date_Of_Birth.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Date_Of_Birth.Location = new Point(48, 324);
            Date_Of_Birth.Name = "Date_Of_Birth";
            Date_Of_Birth.Size = new Size(136, 18);
            Date_Of_Birth.TabIndex = 13;
            Date_Of_Birth.Text = "Date of Birth *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 105);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 14;
            label2.Text = "First name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 159);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 15;
            label3.Text = "Last name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 211);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 16;
            label4.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 403);
            label5.Name = "label5";
            label5.Size = new Size(177, 18);
            label5.TabIndex = 17;
            label5.Text = "Program to Apply *";
            // 
            // Course
            // 
            Course.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Course.FormattingEnabled = true;
            Course.Location = new Point(48, 440);
            Course.Name = "Course";
            Course.Size = new Size(367, 28);
            Course.TabIndex = 18;
            Course.Text = "Program";
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3;
            ClientSize = new Size(443, 537);
            Controls.Add(Course);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Date_Of_Birth);
            Controls.Add(label1);
            Controls.Add(Student_Register);
            Controls.Add(Register);
            Controls.Add(Year);
            Controls.Add(Month);
            Controls.Add(Day);
            Controls.Add(Male);
            Controls.Add(Female);
            Controls.Add(LastName);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Name = "frmStudentRegistration";
            Text = "Form1";
            Load += frmStudentRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstName;
        private TextBox MiddleName;
        private TextBox LastName;
        private RadioButton Female;
        private RadioButton Male;
        private ComboBox Day;
        private ComboBox Month;
        private ComboBox Year;
        private Button Register;
        private Label Student_Register;
        private Label label1;
        private Label Date_Of_Birth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox Course;
    }
}