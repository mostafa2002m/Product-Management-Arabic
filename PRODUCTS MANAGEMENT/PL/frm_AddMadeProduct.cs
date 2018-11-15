using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddMadeProduct : Form
    {
        string ch;
        public frm_AddMadeProduct(string _ch)
        {
            InitializeComponent();
            ch = _ch;
            groupBox1.Enabled = false;
            btnSave.Enabled = false;
            ClearBoxes();
            // bind list text and value with columns name
            fillComboBox();
            cboCat.SelectedIndex = -1;
            if (ch == "u")
            {
                this.Text = "تعديل بيانات منتج";
                btnAdd.Text = "تعديل";
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_MadeProduct.stp_SelectSingle_MadeProduct(frmMadeProductList.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    cboCat.Text = dr["Cat_Name"].ToString();
                    txtBarcode.Text = dr["Barcode"].ToString();
                    txtProNo.Text = dr["Product_Id"].ToString();
                    txtref.Text = dr["Product_Name"].ToString();
                    txtReOrder.Text = dr["Qte_In_Order"].ToString();
                    txtLargeUnit.Text = dr["LUnitQty"].ToString();
                    txtLargePrice.Text = dr["LUnitPrice"].ToString();
                    txtSmallUnit.Text = dr["SUnitQty"].ToString();
                    txtSmallPrice.Text = dr["SUnitPrice"].ToString();
                    byte[] Arr = (byte[])dr["Product_Image"];
                    MemoryStream ms = new MemoryStream(Arr);
                    picBox.Image = Image.FromStream(ms);
                }
            }
            else if (ch == "a")
            {
                this.Text = "إضافة بيانات منتج";
                btnAdd.Text = "إضافة";
            }

            else if (ch == "d")
            {
                this.Text = "حذف بيانات منتج";
                btnAdd.Text = "حذف";
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                groupBox1.Enabled = true;
                DataTable dt = cls_Product.stp_SelectSingle_Product(frmProducts_List.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    cboCat.Text = dr["Cat_Name"].ToString();
                    txtBarcode.Text = dr["Barcode"].ToString();
                    txtProNo.Text = dr["Product_Id"].ToString();
                    txtref.Text = dr["Product_Name"].ToString();
                    txtReOrder.Text = dr["Qte_In_Order"].ToString();
                    txtLargeUnit.Text = dr["LUnitQty"].ToString();
                    txtLargePrice.Text = dr["LUnitPrice"].ToString();
                    txtSmallUnit.Text = dr["SUnitQty"].ToString();
                    txtSmallPrice.Text = dr["SUnitPrice"].ToString();
                    byte[] Arr = (byte[])dr["Product_Image"];
                    MemoryStream ms = new MemoryStream(Arr);
                    picBox.Image = Image.FromStream(ms);
                }
            }
        }
        private void ClearBoxes()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }

        private void fillComboBox()
        {
            cls_Controls.BindCombo(ref cboCat, "stp_SelectAll_Category", "Cat_Name", "cat_Id");
            cboCat.Refresh();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            lblmassage.Text = "";
            txtProNo.Clear();
            txtProNo.Clear();
            txtref.Clear();
            txtReOrder.Text = "0";
            cboCat.SelectedIndex = -1;
            ButtonEnables(false);
            txtProNo.Text = cls_MadeProduct.stp_SelectLast_MadeProduct_Id().Rows[0][0].ToString();
            txtBarcode.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEnables(bool p)
        {
            btnAdd.Enabled = p;
            btnSave.Enabled = !p;


            //btnSearch.Enabled = p;
            picBox.Image = PRODUCTS_MANAGEMENT.Properties.Resources.nopicture;

        }

        private void ButtonEnables1(bool p)
        {
            groupBox1.Enabled = !p;
            btnAdd.Enabled = p;
            btnSave.Enabled = !p;


            //btnSearch.Enabled = p;
            picBox.Image = PRODUCTS_MANAGEMENT.Properties.Resources.nopicture;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // to save the image byte
                MemoryStream ms = new MemoryStream();
                picBox.Image.Save(ms, picBox.Image.RawFormat);
                byte[] arr = ms.ToArray();



                //دالة للتاكد من عدم تكرار اسم المنتج
                //Repeat();  

                if (cboCat.Text == string.Empty || txtProNo.Text == string.Empty || txtref.Text == string.Empty)
                {
                    MessageBox.Show(@"تحقق من البيانات");
                    return;

                }



                if (ch == "a")
                {
                    int x = cls_MadeProduct.stp_ManipulateMadeProduct(ch, Convert.ToInt32(txtProNo.Text), txtBarcode.Text, txtref.Text,
                     txtReOrder.Text, arr, (int)cboCat.SelectedValue,
                  txtLargeUnit.Text, txtSmallUnit.Text, txtLargePrice.Text,
                  txtSmallPrice.Text, txtDetail.Text);
                    if (x == 1)
                    {
                        lblmassage.Text = @"تم اضافة المنتج بنجاح";
                        ButtonEnables(true);
                    }
                    else
                    {
                        lblmassage.Text = @"فشل عملية الاضافة";
                        return;
                    }
                }


                else if (ch == "u")
                {

                    int x = cls_MadeProduct.stp_ManipulateMadeProduct(ch, frmProducts_List.ID, txtBarcode.Text, txtref.Text,
                                txtReOrder.Text, arr, (int)cboCat.SelectedValue,
                              txtLargeUnit.Text, txtSmallUnit.Text, txtLargePrice.Text
                              , txtSmallPrice.Text, txtDetail.Text);
                    if (x == 1)
                    {
                        lblmassage.Text = @"تم تعديل المنتج بنجاح";

                        ButtonEnables(true);
                    }
                    else
                    {
                        lblmassage.Text = @"فشل تعديل الملف";

                        ButtonEnables(false);
                        return;

                    }

                }
                else if (ch == "d")
                {
                    DialogResult dr = MessageBox.Show(@"هل تريد فعلا حذف هذا المنتج؟", @"تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        int x = cls_MadeProduct.stp_ManipulateMadeProduct(ch, frmProducts_List.ID, txtBarcode.Text, txtref.Text,
                               txtReOrder.Text, arr, (int)cboCat.SelectedValue,
                             txtLargeUnit.Text, txtSmallUnit.Text, txtLargePrice.Text
                             , txtSmallPrice.Text, txtDetail.Text);
                        if (x == 1)
                        {
                            lblmassage.Text = @"تم حذف المنتج بنجاح";

                            ButtonEnables(true);
                        }
                        else
                        {
                            lblmassage.Text = @"فشل حذف الملف";

                            ButtonEnables(false);
                            return;

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory="C:\\";

            ofd.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF; *.BMP";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //string picPath = ofd.SafeFileName.ToString();
                //picBox.ImageLocation = picPath;
                picBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Repeat()
        {
            DataTable dt = new DataTable();
            dt = cls_Product.Verify_Product(txtref.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(@"تحقق من البيانات", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtref.Focus();
                txtref.SelectionStart = 0;
                txtref.SelectionLength = txtref.TextLength;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_AddCategory frm = new frm_AddCategory("a");
            frm.ShowDialog();
            fillComboBox();
        }

        private void txtProNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtLargeUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtSmallUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtReOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtref_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtSmallPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void cboCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }



        private void txtLargePrice_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    this.SelectNextControl(this.ActiveControl, true, true, true, true);



                    if (txtLargeUnit.Text != string.Empty && txtSmallUnit.Text != string.Empty && txtLargePrice.Text != string.Empty && txtLargePrice.Text != ".")
                    {
                        txtSmallPrice.Text = (Double.Parse(txtLargePrice.Text) / Double.Parse(txtSmallUnit.Text)).ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
    }
