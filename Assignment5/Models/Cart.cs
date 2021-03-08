﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Book bk, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Book.BookId == bk.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bk,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveLine(Book bk) =>
            Lines.RemoveAll(x => x.Book.BookId == bk.BookId);

        public virtual void Clear() => Lines.Clear();

        public double ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);
        

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
