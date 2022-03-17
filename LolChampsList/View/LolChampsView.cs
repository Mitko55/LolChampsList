using LolChampsList.Controller;
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

        public LolChampsView()
        {
            InitializeComponent();
        }

        private void LolChampsView_Load(object sender, EventArgs e)
        {
            dgvLolChamps.DataSource = lolChampController.GetAllChamps();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
