
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.PanelInput = new System.Windows.Forms.Panel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.PanelInput.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(212, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tbclue1
            // 
            this.tbclue1.Enabled = false;
            this.tbclue1.Location = new System.Drawing.Point(114, 46);
            this.tbclue1.Name = "tbclue1";
            this.tbclue1.Size = new System.Drawing.Size(169, 23);
            this.tbclue1.TabIndex = 2;
            // 
            // clue1
            // 
            this.clue1.AutoSize = true;
            this.clue1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue1.ForeColor = System.Drawing.Color.White;
            this.clue1.Location = new System.Drawing.Point(13, 56);
            this.clue1.Name = "clue1";
            this.clue1.Size = new System.Drawing.Size(40, 13);
            this.clue1.TabIndex = 3;
            this.clue1.Text = "value1";
            // 
            // clue2
            // 
            this.clue2.AutoSize = true;
            this.clue2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue2.ForeColor = System.Drawing.Color.White;
            this.clue2.Location = new System.Drawing.Point(13, 85);
            this.clue2.Name = "clue2";
            this.clue2.Size = new System.Drawing.Size(40, 13);
            this.clue2.TabIndex = 5;
            this.clue2.Text = "value2";
            // 
            // tbclue2
            // 
            this.tbclue2.Enabled = false;
            this.tbclue2.Location = new System.Drawing.Point(114, 75);
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
            this.comboBox1.Location = new System.Drawing.Point(13, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(13, 101);
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
            this.answer.ForeColor = System.Drawing.Color.White;
            this.answer.Location = new System.Drawing.Point(13, 132);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(60, 21);
            this.answer.TabIndex = 9;
            this.answer.Text = "answer";
            // 
            // tbanswer
            // 
            this.tbanswer.Location = new System.Drawing.Point(13, 158);
            this.tbanswer.Name = "tbanswer";
            this.tbanswer.ReadOnly = true;
            this.tbanswer.Size = new System.Drawing.Size(270, 23);
            this.tbanswer.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(13, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(272, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLog
            // 
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(180, 164);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(76, 23);
            this.btnLog.TabIndex = 19;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(46, 164);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(77, 23);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Calculator";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // PanelInput
            // 
            this.PanelInput.Controls.Add(this.comboBox1);
            this.PanelInput.Controls.Add(this.tbclue1);
            this.PanelInput.Controls.Add(this.clue1);
            this.PanelInput.Controls.Add(this.btnClear);
            this.PanelInput.Controls.Add(this.tbclue2);
            this.PanelInput.Controls.Add(this.answer);
            this.PanelInput.Controls.Add(this.clue2);
            this.PanelInput.Controls.Add(this.tbanswer);
            this.PanelInput.Controls.Add(this.btnCalc);
            this.PanelInput.Location = new System.Drawing.Point(2, 198);
            this.PanelInput.Name = "PanelInput";
            this.PanelInput.Size = new System.Drawing.Size(297, 220);
            this.PanelInput.TabIndex = 20;
            this.PanelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInput_Paint);
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.button3);
            this.panelLog.Controls.Add(this.listLog);
            this.panelLog.Location = new System.Drawing.Point(2, 198);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(297, 295);
            this.panelLog.TabIndex = 21;
            this.panelLog.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(10, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listLog
            // 
            this.listLog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(10, 19);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(275, 225);
            this.listLog.TabIndex = 0;
            // 
            // Fglb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Fislab_Project.Properties.Resources.bgGLB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(299, 521);
            this.ControlBox = false;
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.PanelInput);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnMenu);
            this.DoubleBuffered = true;
            this.Name = "Fglb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fglb";
            this.Load += new System.EventHandler(this.Fglb_Load);
            this.PanelInput.ResumeLayout(false);
            this.PanelInput.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel PanelInput;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Button button3;
    }
}