using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            OMS125DataContext dbo = new OMS125DataContext();
            var Customer = from c in dbo.Customers
                           select c;
            dataGridView1.DataSource = Customer.ToList();

            listBox2.DataSource = Customer;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "Id";

            comboBox1.DataSource = Customer;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

          
            TxtName.Text = TxtMaskedContactNo.Text = TxtEmail.Text = " ";
            DTPDOB.Value = DateTime.Now;

            TxtNameforUpdate.Text = TxtEmail.Text = TxtContactNoUpdate.Text;

            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OMS125DataContext dbo = new OMS125DataContext();
            Customer newCust1 = new Customer()
            {
                Name = TxtName.Text,
                ContactNo = TxtMaskedContactNo.Text,
                Email = TxtEmail.Text,
                DOB = DTPDOB.Value
            };
                
            dbo.Customers.InsertOnSubmit(newCust1);
            dbo.SubmitChanges();

            ResetForm();
            MessageBox.Show("Customer Added Successfully");
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            //Woo customer lana ya listbox ma selected ha //
            OMS125DataContext dbo = new OMS125DataContext();
            int SN = Convert.ToInt32(listBox2.SelectedValue);
            //var selectedcustomer = from c in DB.Customer23s
            //                       where c.id == SN
            //                       select c;

            var selectedcustomer = dbo.Customers.First(c => c.Id == SN);

            TxtNameforUpdate.Text = selectedcustomer.Name;
            TxtBoxEmail.Text = selectedcustomer.Email;
            TxtContactNoUpdate.Text = selectedcustomer.ContactNo;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OMS125DataContext dbo = new OMS125DataContext();
            int SN = Convert.ToInt32(listBox2.SelectedValue);
            var selectedcustomer = dbo.Customers.First(c => c.Id == SN);

            selectedcustomer.Name = TxtNameforUpdate.Text;
            selectedcustomer.Email = TxtEmail.Text;
            selectedcustomer.ContactNo = TxtContactNoUpdate.Text;

            dbo.SubmitChanges();
            ResetForm();
            MessageBox.Show("Customer Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OMS125DataContext dbo = new OMS125DataContext();
            int Del = Convert.ToInt32(comboBox1.SelectedValue);
            var selectedcustomer = dbo.Customers.First(c => c.Id == Del);

            dbo.Customers.DeleteOnSubmit(selectedcustomer);
            dbo.SubmitChanges();

            ResetForm();
            MessageBox.Show("Customer Deleted Successfully");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}









