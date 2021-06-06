
namespace Fislab_Project
{
    partial class Fglb
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.tbclue1 = new System.Windows.Forms.TextBox();
            this.clue1 = new System.Windows.Forms.Label();
            this.clue2 = new System.Windows.Forms.Label();
            this.tbclue2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.tbanswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(307, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tbclue1
            // 
            this.tbclue1.Location = new System.Drawing.Point(169, 226);
            this.tbclue1.Name = "tbclue1";
            this.tbclue1.Size = new System.Drawing.Size(169, 23);
            this.tbclue1.TabIndex = 2;
            // 
            // clue1
            // 
            this.clue1.AutoSize = true;
            this.clue1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue1.Location = new System.Drawing.Point(68, 228);
            this.clue1.Name = "clue1";
            this.clue1.Size = new System.Drawing.Size(47, 21);
            this.clue1.TabIndex = 3;
            this.clue1.Text = "clue1";
            // 
            // clue2
            // 
            this.clue2.AutoSize = true;
            this.clue2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue2.Location = new System.Drawing.Point(68, 257);
            this.clue2.Name = "clue2";
            this.clue2.Size = new System.Drawing.Size(47, 21);
            this.clue2.TabIndex = 5;
            this.clue2.Text = "clue2";
            // 
            // tbclue2
            // 
            this.tbclue2.Location = new System.Drawing.Point(169, 255);
            this.tbclue2.Name = "tbclue2";
            this.tbclue2.Size = new System.Drawing.Size(169, 23);
            this.tbclue2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Velocity",
            "Time",
            "Distance"});
            this.comboBox1.Location = new System.Drawing.Point(68, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(68, 300);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(270, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer.Location = new System.Drawing.Point(68, 354);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(60, 21);
            this.answer.TabIndex = 9;
            this.answer.Text = "answer";
            // 
            // tbanswer
            // 
            this.tbanswer.Location = new System.Drawing.Point(169, 352);
            this.tbanswer.Name = "tbanswer";
            this.tbanswer.ReadOnly = true;
            this.tbanswer.Size = new System.Drawing.Size(169, 23);
            this.tbanswer.TabIndex = 8;
            // 
            // Fglb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(394, 501);
            this.ControlBox = false;
            this.Controls.Add(this.answer);
            this.Controls.Add(this.tbanswer);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clue2);
            this.Controls.Add(this.tbclue2);
            this.Controls.Add(this.clue1);
            this.Controls.Add(this.tbclue1);
            this.Controls.Add(this.btnMenu);
            this.Name = "Fglb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fglb";
            this.Load += new System.EventHandler(this.Fglb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox tbclue1;
        private System.Windows.Forms.Label clue1;
        private System.Windows.Forms.Label clue2;
        private System.Windows.Forms.TextBox tbclue2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox tbanswer;
    }
}