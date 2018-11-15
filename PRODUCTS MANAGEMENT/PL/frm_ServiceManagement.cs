using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_ServiceManagement : Form
    {
        public static int ID;
        public frm_ServiceManagement()
        {
            InitializeComponent();
            dgvService.DataSource = cls_Service.stp_SelectAll_Service();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frm_AddService("a").ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvService.Rows.Count <0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لتعديلها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ID = int.Parse(dgvService.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddService("u").ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvService.Rows.Count == 0)
                {
                    MessageBox.Show(@"لا يوجد بيانات لحزفها", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ID = int.Parse(dgvService.SelectedRows[0].Cells[0].Value.ToString());
                new frm_AddService("d").ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeColour(object sender, EventArgs e)
        {
            Button bColour = (Button)sender;
            bColour.BackColor = Color.LightSteelBlue;
        }

        private void ColourChange(object sender, EventArgs e)
        {
            Button bColour = (Button)sender;
            bColour.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
    }
}
