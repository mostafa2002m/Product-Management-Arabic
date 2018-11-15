using System;
using System.Data;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;
using System.Drawing;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddPayment_Punch : Form
    {
        int x; 
        public frm_AddPayment_Punch(string custid,string custname,string orderid,string value,string title)
        {
            InitializeComponent();
            this.Text = title;
            txtPunchId.Text = cls_Punches.stp_SelectLast_Trans_Id().Rows[0][0].ToString();
            txtcustid.Text = custid;
            txtcustname.Text = custname;
            txtorderid.Text = orderid;
            txtordervalue.Text = value;
            btnSave.Enabled = false;

        }

     
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                btnCalculate.Text = @"إعادة حساب القسط";
                btnSave.Enabled = true;
                dgvPackage.Rows.Clear();
                dgvPackage.Refresh();
                DateTime dtpPackage1 = dtpPackageStart.Value;
               
                // القسط الشهري
                decimal Punch = Convert.ToDecimal(txtPackage.Text);
                //  تسلسل الاقساط
                int ser = 1;
                // المبلغ بعد اقتطاع الدفعة المقدمة ان وجدت
                Decimal newsum = decimal.Round(Convert.ToDecimal(txtordervalue.Text) - Convert.ToDecimal(txtDownPayment.Text));
                // عدد الاقساط
                decimal package = decimal.Round((Convert.ToDecimal(txtordervalue.Text) - Convert.ToDecimal(txtDownPayment.Text)) / Convert.ToDecimal(txtPackage.Text), 0);
                txtPackNo.Text = package.ToString();
               dtpPackageEnd.Value = Convert.ToDateTime(dtpPackage1.ToString()).AddMonths(Convert.ToInt32(txtPackNo.Text) - 1);
                // تكرار لاظهار بيان الاقساط بالداتا جريد
                for (int i = 0; i <= package; i++)
                {
                    if (newsum == 0)
                    {
                        return;
                    }
                    if (Punch <= newsum)
                    {

                        Punch = Convert.ToDecimal(txtPackage.Text);

                    }
                    else
                    {
                        Punch = newsum;

                    }
                    dgvPackage.Rows.Add(ser, txtPunchId.Text, Punch, Convert.ToDateTime(dtpPackage1).ToString("dd/MM/yyyy"), 0,
                                       0, 0, newsum, false);
                    ser += 1;
                    newsum -= Punch;
                    dtpPackage1 = Convert.ToDateTime(dtpPackage1.ToString()).AddMonths(1);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                
                if (dgvPackage.Rows.Count >0 && txtPackage.Text !=string.Empty)
                {
                    DialogResult respnse = MessageBox.Show(@"هل تريد حفظ بيانات الاقساط", @"عملية تسجيل الاقساط", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respnse == DialogResult.Yes)
                    {
                        Insert_Punch_Detail();
                        if (x > 0)
                        {
                            Inaert_Punch();
                            Add_Payment_Cash("سداد فسط");
                            MessageBox.Show(@"تم السداد");
                            btnCalculate.Enabled = false;
                            this.Close();
                        }
                        else
                        {
                            return;
                        }
                        return;
                    }
                   
                   
                   
                }
                else
                {
                    MessageBox.Show(@"لم يتم احتساب القسط ... من فضلك أكمل البيانات المطلوبة");
                    return;
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Inaert_Punch()
        {
            try
            {
                 cls_Punches.Add_Punch(int.Parse(txtPunchId.Text), dtpPackageStart.Value, int.Parse(txtorderid.Text),
                          int.Parse(txtcustid.Text), decimal.Parse(txtordervalue.Text), Convert.ToDecimal(txtPackage.Text),
                          Convert.ToInt32(txtPackNo.Text), Convert.ToDecimal(txtDownPayment.Text), dtpPackageStart.Value, dtpPackageEnd.Value,
                          false);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Insert_Punch_Detail()
        {
            try
            {
                 for (int i = 0; i < dgvPackage.Rows.Count -1; i++)
                    {
                      x=  cls_Punches.Add_Punch_Details(
                                                  Convert.ToInt32(dgvPackage.Rows[i].Cells[0].Value),
                                                  Convert.ToInt32(dgvPackage.Rows[i].Cells[1].Value),
                                                  Convert.ToDecimal(dgvPackage.Rows[i].Cells[2].Value),
                                                  Convert.ToDateTime(dgvPackage.Rows[i].Cells[3].Value),
                                                  Convert.ToDateTime(dgvPackage.Rows[i].Cells[3].Value),
                                                  Convert.ToInt32(dgvPackage.Rows[i].Cells[5].Value),
                                                  Convert.ToInt32(dgvPackage.Rows[i].Cells[6].Value),
                                                  Convert.ToDecimal(dgvPackage.Rows[i].Cells[7].Value),
                                                  Convert.ToBoolean(dgvPackage.Rows[i].Cells[8].Value));
                    }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        private void Add_Payment_Cash(string paymethod)
        {
            DataTable dt = cls_CashIn.stp_SelectLast_CashIn_Id();
            int cashid = Convert.ToInt32(dt.Rows[0][0].ToString());
            cls_CashIn.Add_CashIn(cashid, Convert.ToDateTime(dtpDown.Value), Convert.ToDecimal(dtpDown.Text), paymethod, int.Parse(txtcustid.Text));

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
