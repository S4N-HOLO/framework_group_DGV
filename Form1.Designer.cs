namespace Списки_ver_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.view_cards_button = new System.Windows.Forms.Button();
            this.Edit_cards_button = new System.Windows.Forms.Button();
            this.view_users_panel = new System.Windows.Forms.Panel();
            this.cardview_panel = new System.Windows.Forms.Panel();
            this.pictureBox_view_card = new System.Windows.Forms.PictureBox();
            this.group_view_textbox = new System.Windows.Forms.TextBox();
            this.secondname_view_textbox = new System.Windows.Forms.TextBox();
            this.surname_view_textbox = new System.Windows.Forms.TextBox();
            this.name_view_textbox = new System.Windows.Forms.TextBox();
            this.viewpanel_closebutton = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.Label();
            this.otch = new System.Windows.Forms.Label();
            this.famil = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Списки_ver_2.usersDataSet();
            this.back_button_view = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.edit_cards_panel = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersgroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersTableAdapter = new Списки_ver_2.usersDataSetTableAdapters.usersTableAdapter();
            this.deleterow_button = new System.Windows.Forms.Button();
            this.view_users_panel.SuspendLayout();
            this.cardview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.edit_cards_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // view_cards_button
            // 
            this.view_cards_button.Location = new System.Drawing.Point(155, 205);
            this.view_cards_button.Name = "view_cards_button";
            this.view_cards_button.Size = new System.Drawing.Size(126, 103);
            this.view_cards_button.TabIndex = 0;
            this.view_cards_button.Text = "Просмотр карточек";
            this.view_cards_button.UseVisualStyleBackColor = true;
            this.view_cards_button.Click += new System.EventHandler(this.view_cards_button_Click);
            // 
            // Edit_cards_button
            // 
            this.Edit_cards_button.Location = new System.Drawing.Point(321, 205);
            this.Edit_cards_button.Name = "Edit_cards_button";
            this.Edit_cards_button.Size = new System.Drawing.Size(124, 103);
            this.Edit_cards_button.TabIndex = 1;
            this.Edit_cards_button.Text = "Редактирование карточек";
            this.Edit_cards_button.UseVisualStyleBackColor = true;
            this.Edit_cards_button.Click += new System.EventHandler(this.Edit_cards_button_Click);
            // 
            // view_users_panel
            // 
            this.view_users_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_users_panel.Controls.Add(this.cardview_panel);
            this.view_users_panel.Controls.Add(this.button1);
            this.view_users_panel.Controls.Add(this.dataGridView1);
            this.view_users_panel.Controls.Add(this.back_button_view);
            this.view_users_panel.Location = new System.Drawing.Point(1, 1);
            this.view_users_panel.Name = "view_users_panel";
            this.view_users_panel.Size = new System.Drawing.Size(797, 446);
            this.view_users_panel.TabIndex = 2;
            this.view_users_panel.Visible = false;
            // 
            // cardview_panel
            // 
            this.cardview_panel.Controls.Add(this.pictureBox_view_card);
            this.cardview_panel.Controls.Add(this.group_view_textbox);
            this.cardview_panel.Controls.Add(this.secondname_view_textbox);
            this.cardview_panel.Controls.Add(this.surname_view_textbox);
            this.cardview_panel.Controls.Add(this.name_view_textbox);
            this.cardview_panel.Controls.Add(this.viewpanel_closebutton);
            this.cardview_panel.Controls.Add(this.group);
            this.cardview_panel.Controls.Add(this.otch);
            this.cardview_panel.Controls.Add(this.famil);
            this.cardview_panel.Controls.Add(this.name);
            this.cardview_panel.Location = new System.Drawing.Point(345, 255);
            this.cardview_panel.Name = "cardview_panel";
            this.cardview_panel.Size = new System.Drawing.Size(351, 150);
            this.cardview_panel.TabIndex = 5;
            this.cardview_panel.Visible = false;
            // 
            // pictureBox_view_card
            // 
            this.pictureBox_view_card.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_view_card.Image")));
            this.pictureBox_view_card.Location = new System.Drawing.Point(227, 9);
            this.pictureBox_view_card.Name = "pictureBox_view_card";
            this.pictureBox_view_card.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_view_card.TabIndex = 21;
            this.pictureBox_view_card.TabStop = false;
            // 
            // group_view_textbox
            // 
            this.group_view_textbox.Location = new System.Drawing.Point(112, 92);
            this.group_view_textbox.Name = "group_view_textbox";
            this.group_view_textbox.Size = new System.Drawing.Size(100, 20);
            this.group_view_textbox.TabIndex = 20;
            // 
            // secondname_view_textbox
            // 
            this.secondname_view_textbox.Location = new System.Drawing.Point(112, 64);
            this.secondname_view_textbox.Name = "secondname_view_textbox";
            this.secondname_view_textbox.Size = new System.Drawing.Size(100, 20);
            this.secondname_view_textbox.TabIndex = 19;
            // 
            // surname_view_textbox
            // 
            this.surname_view_textbox.Location = new System.Drawing.Point(112, 38);
            this.surname_view_textbox.Name = "surname_view_textbox";
            this.surname_view_textbox.Size = new System.Drawing.Size(100, 20);
            this.surname_view_textbox.TabIndex = 18;
            // 
            // name_view_textbox
            // 
            this.name_view_textbox.Location = new System.Drawing.Point(112, 9);
            this.name_view_textbox.Name = "name_view_textbox";
            this.name_view_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_view_textbox.TabIndex = 17;
            // 
            // viewpanel_closebutton
            // 
            this.viewpanel_closebutton.Location = new System.Drawing.Point(208, 118);
            this.viewpanel_closebutton.Name = "viewpanel_closebutton";
            this.viewpanel_closebutton.Size = new System.Drawing.Size(75, 23);
            this.viewpanel_closebutton.TabIndex = 16;
            this.viewpanel_closebutton.Text = "Закрыть";
            this.viewpanel_closebutton.UseVisualStyleBackColor = true;
            this.viewpanel_closebutton.Click += new System.EventHandler(this.viewpanel_closebutton_Click);
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(24, 92);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(42, 13);
            this.group.TabIndex = 14;
            this.group.Text = "Группа";
            // 
            // otch
            // 
            this.otch.AutoSize = true;
            this.otch.Location = new System.Drawing.Point(24, 67);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(54, 13);
            this.otch.TabIndex = 13;
            this.otch.Text = "Отчество";
            // 
            // famil
            // 
            this.famil.AutoSize = true;
            this.famil.Location = new System.Drawing.Point(24, 41);
            this.famil.Name = "famil";
            this.famil.Size = new System.Drawing.Size(56, 13);
            this.famil.TabIndex = 12;
            this.famil.Text = "Фамилия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(24, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 11;
            this.name.Text = "Имя";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "просмотреть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.nnameDataGridViewTextBoxColumn,
            this.surnnameDataGridViewTextBoxColumn,
            this.usersgroupDataGridViewTextBoxColumn,
            this.avatarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "familiya";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            this.familiyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nnameDataGridViewTextBoxColumn
            // 
            this.nnameDataGridViewTextBoxColumn.DataPropertyName = "Nname";
            this.nnameDataGridViewTextBoxColumn.HeaderText = "Nname";
            this.nnameDataGridViewTextBoxColumn.Name = "nnameDataGridViewTextBoxColumn";
            this.nnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnnameDataGridViewTextBoxColumn
            // 
            this.surnnameDataGridViewTextBoxColumn.DataPropertyName = "surnname";
            this.surnnameDataGridViewTextBoxColumn.HeaderText = "surnname";
            this.surnnameDataGridViewTextBoxColumn.Name = "surnnameDataGridViewTextBoxColumn";
            this.surnnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersgroupDataGridViewTextBoxColumn
            // 
            this.usersgroupDataGridViewTextBoxColumn.DataPropertyName = "users_group";
            this.usersgroupDataGridViewTextBoxColumn.HeaderText = "users_group";
            this.usersgroupDataGridViewTextBoxColumn.Name = "usersgroupDataGridViewTextBoxColumn";
            this.usersgroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avatarDataGridViewTextBoxColumn
            // 
            this.avatarDataGridViewTextBoxColumn.DataPropertyName = "avatar";
            this.avatarDataGridViewTextBoxColumn.HeaderText = "avatar";
            this.avatarDataGridViewTextBoxColumn.Name = "avatarDataGridViewTextBoxColumn";
            this.avatarDataGridViewTextBoxColumn.ReadOnly = true;
            this.avatarDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "usersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back_button_view
            // 
            this.back_button_view.Location = new System.Drawing.Point(39, 404);
            this.back_button_view.Name = "back_button_view";
            this.back_button_view.Size = new System.Drawing.Size(128, 23);
            this.back_button_view.TabIndex = 2;
            this.back_button_view.Text = "На главный экран";
            this.back_button_view.UseVisualStyleBackColor = true;
            this.back_button_view.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(26, 403);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(128, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "На главный экран";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // edit_cards_panel
            // 
            this.edit_cards_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edit_cards_panel.Controls.Add(this.deleterow_button);
            this.edit_cards_panel.Controls.Add(this.save_button);
            this.edit_cards_panel.Controls.Add(this.add);
            this.edit_cards_panel.Controls.Add(this.dataGridView2);
            this.edit_cards_panel.Controls.Add(this.back_button);
            this.edit_cards_panel.Location = new System.Drawing.Point(1, 0);
            this.edit_cards_panel.Name = "edit_cards_panel";
            this.edit_cards_panel.Size = new System.Drawing.Size(789, 438);
            this.edit_cards_panel.TabIndex = 1;
            this.edit_cards_panel.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(228, 374);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(228, 403);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "добавить строку";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.familiyaDataGridViewTextBoxColumn1,
            this.nnameDataGridViewTextBoxColumn1,
            this.surnnameDataGridViewTextBoxColumn1,
            this.usersgroupDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.usersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 32);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(749, 275);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // familiyaDataGridViewTextBoxColumn1
            // 
            this.familiyaDataGridViewTextBoxColumn1.DataPropertyName = "familiya";
            this.familiyaDataGridViewTextBoxColumn1.HeaderText = "familiya";
            this.familiyaDataGridViewTextBoxColumn1.Name = "familiyaDataGridViewTextBoxColumn1";
            this.familiyaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nnameDataGridViewTextBoxColumn1
            // 
            this.nnameDataGridViewTextBoxColumn1.DataPropertyName = "Nname";
            this.nnameDataGridViewTextBoxColumn1.HeaderText = "Nname";
            this.nnameDataGridViewTextBoxColumn1.Name = "nnameDataGridViewTextBoxColumn1";
            this.nnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnnameDataGridViewTextBoxColumn1
            // 
            this.surnnameDataGridViewTextBoxColumn1.DataPropertyName = "surnname";
            this.surnnameDataGridViewTextBoxColumn1.HeaderText = "surnname";
            this.surnnameDataGridViewTextBoxColumn1.Name = "surnnameDataGridViewTextBoxColumn1";
            this.surnnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usersgroupDataGridViewTextBoxColumn1
            // 
            this.usersgroupDataGridViewTextBoxColumn1.DataPropertyName = "users_group";
            this.usersgroupDataGridViewTextBoxColumn1.HeaderText = "users_group";
            this.usersgroupDataGridViewTextBoxColumn1.Name = "usersgroupDataGridViewTextBoxColumn1";
            this.usersgroupDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // deleterow_button
            // 
            this.deleterow_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleterow_button.Location = new System.Drawing.Point(228, 346);
            this.deleterow_button.Name = "deleterow_button";
            this.deleterow_button.Size = new System.Drawing.Size(75, 23);
            this.deleterow_button.TabIndex = 5;
            this.deleterow_button.Text = "удалить запись";
            this.deleterow_button.UseVisualStyleBackColor = true;
            this.deleterow_button.Click += new System.EventHandler(this.deleterow_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_users_panel);
            this.Controls.Add(this.edit_cards_panel);
            this.Controls.Add(this.Edit_cards_button);
            this.Controls.Add(this.view_cards_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.view_users_panel.ResumeLayout(false);
            this.cardview_panel.ResumeLayout(false);
            this.cardview_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.edit_cards_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_cards_button;
        private System.Windows.Forms.Button Edit_cards_button;
        private System.Windows.Forms.Panel view_users_panel;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel edit_cards_panel;
        private System.Windows.Forms.Button back_button_view;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button add;
        public usersDataSet usersDataSet;
        public System.Windows.Forms.DataGridView dataGridView1;
        public usersDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersgroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel cardview_panel;
        private System.Windows.Forms.PictureBox pictureBox_view_card;
        private System.Windows.Forms.TextBox group_view_textbox;
        private System.Windows.Forms.TextBox secondname_view_textbox;
        private System.Windows.Forms.TextBox surname_view_textbox;
        private System.Windows.Forms.TextBox name_view_textbox;
        private System.Windows.Forms.Button viewpanel_closebutton;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label otch;
        private System.Windows.Forms.Label famil;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button deleterow_button;
    }
}

