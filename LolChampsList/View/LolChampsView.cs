using LolChampsList.Controller;
using LolChampsList.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LolChampsList.View
{
    public partial class LolChampsView : Form
    {
        MainController lolChampController = new MainController();

        private void RefreshTable()
        {
            dgvLolChamps.DataSource = lolChampController.GetAllChamps();
        }

        public LolChampsView()
        {
            InitializeComponent();
        }

        private void LolChampsView_Load(object sender, EventArgs e)
        {
            dgvLolChamps.DataSource = lolChampController.GetAllChamps();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            LolChamp champ = new LolChamp();
            champ.Name = txtName.Text;
            champ.Age = int.Parse(txtAge.Text);
            lolChampController.CreateLolChamp(champ);
            RefreshTable();
        }
    }
}
