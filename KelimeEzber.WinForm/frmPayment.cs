using KelimeEzber.BLL;
using KelimeEzber.Entities;
using KelimeEzber.WinForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzber.WinForm
{
    public partial class frmPayment : Form
    {
        public bool flag;
        string temp = string.Empty;
        PaymentHelper helper;
        public Payment _payment;
        PaymentBLL _paymentBLL;
        public frmPayment()
        {
            InitializeComponent();
            helper = new PaymentHelper();
            flag = false;
            _payment = new Payment();
            _paymentBLL = new PaymentBLL(); 
        }
        private void RadioCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCash.Checked)
            {
                creditPayment.Enabled = false;
            }
            else
            {
                creditPayment.Enabled = true;
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioCredit.Checked)
                {
                    helper.CheckCreditCardNo(txtCreditNo.Text);
                    helper.CheckSecurityNo(txtSecurityCode.Text);
                    helper.CheckMonth(txtMonth.Text);
                    helper.CheckYear(txtYear.Text);
                }                
                flag = true;
                _payment.TypeID = radioCash.Checked ? 1 : 2;
                this.Close();
                MessageBox.Show("Ödeme Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
