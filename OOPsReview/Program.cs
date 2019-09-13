using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 6.5;
            double width = 8.0;
            double linearheight = 125.0;
            string style = "Neighbour Friendly";
            double price = 296.80;

            //creae a non-statice instance of a class 
            //the new command reference the class constructor 

            FencePanel fenceinfo = new FencePanel(height, width, style, price);


            Gate gateInfo;
            List<Gate> gateList = new List<Gate>();

            gateInfo = new Gate();
            height = 6.25;
            width = 4.0;
            style = "neighbour Friendly - Picket";
            price = 325.0;
            gateInfo.Height = height;
            gateInfo.Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            //pass 2
            gateInfo = new Gate();
            height = 6.25;
            width = 4.0;
            style = "neighbour Friendly - Spruce";
            price = 325.0;
            gateInfo.Height = height;
            gateInfo.Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            //create the estimate
            Estimate theestimate = new Estimate();      //class default costructor
            theestimate.LinearLength = linearheight;
            theestimate.Panel = fenceinfo;
            theestimate.Gates = gateList;
            theestimate.CalculatePrice();

            Console.WriteLine("The Fence is to be a" + theestimate.Panel.Style);
            Console.WriteLine("Total Linear Length {0}", theestimate.LinearLength);
            Console.WriteLine("Number of Required panels{0}", theestimate.Panel.EstimatedNumberOfPanels(theestimate.LinearLength));
            Console.WriteLine("Number of Gates{0}", theestimate.Gates.Count);

            double fencearea = theestimate.Panel.FenceArea(theestimate.LinearLength);
            foreach (var item in theestimate.Gates)
            {
                fencearea += item.GateArea();
            }

            Console.WriteLine(string.Format("The total Fence Area is{0}", fencearea*2));
            Console.ReadKey();
        }
    }
}
