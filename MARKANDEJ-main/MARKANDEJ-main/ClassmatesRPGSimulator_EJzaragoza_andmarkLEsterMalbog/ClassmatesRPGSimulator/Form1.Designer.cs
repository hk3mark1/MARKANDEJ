namespace ClassmatesRPGSimulator
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblCharacter1 = new System.Windows.Forms.Label();
            this.cbCharacter1 = new System.Windows.Forms.ComboBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblCharacter2 = new System.Windows.Forms.Label();
            this.cbCharacter2 = new System.Windows.Forms.ComboBox();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.lstBattleLog = new System.Windows.Forms.ListBox();
            this.lblHealth1 = new System.Windows.Forms.Label();
            this.lblHealth2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(7, 19);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(77, 13);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1 name:";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1.Location = new System.Drawing.Point(121, 13);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(113, 26);
            this.txtPlayer1.TabIndex = 1;
            // 
            // lblCharacter1
            // 
            this.lblCharacter1.AutoSize = true;
            this.lblCharacter1.Location = new System.Drawing.Point(7, 43);
            this.lblCharacter1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharacter1.Name = "lblCharacter1";
            this.lblCharacter1.Size = new System.Drawing.Size(101, 13);
            this.lblCharacter1.TabIndex = 2;
            this.lblCharacter1.Text = "Choose Character:  ";
            this.lblCharacter1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // cbCharacter1
            // 
            this.cbCharacter1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCharacter1.FormattingEnabled = true;
            this.cbCharacter1.Location = new System.Drawing.Point(121, 39);
            this.cbCharacter1.Margin = new System.Windows.Forms.Padding(2);
            this.cbCharacter1.Name = "cbCharacter1";
            this.cbCharacter1.Size = new System.Drawing.Size(113, 21);
            this.cbCharacter1.TabIndex = 3;
            this.cbCharacter1.SelectedIndexChanged += new System.EventHandler(this.cbCharacter1_SelectedIndexChanged);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(7, 84);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(77, 13);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Player 2 name:";
            this.lblPlayer2.Click += new System.EventHandler(this.lblPlayer2_Click);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2.Location = new System.Drawing.Point(121, 77);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(113, 26);
            this.txtPlayer2.TabIndex = 5;
            // 
            // lblCharacter2
            // 
            this.lblCharacter2.AutoSize = true;
            this.lblCharacter2.Location = new System.Drawing.Point(7, 107);
            this.lblCharacter2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharacter2.Name = "lblCharacter2";
            this.lblCharacter2.Size = new System.Drawing.Size(95, 13);
            this.lblCharacter2.TabIndex = 6;
            this.lblCharacter2.Text = "Choose Character:";
            // 
            // cbCharacter2
            // 
            this.cbCharacter2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCharacter2.FormattingEnabled = true;
            this.cbCharacter2.Location = new System.Drawing.Point(121, 103);
            this.cbCharacter2.Margin = new System.Windows.Forms.Padding(2);
            this.cbCharacter2.Name = "cbCharacter2";
            this.cbCharacter2.Size = new System.Drawing.Size(113, 21);
            this.cbCharacter2.TabIndex = 7;
            this.cbCharacter2.SelectedIndexChanged += new System.EventHandler(this.cbCharacter2_SelectedIndexChanged);
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.BackColor = System.Drawing.Color.Chocolate;
            this.btnStartBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBattle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartBattle.Location = new System.Drawing.Point(89, 136);
            this.btnStartBattle.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(81, 29);
            this.btnStartBattle.TabIndex = 8;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartBattle.UseVisualStyleBackColor = false;
            // 
            // lstBattleLog
            // 
            this.lstBattleLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstBattleLog.FormattingEnabled = true;
            this.lstBattleLog.Location = new System.Drawing.Point(17, 177);
            this.lstBattleLog.Margin = new System.Windows.Forms.Padding(2);
            this.lstBattleLog.Name = "lstBattleLog";
            this.lstBattleLog.Size = new System.Drawing.Size(224, 82);
            this.lstBattleLog.TabIndex = 9;
            // 
            // lblHealth1
            // 
            this.lblHealth1.AutoSize = true;
            this.lblHealth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHealth1.Location = new System.Drawing.Point(11, 15);
            this.lblHealth1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHealth1.Name = "lblHealth1";
            this.lblHealth1.Size = new System.Drawing.Size(53, 15);
            this.lblHealth1.TabIndex = 11;
            this.lblHealth1.Text = "Health:";
            this.lblHealth1.Click += new System.EventHandler(this.lblHealth1_Click);
            // 
            // lblHealth2
            // 
            this.lblHealth2.AutoSize = true;
            this.lblHealth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHealth2.Location = new System.Drawing.Point(164, 15);
            this.lblHealth2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHealth2.Name = "lblHealth2";
            this.lblHealth2.Size = new System.Drawing.Size(53, 15);
            this.lblHealth2.TabIndex = 12;
            this.lblHealth2.Text = "Health:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWinner.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWinner.Location = new System.Drawing.Point(29, 167);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(88, 27);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "Winner:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(167, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Controls.Add(this.lblHealth2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblHealth1);
            this.groupBox1.Controls.Add(this.lblWinner);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(250, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(307, 249);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lstBattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.cbCharacter2);
            this.Controls.Add(this.lblCharacter2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.cbCharacter1);
            this.Controls.Add(this.lblCharacter1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ve";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblCharacter1;
        private System.Windows.Forms.ComboBox cbCharacter1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblCharacter2;
        private System.Windows.Forms.ComboBox cbCharacter2;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.ListBox lstBattleLog;
        private System.Windows.Forms.Label lblHealth1;
        private System.Windows.Forms.Label lblHealth2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

