namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_insert = new Button();
            lbl_id = new Label();
            txt_id = new TextBox();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            txt_name = new TextBox();
            btn_update = new Button();
            btn_delete = new Button();
            groupBox1 = new GroupBox();
            lbl_name = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(77, 252);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(338, 44);
            btn_insert.TabIndex = 0;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += Btn_insert_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(68, 109);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(31, 20);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "ID :";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(125, 106);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(237, 27);
            txt_id.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, id });
            dataGridView1.Location = new Point(513, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(304, 300);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "NOME";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(125, 55);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(237, 27);
            txt_name.TabIndex = 5;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(77, 314);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(338, 41);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += Btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(77, 372);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(338, 34);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += Btn_delete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_id);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(lbl_name);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Location = new Point(35, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 168);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(42, 59);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(57, 20);
            lbl_name.TabIndex = 4;
            lbl_name.Text = "Nome :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(groupBox1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(dataGridView1);
            Controls.Add(btn_insert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_insert;
        private Label lbl_id;
        private TextBox txt_id;
        private DataGridView dataGridView1;
        private TextBox txt_name;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox1;
        private Label lbl_name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn id;
    }
}
