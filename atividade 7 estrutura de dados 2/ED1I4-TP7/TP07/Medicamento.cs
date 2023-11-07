using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
    class Medication
    {
        private int identifier;
        private string name;
        private string laboratory;
        private Queue<Batch> batches;

        public Medication()
        {
        }

        public Medication(int identifier, string name, string laboratory)
        {
            this.identifier = identifier;
            this.name = name;
            this.laboratory = laboratory;
            this.batches = new Queue<Batch>();
        }

        public int Identifier { get => identifier; }
        public string Name { get => name; }
        public string Laboratory { get => laboratory; }
        public Queue<Batch> Batches { get => batches; }

        public int AvailableQuantity()
        {
            int quantity = 0;
            foreach (Batch batch in batches)
            {
                quantity += batch.Quantity;
            }
            return quantity;
        }

        public void Purchase(Batch batch)
        {
            batches.Enqueue(batch);
        }

        public bool Sell(int quantity)
        {
            if (AvailableQuantity() >= quantity)
            {
                while (quantity > 0)
                {
                    Batch batch = batches.Peek();
                    if (batch.Quantity > quantity)
                    {
                        batch.Quantity -= quantity;
                        quantity = 0;
                    }
                    else
                    {
                        quantity -= batch.Quantity;
                        batches.Dequeue();
                    }
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return identifier + "-" + name + "-" + laboratory + "-" + AvailableQuantity();
        }

        public override bool Equals(object obj)
        {
            Medication medication1 = (Medication)obj;
            return this.identifier == medication1.Identifier;
        }
    }
}
