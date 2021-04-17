namespace intra_inf1034
{
    partial class Rapport
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
            this.rapportTitre = new System.Windows.Forms.MaskedTextBox();
            this.soldeCourantLabel = new System.Windows.Forms.Label();
            this.soldeEpargneLabel = new System.Windows.Forms.Label();
            this.rapportCourantTextBox = new System.Windows.Forms.TextBox();
            this.rapportEpargneTxtBox = new System.Windows.Forms.TextBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rapportTitre
            // 
            this.rapportTitre.BackColor = System.Drawing.SystemColors.MenuText;
            this.rapportTitre.ForeColor = System.Drawing.Color.Gold;
            this.rapportTitre.Location = new System.Drawing.Point(517, 50);
            this.rapportTitre.Name = "rapportTitre";
            this.rapportTitre.Size = new System.Drawing.Size(299, 31);
            this.rapportTitre.TabIndex = 2;
            this.rapportTitre.Text = "Rapport de vos comptes";
            this.rapportTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rapportTitre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.banqueTitre_MaskInputRejected);
            // 
            // soldeCourantLabel
            // 
            this.soldeCourantLabel.AutoSize = true;
            this.soldeCourantLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soldeCourantLabel.Location = new System.Drawing.Point(351, 138);
            this.soldeCourantLabel.Name = "soldeCourantLabel";
            this.soldeCourantLabel.Size = new System.Drawing.Size(271, 25);
            this.soldeCourantLabel.TabIndex = 3;
            this.soldeCourantLabel.Text = "Solde de Compte Courant :";
            // 
            // soldeEpargneLabel
            // 
            this.soldeEpargneLabel.AutoSize = true;
            this.soldeEpargneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soldeEpargneLabel.Location = new System.Drawing.Point(737, 138);
            this.soldeEpargneLabel.Name = "soldeEpargneLabel";
            this.soldeEpargneLabel.Size = new System.Drawing.Size(270, 25);
            this.soldeEpargneLabel.TabIndex = 4;
            this.soldeEpargneLabel.Text = "Solde de Compte Epargne:";
            // 
            // rapportCourantTextBox
            // 
            this.rapportCourantTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rapportCourantTextBox.Location = new System.Drawing.Point(440, 209);
            this.rapportCourantTextBox.Name = "rapportCourantTextBox";
            this.rapportCourantTextBox.Size = new System.Drawing.Size(100, 31);
            this.rapportCourantTextBox.TabIndex = 5;
            this.rapportCourantTextBox.TextChanged += new System.EventHandler(this.rapportCourantTextBox_TextChanged);
            // 
            // rapportEpargneTxtBox
            // 
            this.rapportEpargneTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rapportEpargneTxtBox.Location = new System.Drawing.Point(854, 218);
            this.rapportEpargneTxtBox.Name = "rapportEpargneTxtBox";
            this.rapportEpargneTxtBox.Size = new System.Drawing.Size(100, 31);
            this.rapportEpargneTxtBox.TabIndex = 6;
            this.rapportEpargneTxtBox.TextChanged += new System.EventHandler(this.rapportEpargneTxtBox_TextChanged);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBtn.Location = new System.Drawing.Point(612, 337);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(142, 90);
            this.menuBtn.TabIndex = 7;
            this.menuBtn.Text = "Menu Principal";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 839);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.rapportEpargneTxtBox);
            this.Controls.Add(this.rapportCourantTextBox);
            this.Controls.Add(this.soldeEpargneLabel);
            this.Controls.Add(this.soldeCourantLabel);
            this.Controls.Add(this.rapportTitre);
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox rapportTitre;
        private System.Windows.Forms.Label soldeCourantLabel;
        private System.Windows.Forms.Label soldeEpargneLabel;
        private System.Windows.Forms.TextBox rapportCourantTextBox;
        private System.Windows.Forms.TextBox rapportEpargneTxtBox;
        private System.Windows.Forms.Button menuBtn;
    }
}