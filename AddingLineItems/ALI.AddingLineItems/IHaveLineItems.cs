using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALI.AddingLineItems
{
    public interface IHaveLineItems
    {
        string Id { get; set; }

        List<LineItem> LineItems { get; set; }

        /// <summary>
        /// method to add the line items to the the LineItems property
        /// when building the header dynamically
        /// </summary>
        /// <param name="item">The line item</param>
        void AddLineItem(object item);
    }
}
