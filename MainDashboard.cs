using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIMS_dan
{
public partial class MainDashboard : Form
{
    public MainDashboard()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private async void button4_Click(object sender, EventArgs e)
    {
        await LoadControlAsync(new controllerFormRequests());
    }

    private void MainDashboard_Load(object sender, EventArgs e)
    {

    }

    private async void residentsButton_Click(object sender, EventArgs e)
    {
        await LoadControlAsync(new controllerResidents());
    }

    private Task LoadControlAsync(UserControl control)
    {
        return Task.Run(() =>
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => LoadControl(control)));
            }
            else
            {
                LoadControl(control);
            }
        });
    }

    private void LoadControl(UserControl control)
    {
        mainPlaceholder.Controls.Clear();
        control.Dock = DockStyle.Fill;
        mainPlaceholder.Controls.Add(control);
    }

    private void barangaySettingsButton_Click(object sender, EventArgs e)
    {

    }

    private async void DashboardButton_Click(object sender, EventArgs e)
    {
        await LoadControlAsync(new controllerDashboardActivities());
    }

    private async void barangayOfficialsButton_Click(object sender, EventArgs e)
    {
        await LoadControlAsync(new controllerBarangayOfficials());
    }

    private async void eventsButton_Click(object sender, EventArgs e)
    {
        await LoadControlAsync(new controllerBarangayEvents());
    }

    private void mainPlaceholder_Paint(object sender, PaintEventArgs e)
    {

    }
}
}
