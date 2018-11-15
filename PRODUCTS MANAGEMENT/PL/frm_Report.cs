using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_Report : Form
    {
        string RepKind;
        int id = 0;
        public frm_Report(string _RepKind)
        {
            InitializeComponent();
            RepKind = _RepKind;
            Select_All(RepKind);
            //cboCust_Name.SelectedIndex = -1;
        }

        private void Select_All(string repKind)
        {
            if (RepKind == "Purchase")
            {
                this.Text = "تقارير المشتريات";
                dgvReport.DataSource = cls_Invoice.stp_Search_Invoices("");
                cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Supplier", "Sup_Company", "Sup_Id");
                cboCust_Name.SelectedIndex = -1;
            }
            else if (RepKind == "Sales")
            {
                this.Text = "تقارير المبيعات";
                dgvReport.DataSource = cls_Order.stp_Search_Orders("");
                cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
                cboCust_Name.SelectedIndex = -1;
            }
            else if (RepKind == "RPurchase")
            {
                this.Text = "تقارير مردودات المشتريات";
                dgvReport.DataSource = cls_RInvoice.stp_Search_RInvoices("");
                cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Supplier", "Sup_Company", "Sup_Id");
                cboCust_Name.SelectedIndex = -1;
            }

            else if (RepKind == "RSales")
            {
                this.Text = "تقارير مردودات المبيعات";
                dgvReport.DataSource = cls_ROrder.stp_Search_ROrders("");
                cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
                cboCust_Name.SelectedIndex = -1;
            }
            else if (RepKind == "Credit")
            {
                this.Text = "تقارير حركة الموردين/المدفوعات";
                dgvReport.DataSource = cls_Credit.stp_Search_SupplierTrans("");
                cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Supplier", "Sup_Company", "Sup_Id");
                cboCust_Name.SelectedIndex = -1;
            }
            else if (RepKind == "Debit")
            {
                this.Text = "تقارير حركة العملاء/المقبوضات";
                dgvReport.DataSource = cls_Debit.stp_Search_CustomerTrans("");
                cls_Controls.BindCombo(ref cboCust_Name, "stp_SelectAll_Customers", "Cust_Name", "Cust_Id");
                cboCust_Name.SelectedIndex = -1;
            }
        }

        private void Select_ByDate(DateTime dtpStart, DateTime dtpEnd)
        {
            if (RepKind == "Purchase")
            {
                this.Text = "تقارير المشتريات خلال فترة";
                dgvReport.DataSource = cls_Invoice.Print_Invoices_ByDate(dtpStart,dtpEnd);
               
            }
            else if (RepKind == "Sales")
            {
                this.Text = "تقارير المبيعات";
                dgvReport.DataSource = cls_Order.Print_Orders_ByDate(dtpStart, dtpEnd);
               
            }
            else if (RepKind == "RPurchase")
            {
                this.Text = "تقارير مردودات المشتريات";
                dgvReport.DataSource = cls_RInvoice.Print_RInvoices_ByDate(dtpStart, dtpEnd);
               
            }
            else if (RepKind == "RSales")
            {
                this.Text = "تقارير مردودات المبيعات";
                dgvReport.DataSource = cls_ROrder.Print_ROrders_ByDate(dtpStart, dtpEnd);
               
            }
            else if (RepKind == "Credit")
            {
                this.Text = "تقارير حركة الموردين/المدفوعات";
                dgvReport.DataSource = cls_Credit.Print_SupplierTrans_ByDate(dtpStart, dtpEnd);
              
            }
            else if (RepKind == "Debit")
            {
                this.Text = "تقارير حركة العملاء/المقبوضات";
                dgvReport.DataSource = cls_Debit.Print_CustomerTrans_ByDate(dtpStart, dtpEnd);
                
            }

        }

        private void Select_ById(int id)
        {
            if (RepKind == "Purchase")
            {
                this.Text = "تقارير المشتريات لمورد";
                dgvReport.DataSource = cls_Invoice.Print_Invoices_BySupId(id);
               
            }
            else if (RepKind == "Sales")
            {
                this.Text = "تقارير المبيعات لعميل";
                dgvReport.DataSource = cls_Order.Print_Orders_ByCust_Id(id);
              
            }
            else if (RepKind == "RPurchase")
            {
                this.Text = "تقارير مردودات المشتريات لمورد";
                dgvReport.DataSource = cls_RInvoice.Print_RInvoices_BySupId(id);
                
            }
            else if (RepKind == "RSales")
            {
                this.Text = "تقارير المبيعات لعميل";
                dgvReport.DataSource = cls_ROrder.Print_ROrders_ByCust_Id(id);
               
            }
            else if (RepKind == "Credit")
            {
                this.Text = "تقارير حركة مورد";
                dgvReport.DataSource = cls_Credit.Print_SupplierTrans_BySupId(id);
              
            }
            else if (RepKind == "Debit")
            {
                this.Text = "تقارير حركة لعميل";
                dgvReport.DataSource = cls_Debit.Print_CustomerTrans_ByCustId(id);
                
            }

        }

        private void frm_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnquire_Click(object sender, EventArgs e)
        {
            if (rdbAll.Checked && RepKind== "Purchase")
            {
                Select_All("Purchase");
            }
            else if (rdbAll.Checked && RepKind == "Sales")
            {
                Select_All("Sales");
            }
            else if (rdbAll.Checked && RepKind == "RPurchase")
            {
                Select_All("RPurchase");
            }
            else if (rdbAll.Checked && RepKind == "RSales")
            {
                Select_All("RSales");
            }
            else if (rdbAll.Checked && RepKind == "Credit")
            {
                Select_All("Credit");
            }
            else if (rdbAll.Checked && RepKind == "Debit")
            {
                Select_All("Debit");
            }

// By Date

            if (rdbDate.Checked && RepKind == "Purchase")
            {
                Select_ByDate(dtpStart.Value, dtpEnd.Value);
            }
            else if (rdbDate.Checked && RepKind == "Sales")
            {
                Select_ByDate(dtpStart.Value, dtpEnd.Value);
            }
            else if(rdbDate.Checked && RepKind == "RPurchase")
            {
                Select_ByDate(dtpStart.Value, dtpEnd.Value);
            }
            else if(rdbDate.Checked && RepKind == "RSales")
            {
                Select_ByDate(dtpStart.Value, dtpEnd.Value);
            }
            else if(rdbDate.Checked && RepKind == "Credit")
            {
                Select_ByDate(dtpStart.Value, dtpEnd.Value);
            }
            else if(rdbDate.Checked && RepKind == "Debit")
            {
                Select_ByDate(dtpStart.Value, dtpEnd.Value);
            }

            // By Suppllier-Customer
            if (rdbId.Checked && RepKind == "Purchase")
            {
                Select_ById(id);
            }
            else if (rdbId.Checked && RepKind == "Sales")
            {
                Select_ById(id);
            }
            else if (rdbId.Checked && RepKind == "RPurchase")
            {
                Select_ById(id);
            }
            else if (rdbId.Checked && RepKind == "RSales")
            {
                Select_ById(id);
            }
            else if (rdbId.Checked && RepKind == "Credit")
            {
                Select_ById(id);
            }
            else if (rdbId.Checked && RepKind == "Debit")
            {
                Select_ById(id);
            }
            

        }
        


        private void rdbDate_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            cboCust_Name.Enabled = false;
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            txtId.Enabled = true;
            cboCust_Name.Enabled = true;

        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            txtId.Enabled = false;
            cboCust_Name.Enabled = false;
        }




        private void cboCust_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RepKind == "Purchase" || RepKind == "RPurchase" || RepKind== "Credit")
            {
                DataTable dt = cls_Supplier.stp_SelectAll_SuppliersById(cboCust_Name.Text);
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0][0].ToString();
                    id = Convert.ToInt32(txtId.Text);
                }
            }

            else if (RepKind == "Sales" || RepKind== "Debit" || RepKind== "RSales" )
            {
                DataTable dt = cls_Customer.stp_SelectCustomersByName(cboCust_Name.Text);
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0][0].ToString();
                    id = Convert.ToInt32(txtId.Text);
                }
            }
           
        }
            private void btnPrint_Click(object sender, EventArgs e)
            {
                 if (rdbAll.Checked && RepKind == "Purchase")
                {
                    // get last order to print

                    try
                    {
                        if (dgvReport.Rows.Count == 0)
                        {
                            return;
                        }
                        this.Cursor = Cursors.WaitCursor;
                        int Order_No = Convert.ToInt32(dgvReport.CurrentRow.Cells[0].Value);
                        RPT.rpt_PrintAll_Invoices MyReport = new RPT.rpt_PrintAll_Invoices();
                        RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                        MyReport.SetDataSource(cls_Invoice.stp_Search_Invoices(""));
                        //MyReport.Refresh();
                        MyForm.crystalReportViewer1.ReportSource = MyReport;
                        MyForm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbAll.Checked && RepKind == "Sales")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    int Order_No = Convert.ToInt32(dgvReport.CurrentRow.Cells[0].Value);
                    RPT.rpt_PrintAll_Orders MyReport = new RPT.rpt_PrintAll_Orders();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_Order.stp_Search_Orders(""));
                    //MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbAll.Checked && RepKind == "RPurchase")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    RPT.rpt_PrintAll_RPurchase MyReport = new RPT.rpt_PrintAll_RPurchase();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_RInvoice.stp_Search_RInvoices(""));
                    //MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbAll.Checked && RepKind == "RSales")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    RPT.rpt_PrintAll_RSales MyReport = new RPT.rpt_PrintAll_RSales();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_ROrder.stp_Search_ROrders(""));
                    //MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbAll.Checked && RepKind == "Credit")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                        RPT.rpt_PrintAll_SupplierTrans Report = new RPT.rpt_PrintAll_SupplierTrans();
                        Report.SetDataSource(cls_Credit.stp_Search_SupplierTrans(""));
                        frm.crystalReportViewer1.ReportSource = Report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (rdbAll.Checked && RepKind == "Debit")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                        RPT.rpt_PrintAll_CustomerTrans Report = new RPT.rpt_PrintAll_CustomerTrans();
                        Report.SetDataSource(cls_Debit.stp_Search_CustomerTrans(""));
                        frm.crystalReportViewer1.ReportSource = Report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // By Date

                if (rdbDate.Checked && RepKind == "Purchase")
                {

                    try
                    {
                        if (dgvReport.Rows.Count == 0)
                        {
                            return;
                        }
                        this.Cursor = Cursors.WaitCursor;
                        RPT.rpt_Print_PurchaseByDate MyReport = new RPT.rpt_Print_PurchaseByDate();
                        RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                        MyReport.SetDataSource(cls_Invoice.Print_Invoices_ByDate(dtpStart.Value, dtpEnd.Value));
                        //MyReport.Refresh();
                        MyForm.crystalReportViewer1.ReportSource = MyReport;
                        MyForm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbDate.Checked && RepKind == "Sales")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    RPT.rpt_PrintSalesByDate MyReport = new RPT.rpt_PrintSalesByDate();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_Order.Print_Orders_ByDate(dtpStart.Value, dtpEnd.Value));
                    //MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbDate.Checked && RepKind == "RPurchase")
                {
                    try
                    {
                        if (dgvReport.Rows.Count == 0)
                        {
                            return;
                        }
                        this.Cursor = Cursors.WaitCursor;
                        RPT.rpt_Print_RPuchaseByDate MyReport = new RPT.rpt_Print_RPuchaseByDate();
                        RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                        MyReport.SetDataSource(cls_RInvoice.Print_RInvoices_ByDate(dtpStart.Value, dtpEnd.Value));
                        //MyReport.Refresh();
                        MyForm.crystalReportViewer1.ReportSource = MyReport;
                        MyForm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbDate.Checked && RepKind == "RSales")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;

                    RPT.rpt_Print_ROrderById MyReport = new RPT.rpt_Print_ROrderById();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_ROrder.Print_ROrders_ByDate(dtpStart.Value, dtpEnd.Value));
                    //MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbDate.Checked && RepKind == "Credit")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                        RPT.rpt_Print_SupplierTransByDate Report = new RPT.rpt_Print_SupplierTransByDate();
                        Report.SetDataSource(cls_Credit.Print_SupplierTrans_ByDate(dtpStart.Value, dtpEnd.Value));
                        frm.crystalReportViewer1.ReportSource = Report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbDate.Checked && RepKind == "Debit")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                        RPT.rpt_PrintAll_CustomerTrans Report = new RPT.rpt_PrintAll_CustomerTrans();
                        Report.SetDataSource(cls_Debit.Print_CustomerTrans_ByDate(dtpStart.Value, dtpEnd.Value));
                        frm.crystalReportViewer1.ReportSource = Report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // By Suppllier-Customer
                if (rdbId.Checked && RepKind == "Purchase")
                {
                    try
                    {
                        if (dgvReport.Rows.Count == 0)
                        {
                            return;
                        }
                        this.Cursor = Cursors.WaitCursor;
                        RPT.rpt_Print_InvoiceById MyReport = new RPT.rpt_Print_InvoiceById();
                        RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                        MyReport.SetDataSource(cls_Invoice.Print_Invoices_BySupId(Convert.ToInt32(txtId.Text)));
                        //MyReport.Refresh();
                        MyForm.crystalReportViewer1.ReportSource = MyReport;
                        MyForm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbId.Checked && RepKind == "Sales")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    RPT.rpt_Print_OrderById MyReport = new RPT.rpt_Print_OrderById();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_Order.Print_Orders_ByCust_Id(Convert.ToInt32(txtId.Text)));
                    //MyReport.Refresh();
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbId.Checked && RepKind == "RPurchase")
                {
                    try
                    {
                        if (dgvReport.Rows.Count == 0)
                        {
                            return;
                        }
                        this.Cursor = Cursors.WaitCursor;
                        RPT.rpt_Print_RInvoiceById MyReport = new RPT.rpt_Print_RInvoiceById();
                        RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                        MyReport.SetDataSource(cls_RInvoice.Print_RInvoices_BySupId(Convert.ToInt32(txtId.Text)));
                        //MyReport.Refresh();
                        MyForm.crystalReportViewer1.ReportSource = MyReport;
                        MyForm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbId.Checked && RepKind == "RSales")
                {
                    if (dgvReport.Rows.Count == 0)
                    {
                        return;
                    }
                    this.Cursor = Cursors.WaitCursor;
                    RPT.rpt_Print_ROrderById MyReport = new RPT.rpt_Print_ROrderById();
                    RPT.frm_Rpt_Product MyForm = new RPT.frm_Rpt_Product();
                    MyReport.SetDataSource(cls_ROrder.Print_ROrders_ByCust_Id(Convert.ToInt32(txtId.Text)));
                    MyForm.crystalReportViewer1.ReportSource = MyReport;
                    MyForm.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else if (rdbId.Checked && RepKind == "Credit")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                        RPT.rpt_Print_SupplierTransById Report = new RPT.rpt_Print_SupplierTransById();
                        Report.SetDataSource(cls_Credit.Print_SupplierTrans_BySupId(Convert.ToInt32(txtId.Text)));
                        frm.crystalReportViewer1.ReportSource = Report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (rdbId.Checked && RepKind == "Debit")
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        RPT.frm_Rpt_Product frm = new RPT.frm_Rpt_Product();
                        RPT.rpt_Print_CustomerTransById Report = new RPT.rpt_Print_CustomerTransById();
                        Report.SetDataSource(cls_Debit.Print_CustomerTrans_ByCustId(Convert.ToInt32(txtId.Text)));
                        frm.crystalReportViewer1.ReportSource = Report;
                        frm.ShowDialog();
                        this.Cursor = Cursors.Default;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }


        }
}
