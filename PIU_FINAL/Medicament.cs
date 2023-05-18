using System;

namespace PIU_FINAL
{
    public class Medicament
    {
        public static int idCurrent = 0;
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int POZITIE_ID = 0;
        private const int POZITIE_NUME_MEDICAMENT = 1;
        private const int POZITIE_NR_MEDICAMENTE = 2;

        public int Id { get; set; } //identificator unic medicament
        public string NumeMedicament { get; set; }
        public string CantitateStoc { get; set; }
        public double Gramaj { get; set; }
        public string Tip { get; set; }

        //contructor implicit { get; set; }
        public Medicament()
        {
            Id = idCurrent++;
            NumeMedicament = string.Empty;
            CantitateStoc = string.Empty;
            Gramaj = 0;
            Tip = "Necunoscut";
        }

        //constructor cu parametri
        public Medicament(string numeMedicament, string cantitateMedicament, double gramaj, string tip)
        {
            Id = idCurrent++;
            NumeMedicament = numeMedicament;
            CantitateStoc = cantitateMedicament;
            Gramaj = gramaj;
            Tip = tip;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            Id = Convert.ToInt32(dateFisier[POZITIE_ID]);
            NumeMedicament = dateFisier[POZITIE_NUME_MEDICAMENT];
            CantitateStoc = dateFisier[POZITIE_NR_MEDICAMENTE];
            Gramaj = double.Parse(dateFisier[3]);
            Tip = dateFisier[4];
        }

        public string Info()
        {
            string info = string.Format("Id:{0} Nume:{1} Nr: {2}",
                ///interpolarea pentru formatarea șirului
                Id.ToString().PadLeft(5),
                NumeMedicament ?? " NECUNOSCUT ",
                CantitateStoc ?? " NECUNOSCUT ");


            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = 
                $"{Id}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{NumeMedicament}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{CantitateStoc}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{Gramaj}{SEPARATOR_PRINCIPAL_FISIER}" +
                $"{Tip}{SEPARATOR_PRINCIPAL_FISIER}\n";

            return obiectMedicamentPentruFisier;
        }


        public int GetIdMedicament()
        {
            return Id;
        }

        public string GetNume_medicament()
        {
            return NumeMedicament;
        }

        public string GetNr_Medicamente()
        {
            return CantitateStoc;
        }
    }
}
