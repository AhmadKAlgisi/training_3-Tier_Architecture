using Business_Tier_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app_3_tier_in_containt
{
    public partial class formedit_delete : Form
    {
        public enum MODE_OBJECT
        {
            ADD,
            UPDATE
        }
        private  int id_countaint;
        ClsContant contant;
        Clscontrie countre;
        public MODE_OBJECT mode { get; set; }



        public formedit_delete(int id )//counstroctor
        {
            id_countaint = id;

            if (id_countaint == -1)
            
                mode = MODE_OBJECT.ADD;

            
            else
                mode = MODE_OBJECT.UPDATE;

            InitializeComponent();
        }


        private void  faiil_data_countre()
        {
            DataTable t1 = Clscontrie.get_list_data_countre();

            foreach(DataRow r1 in  t1.Rows)
            {
                comboBox_countre.Items.Add(r1["CountryName"]);

            }
        }

        private void formedit_delete_Load(object sender, EventArgs e)
        {
            faiil_data_countre();
            comboBox_countre.SelectedIndex = 0;
            if (mode==MODE_OBJECT.ADD)
            {
                contant = new ClsContant();
                label_add_update.Text = "ADD New Countant";
                linkLabel_renove.Visible = false;

            }
            else
            {
                contant = ClsContant.Find(id_countaint);
                countre= Clscontrie.Find_by_id(contant.CountryID);
                label_add_update.Text = "Update New Countant";
              label_VALUE_ID. Text = Convert.ToString(id_countaint);
               textBox_first_name.Text = contant.FirstName;
                textBox_last_name.Text = contant.LastName;
                textBox_email.Text = contant.Email;
                textBox_phone.Text = contant.Phone;
                textBox_ADDRES.Text = contant.Address;
                dateTimePicker1.Text = Convert.ToString( contant.DateOfBirth);
                comboBox_countre.SelectedIndex = countre.countrie_id;
                if (contant.ImagePath != "")

                    try
                    {
                        pictureBox1.Load(contant.ImagePath);
                    }
                    catch 
                    {
                        MessageBox.Show("الصورة العميل غير موجودة في الجهاز ");
                    }




            }
        }

        private void linkLabel_immeg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                
            }
        }

        private void linkLabel_renove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pictureBox1.ImageLocation ="";
            linkLabel_renove.Visible = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
           

                contant.FirstName = textBox_first_name.Text;
                contant.LastName = textBox_last_name.Text;
                contant.Email= textBox_email.Text ;
                contant.Phone=textBox_phone.Text;
                contant.Address = textBox_ADDRES.Text;
                contant.DateOfBirth =Convert.ToDateTime( dateTimePicker1.Text);
            if (pictureBox1.ImageLocation != null)
                contant.ImagePath = pictureBox1.ImageLocation.ToString();
            else
                contant.ImagePath="";

               countre = Clscontrie.Find_by_name(comboBox_countre.Text);
               contant.CountryID = countre.countrie_id;

            ////////////////


                if (contant.save())
                    MessageBox.Show("Data Saved Successfully.");
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

                mode = MODE_OBJECT.UPDATE;
                label_add_update.Text = "Update contant";
                label_VALUE_ID.Text = Convert.ToString( contant.ContactID);

                this.Close();

        }

        private void button_cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
