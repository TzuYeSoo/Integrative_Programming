namespace StudentGradeApplication
{
    partial class frmStudentGradeProgram
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
            this.name = new System.Windows.Forms.Label();
            this.Grades = new System.Windows.Forms.Label();
            this.Math = new System.Windows.Forms.Label();
            this.English = new System.Windows.Forms.Label();
            this.Science = new System.Windows.Forms.Label();
            this.Filipino = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.generate_grades = new System.Windows.Forms.Button();
            this.Name_T = new System.Windows.Forms.TextBox();
            this.EnglishG = new System.Windows.Forms.TextBox();
            this.MathG = new System.Windows.Forms.TextBox();
            this.ScienceG = new System.Windows.Forms.TextBox();
            this.FilipinoG = new System.Windows.Forms.TextBox();
            this.HistoryG = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name.Location = new System.Drawing.Point(31, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // Grades
            // 
            this.Grades.AutoSize = true;
            this.Grades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Grades.Location = new System.Drawing.Point(97, 97);
            this.Grades.Name = "Grades";
            this.Grades.Size = new System.Drawing.Size(71, 24);
            this.Grades.TabIndex = 2;
            this.Grades.Text = "Grades";
            // 
            // Math
            // 
            this.Math.AutoSize = true;
            this.Math.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Math.Location = new System.Drawing.Point(12, 171);
            this.Math.Name = "Math";
            this.Math.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Math.Size = new System.Drawing.Size(51, 24);
            this.Math.TabIndex = 3;
            this.Math.Text = "Math";
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.English.Location = new System.Drawing.Point(12, 124);
            this.English.Name = "English";
            this.English.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.English.Size = new System.Drawing.Size(73, 24);
            this.English.TabIndex = 9;
            this.English.Text = "English";
            // 
            // Science
            // 
            this.Science.AutoSize = true;
            this.Science.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Science.Location = new System.Drawing.Point(12, 224);
            this.Science.Name = "Science";
            this.Science.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Science.Size = new System.Drawing.Size(79, 24);
            this.Science.TabIndex = 10;
            this.Science.Text = "Science";
            // 
            // Filipino
            // 
            this.Filipino.AutoSize = true;
            this.Filipino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Filipino.Location = new System.Drawing.Point(12, 277);
            this.Filipino.Name = "Filipino";
            this.Filipino.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Filipino.Size = new System.Drawing.Size(71, 24);
            this.Filipino.TabIndex = 11;
            this.Filipino.Text = "Filipino";
            this.Filipino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.History.Location = new System.Drawing.Point(12, 335);
            this.History.Name = "History";
            this.History.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.History.Size = new System.Drawing.Size(67, 24);
            this.History.TabIndex = 12;
            this.History.Text = "History";
            // 
            // generate_grades
            // 
            this.generate_grades.Location = new System.Drawing.Point(12, 396);
            this.generate_grades.Name = "generate_grades";
            this.generate_grades.Size = new System.Drawing.Size(147, 42);
            this.generate_grades.TabIndex = 13;
            this.generate_grades.Text = "Generate Grades";
            this.generate_grades.UseVisualStyleBackColor = true;
            this.generate_grades.Click += new System.EventHandler(this.generate_grades_Click);
            // 
            // Name_T
            // 
            this.Name_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_T.Location = new System.Drawing.Point(101, 37);
            this.Name_T.Name = "Name_T";
            this.Name_T.Size = new System.Drawing.Size(534, 29);
            this.Name_T.TabIndex = 14;
            // 
            // EnglishG
            // 
            this.EnglishG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishG.Location = new System.Drawing.Point(101, 124);
            this.EnglishG.Name = "EnglishG";
            this.EnglishG.Size = new System.Drawing.Size(93, 29);
            this.EnglishG.TabIndex = 15;
            // 
            // MathG
            // 
            this.MathG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathG.Location = new System.Drawing.Point(101, 171);
            this.MathG.Name = "MathG";
            this.MathG.Size = new System.Drawing.Size(93, 29);
            this.MathG.TabIndex = 16;
            // 
            // ScienceG
            // 
            this.ScienceG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScienceG.Location = new System.Drawing.Point(101, 224);
            this.ScienceG.Name = "ScienceG";
            this.ScienceG.Size = new System.Drawing.Size(93, 29);
            this.ScienceG.TabIndex = 17;
            // 
            // FilipinoG
            // 
            this.FilipinoG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilipinoG.Location = new System.Drawing.Point(101, 277);
            this.FilipinoG.Name = "FilipinoG";
            this.FilipinoG.Size = new System.Drawing.Size(93, 29);
            this.FilipinoG.TabIndex = 18;
            // 
            // HistoryG
            // 
            this.HistoryG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryG.Location = new System.Drawing.Point(101, 335);
            this.HistoryG.Name = "HistoryG";
            this.HistoryG.Size = new System.Drawing.Size(93, 29);
            this.HistoryG.TabIndex = 19;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Result.Location = new System.Drawing.Point(283, 224);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 24);
            this.Result.TabIndex = 20;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStudentGradeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 475);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.HistoryG);
            this.Controls.Add(this.FilipinoG);
            this.Controls.Add(this.ScienceG);
            this.Controls.Add(this.MathG);
            this.Controls.Add(this.EnglishG);
            this.Controls.Add(this.Name_T);
            this.Controls.Add(this.generate_grades);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Filipino);
            this.Controls.Add(this.Science);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.Grades);
            this.Controls.Add(this.name);
            this.Name = "frmStudentGradeProgram";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Grades;
        private System.Windows.Forms.Label Math;
        private System.Windows.Forms.Label English;
        private System.Windows.Forms.Label Science;
        private System.Windows.Forms.Label Filipino;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Button generate_grades;
        private System.Windows.Forms.TextBox Name_T;
        private System.Windows.Forms.TextBox EnglishG;
        private System.Windows.Forms.TextBox MathG;
        private System.Windows.Forms.TextBox ScienceG;
        private System.Windows.Forms.TextBox FilipinoG;
        private System.Windows.Forms.TextBox HistoryG;
        private System.Windows.Forms.Label Result;
    }
}

