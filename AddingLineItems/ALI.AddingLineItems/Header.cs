using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALI.AddingLineItems
{
    public class Header : IHaveLineItems
    {
        public string Id { get; set; }

        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// method to add the line items to the the LineItems property
        /// when building the header dynamically
        /// </summary>
        /// <param name="item">The line item</param>
        public void AddLineItem(object item)
        {
            if (LineItems == null)
            {
                LineItems = new List<LineItem>();
            }
            LineItems.Add((LineItem)item);
        }
    }
}
