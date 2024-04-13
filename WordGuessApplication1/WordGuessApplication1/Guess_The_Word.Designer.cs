namespace WordGuessApplication1
{
    partial class Guess_The_Word
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Answer = new System.Windows.Forms.TextBox();
            this.Words = new System.Windows.Forms.Label();
            this.GuessBut = new System.Windows.Forms.Button();
            this.IncoAns = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Answer.Location = new System.Drawing.Point(40, 202);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(282, 29);
            this.Answer.TabIndex = 1;
            // 
            // Words
            // 
            this.Words.AutoSize = true;
            this.Words.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Words.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Words.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Words.Location = new System.Drawing.Point(121, 129);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(86, 31);
            this.Words.TabIndex = 2;
            this.Words.Text = "label1";
            // 
            // GuessBut
            // 
            this.GuessBut.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GuessBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GuessBut.Location = new System.Drawing.Point(114, 237);
            this.GuessBut.Name = "GuessBut";
            this.GuessBut.Size = new System.Drawing.Size(130, 27);
            this.GuessBut.TabIndex = 3;
            this.GuessBut.Text = "Guess";
            this.GuessBut.UseVisualStyleBackColor = false;
            this.GuessBut.Click += new System.EventHandler(this.GuessBut_Click);
            // 
            // IncoAns
            // 
            this.IncoAns.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.IncoAns.FormattingEnabled = true;
            this.IncoAns.Location = new System.Drawing.Point(351, 65);
            this.IncoAns.Name = "IncoAns";
            this.IncoAns.Size = new System.Drawing.Size(120, 199);
            this.IncoAns.TabIndex = 4;
            // 
            // Guess_The_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(497, 323);
            this.Controls.Add(this.IncoAns);
            this.Controls.Add(this.GuessBut);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Answer);
            this.Name = "Guess_The_Word";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Words;
        private System.Windows.Forms.Button GuessBut;
        private System.Windows.Forms.ListBox IncoAns;
    }
}

