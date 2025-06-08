using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Tier_Logic;

namespace desktop_app_3_tier_in_containt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _refreach_list_contant()
        {
            DGVLIST_CONTANT.DataSource = ClsContant.oll_contant();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _refreach_list_contant();
        }

        private void button_add_countant_Click(object sender, EventArgs e)
        {
            Form fr1 = new formedit_delete(-1);
            fr1.ShowDialog();
            _refreach_list_contant();

        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr1 = new formedit_delete((int)DGVLIST_CONTANT.CurrentRow.Cells[0].Value);//وصلت الدتا قرد فيو الى الرو الي انتا مختارو الى كولم 0 جبت الفيمة منو 
           fr1.ShowDialog();
           _refreach_list_contant();


        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        { int id = (int)DGVLIST_CONTANT.CurrentRow.Cells[0].Value;
            ClsContant contant = ClsContant.Find(id);
            if(contant!=null)
            {
                if(contant.delete_contant(id))
                {
                    MessageBox.Show("Data Delete Successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Data  Delete NOT Successfully.");
                }
            }
            else
            {
                MessageBox.Show("not Exsit Countant");
            }
            _refreach_list_contant();


        }

     
    }
}
