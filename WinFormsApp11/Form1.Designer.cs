namespace WinFormsApp11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colSay = new DataGridViewTextBoxColumn();
            colQiymet = new DataGridViewTextBoxColumn();
            colYekun = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            btnSatis = new Button();
            label4 = new Label();
            lblToplam = new Label();
            btnCixis = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colSay, colQiymet, colYekun });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1086, 400);
            dataGridView1.TabIndex = 0;
            // 
            // colAd
            // 
            colAd.FillWeight = 160F;
            colAd.HeaderText = "Gül növü (gül adı)";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.ReadOnly = true;
            colAd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colSay
            // 
            colSay.FillWeight = 60F;
            colSay.HeaderText = "Satış sayı";
            colSay.MinimumWidth = 6;
            colSay.Name = "colSay";
            colSay.ReadOnly = true;
            colSay.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colQiymet
            // 
            colQiymet.FillWeight = 60F;
            colQiymet.HeaderText = "Qiyməti";
            colQiymet.MinimumWidth = 6;
            colQiymet.Name = "colQiymet";
            colQiymet.ReadOnly = true;
            colQiymet.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colYekun
            // 
            colYekun.FillWeight = 70F;
            colYekun.HeaderText = "Yekun qiyməti";
            colYekun.MinimumWidth = 6;
            colYekun.Name = "colYekun";
            colYekun.ReadOnly = true;
            colYekun.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblToplam);
            panel1.Controls.Add(btnCixis);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 400);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnSatis);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(25, 40);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(474, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gül məlumatları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "Gül növü";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(40, 100);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 34);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 180);
            label2.Name = "label2";
            label2.Size = new Size(45, 28);
            label2.TabIndex = 1;
            label2.Text = "Say";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(40, 220);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 34);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 180);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Qiymət";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox3.Location = new Point(183, 220);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(79, 34);
            textBox3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSatis
            // 
            btnSatis.BackColor = Color.Sienna;
            btnSatis.ForeColor = Color.White;
            btnSatis.Location = new Point(291, 173);
            btnSatis.Margin = new Padding(3, 4, 3, 4);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(131, 80);
            btnSatis.TabIndex = 3;
            btnSatis.Text = "Satış et";
            btnSatis.UseVisualStyleBackColor = false;
            btnSatis.Click += btnSatis_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(754, 33);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 1;
            label4.Text = "Toplam gəlir:";
            // 
            // lblToplam
            // 
            lblToplam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplam.ForeColor = Color.White;
            lblToplam.Location = new Point(903, 33);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(53, 28);
            lblToplam.TabIndex = 2;
            lblToplam.Text = "0.00";
            // 
            // btnCixis
            // 
            btnCixis.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCixis.BackColor = Color.SandyBrown;
            btnCixis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCixis.Location = new Point(874, 313);
            btnCixis.Margin = new Padding(3, 4, 3, 4);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(91, 43);
            btnCixis.TabIndex = 4;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = false;
            btnCixis.Click += btnCixis_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(811, 107);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 800);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gül satışı";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQiymet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYekun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnCixis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}