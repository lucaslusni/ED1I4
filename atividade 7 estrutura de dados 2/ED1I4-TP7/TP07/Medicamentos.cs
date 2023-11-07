using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
    class Medications
    {
        private List<Medication> medicationList;

        public Medications()
        {
            medicationList = new List<Medication>();
        }

        public List<Medication> MedicationList { get => medicationList; }

        public void Add(Medication medication)
        {
            medicationList.Add(medication);
        }

        public bool Delete(Medication medication)
        {
            if (medication.AvailableQuantity() == 0)
            {
                medicationList.Remove(medication);
                return true;
            }
            return false;
        }

        public Medication Search(Medication medication)
        {
            foreach (Medication m in medicationList)
            {
                if (m.Identifier == medication.Identifier)
                {
                    return m;
                }
            }
            return new Medication(-1, "", "");
        }

        public Batch SearchBatch(Medication medication, Batch batch)
        {
            foreach (Medication m in medicationList)
            {
                if (m.Identifier == medication.Identifier)
                {
                    foreach (Batch b in m.Batches)
                    {
                        if (b.Identifier == batch.Identifier)
                        {
                            return b;
                        }
                    }
                }
            }
            return new Batch(-1, -1, DateTime.Now);
        }
    }
}
