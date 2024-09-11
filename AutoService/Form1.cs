using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!FSWork.IsFileExist("AutoService.db")) MakeStore();
            FillMechanicsNames();
        }
        private void MakeStore()
        {
            if (DBWork.MakeDB())
            {
                MessageBox.Show($"База данных существует");
            } ;
        }
        private void FillMechanicsNames()
        {
            foreach (string name in DBWork.GetMechanics())
            {
                cmbMechanic.Items.Add(name);
            }
        }

        private void btn_AddMaster_Click(object sender, EventArgs e)
        {
            
            string addMaster = cmbMechanic.Text;
            DBWork.AddMechanic(addMaster);
        }

        private void btn_DelMechanic_Click(object sender, EventArgs e)
        {
            string DelMechanic = cmbMechanic.Text;
            DBWork.DelMechanic(DelMechanic);    
        }

        private void btn_EditMechanic_Click(object sender, EventArgs e)
        {
            string oldstring = cmbMechanic.Text;
            string newstring = tb_add_del_edit_Master.Text;
            DBWork.EditMechanic(oldstring, newstring);
        }
    }
}
