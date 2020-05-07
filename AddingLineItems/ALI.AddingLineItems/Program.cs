using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALI.AddingLineItems
{
    //Run the app with CTRL+F5 and it will remin open 
    //When pressing F5 the app will close autometically. We can either do Console.ReadLine(); or Console.ReadKey(); and wait.
    class Program
    {
        static void Main(string[] args)
        {
            "1. We have a List<T> of Header".WriteNewLine();
            "2. Building the header dynamicaly".WriteNewLine();
            "3. Each header will have multiple items".WriteNewLine();
            "4. Using the last header and adding the line items to it".WriteNewLine();
            "".EmptyLine();
            "".EmptyLine();

            var headers = new List<Header>();
            IHaveLineItems lastHeader = null;
            for (var i = 0; i < 2; i++)
            {
                var myData = new Header() { Id = i.ToString() };
                headers.Add(myData);
                lastHeader = myData;

                for (var j = 0; j < 2; j++)
                {
                    var line = new LineItem() { Description = $"Header {i} Line {j}" };
                    //new List<LineItem>(); is in the AddLineItem 
                    lastHeader.AddLineItem(line);
                }
            }

            foreach(var h in headers)
            {
                $"Header Id: {h.Id}".WriteNewLine(WriteLine.ColorCyan);
                foreach(var i in h.LineItems)
                {
                    $"\t LineItem Description: {i.Description}".WriteNewLine(WriteLine.ColorYellow);
                }
            }

            "".EmptyLine();
            "".EmptyLine();
            "Press any key to exit >>".WriteSameLine(WriteLine.ColorRed);
            Console.ReadKey();
        }
    }
}
