
namespace BetaMart
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editt = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.judul = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_add = new System.Windows.Forms.Button();
            this.cancel_add = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_barang = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save_edit = new System.Windows.Forms.Button();
            this.cancel_edit = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDown6);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.editt);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.judul);
            this.panel1.Location = new System.Drawing.Point(5, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 405);
            this.panel1.TabIndex = 0;
            this.panel1.VisibleChanged += new System.EventHandler(this.betamart_visible_changed);
            // 
            // editt
            // 
            this.editt.BackColor = System.Drawing.Color.Tan;
            this.editt.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editt.Location = new System.Drawing.Point(699, 325);
            this.editt.Name = "editt";
            this.editt.Size = new System.Drawing.Size(82, 26);
            this.editt.TabIndex = 3;
            this.editt.Text = "Edit";
            this.editt.UseVisualStyleBackColor = false;
            this.editt.Click += new System.EventHandler(this.editt_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Tan;
            this.add.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(10, 62);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(82, 26);
            this.add.TabIndex = 2;
            this.add.Text = "Tambah";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.BackColor = System.Drawing.Color.Wheat;
            this.judul.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.ForeColor = System.Drawing.Color.SaddleBrown;
            this.judul.Location = new System.Drawing.Point(336, 16);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(175, 42);
            this.judul.TabIndex = 1;
            this.judul.Text = "Beta Mart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.save_add);
            this.panel2.Controls.Add(this.cancel_add);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.add_barang);
            this.panel2.Location = new System.Drawing.Point(5, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 420);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // save_add
            // 
            this.save_add.BackColor = System.Drawing.Color.Tan;
            this.save_add.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_add.Location = new System.Drawing.Point(547, 315);
            this.save_add.Name = "save_add";
            this.save_add.Size = new System.Drawing.Size(89, 30);
            this.save_add.TabIndex = 8;
            this.save_add.Text = "Simpan";
            this.save_add.UseVisualStyleBackColor = false;
            this.save_add.Click += new System.EventHandler(this.save_add_Click);
            // 
            // cancel_add
            // 
            this.cancel_add.BackColor = System.Drawing.Color.SandyBrown;
            this.cancel_add.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_add.Location = new System.Drawing.Point(148, 315);
            this.cancel_add.Name = "cancel_add";
            this.cancel_add.Size = new System.Drawing.Size(89, 30);
            this.cancel_add.TabIndex = 7;
            this.cancel_add.Text = "Batal";
            this.cancel_add.UseVisualStyleBackColor = false;
            this.cancel_add.Click += new System.EventHandler(this.cancel_add_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(276, 229);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(360, 29);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(276, 167);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(360, 29);
            this.numericUpDown1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(276, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(144, 169);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga Barang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(144, 231);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(144, 108);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_barang
            // 
            this.add_barang.AutoSize = true;
            this.add_barang.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_barang.ForeColor = System.Drawing.Color.SaddleBrown;
            this.add_barang.Location = new System.Drawing.Point(270, 23);
            this.add_barang.Name = "add_barang";
            this.add_barang.Size = new System.Drawing.Size(260, 31);
            this.add_barang.TabIndex = 0;
            this.add_barang.Text = "Tambah Barang Baru";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.save_edit);
            this.panel3.Controls.Add(this.cancel_edit);
            this.panel3.Controls.Add(this.numericUpDown3);
            this.panel3.Controls.Add(this.numericUpDown4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Edit);
            this.panel3.Location = new System.Drawing.Point(4, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 434);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // save_edit
            // 
            this.save_edit.BackColor = System.Drawing.Color.Tan;
            this.save_edit.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_edit.Location = new System.Drawing.Point(552, 348);
            this.save_edit.Name = "save_edit";
            this.save_edit.Size = new System.Drawing.Size(89, 30);
            this.save_edit.TabIndex = 17;
            this.save_edit.Text = "Simpan";
            this.save_edit.UseVisualStyleBackColor = false;
            this.save_edit.Click += new System.EventHandler(this.save_edit_Click);
            // 
            // cancel_edit
            // 
            this.cancel_edit.BackColor = System.Drawing.Color.SandyBrown;
            this.cancel_edit.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_edit.Location = new System.Drawing.Point(153, 348);
            this.cancel_edit.Name = "cancel_edit";
            this.cancel_edit.Size = new System.Drawing.Size(89, 30);
            this.cancel_edit.TabIndex = 16;
            this.cancel_edit.Text = "Batal";
            this.cancel_edit.UseVisualStyleBackColor = false;
            this.cancel_edit.Click += new System.EventHandler(this.cancel_edit_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(281, 262);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(360, 29);
            this.numericUpDown3.TabIndex = 15;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(281, 200);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(360, 29);
            this.numericUpDown4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(281, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(360, 29);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(149, 202);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Harga Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(149, 264);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stok Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(149, 141);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nama Barang";
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.BackColor = System.Drawing.Color.Wheat;
            this.Edit.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Edit.Location = new System.Drawing.Point(324, 56);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(151, 31);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit Barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 218);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.SandyBrown;
            this.delete.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(699, 357);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 26);
            this.delete.TabIndex = 6;
            this.delete.Text = "Hapus";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.Location = new System.Drawing.Point(566, 326);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown5.TabIndex = 7;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.Location = new System.Drawing.Point(566, 361);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Button editt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button save_add;
        private System.Windows.Forms.Button cancel_add;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label add_barang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button save_edit;
        private System.Windows.Forms.Button cancel_edit;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label8;
    }
}

