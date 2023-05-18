namespace PIU_FINAL
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
            this.buttonAdaugare = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalvare = new System.Windows.Forms.Button();
            this.buttonIncarcare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdaugare
            // 
            this.buttonAdaugare.Location = new System.Drawing.Point(421, 455);
            this.buttonAdaugare.Name = "buttonAdaugare";
            this.buttonAdaugare.Size = new System.Drawing.Size(100, 79);
            this.buttonAdaugare.TabIndex = 1;
            this.buttonAdaugare.Text = "Adauga \r\nMedicamente\r\n";
            this.buttonAdaugare.UseVisualStyleBackColor = true;
            this.buttonAdaugare.Click += new System.EventHandler(this.buttonAdaugare_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(527, 455);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(103, 79);
            this.buttonAfisare.TabIndex = 2;
            this.buttonAfisare.Text = "Afisare medicament";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // buttonCautare
            // 
            this.buttonCautare.Location = new System.Drawing.Point(636, 455);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(101, 79);
            this.buttonCautare.TabIndex = 3;
            this.buttonCautare.Text = "Cautare medicament";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIU_FINAL.Properties.Resources.farmacie_simbol;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonSalvare
            // 
            this.buttonSalvare.Location = new System.Drawing.Point(743, 455);
            this.buttonSalvare.Name = "buttonSalvare";
            this.buttonSalvare.Size = new System.Drawing.Size(111, 79);
            this.buttonSalvare.TabIndex = 4;
            this.buttonSalvare.Text = "Salvare medicamente\r\n";
            this.buttonSalvare.UseVisualStyleBackColor = true;
            this.buttonSalvare.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // buttonIncarcare
            // 
            this.buttonIncarcare.Location = new System.Drawing.Point(860, 455);
            this.buttonIncarcare.Name = "buttonIncarcare";
            this.buttonIncarcare.Size = new System.Drawing.Size(118, 79);
            this.buttonIncarcare.TabIndex = 5;
            this.buttonIncarcare.Text = "Incarcare\r\nmedicamente\r\n";
            this.buttonIncarcare.UseVisualStyleBackColor = true;
            this.buttonIncarcare.Click += new System.EventHandler(this.buttonIncarcare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1318, 546);
            this.Controls.Add(this.buttonIncarcare);
            this.Controls.Add(this.buttonSalvare);
            this.Controls.Add(this.buttonCautare);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.buttonAdaugare);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Farmacia Simona";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdaugare;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.Button buttonSalvare;
        private System.Windows.Forms.Button buttonIncarcare;
        private System.Windows.Forms.Label labelintrodNume;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelIntrodTip;
        private System.Windows.Forms.TextBox textBoxStoc;
        private System.Windows.Forms.Label labelIntrodGramaj;
        private System.Windows.Forms.TextBox textBoxCGramaj;
        private System.Windows.Forms.Label labelIntrodStoc;
        private System.Windows.Forms.GroupBox groupBoxAlegetip;
        private System.Windows.Forms.RadioButton radioButtonPastile;
        private System.Windows.Forms.RadioButton radioButtonPlicuri;
        private System.Windows.Forms.RadioButton radioButtonSirop;
        private System.Windows.Forms.RadioButton radioButtonUnguent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCauta;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label labelntrodnumCautare;
        private System.Windows.Forms.Button buttonSearch;
    }
}

