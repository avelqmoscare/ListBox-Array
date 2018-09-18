using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        enum Holidays { NewYear, AllSaintsDay, LaborDay, Christmas, Muntinlupa };
        struct HolidayStruct
        {
            public string Holiday;
        };


        private void btnShowEnumResult_Click(object sender, EventArgs e)
        {
            int NewYear = (int)Holidays.NewYear;
            int AllSaintsDay = (int)Holidays.AllSaintsDay;
            int LaborDay = (int)Holidays.LaborDay;
            int Christmas = (int)Holidays.Christmas;
            int Muntinlupa = (int)Holidays.Muntinlupa;


            string[] ListofHolidays = new string[] {lstHolidaysEnum.Items[0].ToString(),
                                                    lstHolidaysEnum.Items[1].ToString(),
                                                    lstHolidaysEnum.Items[2].ToString(),
                                                    lstHolidaysEnum.Items[3].ToString(),
                                                    lstHolidaysEnum.Items[4].ToString()};

            MessageBox.Show(ListofHolidays[NewYear]);
            MessageBox.Show(ListofHolidays[AllSaintsDay]);
            MessageBox.Show(ListofHolidays[LaborDay]);
            MessageBox.Show(ListofHolidays[Christmas]);
            MessageBox.Show(ListofHolidays[Muntinlupa]);

        }





        private void btnShowStructResult_Click(object sender, EventArgs e)
        {
            HolidayStruct NewYearStruct = new HolidayStruct();
            HolidayStruct AllSaintsDayStruct = new HolidayStruct();
            HolidayStruct LaborDayStruct = new HolidayStruct();
            HolidayStruct ChristmasStruct = new HolidayStruct();
            HolidayStruct MuntinlupaStruct= new HolidayStruct();


            NewYearStruct.Holiday = lstHolidaysStruct.Items[0].ToString();
            AllSaintsDayStruct.Holiday = lstHolidaysStruct.Items[1].ToString();
            LaborDayStruct.Holiday = lstHolidaysStruct.Items[2].ToString();
            ChristmasStruct.Holiday = lstHolidaysStruct.Items[3].ToString();
            MuntinlupaStruct.Holiday = lstHolidaysStruct.Items[4].ToString();

            string[] ListofHolidayStruct = new string[] { NewYearStruct.Holiday,
                                                          AllSaintsDayStruct.Holiday,
                                                          LaborDayStruct.Holiday,
                                                          ChristmasStruct.Holiday,
                                                          MuntinlupaStruct.Holiday};
            MessageBox.Show(ListofHolidayStruct[0]);
            MessageBox.Show(ListofHolidayStruct[1]);
            MessageBox.Show(ListofHolidayStruct[2]);
            MessageBox.Show(ListofHolidayStruct[3]);
            MessageBox.Show(ListofHolidayStruct[4]);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowStructResult_Click_1(object sender, EventArgs e)
        {

        }

        private void frmStrings_Load(object sender, EventArgs e)
        {

        }

    }
}
