namespace CollectJoe
{
    partial class frmAdvancedOptions
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
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.nudPlayTime = new System.Windows.Forms.NumericUpDown();
            this.nudGameOverAt = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblErweiterteEinstellungen = new System.Windows.Forms.Label();
            this.lblSpielgeschwindigkeit = new System.Windows.Forms.Label();
            this.lblSpiellänge = new System.Windows.Forms.Label();
            this.lblSpielendeWenn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameOverAt)).BeginInit();
            this.SuspendLayout();
            // 
            // nudInterval
            // 
            this.nudInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterval.Location = new System.Drawing.Point(176, 56);
            this.nudInterval.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(117, 20);
            this.nudInterval.TabIndex = 2;
            this.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudPlayTime
            // 
            this.nudPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlayTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlayTime.Location = new System.Drawing.Point(176, 83);
            this.nudPlayTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudPlayTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayTime.Name = "nudPlayTime";
            this.nudPlayTime.Size = new System.Drawing.Size(117, 20);
            this.nudPlayTime.TabIndex = 3;
            this.nudPlayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPlayTime.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nudGameOverAt
            // 
            this.nudGameOverAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGameOverAt.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudGameOverAt.Location = new System.Drawing.Point(176, 110);
            this.nudGameOverAt.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudGameOverAt.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nudGameOverAt.Name = "nudGameOverAt";
            this.nudGameOverAt.Size = new System.Drawing.Size(117, 20);
            this.nudGameOverAt.TabIndex = 4;
            this.nudGameOverAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(13, 140);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 30);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // lblErweiterteEinstellungen
            // 
            this.lblErweiterteEinstellungen.AutoSize = true;
            this.lblErweiterteEinstellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErweiterteEinstellungen.Location = new System.Drawing.Point(12, 16);
            this.lblErweiterteEinstellungen.Name = "lblErweiterteEinstellungen";
            this.lblErweiterteEinstellungen.Size = new System.Drawing.Size(244, 25);
            this.lblErweiterteEinstellungen.TabIndex = 14;
            this.lblErweiterteEinstellungen.Text = "Erweiterte Einstellungen";
            // 
            // lblSpielgeschwindigkeit
            // 
            this.lblSpielgeschwindigkeit.AutoSize = true;
            this.lblSpielgeschwindigkeit.Location = new System.Drawing.Point(14, 58);
            this.lblSpielgeschwindigkeit.Name = "lblSpielgeschwindigkeit";
            this.lblSpielgeschwindigkeit.Size = new System.Drawing.Size(142, 13);
            this.lblSpielgeschwindigkeit.TabIndex = 15;
            this.lblSpielgeschwindigkeit.Text = "Spielgeschwindigkeit (in ms):";
            // 
            // lblSpiellänge
            // 
            this.lblSpiellänge.AutoSize = true;
            this.lblSpiellänge.Location = new System.Drawing.Point(14, 85);
            this.lblSpiellänge.Name = "lblSpiellänge";
            this.lblSpiellänge.Size = new System.Drawing.Size(96, 13);
            this.lblSpiellänge.TabIndex = 16;
            this.lblSpiellänge.Text = "Spiellänge (in sek):";
            // 
            // lblSpielendeWenn
            // 
            this.lblSpielendeWenn.AutoSize = true;
            this.lblSpielendeWenn.Location = new System.Drawing.Point(14, 112);
            this.lblSpielendeWenn.Name = "lblSpielendeWenn";
            this.lblSpielendeWenn.Size = new System.Drawing.Size(141, 13);
            this.lblSpielendeWenn.TabIndex = 17;
            this.lblSpielendeWenn.Text = "Spielende wenn Punkte < ..:";
            // 
            // frmAdvancedOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 182);
            this.Controls.Add(this.lblSpielendeWenn);
            this.Controls.Add(this.lblSpiellänge);
            this.Controls.Add(this.lblSpielgeschwindigkeit);
            this.Controls.Add(this.lblErweiterteEinstellungen);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.nudGameOverAt);
            this.Controls.Add(this.nudPlayTime);
            this.Controls.Add(this.nudInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdvancedOptions";
            this.Text = "Erweiterte Optionen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdvancedOptions_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdvancedOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGameOverAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown nudInterval;
        public System.Windows.Forms.NumericUpDown nudPlayTime;
        public System.Windows.Forms.NumericUpDown nudGameOverAt;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblErweiterteEinstellungen;
        private System.Windows.Forms.Label lblSpielgeschwindigkeit;
        private System.Windows.Forms.Label lblSpiellänge;
        private System.Windows.Forms.Label lblSpielendeWenn;
    }
}