using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        double toplamGelir = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            // 1) Boşluq yoxlaması
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Bütün xanaları doldurun!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Say yoxlaması (tam ədəd və 0-dan böyük)
            if (!int.TryParse(textBox2.Text.Trim(), out int count))
            {
                MessageBox.Show("Say tam ədəd olmalıdır!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (count <= 0)
            {
                MessageBox.Show("Say sıfır və ya mənfi ola bilməz!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // 3) Qiymət yoxlaması (nöqtə və ya vergül qəbul edilir, 0-dan böyük)
            string qiymetMetn = textBox3.Text.Trim().Replace(',', '.');
            if (!double.TryParse(qiymetMetn, NumberStyles.Any,
                CultureInfo.InvariantCulture, out double price))
            {
                MessageBox.Show("Qiymət düzgün ədəd olmalıdır!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Qiymət sıfır və ya mənfi ola bilməz!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 4) Hesablama və cədvələ əlavə
            double result = count * price;

            dataGridView1.Rows.Add(
                textBox1.Text.Trim(),
                count.ToString(),
                price.ToString(CultureInfo.InvariantCulture),
                result.ToString("F2", CultureInfo.InvariantCulture));

            // 5) Toplam gəlir
            toplamGelir += result;
            lblToplam.Text = toplamGelir.ToString("F2", CultureInfo.InvariantCulture);

            // 6) Xanaların sıfırlanması
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Çıxış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}