using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orol2
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            lblTest.Text = "ciao";

           

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void ciao(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(this.pictureBox1, this.pictureBox1.Text = "VAI ALL'OROLOGIO");

        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text , Height=100};
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog(("Non sei " + lblNomee.Text + "?\nCome ti chiami?") , "Cambio Nome");
            lblNomee.Text = promptValue;
            lblNome2.Text = promptValue;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog(("Non sei " + lblNomee.Text + "?\nCome ti chiami?"), "Cambio Nome");
            lblNomee.Text = promptValue;
            lblNome2.Text = promptValue;
        }

        private void lblNome2_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog(("Non sei " + lblNomee.Text + "?\nCome ti chiami?"), "Cambio Nome");
            lblNomee.Text = promptValue;
            lblNome2.Text = promptValue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog(("Non sei " + lblNomee.Text + "?\nCome ti chiami?"), "Cambio Nome");
            lblNomee.Text = promptValue;
            lblNome2.Text = promptValue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog(("Non sei " + lblNomee.Text + "?\nCome ti chiami?"), "Cambio Nome");
            lblNomee.Text = promptValue;
            lblNome2.Text = promptValue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog(("Non sei " + lblNomee.Text + "?\nCome ti chiami?"), "Cambio Nome");
            lblNomee.Text = promptValue;
            lblNome2.Text = promptValue;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

     
    }
}
