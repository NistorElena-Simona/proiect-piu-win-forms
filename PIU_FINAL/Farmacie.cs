using System;
using System.Collections.Generic;
using System.IO;

namespace PIU_FINAL
{
    public class Farmacie
    {
        public string nume;
        public List<Medicament> listaMedicamente = new List<Medicament>();

        public Farmacie(string nume_farmacie)
        {

            this.nume = nume_farmacie;
        }

        public void AddMedicament(Medicament medicament)
        {
            this.listaMedicamente.Add(medicament);
        }

        public Medicament GetMedicament(string nune_medicament)
        {
            foreach (Medicament me in this.listaMedicamente)
            {
                if (me == null) break;

                if (me.GetNume_medicament() == nune_medicament)
                    return me;

            }
            return null;
        }

        public int LoadMedicamentFromFile(string fileName)
        {
            listaMedicamente.Clear();

            int nrMedicamenteAdaugate = 0;

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string linieFisier;

                /* citeste cate o linie si creaza un obiect de tip Person
                pe baza datelor din linia citita */

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    if (linieFisier.Length == 0) continue;

                    this.listaMedicamente.Add(new Medicament(linieFisier));
                    nrMedicamenteAdaugate++;
                }
            }

            return nrMedicamenteAdaugate;
        }

        /// <summary>
        /// Saves all the current contacts to the specified file
        /// </summary>
        /// <param name="fileName"> The name of the file to save the contacts to</param>
        public void SaveMedicametnToFile(string fileName)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(fileName, false))
            {
                foreach (var medicament in listaMedicamente)
                {
                    streamWriterFisierText.Write(medicament.ConversieLaSir_PentruFisier());
                }
            }
        }
    }
}
