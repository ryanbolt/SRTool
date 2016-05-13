using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRTool
{
    public partial class Form1 : Form
    {
        TimeZoneInfo utcZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        TimeZoneInfo nstZone = TimeZoneInfo.FindSystemTimeZoneById("Newfoundland Standard Time");
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (nstRadioButton.Checked)
            {
                ConvertFromNst();
            }

            if (pstRadioButton.Checked)
            {
                ConvertFromPst();
            }

            if (utcRadioButton.Checked)
            {
                ConvertFromUtc();
            }
        }

        private void Enable_Boxes(object sender, EventArgs e)
        {
            if (nstRadioButton.Checked)
            {
                nstTimePicker.Enabled = true;
                pstTimePicker.Enabled = false;
                utcTimePicker.Enabled = false;
            }

            if (pstRadioButton.Checked)
            {
                nstTimePicker.Enabled = false;
                pstTimePicker.Enabled = true;
                utcTimePicker.Enabled = false;
            }

            if (utcRadioButton.Checked)
            {
                nstTimePicker.Enabled = false;
                pstTimePicker.Enabled = false;
                utcTimePicker.Enabled = true;
            }





        }

        public void ConvertFromNst()
        {


            DateTime nstTime = nstTimePicker.Value;
            DateTime utcTime = TimeZoneInfo.ConvertTime(nstTime, utcZone);
            DateTime pstTime = TimeZoneInfo.ConvertTime(nstTime, pstZone);

            utcTimePicker.Value = utcTime;
            pstTimePicker.Value = pstTime;

        }
        public void ConvertFromPst()
        {

            DateTime pstTime = pstTimePicker.Value;
            DateTime utcTime = TimeZoneInfo.ConvertTime(pstTime, utcZone);
            DateTime nstTime = TimeZoneInfo.ConvertTime(pstTime, nstZone);


            utcTimePicker.Value = utcTime;
            nstTimePicker.Value = nstTime;

        }


        public void ConvertFromUtc()
        {

            DateTime utcTime = utcTimePicker.Value;
            DateTime pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);
            DateTime nstTime = TimeZoneInfo.ConvertTime(utcTime, nstZone);

            pstTimePicker.Value = pstTime;
            nstTimePicker.Value = nstTime;

        }

    }
}
