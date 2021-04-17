namespace intra_inf1034
{
    partial class bottomLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.banqueTitre = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.montant_textbox = new System.Windows.Forms.TextBox();
            this.retirerBtn = new System.Windows.Forms.Button();
            this.deposerBtn = new System.Windows.Forms.Button();
            this.cptCourantLabel = new System.Windows.Forms.Label();
            this.cptEpargneLabel = new System.Windows.Forms.Label();
            this.montantLabel = new System.Windows.Forms.Label();
            this.compteLabel = new System.Windows.Forms.Label();
            this.epargneCheckbox = new System.Windows.Forms.CheckBox();
            this.courantCheckbox = new System.Windows.Forms.CheckBox();
            this.extraLabel = new System.Windows.Forms.Label();
            this.accepterBtn = new System.Windows.Forms.Button();
            this.refuserBtn = new System.Windows.Forms.Button();
            this.rapportBtn = new System.Windows.Forms.Button();
            this.compteCourantTextbox = new System.Windows.Forms.TextBox();
            this.compteEpargneTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(961, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // banqueTitre
            // 
            this.banqueTitre.BackColor = System.Drawing.SystemColors.MenuText;
            this.banqueTitre.ForeColor = System.Drawing.Color.Gold;
            this.banqueTitre.Location = new System.Drawing.Point(591, 83);
            this.banqueTitre.Name = "banqueTitre";
            this.banqueTitre.Size = new System.Drawing.Size(299, 31);
            this.banqueTitre.TabIndex = 1;
            this.banqueTitre.Text = "MA BANQUE";
            this.banqueTitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1592, 31);
            this.textBox1.TabIndex = 2;
            // 
            // montant_textbox
            // 
            this.montant_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.montant_textbox.Location = new System.Drawing.Point(699, 310);
            this.montant_textbox.Name = "montant_textbox";
            this.montant_textbox.Size = new System.Drawing.Size(184, 31);
            this.montant_textbox.TabIndex = 8;
            // 
            // retirerBtn
            // 
            this.retirerBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retirerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retirerBtn.Location = new System.Drawing.Point(366, 438);
            this.retirerBtn.Name = "retirerBtn";
            this.retirerBtn.Size = new System.Drawing.Size(127, 61);
            this.retirerBtn.TabIndex = 13;
            this.retirerBtn.Text = "Retirer";
            this.retirerBtn.UseVisualStyleBackColor = false;
            this.retirerBtn.Click += new System.EventHandler(this.retirerBtn_Click);
            // 
            // deposerBtn
            // 
            this.deposerBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deposerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deposerBtn.Location = new System.Drawing.Point(591, 438);
            this.deposerBtn.Name = "deposerBtn";
            this.deposerBtn.Size = new System.Drawing.Size(136, 61);
            this.deposerBtn.TabIndex = 14;
            this.deposerBtn.Text = "Deposer";
            this.deposerBtn.UseVisualStyleBackColor = false;
            this.deposerBtn.Click += new System.EventHandler(this.deposerBtn_Click);
            // 
            // cptCourantLabel
            // 
            this.cptCourantLabel.AutoSize = true;
            this.cptCourantLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cptCourantLabel.Location = new System.Drawing.Point(371, 168);
            this.cptCourantLabel.Name = "cptCourantLabel";
            this.cptCourantLabel.Size = new System.Drawing.Size(263, 25);
            this.cptCourantLabel.TabIndex = 16;
            this.cptCourantLabel.Text = "Solde du compte courant :";
            // 
            // cptEpargneLabel
            // 
            this.cptEpargneLabel.AutoSize = true;
            this.cptEpargneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cptEpargneLabel.Location = new System.Drawing.Point(371, 237);
            this.cptEpargneLabel.Name = "cptEpargneLabel";
            this.cptEpargneLabel.Size = new System.Drawing.Size(270, 25);
            this.cptEpargneLabel.TabIndex = 17;
            this.cptEpargneLabel.Text = "Solde du compte epargne :";
            // 
            // montantLabel
            // 
            this.montantLabel.AutoSize = true;
            this.montantLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.montantLabel.Location = new System.Drawing.Point(471, 316);
            this.montantLabel.Name = "montantLabel";
            this.montantLabel.Size = new System.Drawing.Size(170, 25);
            this.montantLabel.TabIndex = 18;
            this.montantLabel.Text = "Entrez Montant :";
            // 
            // compteLabel
            // 
            this.compteLabel.AutoSize = true;
            this.compteLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compteLabel.Location = new System.Drawing.Point(1018, 203);
            this.compteLabel.Name = "compteLabel";
            this.compteLabel.Size = new System.Drawing.Size(86, 25);
            this.compteLabel.TabIndex = 19;
            this.compteLabel.Text = "Compte";
            // 
            // epargneCheckbox
            // 
            this.epargneCheckbox.AutoSize = true;
            this.epargneCheckbox.Location = new System.Drawing.Point(1078, 272);
            this.epargneCheckbox.Name = "epargneCheckbox";
            this.epargneCheckbox.Size = new System.Drawing.Size(125, 29);
            this.epargneCheckbox.TabIndex = 12;
            this.epargneCheckbox.Text = "Epargne";
            this.epargneCheckbox.UseVisualStyleBackColor = true;
            this.epargneCheckbox.CheckedChanged += new System.EventHandler(this.epargneCheckbox_CheckedChanged);
            // 
            // courantCheckbox
            // 
            this.courantCheckbox.AutoSize = true;
            this.courantCheckbox.Location = new System.Drawing.Point(952, 272);
            this.courantCheckbox.Name = "courantCheckbox";
            this.courantCheckbox.Size = new System.Drawing.Size(120, 29);
            this.courantCheckbox.TabIndex = 10;
            this.courantCheckbox.Text = "Courant";
            this.courantCheckbox.UseVisualStyleBackColor = true;
            this.courantCheckbox.CheckedChanged += new System.EventHandler(this.courantCheckbox_CheckedChanged);
            // 
            // extraLabel
            // 
            this.extraLabel.AutoSize = true;
            this.extraLabel.Location = new System.Drawing.Point(1120, 237);
            this.extraLabel.Name = "extraLabel";
            this.extraLabel.Size = new System.Drawing.Size(111, 25);
            this.extraLabel.TabIndex = 20;
            this.extraLabel.Text = "Extra : 2%";
            this.extraLabel.Visible = false;
            this.extraLabel.Click += new System.EventHandler(this.extraLabel_Click);
            // 
            // accepterBtn
            // 
            this.accepterBtn.Location = new System.Drawing.Point(961, 345);
            this.accepterBtn.Name = "accepterBtn";
            this.accepterBtn.Size = new System.Drawing.Size(111, 55);
            this.accepterBtn.TabIndex = 21;
            this.accepterBtn.Text = "Accepter";
            this.accepterBtn.UseVisualStyleBackColor = true;
            this.accepterBtn.Visible = false;
            this.accepterBtn.Click += new System.EventHandler(this.accepterBtn_Click);
            // 
            // refuserBtn
            // 
            this.refuserBtn.Location = new System.Drawing.Point(1109, 345);
            this.refuserBtn.Name = "refuserBtn";
            this.refuserBtn.Size = new System.Drawing.Size(93, 54);
            this.refuserBtn.TabIndex = 22;
            this.refuserBtn.Text = "Refuser";
            this.refuserBtn.UseVisualStyleBackColor = true;
            this.refuserBtn.Visible = false;
            this.refuserBtn.Click += new System.EventHandler(this.refuserBtn_Click);
            // 
            // rapportBtn
            // 
            this.rapportBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rapportBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rapportBtn.Location = new System.Drawing.Point(782, 438);
            this.rapportBtn.Name = "rapportBtn";
            this.rapportBtn.Size = new System.Drawing.Size(133, 61);
            this.rapportBtn.TabIndex = 23;
            this.rapportBtn.Text = "Rapport";
            this.rapportBtn.UseVisualStyleBackColor = false;
            this.rapportBtn.Click += new System.EventHandler(this.rapportBtn_Click);
            // 
            // compteCourantTextbox
            // 
            this.compteCourantTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.compteCourantTextbox.Location = new System.Drawing.Point(699, 161);
            this.compteCourantTextbox.Name = "compteCourantTextbox";
            this.compteCourantTextbox.Size = new System.Drawing.Size(100, 31);
            this.compteCourantTextbox.TabIndex = 24;
            this.compteCourantTextbox.TextChanged += new System.EventHandler(this.compteCourantTextbox_TextChanged);
            // 
            // compteEpargneTextbox
            // 
            this.compteEpargneTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.compteEpargneTextbox.Location = new System.Drawing.Point(699, 237);
            this.compteEpargneTextbox.Name = "compteEpargneTextbox";
            this.compteEpargneTextbox.Size = new System.Drawing.Size(100, 31);
            this.compteEpargneTextbox.TabIndex = 25;
            this.compteEpargneTextbox.TextChanged += new System.EventHandler(this.compteEpargneTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1334, 743);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ma banque";
            // 
            // bottomLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 824);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compteEpargneTextbox);
            this.Controls.Add(this.compteCourantTextbox);
            this.Controls.Add(this.rapportBtn);
            this.Controls.Add(this.refuserBtn);
            this.Controls.Add(this.accepterBtn);
            this.Controls.Add(this.extraLabel);
            this.Controls.Add(this.compteLabel);
            this.Controls.Add(this.montantLabel);
            this.Controls.Add(this.cptEpargneLabel);
            this.Controls.Add(this.cptCourantLabel);
            this.Controls.Add(this.deposerBtn);
            this.Controls.Add(this.retirerBtn);
            this.Controls.Add(this.epargneCheckbox);
            this.Controls.Add(this.courantCheckbox);
            this.Controls.Add(this.montant_textbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.banqueTitre);
            this.Controls.Add(this.label1);
            this.Name = "bottomLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox banqueTitre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox montant_textbox;
        private System.Windows.Forms.Button retirerBtn;
        private System.Windows.Forms.Button deposerBtn;
        private System.Windows.Forms.Label cptCourantLabel;
        private System.Windows.Forms.Label cptEpargneLabel;
        private System.Windows.Forms.Label montantLabel;
        private System.Windows.Forms.Label compteLabel;
        private System.Windows.Forms.CheckBox epargneCheckbox;
        private System.Windows.Forms.CheckBox courantCheckbox;
        private System.Windows.Forms.Label extraLabel;
        private System.Windows.Forms.Button accepterBtn;
        private System.Windows.Forms.Button refuserBtn;
        private System.Windows.Forms.Button rapportBtn;
        private System.Windows.Forms.TextBox compteCourantTextbox;
        private System.Windows.Forms.TextBox compteEpargneTextbox;
        private System.Windows.Forms.Label label2;
    }
}

