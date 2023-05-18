using System;
using System.Windows.Forms;

namespace PIU_FINAL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var farmacie = new Farmacie("Catena");

            //farmacie.AddMedicament(new Medicament("Aspirina", "10 cutii", 25, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Nurofen", "5 cutii", 18, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Paracetamol", "8 cutii", 12, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Ibuprofen", "6 sticle", 15, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Omeprazol", "3 cutii", 30, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Amoxicilina", "4 cutii", 20, "Sirop"));
            //farmacie.AddMedicament(new Medicament("Ranitidina", "2 cutii", 10, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Cetirizina", "7 cutii", 8, "Pastile"));
            //farmacie.AddMedicament(new Medicament("Diazepam", "1 cutie", 35, "Pastile"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ;
            Application.Run(new Form1(farmacie));
        }
    }
}
