using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Anthony A----------
//
// Form application to determine the price of a haircut. 
// The form takes selections from the user (hairdresser and service(s)) to determine the price required for their choosen haircut.
// The selections are done through a combobox and listboxes.
// The user can add services, calculate total price, reset the form, or exit the form with buttons

namespace Lab3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculateTotalButton.Enabled = false;   // sets calculate button to disable
            addServiceButton.Enabled = false;
        }

        decimal totalPrice = 0m;    // total price of the whole haircut

        /// <summary>
        /// Adds hairdresser + 1st service selected to the charged items listbox
        /// After that, will only add the next selected item selected to charged items listbox
        /// until the user decides to calculate, reset, or exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            calculateTotalButton.Enabled = true;    // sets calculate button to enable (once service + hairdresser are added)     

            // Adds hairdresser and service items to itemListBox for display (first time "Add Service" button is hit)
            if (serviceListBox != null && itemsListBox.Items.Count == 0)
            {
                string hairItem = hairdresserComboBox.SelectedItem.ToString();
                itemsListBox.Items.Add(hairItem);
                hairdresserComboBox.Enabled = false;
            }

            // If statement to disable hairdresser combobox (hairdresserComboBox) if the user already chose a hairdresser
            if (serviceListBox != null && hairdresserComboBox.Enabled == false && itemsListBox.Items.Contains("Jane Samley") || itemsListBox.Items.Contains("Pat Johnson") ||
                itemsListBox.Items.Contains("Ron Chambers") || itemsListBox.Items.Contains("Sue Pallon") ||
                itemsListBox.Items.Contains("Laura Renkins"))
            {
                string servItem = serviceListBox.SelectedItem.ToString();
                itemsListBox.Items.Add(servItem);
            }
            else
            {
                MessageBox.Show("Error in Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     // error message display
            }

            // Check to see if anything is in the items list box / no prices (hairdresser + first service selected added to price)
            if (itemsListBox.Items.Count > 0 && priceListBox.Items.Count == 0)
            {
                // does not allow user to select items in listboxes
                itemsListBox.Enabled = false;
                priceListBox.Enabled = false;

                // hairdresser price added to total
                if (itemsListBox.Items.Contains("Jane Samley"))
                {
                    priceListBox.Items.Add("$30.00");
                    totalPrice += 30m;
                }
                if (itemsListBox.Items.Contains("Pat Johnson"))
                {
                    priceListBox.Items.Add("$45.00");
                    totalPrice += 45m;
                }
                if (itemsListBox.Items.Contains("Ron Chambers"))
                {
                    priceListBox.Items.Add("$40.00");
                    totalPrice += 40m;
                }
                if (itemsListBox.Items.Contains("Sue Pallon"))
                {
                    priceListBox.Items.Add("$50.00");
                    totalPrice += 50m;
                }
                if (itemsListBox.Items.Contains("Laura Renkins"))
                {
                    priceListBox.Items.Add("$55.00");
                    totalPrice += 55m;
                }
                // service price added to total
                if (itemsListBox.Items.Contains("Cut"))
                {
                    priceListBox.Items.Add("$30.00");
                    totalPrice += 30m;
                }
                if (itemsListBox.Items.Contains("Wash, blow-dry, and style"))
                {
                    priceListBox.Items.Add("$20.00");
                    totalPrice += 20m;
                }
                if (itemsListBox.Items.Contains("Colour"))
                {
                    priceListBox.Items.Add("$40.00");
                    totalPrice += 40m;
                }
                if (itemsListBox.Items.Contains("Highlights"))
                {
                    priceListBox.Items.Add("$50.00");
                    totalPrice += 50m;
                }
                if (itemsListBox.Items.Contains("Extensions"))
                {
                    priceListBox.Items.Add("$200.00");
                    totalPrice += 200m;
                }
                if (itemsListBox.Items.Contains("Up-do"))
                {
                    priceListBox.Items.Add("$60.00");
                    totalPrice += 60m;
                }
            }
            // if statement for when priceListBox contains the hairdresser + 1st service already
            else if (itemsListBox.Items.Count > 0)
            {
                // variable to hold the last service inputted - check to see what service it was so I can add price
                string temp = itemsListBox.Items[itemsListBox.Items.Count - 1].ToString();

                // service price added to total
                if (temp.Equals("Cut"))
                {
                    priceListBox.Items.Add("$30.00");
                    totalPrice += 30m;
                }
                if (temp.Equals("Wash, blow-dry, and style"))
                {
                    priceListBox.Items.Add("$20.00");
                    totalPrice += 20m;
                }
                if (temp.Equals("Colour"))
                {
                    priceListBox.Items.Add("$40.00");
                    totalPrice += 40m;
                }
                if (temp.Equals("Highlights"))
                {
                    priceListBox.Items.Add("$50.00");
                    totalPrice += 50m;
                }
                if (temp.Equals("Extensions"))
                {
                    priceListBox.Items.Add("$200.00");
                    totalPrice += 200m;
                }
                if (temp.Equals("Up-do"))
                {
                    priceListBox.Items.Add("$60.00");
                    totalPrice += 60m;
                }
            }
            else
            {
                MessageBox.Show("Error in Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     // error message display
            }
        }

        /// <summary>
        /// Enables add service button once a service is picked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addServiceButton.Enabled = true;
        }

        /// <summary>
        /// Calculates total price of hairdresser and service(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            totalTextBox.Text = $"{totalPrice:C}";
        }

        /// <summary>
        /// Clears the form for a new user to choose options
        /// Resets controls to originals and sets focus to the hairdresser combobox
        /// Also defaults to first entry in the combobox (Jane Samley)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            hairdresserComboBox.Enabled = true;
            serviceListBox.SelectedIndex = -1;
            itemsListBox.Items.Clear();
            priceListBox.Items.Clear();
            calculateTotalButton.Enabled = false;
            addServiceButton.Enabled = false;
            totalTextBox.Clear();
            totalPrice = 0;
            hairdresserComboBox.SelectedIndex = 0;
            hairdresserComboBox.Focus();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
