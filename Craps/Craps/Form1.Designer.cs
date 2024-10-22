namespace Craps
{
    partial class Craps
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
            this.lblDie1 = new System.Windows.Forms.Label();
            this.picDieImage = new System.Windows.Forms.PictureBox();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.txtEnterBet = new System.Windows.Forms.TextBox();
            this.lblEnterBet = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblTotalRoll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.Location = new System.Drawing.Point(141, 178);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(0, 24);
            this.lblDie1.TabIndex = 0;
            // 
            // picDieImage
            // 
            this.picDieImage.Image = global::Craps.Properties.Resources.Dice4;
            this.picDieImage.Location = new System.Drawing.Point(108, 12);
            this.picDieImage.Name = "picDieImage";
            this.picDieImage.Size = new System.Drawing.Size(215, 158);
            this.picDieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDieImage.TabIndex = 1;
            this.picDieImage.TabStop = false;
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.Location = new System.Drawing.Point(265, 178);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(0, 24);
            this.lblDie2.TabIndex = 2;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(154, 221);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(87, 71);
            this.btnRollDice.TabIndex = 3;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(33, 298);
            this.lblResult.MaximumSize = new System.Drawing.Size(400, 60);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 24);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankBalance.Location = new System.Drawing.Point(212, 446);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(54, 24);
            this.lblBankBalance.TabIndex = 5;
            this.lblBankBalance.Text = "$100";
            this.lblBankBalance.Click += new System.EventHandler(this.lblBankBalance_Click);
            // 
            // txtEnterBet
            // 
            this.txtEnterBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterBet.Location = new System.Drawing.Point(109, 395);
            this.txtEnterBet.Multiline = true;
            this.txtEnterBet.Name = "txtEnterBet";
            this.txtEnterBet.PasswordChar = '*';
            this.txtEnterBet.Size = new System.Drawing.Size(215, 30);
            this.txtEnterBet.TabIndex = 6;
            this.txtEnterBet.UseSystemPasswordChar = true;
            this.txtEnterBet.TextChanged += new System.EventHandler(this.txtEnterBet_TextChanged);
            // 
            // lblEnterBet
            // 
            this.lblEnterBet.AutoSize = true;
            this.lblEnterBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBet.Location = new System.Drawing.Point(141, 359);
            this.lblEnterBet.Name = "lblEnterBet";
            this.lblEnterBet.Size = new System.Drawing.Size(146, 24);
            this.lblEnterBet.TabIndex = 7;
            this.lblEnterBet.Text = "Enter Your Bet";
            this.lblEnterBet.Click += new System.EventHandler(this.lblEnterBet_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(105, 446);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(85, 24);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(344, 178);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(52, 24);
            this.lblSum.TabIndex = 9;
            this.lblSum.Text = "Sum";
            // 
            // lblTotalRoll
            // 
            this.lblTotalRoll.AutoSize = true;
            this.lblTotalRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRoll.Location = new System.Drawing.Point(330, 156);
            this.lblTotalRoll.Name = "lblTotalRoll";
            this.lblTotalRoll.Size = new System.Drawing.Size(98, 24);
            this.lblTotalRoll.TabIndex = 10;
            this.lblTotalRoll.Text = "Total Roll";
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 476);
            this.Controls.Add(this.lblTotalRoll);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblEnterBet);
            this.Controls.Add(this.txtEnterBet);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.picDieImage);
            this.Controls.Add(this.lblDie1);
            this.Name = "Craps";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.frmCraps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.PictureBox picDieImage;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.TextBox txtEnterBet;
        private System.Windows.Forms.Label lblEnterBet;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblTotalRoll;
    }
}

