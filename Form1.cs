using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2
{
    public partial class ManageFlight : Form
    {
        SQLConnect r = new SQLConnect();
        String sql;
        int from, To;
        public ManageFlight()
        {
            InitializeComponent();
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            Apply a = new Apply();
            a.Show();
            this.Hide();
        }

        private void ManageFlight_Load(object sender, EventArgs e)
        {
            color();
            dg();
            this.scheddg.Columns["ID"].Visible = false;
            this.scheddg.Columns["Confirmed"].Visible = false;
        }
        private void dg()
        {
            sql = @"Select Schedules.Date, Schedules.Time,
            (Select IATACode from Airports where ID = Routes.DepartureAirportID) as [From],
            (Select IATACode from Airports where ID = Routes.ArrivalAirportID) as [To],
            Schedules.FlightNumber,Aircrafts.Name as[Aircraft],
            cast((EconomyPrice) as float) as[Economy Price],
            cast(EconomyPrice * .35 + EconomyPrice as float) as[Business Price],
            cast((EconomyPrice * .35 + EconomyPrice)  * .30 + (EconomyPrice * .35 + EconomyPrice)as float) as[First Class Price],Schedules.ID,Confirmed
            from Schedules
            inner join Routes on Schedules.RouteID = Routes.ID
            inner
            join Aircrafts on Schedules.AircraftID = Aircrafts.ID order by Date desc";
            scheddg.DataSource = r.MultipleData(sql).Tables["tbl"];
            color();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fromTo();
            if (cmbSort.SelectedIndex == 0)
            {
                sql = @"Select Schedules.Date, Schedules.Time,
            (Select IATACode from Airports where ID = Routes.DepartureAirportID) as [From],
            (Select IATACode from Airports where ID = Routes.ArrivalAirportID) as [To],
            Schedules.FlightNumber,Aircrafts.Name as[Aircraft],
            cast((EconomyPrice) as float) as[Economy Price],
            cast(EconomyPrice * .35 + EconomyPrice as float) as[Business Price],
            cast((EconomyPrice * .35 + EconomyPrice)  * .30 + (EconomyPrice * .35 + EconomyPrice)as float) as[First Class Price],Schedules.ID,Confirmed
            from Schedules
            inner join Routes on Schedules.RouteID = Routes.ID
            inner
            join Aircrafts on Schedules.AircraftID = Aircrafts.ID where DepartureAirportID ='" + from+ "'and ArrivalAirportID='" + To+"'and Date='" + outboundate.Value.ToString("yyyyMMdd")+ "'order by Date desc";
               scheddg.DataSource = r.MultipleData(sql).Tables["tbl"];
            }
            else if (cmbSort.SelectedIndex == 1)
            {
                sql = @"Select Schedules.Date, Schedules.Time,
            (Select IATACode from Airports where ID = Routes.DepartureAirportID) as [From],
            (Select IATACode from Airports where ID = Routes.ArrivalAirportID) as [To],
            Schedules.FlightNumber,Aircrafts.Name as[Aircraft],
            cast((EconomyPrice) as float) as[Economy Price],
            cast(EconomyPrice * .35 + EconomyPrice as float) as[Business Price],
            cast((EconomyPrice * .35 + EconomyPrice) * .30 + (EconomyPrice * .35 + EconomyPrice)as float)  as[First Class Price],Schedules.ID,Confirmed
            from Schedules
            inner join Routes on Schedules.RouteID = Routes.ID
            inner
            join Aircrafts on Schedules.AircraftID = Aircrafts.ID where DepartureAirportID ='" + from + "' and ArrivalAirportID='" + To + "'and FlightNumber='" + txtflightnum.Text + "'order by Date desc";
                scheddg.DataSource = r.MultipleData(sql).Tables["tbl"];
            }
            else if (cmbSort.SelectedIndex == 2)
            {
                sql = @"Select Schedules.Date, Schedules.Time,
            (Select IATACode from Airports where ID = Routes.DepartureAirportID) as [From],
            (Select IATACode from Airports where ID = Routes.ArrivalAirportID) as [To],
            Schedules.FlightNumber,Aircrafts.Name as[Aircraft],
            cast((EconomyPrice) as float) as[Economy Price],
            cast(EconomyPrice * .35 + EconomyPrice as float) as[Business Price],
            cast((EconomyPrice * .35 + EconomyPrice)  * .30 + (EconomyPrice * .35 + EconomyPrice)as float) as[First Class Price],Schedules.ID,Confirmed
            from Schedules
            inner join Routes on Schedules.RouteID = Routes.ID
            inner
            join Aircrafts on Schedules.AircraftID = Aircrafts.ID where DepartureAirportID ='" + from + "' and ArrivalAirportID='" + To + "'and FlightNumber='" + txtflightnum.Text + "'and Date='" + outboundate.Value.ToString("yyyyMMdd") + "'order by Date desc";
                scheddg.DataSource = r.MultipleData(sql).Tables["tbl"];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(scheddg.Rows[scheddg.CurrentRow.Index].Cells["Confirmed"].Value.ToString()) == true)
            {
                sql = "Update Schedules set Confirmed=0 where ID='" + scheddg.Rows[scheddg.CurrentRow.Index].Cells["ID"].Value + "'";
                r.Modify(sql);
                MessageBox.Show("The Schedule was cancel!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                color();
                dg();
            }
            else 
            {
                MessageBox.Show("Schedule is already cancelled!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void color()
        {
            foreach(DataGridViewRow a in scheddg.Rows)
            {
                if(Convert.ToBoolean(a.Cells["Confirmed"].Value.ToString()) == true)
                {
                    scheddg.DefaultCellStyle.BackColor = Color.FromArgb(247,148,032);
                }
                if (Convert.ToBoolean(a.Cells["Confirmed"].Value.ToString()) == false)
                {
                    scheddg.DefaultCellStyle.BackColor = Color.Red;
                }
                
               
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit a = new Edit();
            a.dv = scheddg.Rows[scheddg.CurrentRow.Index];
            a.Show();
            this.Hide();
        }

        //fromto code
        private void fromTo()
        {
            if (cmbfrom.Text == "AUH")
            {
                from = 2;
            }
            else if (cmbfrom.Text == "CAI")
            {
                from = 3;
            }
            else if (cmbfrom.Text == "BAH")
            {
                from = 4;
            }
            else if (cmbfrom.Text == "ADE")
            {
                from = 5;
            }
            else if (cmbfrom.Text == "DOH")
            {
                from = 6;
            }
            else if (cmbfrom.Text == "RUH")
            {
                from = 7;
            }
            if (cmbTo.Text == "AUH")
            {
                To = 2;
            }
            else if (cmbTo.Text == "CAI")
            {
                To = 3;
            }
            else if (cmbTo.Text == "BAH")
            {
                To = 4;
            }
            else if (cmbTo.Text == "ADE")
            {
                To = 5;
            }
            else if (cmbTo.Text == "DOH")
            {
                To = 6;
            }
            else if (cmbTo.Text == "RUH")
            {
                To = 7;
            }
        }
    }
}
