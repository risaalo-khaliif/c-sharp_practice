using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HOTEL_ROOM_BOOKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    // 1. Akhriska xogta ku jirta Textboxyada
                    string guestName = txtName.Text;
                    int guestAge = int.Parse(txtAge.Text);
                    int numberOfNights = int.Parse(txtNights.Text);
                    int numberOfGuests = int.Parse(txtguests.Text);

                    double roomRate = 0;

                    // 2. Go'aaminta qiimaha qolka iyadoo la eegayo RadioButton-ka la doortay
                    if (radStandard.Checked)
                    {
                        roomRate = 50; // Qiimaha Standard
                    }
                    else if (radNormal.Checked)
                    {
                        roomRate = 80; // Qiimaha Normal
                    }
                    else if (radHigh.Checked)
                    {
                        roomRate = 120; // Qiimaha Hight
                    }

                    // 3. Xisaabinta wadarta qiimaha qolka iyo quraacda
                    double totalRoomCost = roomRate * numberOfNights * numberOfGuests;
                    double breakfastCost = 0;

                    if (chkBreakfast.Checked)
                    {
                        breakfastCost = 10 * numberOfGuests * numberOfNights; // $10 per guest per night
                    }

                    double grandTotal = totalRoomCost + breakfastCost;

                    // 4. Ku soo bandhigida natiijada ListBox-ka
                    listBox1.Items.Clear();
                    listBox1.Items.Add("=== FAAFHIN BIXINTA ===");
                    listBox1.Items.Add("Magaca: " + guestName);
                    listBox1.Items.Add("Da'da: " + guestAge);
                    listBox1.Items.Add("Habeenada: " + numberOfNights);
                    listBox1.Items.Add("Tirada Martida: " + numberOfGuests);
                    listBox1.Items.Add("Qiimaha Qolka: $" + totalRoomCost);

                    if (chkBreakfast.Checked)
                    {
                        listBox1.Items.Add("Qiimaha Quraacda: $" + breakfastCost);
                    }

                    listBox1.Items.Add("-----------------------------");
                    listBox1.Items.Add("Wadarta Guud: $" + grandTotal);
                }
                catch (FormatException)
                {
                    // Haddii int.Parse uu ku dhaco tiro aan sax ahayn (Muddan inaad xarfo ku qortay age, nights, ama guests)
                    MessageBox.Show("Fadlan da'da, tirada habeenada, iyo tirada martida ku qor tirooyin sax ah!", "Khalad Gelin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    // Khalad kasta oo kale oo dhaca
                    MessageBox.Show("Khalad ayaa dhacay: " + ex.Message, "Digniin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        {
            // Tir-tir xogta Textboxyada
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtguests.Clear();

            // Ka bixi doorashooyinka RadioButtons-ka iyo CheckBox-ka
            radStandard.Checked = false;
            radNormal.Checked = false;
            radHigh.Checked = false;
            chkBreakfast.Checked = false;

            // Faaruqi ListBox-ka
            listBox1.Items.Clear();

            // Cursor-ka (mishiinka qoraalka) ku celi magaca ku bilaabida
            txtName.Focus();
        }
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
