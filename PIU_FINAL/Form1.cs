using PIU_FINAL.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIU_FINAL
{
    public partial class Form1 : Form
    {
        private readonly Farmacie _farmacie;

        private readonly int PAS_Y = 28;

        private  List<IDisposable> elemente = new List <IDisposable>();

        public Form1(Farmacie farmacie)
        {
            InitializeComponent();
            _farmacie = farmacie;
        }

        public void ClearScreen()
        {
            foreach(var element in elemente)
            {
                element.Dispose();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            ClearScreen();
            var labelId = new Label();
            var labelNume = new System.Windows.Forms.Label();
            var labelCantitate = new System.Windows.Forms.Label();
            var labelGramaj = new System.Windows.Forms.Label();
            var labelTip = new System.Windows.Forms.Label();
            // 
            // labelId
            // 
            
            labelId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelId.ForeColor = System.Drawing.Color.White;
            labelId.Location = new System.Drawing.Point(210, 32);
            labelId.Name = "labelId";
            labelId.Size = new System.Drawing.Size(38, 26);
            labelId.TabIndex = 6;
            labelId.Text = "ID";
            // 
            // labelNume
            // 
            
            labelNume.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNume.ForeColor = System.Drawing.Color.White;
            labelNume.Location = new System.Drawing.Point(280, 32);
            labelNume.Name = "labelNume";
            labelNume.Size = new System.Drawing.Size(72, 26);
            labelNume.TabIndex = 7;
            labelNume.Text = "Nume";
            // 
            // labelCantitate
            // 
         
            labelCantitate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCantitate.ForeColor = System.Drawing.Color.White;
            labelCantitate.Location = new System.Drawing.Point(500, 32);
            labelCantitate.Name = "labelCantitate";
            labelCantitate.Size = new System.Drawing.Size(108, 26);
            labelCantitate.TabIndex = 8;
            labelCantitate.Text = "Cantitate";
            // 
            // labelGramaj
            // 
          
            labelGramaj.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGramaj.ForeColor = System.Drawing.Color.White;
            labelGramaj.Location = new System.Drawing.Point(700, 32);
            labelGramaj.Name = "labelGramaj";
            labelGramaj.Size = new System.Drawing.Size(92, 26);
            labelGramaj.TabIndex = 9;
            labelGramaj.Text = "Gramaj";
            // 
            // labelTip
            // 
     
            labelTip.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTip.ForeColor = System.Drawing.Color.White;
            labelTip.Location = new System.Drawing.Point(800, 32);
            labelTip.Name = "labelTip";
            labelTip.Size = new System.Drawing.Size(47, 26);
            labelTip.TabIndex = 10;
            labelTip.Text = "Tip";

            Controls.Add(labelTip);
            Controls.Add(labelGramaj);
            Controls.Add(labelCantitate);
            Controls.Add(labelNume);
            Controls.Add(labelId);

            elemente.Add(labelTip);
            elemente.Add(labelGramaj);
            elemente.Add(labelCantitate);
            elemente.Add(labelNume);
            elemente.Add(labelId);

            var pozitieYCurrenta = 26 + PAS_Y;

            foreach (var medicament in _farmacie.listaMedicamente)
            {
                labelId = new Label();
                labelNume = new System.Windows.Forms.Label();
                labelCantitate = new System.Windows.Forms.Label();
                labelGramaj = new System.Windows.Forms.Label();
                labelTip = new System.Windows.Forms.Label();
                // 
                // labelId
                // 

                labelId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelId.ForeColor = System.Drawing.Color.Black;
                labelId.Location = new System.Drawing.Point(210, pozitieYCurrenta);
                labelId.Name = "labelId";
                labelId.Size = new System.Drawing.Size(38, 26);
                labelId.TabIndex = 6;
                labelId.AutoSize = true; ;
                labelId.Text = medicament.Id.ToString();
                // 
                // labelNume
                // 

                labelNume.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelNume.ForeColor = System.Drawing.Color.Black;
                labelNume.Location = new System.Drawing.Point(280, pozitieYCurrenta);
                labelNume.Name = "labelNume";
                labelNume.Size = new System.Drawing.Size(72, 26);
                labelNume.TabIndex = 7;
                labelNume.AutoSize = true; ;
                labelNume.Text = medicament.NumeMedicament;
                // 
                // labelCantitate
                // 

                labelCantitate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCantitate.ForeColor = System.Drawing.Color.Black;
                labelCantitate.Location = new System.Drawing.Point(500, pozitieYCurrenta);
                labelCantitate.Name = "labelCantitate";
                labelCantitate.Size = new System.Drawing.Size(108, 26);
                labelCantitate.TabIndex = 8;
                labelCantitate.AutoSize = true; ;
                labelCantitate.Text = medicament.CantitateStoc;
                // 
                // labelGramaj
                // 

                labelGramaj.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelGramaj.AutoSize = true;
                labelGramaj.ForeColor = System.Drawing.Color.Black;
                labelGramaj.Location = new System.Drawing.Point(700, pozitieYCurrenta);
                labelGramaj.Name = "labelGramaj";
                labelGramaj.Size = new System.Drawing.Size(92, 26);
                labelGramaj.TabIndex = 9;
                labelGramaj.Text = medicament.Gramaj.ToString();
                // 
                // labelTip
                // 
                labelTip.AutoSize = true;
                labelTip.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTip.ForeColor = System.Drawing.Color.Black;
                labelTip.Location = new System.Drawing.Point(800, pozitieYCurrenta);
                labelTip.Name = "labelTip";
                labelTip.Size = new System.Drawing.Size(47, 26);
                labelTip.TabIndex = 10;
                labelTip.Text = medicament.Tip;

                Controls.Add(labelTip);
                Controls.Add(labelGramaj);
                Controls.Add(labelCantitate);
                Controls.Add(labelNume);
                Controls.Add(labelId);

                elemente.Add(labelTip);
                elemente.Add(labelGramaj);
                elemente.Add(labelCantitate);
                elemente.Add(labelNume);
                elemente.Add(labelId);

                pozitieYCurrenta += PAS_Y;
            }
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            ClearScreen();
            this.labelintrodNume = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelIntrodTip = new System.Windows.Forms.Label();
            this.textBoxStoc = new System.Windows.Forms.TextBox();
            this.labelIntrodGramaj = new System.Windows.Forms.Label();
            this.textBoxCGramaj = new System.Windows.Forms.TextBox();
            this.labelIntrodStoc = new System.Windows.Forms.Label();
            this.groupBoxAlegetip = new System.Windows.Forms.GroupBox();
            this.radioButtonSirop = new System.Windows.Forms.RadioButton();
            this.radioButtonPlicuri = new System.Windows.Forms.RadioButton();
            this.radioButtonPastile = new System.Windows.Forms.RadioButton();
            this.radioButtonUnguent = new System.Windows.Forms.RadioButton();
            this.groupBoxAlegetip.SuspendLayout();
            this.buttonSave = new System.Windows.Forms.Button();
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(900- 100, 370-79);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 50);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Salveaza medicament";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // labelintrodNume
            // 
            this.labelintrodNume.AutoSize = true;
            this.labelintrodNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelintrodNume.Location = new System.Drawing.Point(335, 96);
            this.labelintrodNume.Name = "labelintrodNume";
            this.labelintrodNume.Size = new System.Drawing.Size(78, 29);
            this.labelintrodNume.TabIndex = 6;
            this.labelintrodNume.Text = "Nume";
            this.labelintrodNume.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(460, 96);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(407, 22);
            this.textBoxNume.TabIndex = 7;
            // 
            // labelIntrodTip
            // 
            this.labelIntrodTip.AutoSize = true;
            this.labelIntrodTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntrodTip.Location = new System.Drawing.Point(335, 163);
            this.labelIntrodTip.Name = "labelIntrodTip";
            this.labelIntrodTip.Size = new System.Drawing.Size(49, 29);
            this.labelIntrodTip.TabIndex = 8;
            this.labelIntrodTip.Text = "Tip";
            this.labelIntrodTip.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTip
            // 
            this.textBoxStoc.Location = new System.Drawing.Point(460, 267);
            this.textBoxStoc.Name = "textBoxTip";
            this.textBoxStoc.Size = new System.Drawing.Size(407, 22);
            this.textBoxStoc.TabIndex = 9;
            // 
            // labelIntrodGramaj
            // 
            this.labelIntrodGramaj.AutoSize = true;
            this.labelIntrodGramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntrodGramaj.Location = new System.Drawing.Point(335, 216);
            this.labelIntrodGramaj.Name = "labelIntrodGramaj";
            this.labelIntrodGramaj.Size = new System.Drawing.Size(91, 29);
            this.labelIntrodGramaj.TabIndex = 10;
            this.labelIntrodGramaj.Text = "Gramaj";
            this.labelIntrodGramaj.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBoxCGramaj.Location = new System.Drawing.Point(460, 223);
            this.textBoxCGramaj.Name = "textBox1";
            this.textBoxCGramaj.Size = new System.Drawing.Size(407, 22);
            this.textBoxCGramaj.TabIndex = 11;
            // 
            // labelIntrodStoc
            // 
            this.labelIntrodStoc.AutoSize = true;
            this.labelIntrodStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntrodStoc.Location = new System.Drawing.Point(335, 260);
            this.labelIntrodStoc.Name = "labelIntrodStoc";
            this.labelIntrodStoc.Size = new System.Drawing.Size(61, 29);
            this.labelIntrodStoc.TabIndex = 12;
            this.labelIntrodStoc.Text = "Stoc";
            this.labelIntrodStoc.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // groupBoxAlegetip
            // 
            this.groupBoxAlegetip.Controls.Add(this.radioButtonUnguent);
            this.groupBoxAlegetip.Controls.Add(this.radioButtonPastile);
            this.groupBoxAlegetip.Controls.Add(this.radioButtonPlicuri);
            this.groupBoxAlegetip.Controls.Add(this.radioButtonSirop);
            this.groupBoxAlegetip.Location = new System.Drawing.Point(460, 139);
            this.groupBoxAlegetip.Name = "groupBoxAlegetip";
            this.groupBoxAlegetip.Size = new System.Drawing.Size(407, 67);
            this.groupBoxAlegetip.TabIndex = 13;
            this.groupBoxAlegetip.TabStop = false;
            this.groupBoxAlegetip.Text = "Alege Tip";
            // 
            // radioButtonSirop
            // 
            this.radioButtonSirop.AutoSize = true;
            this.radioButtonSirop.Location = new System.Drawing.Point(6, 24);
            this.radioButtonSirop.Name = "radioButtonSirop";
            this.radioButtonSirop.Size = new System.Drawing.Size(60, 20);
            this.radioButtonSirop.TabIndex = 0;
            this.radioButtonSirop.TabStop = true;
            this.radioButtonSirop.Text = "Sirop";
            this.radioButtonSirop.UseVisualStyleBackColor = true;
            this.radioButtonSirop.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonPlicuri
            // 
            this.radioButtonPlicuri.AutoSize = true;
            this.radioButtonPlicuri.Location = new System.Drawing.Point(80, 24);
            this.radioButtonPlicuri.Name = "radioButtonPlicuri";
            this.radioButtonPlicuri.Size = new System.Drawing.Size(64, 20);
            this.radioButtonPlicuri.TabIndex = 1;
            this.radioButtonPlicuri.TabStop = true;
            this.radioButtonPlicuri.Text = "Plicuri";
            this.radioButtonPlicuri.UseVisualStyleBackColor = true;
            // 
            // radioButtonPastile
            // 
            this.radioButtonPastile.AutoSize = true;
            this.radioButtonPastile.Location = new System.Drawing.Point(164, 24);
            this.radioButtonPastile.Name = "radioButtonPastile";
            this.radioButtonPastile.Size = new System.Drawing.Size(69, 20);
            this.radioButtonPastile.TabIndex = 2;
            this.radioButtonPastile.TabStop = true;
            this.radioButtonPastile.Text = "Pastile";
            this.radioButtonPastile.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnguent
            // 
            this.radioButtonUnguent.AutoSize = true;
            this.radioButtonUnguent.Location = new System.Drawing.Point(265, 24);
            this.radioButtonUnguent.Name = "radioButtonUnguent";
            this.radioButtonUnguent.Size = new System.Drawing.Size(78, 20);
            this.radioButtonUnguent.TabIndex = 3;
            this.radioButtonUnguent.TabStop = true;
            this.radioButtonUnguent.Text = "Unguent";
            this.radioButtonUnguent.UseVisualStyleBackColor = true;
            // 
            this.Controls.Add(this.groupBoxAlegetip);
            this.Controls.Add(this.labelIntrodStoc);
            this.Controls.Add(this.textBoxCGramaj);
            this.Controls.Add(this.labelIntrodGramaj);
            this.Controls.Add(this.textBoxStoc);
            this.Controls.Add(this.labelIntrodTip);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelintrodNume); 
            
            this.elemente.Add(this.groupBoxAlegetip);
            this.elemente.Add(this.labelIntrodStoc);
            this.elemente.Add(this.textBoxCGramaj);
            this.elemente.Add(this.labelIntrodGramaj);
            this.elemente.Add(this.textBoxStoc);
            this.elemente.Add(this.labelIntrodTip);
            this.elemente.Add(this.textBoxNume);
            this.elemente.Add(this.labelintrodNume);
            this.elemente.Add(this.buttonSave); 
            this.groupBoxAlegetip.ResumeLayout(false);
            this.groupBoxAlegetip.PerformLayout();
            this.Controls.Add(this.buttonSave);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string numeMedicament = string.Empty;
            string cantitateStoc = string.Empty;
            string tip = string.Empty;
            double gramaj = 0;

            numeMedicament = textBoxNume.Text;
            cantitateStoc = textBoxStoc.Text;

            if (radioButtonPastile.Checked)
            {
                tip = "Pastile";
            }
            else if (radioButtonPlicuri.Checked)
            {
                tip = "Plicuri ";
            }
            else if (radioButtonSirop.Checked)
            {
                tip = "Sirop";
            }
            else if (radioButtonUnguent.Checked)
            {
                tip = "Unguent";
            }
            else {
                MessageBox.Show("Alegeti tipul medicamnetului !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rezultat = double .TryParse(textBoxCGramaj.Text, out gramaj);
            if (!rezultat)
            {
                MessageBox.Show("Gramajul trebuie sa fie un numar !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var medicament = new Medicament(numeMedicament, cantitateStoc, gramaj, tip);
            _farmacie.AddMedicament(medicament);

            MessageBox.Show("Medicament adaugat !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearScreen();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Savesearch(object sender, EventArgs e)
        {
            var listamedicamente_gasite= new List<Medicament>();
            foreach (var medicament in _farmacie.listaMedicamente)
            {
                if (medicament.NumeMedicament.Contains(textBoxCauta.Text.ToLower()))
                {
                    listamedicamente_gasite.Add(medicament);
                }
                else if (medicament.Gramaj.ToString().Contains(textBoxCauta.Text.ToLower()))
                {
                    listamedicamente_gasite.Add(medicament);
                }
            }
            ClearScreen();
            var labelId = new Label();
            var labelNume = new System.Windows.Forms.Label();
            var labelCantitate = new System.Windows.Forms.Label();
            var labelGramaj = new System.Windows.Forms.Label();
            var labelTip = new System.Windows.Forms.Label();
            // 
            // labelId
            // 

            labelId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelId.ForeColor = System.Drawing.Color.White;
            labelId.Location = new System.Drawing.Point(210, 32);
            labelId.Name = "labelId";
            labelId.Size = new System.Drawing.Size(38, 26);
            labelId.TabIndex = 6;
            labelId.Text = "ID";
            // 
            // labelNume
            // 

            labelNume.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNume.ForeColor = System.Drawing.Color.White;
            labelNume.Location = new System.Drawing.Point(280, 32);
            labelNume.Name = "labelNume";
            labelNume.Size = new System.Drawing.Size(72, 26);
            labelNume.TabIndex = 7;
            labelNume.Text = "Nume";
            // 
            // labelCantitate
            // 

            labelCantitate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCantitate.ForeColor = System.Drawing.Color.White;
            labelCantitate.Location = new System.Drawing.Point(500, 32);
            labelCantitate.Name = "labelCantitate";
            labelCantitate.Size = new System.Drawing.Size(108, 26);
            labelCantitate.TabIndex = 8;
            labelCantitate.Text = "Cantitate";
            // 
            // labelGramaj
            // 

            labelGramaj.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGramaj.ForeColor = System.Drawing.Color.White;
            labelGramaj.Location = new System.Drawing.Point(700, 32);
            labelGramaj.Name = "labelGramaj";
            labelGramaj.Size = new System.Drawing.Size(92, 26);
            labelGramaj.TabIndex = 9;
            labelGramaj.Text = "Gramaj";
            // 
            // labelTip
            // 

            labelTip.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTip.ForeColor = System.Drawing.Color.White;
            labelTip.Location = new System.Drawing.Point(800, 32);
            labelTip.Name = "labelTip";
            labelTip.Size = new System.Drawing.Size(47, 26);
            labelTip.TabIndex = 10;
            labelTip.Text = "Tip";

            Controls.Add(labelTip);
            Controls.Add(labelGramaj);
            Controls.Add(labelCantitate);
            Controls.Add(labelNume);
            Controls.Add(labelId);

            elemente.Add(labelTip);
            elemente.Add(labelGramaj);
            elemente.Add(labelCantitate);
            elemente.Add(labelNume);
            elemente.Add(labelId);

            var pozitieYCurrenta = 26 + PAS_Y;

            foreach (var medicament in listamedicamente_gasite)
            {
                labelId = new Label();
                labelNume = new System.Windows.Forms.Label();
                labelCantitate = new System.Windows.Forms.Label();
                labelGramaj = new System.Windows.Forms.Label();
                labelTip = new System.Windows.Forms.Label();
                // 
                // labelId
                // 

                labelId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelId.ForeColor = System.Drawing.Color.Black;
                labelId.Location = new System.Drawing.Point(210, pozitieYCurrenta);
                labelId.Name = "labelId";
                labelId.Size = new System.Drawing.Size(38, 26);
                labelId.TabIndex = 6;
                labelId.AutoSize = true; ;
                labelId.Text = medicament.Id.ToString();
                // 
                // labelNume
                // 

                labelNume.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelNume.ForeColor = System.Drawing.Color.Black;
                labelNume.Location = new System.Drawing.Point(280, pozitieYCurrenta);
                labelNume.Name = "labelNume";
                labelNume.Size = new System.Drawing.Size(72, 26);
                labelNume.TabIndex = 7;
                labelNume.AutoSize = true; ;
                labelNume.Text = medicament.NumeMedicament;
                // 
                // labelCantitate
                // 

                labelCantitate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCantitate.ForeColor = System.Drawing.Color.Black;
                labelCantitate.Location = new System.Drawing.Point(500, pozitieYCurrenta);
                labelCantitate.Name = "labelCantitate";
                labelCantitate.Size = new System.Drawing.Size(108, 26);
                labelCantitate.TabIndex = 8;
                labelCantitate.AutoSize = true; ;
                labelCantitate.Text = medicament.CantitateStoc;
                // 
                // labelGramaj
                // 

                labelGramaj.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelGramaj.AutoSize = true;
                labelGramaj.ForeColor = System.Drawing.Color.Black;
                labelGramaj.Location = new System.Drawing.Point(700, pozitieYCurrenta);
                labelGramaj.Name = "labelGramaj";
                labelGramaj.Size = new System.Drawing.Size(92, 26);
                labelGramaj.TabIndex = 9;
                labelGramaj.Text = medicament.Gramaj.ToString();
                // 
                // labelTip
                // 
                labelTip.AutoSize = true;
                labelTip.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelTip.ForeColor = System.Drawing.Color.Black;
                labelTip.Location = new System.Drawing.Point(800, pozitieYCurrenta);
                labelTip.Name = "labelTip";
                labelTip.Size = new System.Drawing.Size(47, 26);
                labelTip.TabIndex = 10;
                labelTip.Text = medicament.Tip;

                Controls.Add(labelTip);
                Controls.Add(labelGramaj);
                Controls.Add(labelCantitate);
                Controls.Add(labelNume);
                Controls.Add(labelId);

                elemente.Add(labelTip);
                elemente.Add(labelGramaj);
                elemente.Add(labelCantitate);
                elemente.Add(labelNume);
                elemente.Add(labelId);

                pozitieYCurrenta += PAS_Y;
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            ClearScreen();
            this.textBoxCauta = new System.Windows.Forms.TextBox();
            this.labelntrodnumCautare = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();

            // textBoxCauta
            // 
            this.textBoxCauta.Location = new System.Drawing.Point(377, 139);
            this.textBoxCauta.Multiline = true;
            this.textBoxCauta.Name = "textBoxCauta";
            this.textBoxCauta.Size = new System.Drawing.Size(333, 49);
            this.textBoxCauta.TabIndex = 6;
            // 
            // labelntrodnumCautare
            // 
            this.labelntrodnumCautare.AutoSize = true;
            this.labelntrodnumCautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelntrodnumCautare.Location = new System.Drawing.Point(372, 90);
            this.labelntrodnumCautare.Name = "labelntrodnumCautare";
            this.labelntrodnumCautare.Size = new System.Drawing.Size(496, 29);
            this.labelntrodnumCautare.TabIndex = 8;
            this.labelntrodnumCautare.Text = "Introduceti numele medicamentului de cautat ";
            this.labelntrodnumCautare.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::PIU_FINAL.Properties.Resources.descărcare;
            
            this.pictureBoxSearch.Location = new System.Drawing.Point(197, 90);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(165, 132);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 7;
            this.pictureBoxSearch.TabStop = false;
            
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(621, 214);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 70);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Cauta";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Savesearch);
            // 
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelntrodnumCautare);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.textBoxCauta);

            this.elemente.Add(this.buttonSearch);
            this.elemente.Add(this.labelntrodnumCautare);
            this.elemente.Add(this.pictureBoxSearch);
            this.elemente.Add(this.textBoxCauta);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();

        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medicamente salvate in fisier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _farmacie.SaveMedicametnToFile("medicamente.txt");
            ClearScreen();
        }

        private void buttonIncarcare_Click(object sender, EventArgs e)
        {
            var amount = _farmacie.LoadMedicamentFromFile("medicamente.txt");

            MessageBox.Show($"{amount} Medicamente incarcate din fisier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearScreen();
        }
    }
}
