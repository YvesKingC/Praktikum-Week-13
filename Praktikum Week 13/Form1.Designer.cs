namespace Praktikum_Week_13
{
    partial class FormPlayer
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
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAvaOrNot = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TboxPlayerID = new System.Windows.Forms.TextBox();
            this.TboxPlayerName = new System.Windows.Forms.TextBox();
            this.CboxTeam = new System.Windows.Forms.ComboBox();
            this.DTPBIthDate = new System.Windows.Forms.DateTimePicker();
            this.NUPTeamNum = new System.Windows.Forms.NumericUpDown();
            this.CboxNationality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUPTeamNum)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(37, 36);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(59, 45);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "<<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(130, 36);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(59, 45);
            this.BtnPrev.TabIndex = 1;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(219, 36);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(59, 45);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(311, 36);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(59, 45);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team Number";
            // 
            // LblAvaOrNot
            // 
            this.LblAvaOrNot.AutoSize = true;
            this.LblAvaOrNot.Location = new System.Drawing.Point(296, 258);
            this.LblAvaOrNot.Name = "LblAvaOrNot";
            this.LblAvaOrNot.Size = new System.Drawing.Size(16, 13);
            this.LblAvaOrNot.TabIndex = 10;
            this.LblAvaOrNot.Text = "...";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(77, 296);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(219, 296);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TboxPlayerID
            // 
            this.TboxPlayerID.Location = new System.Drawing.Point(117, 103);
            this.TboxPlayerID.Name = "TboxPlayerID";
            this.TboxPlayerID.Size = new System.Drawing.Size(253, 20);
            this.TboxPlayerID.TabIndex = 13;
            // 
            // TboxPlayerName
            // 
            this.TboxPlayerName.Location = new System.Drawing.Point(117, 132);
            this.TboxPlayerName.Name = "TboxPlayerName";
            this.TboxPlayerName.Size = new System.Drawing.Size(253, 20);
            this.TboxPlayerName.TabIndex = 14;
            // 
            // CboxTeam
            // 
            this.CboxTeam.FormattingEnabled = true;
            this.CboxTeam.Location = new System.Drawing.Point(117, 221);
            this.CboxTeam.Name = "CboxTeam";
            this.CboxTeam.Size = new System.Drawing.Size(253, 21);
            this.CboxTeam.TabIndex = 16;
            // 
            // DTPBIthDate
            // 
            this.DTPBIthDate.Location = new System.Drawing.Point(117, 163);
            this.DTPBIthDate.Name = "DTPBIthDate";
            this.DTPBIthDate.Size = new System.Drawing.Size(253, 20);
            this.DTPBIthDate.TabIndex = 17;
            // 
            // NUPTeamNum
            // 
            this.NUPTeamNum.Location = new System.Drawing.Point(117, 251);
            this.NUPTeamNum.Name = "NUPTeamNum";
            this.NUPTeamNum.Size = new System.Drawing.Size(161, 20);
            this.NUPTeamNum.TabIndex = 18;
            this.NUPTeamNum.ValueChanged += new System.EventHandler(this.NUPTeamNum_ValueChanged);
            // 
            // CboxNationality
            // 
            this.CboxNationality.FormattingEnabled = true;
            this.CboxNationality.Location = new System.Drawing.Point(117, 194);
            this.CboxNationality.Name = "CboxNationality";
            this.CboxNationality.Size = new System.Drawing.Size(253, 21);
            this.CboxNationality.TabIndex = 19;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 363);
            this.Controls.Add(this.CboxNationality);
            this.Controls.Add(this.NUPTeamNum);
            this.Controls.Add(this.DTPBIthDate);
            this.Controls.Add(this.CboxTeam);
            this.Controls.Add(this.TboxPlayerName);
            this.Controls.Add(this.TboxPlayerID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblAvaOrNot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnFirst);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUPTeamNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAvaOrNot;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TboxPlayerID;
        private System.Windows.Forms.TextBox TboxPlayerName;
        private System.Windows.Forms.ComboBox CboxTeam;
        private System.Windows.Forms.DateTimePicker DTPBIthDate;
        private System.Windows.Forms.NumericUpDown NUPTeamNum;
        private System.Windows.Forms.ComboBox CboxNationality;
    }
}

