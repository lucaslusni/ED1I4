using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
    class Batch
    {
        private int identifier;
        private int quantity;
        private DateTime expirationDate;

        public Batch()
        {
        }

        public Batch(int identifier, int quantity, DateTime expirationDate)
        {
            this.identifier = identifier;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }

        public int Identifier { get => identifier; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public String ExpirationDateString { get => expirationDate.ToString("dd/MM/yyyy"); }

        public override string ToString()
        {
            return identifier + "-" + quantity + "-" + expirationDate;
        }
    }
}