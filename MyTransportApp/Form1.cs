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
    public partial class Form1 : Form
    {
        Stations stationen = new Stations();
        Transport transport = new Transport();
        StationBoardRoot board = new StationBoardRoot();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            suchenButton.Enabled = false;
        }

        private void startStationEingabe_TextChanged(object sender, EventArgs e)
        {
            suchenButton.Enabled = true;
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            verbindungenAnzeige.Rows.Clear();
            
            // Verbindungen Start-Ende anzeigen
            if (endStationEingabe.Text.Length >= 1)
            {
                var connections = transport.GetConnections(startStationEingabe.Text, endStationEingabe.Text);

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

            // Abfahrtstafel von Startposition
            else 
            {                
                var startStationId = transport.GetStations(startStationEingabe.Text).StationList[0].Id;
                var table = transport.GetStationBoard(startStationEingabe.Text, startStationId);                
                
                for (int i = 0; i < 4; i++)
                {                    
                    var connections = transport.GetConnections(startStationEingabe.Text, table.Entries[i].To);
                    
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
        }
    }
}
