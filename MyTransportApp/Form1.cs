using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class fahrplanApp : Form
    {
        Transport transport = new Transport();
        public fahrplanApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            suchenButton.Enabled = false;
            datumEingabe.Value = DateTime.Now;
            zeitEingabe.Value = DateTime.Now;
        }

        private void startStationEingabe_TextChanged(object sender, EventArgs e)
        {
            suchenButton.Enabled = true;

            if (startStationEingabe.Text.Length > 0)
            {
                try
                {
                    var vorschlaege = transport.GetStations(startStationEingabe.Text);
                    foreach (var vorschlag in vorschlaege.StationList)
                    {
                        startStationEingabe.Items.Add(vorschlag.Name);
                    }
                }
                catch
                {
                    MessageBox.Show("Bitte eine gültige Eingabe machen.");
                }                
            }
        }

        private void endStationEingabe_TextChanged(object sender, EventArgs e)
        {
            if (endStationEingabe.Text.Length > 0)
            {
                try
                {
                    var vorschlaege = transport.GetStations(endStationEingabe.Text);
                    foreach (var vorschlag in vorschlaege.StationList)
                    {
                        endStationEingabe.Items.Add(vorschlag.Name);
                    }
                }
                catch
                {
                    MessageBox.Show("Bitte eine gültige Eingabe machen.");
                }
            }
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            verbindungenAnzeige.Rows.Clear();
            
            if (endStationEingabe.Text.Length >= 1)
            {
                StartEndeAnzeige();                                
            }

            else 
            {
                StartAbfahrtstafel();                
            }
        }

        private void startStationEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verbindungenAnzeige.Rows.Clear();

                if (endStationEingabe.Text.Length >= 1)
                {
                    StartEndeAnzeige();
                }

                else
                {
                    StartAbfahrtstafel();
                }
            }
        }

        private void endStationEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verbindungenAnzeige.Rows.Clear();

                if (endStationEingabe.Text.Length >= 1)
                {
                    StartEndeAnzeige();
                }

                else
                {
                    StartAbfahrtstafel();
                }
            }
        }
        private void StartEndeAnzeige()
        {
            try
            {
                var connections = transport.GetConnections(startStationEingabe.Text, endStationEingabe.Text, datumEingabe.Value.ToString(), zeitEingabe.Value.ToString());

                for (int i = 0; i < 4; i++)
                {
                    verbindungenAnzeige.Rows.Add(new string[]
                    {
                        connections.ConnectionList[i].From.Station.Name.ToString(),
                        connections.ConnectionList[i].From.Departure.ToString(),
                        connections.ConnectionList[i].To.Station.Name.ToString(),
                        connections.ConnectionList[i].To.Arrival.ToString(),
                        connections.ConnectionList[i].Duration.ToString()
                    });
                }
            }
            catch
            {
                MessageBox.Show("Keine Verbindung möglich.");
            }
        }
        private void StartAbfahrtstafel()
        {
            try
            {
                var startStationId = transport.GetStations(startStationEingabe.Text).StationList[0].Id;
                var table = transport.GetStationBoard(startStationEingabe.Text, startStationId);

                for (int i = 0; i < 4; i++)
                {
                    var connections = transport.GetConnections(startStationEingabe.Text, table.Entries[i].To, datumEingabe.Value.ToString(), zeitEingabe.Value.ToString());

                    verbindungenAnzeige.Rows.Add(new string[]
                    {
                        connections.ConnectionList[i].From.Station.Name.ToString(),
                        connections.ConnectionList[i].From.Departure.ToString(),
                        table.Entries[i].To,
                        connections.ConnectionList[i].To.Arrival.ToString(),
                        connections.ConnectionList[i].Duration.ToString()
                    });
                }
            }
            catch
            {
                MessageBox.Show("Keine Verbindung möglich.");
            }
        }        
    }
}
