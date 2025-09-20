using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Stock
{
    //!NOTE!: Class StockBroker has fields broker name and a list of Stock named stocks.
    // addStock method registers the Notify listener with the stock (in addition to
    // adding it to the lsit of stocks held by the broker). This notify method outputs
    // to the console the name, value, and the number of changes of the stock whose
    // value is out of the range given the stock's notification threshold.
    public class StockBroker
    {
        public string BrokerName { get; set; }
        public List<Stock> stocks = new List<Stock>();

        //readonly string docPath = @"C:\Users\Documents\CECS 475\Lab3_output.txt";
        readonly string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lab1_output.txt");
        public string titles = "Broker".PadRight(10) + "Stock".PadRight(15) + "Value".PadRight(10) + "Changes".PadRight(10) + "Date and Time";

        Console.WriteLine(___________________);
        using (StreamWriter outputFile = new StreamWriter(________, _____________))
        {
            outputFile.WriteLine(titles);
        }

        /// <summary>
        /// The stockbroker object
        /// </summary>
        /// <param name="brokerName">The stockbroker's name</param>
        public StockBroker(string brokerName)
        {
            BrokerName = brokerName;
        }

        //---------------------------------------------------------------------------------------
        /// <summary>
        /// Adds stock objects to the stock list
        /// </summary>
        /// <param name="stock">Stock object</param>
        public void AddStock(Stock stock)
        {
            stocks._____________________________;
            stock.____________________________________;
        }

        /// <summary>
        /// The eventhandler that raises the event of a change
        /// </summary>
        /// <param name="sender">The sender that indicated a change</param>
        /// <param name="e">Event arguments</param>
        public ______ void EventHandler(Object sender, StockNotification e)
        {
            Stock newStock = (Stock)sender;
            _____ write(sender, e);
            return;
        }

        public _________ write(________, ______ e)
        {
            String line = BrokerName.PadRight(16) + e.StockName.PadRight(16) + Convert.ToString(e.CurrentValue).PadRight(16) + Convert.ToString(e.NumChanges).PadRight(16) + DateTime.Now;
            try
            {
                if (count == 0)
                {
                    Console.WriteLine(titles);
                    using (StreamWriter outputFile = new StreamWriter(destPath, ______))
                    {
                        ________________________________________;
                    }
                } //end if
                using (StreamWriter outputFile = new StreamWriter(destPath, __________))
                {
                    ____________ outputFile.__________________(__________);
                }
                Console.WriteLine(__________);
            }
            catch(IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}