using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_5
{
    class VisitCounter
    {
        /// <summary>
        /// Web-address
        /// </summary>
        private string web_address;
        public string Web_address { get => (web_address != "" && web_address != " ")? web_address : "None"; set => web_address = value; }
        /// <summary>
        /// IP-address
        /// </summary>
        private string ip;
        public string Ip { get => (ip != "" && ip != " ")? ip : "None"; set => ip = value; }
        /// <summary>
        /// Browser
        /// </summary>
        private string browser;
        public string Browser { get => (browser != "" && browser != " ")? browser : "None"; set => browser = value; }
        /// <summary>
        /// Date of visit website
        /// </summary>
        private DateTime visit_date;
        public DateTime Visit_date { get => visit_date; set => visit_date = value; }
        /// <summary>
        /// Time of visit website
        /// </summary>
        private DateTime visit_time;
        public DateTime Visit_time { get => visit_time; set => visit_time = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public VisitCounter() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="web_address">Initializing web-address</param>
        /// <param name="ip">Initializing ip</param>
        /// <param name="browser">Initializing browser</param>
        /// <param name="visit_date">Initializing date of visit</param>
        /// <param name="visit_time">Initializing time of visit</param>
        public VisitCounter(string web_address, string ip, string browser, DateTime visit_date, DateTime visit_time)
        {
            this.web_address = web_address; this.ip = ip; this.browser = browser; this.visit_date = visit_date; this.visit_time = visit_time;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"Website address: {Web_address}\nIP: {Ip}\nBrowser: {Browser}\nDate of visit: {Visit_date:dddd}\nTime of visit: {Visit_time.ToLongTimeString()}");
        }
        public void Interval(DateTime date_1, DateTime date_2)
        {
            if (date_1 < Visit_time & date_2 > Visit_time)
            {
                Output();
            }
            else { Write("None"); }
        }






    }
}
