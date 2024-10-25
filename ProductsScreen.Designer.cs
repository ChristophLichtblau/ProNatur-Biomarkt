namespace ProNatur_Biomarkt_GmbH
{
    partial class ProductsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsScreen));
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMarke = new System.Windows.Forms.TextBox();
            this.labelMarke = new System.Windows.Forms.Label();
            this.labelKategorie = new System.Windows.Forms.Label();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.labelPreis = new System.Windows.Forms.Label();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(23, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(91, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxMarke
            // 
            this.textBoxMarke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxMarke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMarke.ForeColor = System.Drawing.Color.White;
            this.textBoxMarke.Location = new System.Drawing.Point(91, 42);
            this.textBoxMarke.Name = "textBoxMarke";
            this.textBoxMarke.Size = new System.Drawing.Size(149, 20);
            this.textBoxMarke.TabIndex = 3;
            // 
            // labelMarke
            // 
            this.labelMarke.AutoSize = true;
            this.labelMarke.BackColor = System.Drawing.Color.Transparent;
            this.labelMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarke.ForeColor = System.Drawing.Color.White;
            this.labelMarke.Location = new System.Drawing.Point(23, 44);
            this.labelMarke.Name = "labelMarke";
            this.labelMarke.Size = new System.Drawing.Size(42, 13);
            this.labelMarke.TabIndex = 2;
            this.labelMarke.Text = "Marke";
            // 
            // labelKategorie
            // 
            this.labelKategorie.AutoSize = true;
            this.labelKategorie.BackColor = System.Drawing.Color.Transparent;
            this.labelKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategorie.ForeColor = System.Drawing.Color.White;
            this.labelKategorie.Location = new System.Drawing.Point(23, 70);
            this.labelKategorie.Name = "labelKategorie";
            this.labelKategorie.Size = new System.Drawing.Size(61, 13);
            this.labelKategorie.TabIndex = 4;
            this.labelKategorie.Text = "Kategorie";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPreis.ForeColor = System.Drawing.Color.White;
            this.textBoxPreis.Location = new System.Drawing.Point(91, 94);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(149, 20);
            this.textBoxPreis.TabIndex = 7;
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.BackColor = System.Drawing.Color.Transparent;
            this.labelPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreis.ForeColor = System.Drawing.Color.White;
            this.labelPreis.Location = new System.Drawing.Point(23, 96);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(35, 13);
            this.labelPreis.TabIndex = 6;
            this.labelPreis.Text = "Preis";
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKategorie.ForeColor = System.Drawing.Color.White;
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.comboBoxKategorie.Location = new System.Drawing.Point(91, 67);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(149, 21);
            this.comboBoxKategorie.TabIndex = 8;
            // 
            // ProductsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.comboBoxKategorie);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.labelPreis);
            this.Controls.Add(this.labelKategorie);
            this.Controls.Add(this.textBoxMarke);
            this.Controls.Add(this.labelMarke);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMarke;
        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.Label labelKategorie;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label labelPreis;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
    }
}