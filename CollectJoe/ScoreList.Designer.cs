﻿namespace CollectJoe
{
    partial class frmScoreList
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
            this.lblRangliste = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtScore = new System.Web.Management.ReadOnlyTextBox();
            this.SuspendLayout();
            // 
            // lblRangliste
            // 
            this.lblRangliste.AutoSize = true;
            this.lblRangliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangliste.Location = new System.Drawing.Point(12, 16);
            this.lblRangliste.Name = "lblRangliste";
            this.lblRangliste.Size = new System.Drawing.Size(101, 25);
            this.lblRangliste.TabIndex = 1;
            this.lblRangliste.Text = "Rangliste";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(81, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtScore.Location = new System.Drawing.Point(21, 49);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScore.Size = new System.Drawing.Size(234, 259);
            this.txtScore.TabIndex = 13;
            this.txtScore.TabStop = false;
            // 
            // frmScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 354);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRangliste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScoreList";
            this.Text = "Rangliste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScoreList_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRangliste;
        private System.Windows.Forms.Button btnClose;
        private System.Web.Management.ReadOnlyTextBox txtScore;
    }
}