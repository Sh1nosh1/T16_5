using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_5
{
    class Conditioner
    {
        /// <summary>
        /// Date of activations
        /// </summary>
        private DateTime date_on;
        public DateTime Date_on { get => date_on; set => date_on = value; }
        /// <summary>
        /// Time of activations
        /// </summary>
        private DateTime time_on;
        public DateTime Time_on { get => time_on; set => time_on = value; }
        /// <summary>
        /// Temperature mode
        /// </summary>
        private static string temperature_mode;
        public static string Temperature_mode { get => temperature_mode; set => temperature_mode = value; }
        /// <summary>
        /// Temperature
        /// </summary>
        private int temperature;
        public int Temperature { get => temperature; set => temperature = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Conditioner() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="date_on">Initializing date of activation</param>
        /// <param name="time_on">Initializing time of activation</param>
        /// <param name="temperature">Initializing temperature</param>
        public Conditioner(DateTime date_on, DateTime time_on, int temperature)
        {
            this.Date_on = date_on; this.Time_on = time_on; this.Temperature = temperature;
            if(Temperature < 20) { Temperature_mode = "Cooling"; }
            else { Temperature_mode = "Heating"; }
        }
        /// <summary>
        /// Static constructor
        /// </summary>
        static Conditioner() { Temperature_mode = ""; }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"Activation date: {Date_on.ToShortDateString()}\nActivation time: {Time_on.ToLongTimeString()}\nTemperature mode: {Temperature_mode}\nTemperature: {Temperature}\nTo turn-on {(Time_on - DateTime.Now).TotalMinutes:f0} minutes\n");
        }

    }
}
