using System.Collections.Generic;
using System.Linq;
    using System;

    using System.ComponentModel.DataAnnotations;

    namespace PetStore.Models
    {
        public class Cart
        {
            public int ID { get; set; }
            [Required]
            [StringLength(50)]
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Pet pet, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Product.ID == pet.ID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = pet,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Pet product) =>
           lineCollection.RemoveAll(l => l.Product.ID == product.ID);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Pet Product { get; set; }
        public int Quantity { get; set; }
    }
}
        
    
        