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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int row_pos = 0;
        private string s;

        private void view_cards_button_Click(object sender, EventArgs e)
        {
            view_cards_button.Visible = false;
            Edit_cards_button.Visible = false;
            view_users_panel.Visible = true;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            view_cards_button.Visible = true;
            Edit_cards_button.Visible = true;
            view_users_panel.Visible = false;
            edit_cards_panel.Visible = false;
        }

        private void Edit_cards_button_Click(object sender, EventArgs e)
        {
            edit_cards_panel.Visible = true;
            view_cards_button.Visible = false;
            Edit_cards_button.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_cards_button.Visible = true;
            Edit_cards_button.Visible = true;
            view_users_panel.Visible = false;
            edit_cards_panel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.usersDataSet.users);

        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
           
            usersTableAdapter.Update(usersDataSet);
            MessageBox.Show("SDFSD");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            back_button_view.Visible = false;
            cardview_panel.Visible = true;
            s = dataGridView1.Rows[row_pos].Cells[5].Value.ToString();
            name_view_textbox.Text = dataGridView1.Rows[row_pos].Cells[2].Value.ToString();
            secondname_view_textbox.Text = dataGridView1.Rows[row_pos].Cells[1].Value.ToString();
            surname_view_textbox.Text = dataGridView1.Rows[row_pos].Cells[3].Value.ToString();
            group_view_textbox.Text = dataGridView1.Rows[row_pos].Cells[4].Value.ToString();
            pictureBox_view_card.ImageLocation = s;
        }

        private void viewpanel_closebutton_Click(object sender, EventArgs e) 
        {
            cardview_panel.Visible = false;
            dataGridView1.Visible = true;
            back_button_view.Visible = true;

        }

        private void deleterow_button_Click(object sender, EventArgs e)
        {
           
                if (dataGridView1.CurrentRow != null)
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            
        }
    }
}
