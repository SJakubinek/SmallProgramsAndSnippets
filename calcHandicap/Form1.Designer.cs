namespace calcHandicap
{
    partial class frmCalcHandicap
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCourse = new System.Windows.Forms.Label();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblHandicap = new System.Windows.Forms.Label();
            this.txtBoxHandicap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(50, 47);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(153, 13);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Which course did you play on?";
            // 
            // comboCourse
            // 
            this.comboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Location = new System.Drawing.Point(209, 44);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(185, 21);
            this.comboCourse.Sorted = true;
            this.comboCourse.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "What\'s your name?";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(209, 71);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(185, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(209, 97);
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(185, 20);
            this.txtBoxScore.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(50, 100);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(98, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "What\'s your score?";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(184, 139);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblHandicap
            // 
            this.lblHandicap.AutoSize = true;
            this.lblHandicap.Location = new System.Drawing.Point(50, 187);
            this.lblHandicap.Name = "lblHandicap";
            this.lblHandicap.Size = new System.Drawing.Size(112, 13);
            this.lblHandicap.TabIndex = 7;
            this.lblHandicap.Text = "Your new handicap is:";
            // 
            // txtBoxHandicap
            // 
            this.txtBoxHandicap.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxHandicap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHandicap.Location = new System.Drawing.Point(209, 184);
            this.txtBoxHandicap.Name = "txtBoxHandicap";
            this.txtBoxHandicap.ReadOnly = true;
            this.txtBoxHandicap.Size = new System.Drawing.Size(185, 13);
            this.txtBoxHandicap.TabIndex = 8;
            this.txtBoxHandicap.TabStop = false;
            this.txtBoxHandicap.Text = "0,0";
            // 
            // frmCalcHandicap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 251);
            this.Controls.Add(this.txtBoxHandicap);
            this.Controls.Add(this.lblHandicap);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.lblCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalcHandicap";
            this.ShowIcon = false;
            this.Text = "calcHandicap";
            this.Load += new System.EventHandler(this.frmCalcHandicap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblHandicap;
        private System.Windows.Forms.TextBox txtBoxHandicap;
        internal System.Windows.Forms.ComboBox comboCourse;
    }
}

