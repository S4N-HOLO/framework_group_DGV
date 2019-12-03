using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Списки_ver_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.usersDataSet.Tables[0].NewRow();

                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = Fam_textbox.Text;
                nRow[2] = Name_textBox.Text;
                nRow[3] = otch_textbox.Text;
                nRow[4] = group_textbox.Text;
                nRow[5] = pictureBox1.ImageLocation;

                main.usersDataSet.Tables[0].Rows.Add(nRow);
                main.usersTableAdapter.Update(main.usersDataSet.users);
                main.usersDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();

                Fam_textbox.Text = "";
                Name_textBox.Text = "";
                otch_textbox.Text = "";
                group_textbox.Text = "";
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog image_upload_dialog = new OpenFileDialog();
            image_upload_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (image_upload_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(image_upload_dialog.FileName);
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
