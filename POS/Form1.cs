using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost_of_Items()
        {
            double sum = 0;
            int i = 0;
            for (i= 0; i < (dataGridView1.Rows.Count); i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        private void Total()
        {
            
            if (dataGridView1.Rows.Count > 0)
            {
                
                lblTotal.Text = String.Format("{0:F2}", (Cost_of_Items()));

            }

        }
        private void Cambio()
        {
            Double c, q;
            if (dataGridView1.Rows.Count > 0)
            {
                q = Cost_of_Items();
                c = Convert.ToInt32(lblPago.Text);
                lblVuelto.Text = String.Format("{0:F2}", c - q);
                
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMedio.Items.Add("Efectivo");
            cbMedio.Items.Add("Débito");
            cbMedio.Items.Add("Mercado Pago");

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;

        private void button39_Click(object sender, EventArgs e)
        {
            try {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (cbMedio.Text == "Efectivo")
            {
                Cambio();
            }
            else
            {
                lblVuelto.Text = "";
                lblPago.Text = "0";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try { 
            lblPago.Text = "0";
            lblVuelto.Text = "";
            lblTotal.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            cbMedio.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            if (cbMedio.Text == "Efectivo")
            {
                Cambio();
            }
            else
            {
                lblVuelto.Text = "";
                lblPago.Text = "0";
            }
        }

        private void cbMedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblPago_Click(object sender, EventArgs e)
        {

        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            if (lblPago.Text == "0")
            {
                lblPago.Text = "";
                lblPago.Text = b.Text;

            }
            else
                lblPago.Text = lblPago.Text + b.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double CostofItem = 200;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Stout"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Stout", "1", CostofItem);
            Total();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Double CostofItem = 200;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Porter"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Porter", "1", CostofItem);
            Total();
        }

        private void lblVuelto_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblPago.Text = "0";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Amber"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Amber", "1", CostofItem);
            Total();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Irish"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Irish", "1", CostofItem);
            Total();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Barley"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Barley", "1", CostofItem);
            Total();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Brown"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Brown", "1", CostofItem);
            Total();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Old Ale"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Old Ale", "1", CostofItem);
            Total();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Scotch Ale"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }

            dataGridView1.Rows.Add("Scotch Ale", "1", CostofItem);
            Total();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                lblPago.Text = "0";
                lblVuelto.Text = "";
                lblTotal.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cbMedio.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblPago_Click_1(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Wheat Beer"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }
            dataGridView1.Rows.Add("Wheat Beer", "1", CostofItem);
            Total();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pale Ale"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }
            dataGridView1.Rows.Add("Pale Ale", "1", CostofItem);
            Total();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "India"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }
            dataGridView1.Rows.Add("India", "1", CostofItem);
            Total();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Blond"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }
            dataGridView1.Rows.Add("Blond", "1", CostofItem);
            Total();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Double CostofItem = 230;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Mild Ale"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }
            dataGridView1.Rows.Add("Mild Ale", "1", CostofItem);
            Total();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double CostofItem = 230;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Bitter"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }
            }
            dataGridView1.Rows.Add("Bitter", "1", CostofItem);
            Total();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double CostofItem = 230;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Dubbel"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }

            }
            dataGridView1.Rows.Add("Dubbel", "1", CostofItem);
            Total();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Double CostofItem = 230;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Trippel"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * CostofItem;
                    Total();
                }

            }
            dataGridView1.Rows.Add("Trippel", "1", CostofItem);
            Total();
        }

    }
}
