
namespace Fislab_Project
{
    partial class Fgmb
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lAnswer = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbClue3 = new System.Windows.Forms.TextBox();
            this.clue3 = new System.Windows.Forms.Label();
            this.tbClue2 = new System.Windows.Forms.TextBox();
            this.clue2 = new System.Windows.Forms.Label();
            this.tbClue1 = new System.Windows.Forms.TextBox();
            this.clue1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelList = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelInput.SuspendLayout();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.tbAnswer);
            this.panelInput.Controls.Add(this.lAnswer);
            this.panelInput.Controls.Add(this.btnClear);
            this.panelInput.Controls.Add(this.btnCalc);
            this.panelInput.Controls.Add(this.tbClue3);
            this.panelInput.Controls.Add(this.clue3);
            this.panelInput.Controls.Add(this.tbClue2);
            this.panelInput.Controls.Add(this.clue2);
            this.panelInput.Controls.Add(this.tbClue1);
            this.panelInput.Controls.Add(this.clue1);
            this.panelInput.Controls.Add(this.comboBox1);
            this.panelInput.Location = new System.Drawing.Point(1, 181);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(295, 299);
            this.panelInput.TabIndex = 1;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(16, 206);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(248, 23);
            this.tbAnswer.TabIndex = 12;
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAnswer.ForeColor = System.Drawing.Color.White;
            this.lAnswer.Location = new System.Drawing.Point(10, 180);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(62, 21);
            this.lAnswer.TabIndex = 13;
            this.lAnswer.Text = "Answer";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(16, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(260, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(16, 148);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(260, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbClue3
            // 
            this.tbClue3.Enabled = false;
            this.tbClue3.Location = new System.Drawing.Point(107, 111);
            this.tbClue3.Name = "tbClue3";
            this.tbClue3.Size = new System.Drawing.Size(169, 23);
            this.tbClue3.TabIndex = 8;
            // 
            // clue3
            // 
            this.clue3.AutoSize = true;
            this.clue3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue3.ForeColor = System.Drawing.Color.White;
            this.clue3.Location = new System.Drawing.Point(16, 121);
            this.clue3.Name = "clue3";
            this.clue3.Size = new System.Drawing.Size(40, 13);
            this.clue3.TabIndex = 9;
            this.clue3.Text = "value3";
            // 
            // tbClue2
            // 
            this.tbClue2.Enabled = false;
            this.tbClue2.Location = new System.Drawing.Point(107, 82);
            this.tbClue2.Name = "tbClue2";
            this.tbClue2.Size = new System.Drawing.Size(169, 23);
            this.tbClue2.TabIndex = 6;
            // 
            // clue2
            // 
            this.clue2.AutoSize = true;
            this.clue2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue2.ForeColor = System.Drawing.Color.White;
            this.clue2.Location = new System.Drawing.Point(16, 92);
            this.clue2.Name = "clue2";
            this.clue2.Size = new System.Drawing.Size(40, 13);
            this.clue2.TabIndex = 7;
            this.clue2.Text = "value2";
            // 
            // tbClue1
            // 
            this.tbClue1.Enabled = false;
            this.tbClue1.Location = new System.Drawing.Point(107, 53);
            this.tbClue1.Name = "tbClue1";
            this.tbClue1.Size = new System.Drawing.Size(169, 23);
            this.tbClue1.TabIndex = 4;
            // 
            // clue1
            // 
            this.clue1.AutoSize = true;
            this.clue1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clue1.ForeColor = System.Drawing.Color.White;
            this.clue1.Location = new System.Drawing.Point(16, 63);
            this.clue1.Name = "clue1";
            this.clue1.Size = new System.Drawing.Size(40, 13);
            this.clue1.TabIndex = 5;
            this.clue1.Text = "value1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Angle(Teta)",
            "Angle\'s Velocity",
            "Period",
            "Linear Velocity",
            "Radius",
            "Frequency"});
            this.comboBox1.Location = new System.Drawing.Point(16, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.btnDelete);
            this.panelList.Controls.Add(this.listLog);
            this.panelList.Location = new System.Drawing.Point(1, 181);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(295, 318);
            this.panelList.TabIndex = 2;
            this.panelList.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(16, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listLog
            // 
            this.listLog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(11, 14);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(269, 251);
            this.listLog.TabIndex = 0;
            // 
            // btnLog
            // 
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(185, 134);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(69, 23);
            this.btnLog.TabIndex = 21;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(44, 134);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(77, 23);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Calculator";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Fgmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::Fislab_Project.Properties.Resources.bgGMB;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(299, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Fgmb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fgmb";
            this.Load += new System.EventHandler(this.Fgmb_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbClue1;
        private System.Windows.Forms.Label clue1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbClue3;
        private System.Windows.Forms.Label clue3;
        private System.Windows.Forms.TextBox tbClue2;
        private System.Windows.Forms.Label clue2;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnInsert;
    }
}