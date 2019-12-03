namespace Списки_ver_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_textbox = new System.Windows.Forms.TextBox();
            this.otch_textbox = new System.Windows.Forms.TextBox();
            this.Fam_textbox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Label();
            this.otch = new System.Windows.Forms.Label();
            this.famil = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new Списки_ver_2.usersDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.group_textbox);
            this.groupBox1.Controls.Add(this.otch_textbox);
            this.groupBox1.Controls.Add(this.Fam_textbox);
            this.groupBox1.Controls.Add(this.Name_textBox);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.group);
            this.groupBox1.Controls.Add(this.otch);
            this.groupBox1.Controls.Add(this.famil);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(246, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "добавление записи";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // group_textbox
            // 
            this.group_textbox.Location = new System.Drawing.Point(94, 102);
            this.group_textbox.Name = "group_textbox";
            this.group_textbox.Size = new System.Drawing.Size(100, 20);
            this.group_textbox.TabIndex = 9;
            // 
            // otch_textbox
            // 
            this.otch_textbox.Location = new System.Drawing.Point(94, 74);
            this.otch_textbox.Name = "otch_textbox";
            this.otch_textbox.Size = new System.Drawing.Size(100, 20);
            this.otch_textbox.TabIndex = 8;
            // 
            // Fam_textbox
            // 
            this.Fam_textbox.Location = new System.Drawing.Point(94, 48);
            this.Fam_textbox.Name = "Fam_textbox";
            this.Fam_textbox.Size = new System.Drawing.Size(100, 20);
            this.Fam_textbox.TabIndex = 7;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(94, 19);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Name_textBox.TabIndex = 6;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(190, 128);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "Закрыть";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(94, 128);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(6, 102);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(42, 13);
            this.group.TabIndex = 3;
            this.group.Text = "Группа";
            // 
            // otch
            // 
            this.otch.AutoSize = true;
            this.otch.Location = new System.Drawing.Point(6, 77);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(54, 13);
            this.otch.TabIndex = 2;
            this.otch.Text = "Отчество";
            // 
            // famil
            // 
            this.famil.AutoSize = true;
            this.famil.Location = new System.Drawing.Point(6, 51);
            this.famil.Name = "famil";
            this.famil.Size = new System.Drawing.Size(56, 13);
            this.famil.TabIndex = 1;
            this.famil.Text = "Фамилия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(6, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Имя";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Списки_ver_2.usersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox group_textbox;
        private System.Windows.Forms.TextBox otch_textbox;
        private System.Windows.Forms.TextBox Fam_textbox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label otch;
        private System.Windows.Forms.Label famil;
        private System.Windows.Forms.Label name;
        private usersDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}