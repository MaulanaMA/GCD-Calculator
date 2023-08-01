using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GCDCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int a, b;

            // Langkah 1
            if (!int.TryParse(aTextBox.Text, out a) || !int.TryParse(bTextBox.Text, out b))
            {
                MessageBox.Show("Mohon masukkan bilangan bulat yang valid!");
                return;
            }

            int x = a;
            int y = b;

            // Langkah 2
            resultTextBox.Clear();
            resultTextBox.AppendText("Membandingkan bilangan a dan b..." + Environment.NewLine);

            if (b > a)
            {
                resultTextBox.AppendText("Perbandingan: " + a + " <= " + b + Environment.NewLine);
                int temp = a;
                a = b;
                b = temp;
                resultTextBox.AppendText("Nilai a dan b ditukar." + Environment.NewLine);
                resultTextBox.AppendText("Nilai a sekarang: " + a + Environment.NewLine);
                resultTextBox.AppendText("Nilai b sekarang: " + b + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                resultTextBox.AppendText("Perbandingan: " + a + " >= " + b + Environment.NewLine);
                resultTextBox.AppendText("Tidak ada perubahan pada nilai a dan b." + Environment.NewLine + Environment.NewLine);
            }

            int s;

            do
            {
                // Langkah 3
                s = a % b;
                resultTextBox.AppendText("Sisa pembagian " + a + " dan " + b + ": " + s + Environment.NewLine + Environment.NewLine);

                // Langkah 4
                if (s != 0)
                {
                    resultTextBox.AppendText("Gantikan nilai a dengan b, maka sekarang nilai a = " + b + Environment.NewLine);
                    resultTextBox.AppendText("Gantikan nilai b dengan s, maka sekarang nilai b = " + s + Environment.NewLine + Environment.NewLine);
                    a = b;
                    b = s;
                }
            } while (s != 0);

            // Langkah 5
            resultTextBox.AppendText("Maka PBB dari " + x + " dan " + y + " = " + b + Environment.NewLine);
        }
    }
}
