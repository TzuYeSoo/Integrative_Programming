namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.JT = new System.Windows.Forms.TextBox();
            this.Dep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RPH = new System.Windows.Forms.TextBox();
            this.HW = new System.Windows.Forms.TextBox();
            this.Compute_Sal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Fname_dis = new System.Windows.Forms.Label();
            this.Basic_sal = new System.Windows.Forms.Label();
            this.lname_dis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(63, 68);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(167, 20);
            this.fname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours Work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Job Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(282, 68);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(171, 20);
            this.Lname.TabIndex = 6;
            // 
            // JT
            // 
            this.JT.Location = new System.Drawing.Point(282, 107);
            this.JT.Name = "JT";
            this.JT.Size = new System.Drawing.Size(171, 20);
            this.JT.TabIndex = 7;
            // 
            // Dep
            // 
            this.Dep.Location = new System.Drawing.Point(63, 107);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(167, 20);
            this.Dep.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rate Per Hours";
            // 
            // RPH
            // 
            this.RPH.Location = new System.Drawing.Point(282, 186);
            this.RPH.Name = "RPH";
            this.RPH.Size = new System.Drawing.Size(171, 20);
            this.RPH.TabIndex = 10;
            // 
            // HW
            // 
            this.HW.Location = new System.Drawing.Point(63, 186);
            this.HW.Name = "HW";
            this.HW.Size = new System.Drawing.Size(167, 20);
            this.HW.TabIndex = 11;
            // 
            // Compute_Sal
            // 
            this.Compute_Sal.Location = new System.Drawing.Point(166, 242);
            this.Compute_Sal.Name = "Compute_Sal";
            this.Compute_Sal.Size = new System.Drawing.Size(160, 23);
            this.Compute_Sal.TabIndex = 12;
            this.Compute_Sal.Text = "Compute Salary";
            this.Compute_Sal.UseVisualStyleBackColor = true;
            this.Compute_Sal.Click += new System.EventHandler(this.Compute_Sal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Basic Salary:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Last Name:";
            // 
            // Fname_dis
            // 
            this.Fname_dis.AutoSize = true;
            this.Fname_dis.Location = new System.Drawing.Point(122, 292);
            this.Fname_dis.Name = "Fname_dis";
            this.Fname_dis.Size = new System.Drawing.Size(0, 13);
            this.Fname_dis.TabIndex = 17;
            // 
            // Basic_sal
            // 
            this.Basic_sal.AutoSize = true;
            this.Basic_sal.Location = new System.Drawing.Point(130, 345);
            this.Basic_sal.Name = "Basic_sal";
            this.Basic_sal.Size = new System.Drawing.Size(0, 13);
            this.Basic_sal.TabIndex = 18;
            // 
            // lname_dis
            // 
            this.lname_dis.AutoSize = true;
            this.lname_dis.Location = new System.Drawing.Point(123, 319);
            this.lname_dis.Name = "lname_dis";
            this.lname_dis.Size = new System.Drawing.Size(0, 13);
            this.lname_dis.TabIndex = 19;
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 384);
            this.Controls.Add(this.lname_dis);
            this.Controls.Add(this.Basic_sal);
            this.Controls.Add(this.Fname_dis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Compute_Sal);
            this.Controls.Add(this.HW);
            this.Controls.Add(this.RPH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.JT);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Name = "frmComputeSalary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox JT;
        private System.Windows.Forms.TextBox Dep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RPH;
        private System.Windows.Forms.TextBox HW;
        private System.Windows.Forms.Button Compute_Sal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Fname_dis;
        private System.Windows.Forms.Label Basic_sal;
        private System.Windows.Forms.Label lname_dis;
    }
}

