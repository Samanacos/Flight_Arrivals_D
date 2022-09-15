using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightArrivals_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Arrays to hold the flight information
        string[] flightNumbers = { "KO421", "ML261", "BA376", "MTH419", "ALK238", "KLM265", "THO132", "ALM145", "THO573", "HEN537" };
        string[] departAirport = { "Athens", "Manchester", "Dublin", "Salzburg", "Dallas", "Glasgow", "Geneva", "London", "Bordeaux", "London" };
        string[] arrivalTimes = { "14:32", "13:25", "13:16", "14:54", "14:18", "14:39", "13:57", "14:40", "15:10", "21:30" };

        //Declare the List
        List<Flight> arrivalBoard = new List<Flight>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create arrivals and add them to the List
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                Flight newFlight = new Flight(flightNumbers[i], departAirport[i], arrivalTimes[i]);
                arrivalBoard.Add(newFlight);
            }

            //sort the List
            arrivalBoard.Sort();

            //Display current arrivals
            DisplayArrivals(arrivalBoard);
        }

        //Display the List in the list box
        void DisplayArrivals(List<Flight> flight)
        {
            lstArrivals.Items.Clear();

            //for each object in the List
            for (int i = 0; i < flight.Count; i++)
            {
                //get a Flight object and add it to the list box
                Flight aFlight = (Flight)flight[i];

                lstArrivals.Items.Add(aFlight);
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFlight_Click_1(object sender, EventArgs e)
        {
            Flight newFlight;

            AddFlightForm addForm = new AddFlightForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                newFlight = addForm.GetData();  //get new Flight information

                //add the Flight to the List
                arrivalBoard.Add(newFlight);

                //sort List by arrival time and re-display it
                arrivalBoard.Sort();

                DisplayArrivals(arrivalBoard);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            //get index of selected flight
            int index = lstArrivals.SelectedIndex;

            if (index < 0)   //flight object was not found
            {
                MessageBox.Show("Flight number not found");
            }
            else
            {
                //remove the flight from the list and re-display the list
                arrivalBoard.Remove(arrivalBoard[index]);

                DisplayArrivals(arrivalBoard);
            }
        }

        private void btnAllFlights_Click(object sender, EventArgs e)
        {
            //sort List by arrival time and re-display it
            arrivalBoard.Sort();
            DisplayArrivals(arrivalBoard);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Flight> airportSearch = new List<Flight>();

            string searchName = txtAirport.Text;

                foreach (Flight f in arrivalBoard)
                {
                    if (String.Compare(searchName, f.DepartName) == 0)
                    {
                        airportSearch.Add(f);
                    }
                }

                if (airportSearch.Count == 0)
                {
                    lstArrivals.Items.Clear();
                    lstArrivals.Items.Add("No flights from " + searchName + " due");
                }
                else
                {
                    DisplayArrivals(airportSearch);
                }
        }

        private void lblArrivals_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAirport_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstArrivals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
