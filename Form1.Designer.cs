namespace WordFinder
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulek = new System.Windows.Forms.Label();
            this.lblSlovo = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.tboxSlovo = new System.Windows.Forms.TextBox();
            this.tboxText = new System.Windows.Forms.TextBox();
            this.btnHledat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulek
            // 
            resources.ApplyResources(this.lblTitulek, "lblTitulek");
            this.lblTitulek.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTitulek.Name = "lblTitulek";
            // 
            // lblSlovo
            // 
            resources.ApplyResources(this.lblSlovo, "lblSlovo");
            this.lblSlovo.Name = "lblSlovo";
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            // 
            // tboxSlovo
            // 
            resources.ApplyResources(this.tboxSlovo, "tboxSlovo");
            this.tboxSlovo.Name = "tboxSlovo";
            // 
            // tboxText
            // 
            resources.ApplyResources(this.tboxText, "tboxText");
            this.tboxText.Name = "tboxText";
            // 
            // btnHledat
            // 
            resources.ApplyResources(this.btnHledat, "btnHledat");
            this.btnHledat.Name = "btnHledat";
            this.btnHledat.UseVisualStyleBackColor = true;
            this.btnHledat.Click += new System.EventHandler(this.btnHledat_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHledat);
            this.Controls.Add(this.tboxText);
            this.Controls.Add(this.tboxSlovo);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblSlovo);
            this.Controls.Add(this.lblTitulek);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulek;
        private System.Windows.Forms.Label lblSlovo;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tboxSlovo;
        private System.Windows.Forms.TextBox tboxText;
        private System.Windows.Forms.Button btnHledat;
    }
}

