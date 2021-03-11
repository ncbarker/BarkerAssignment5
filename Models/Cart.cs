using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkerAssignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        //When new item is added do this to build the cart line:
        public void AddItem(Project proj, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Project.BookId == proj.BookId)
                .FirstOrDefault();
            //Add an item
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Project = proj,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }

        }
        //Remove an item from the cart
        public void RemoveLine(Project proj) =>
            Lines.RemoveAll(x => x.Project.BookId == proj.BookId);
        //Clear cart
        public void Clear() => Lines.Clear();

        public decimal ComputeTotalSum()
        {
            return (decimal)Lines.Sum(e => e.Project.BookPrice * e.Quantity);
        }

        public class CartLine
        {
            //Cart line contains these
            public int CartLineID { get; set; }
            public Project Project { get; set; }
            public int Quantity { get; set; }
        }
    }
}
