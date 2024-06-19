using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab29
{
    public partial class SettingsForm : Form
    {
        private Form1 mainForm;
        public SettingsForm(Form1 form)
        {
            mainForm = form;
            InitializeComponent();

            foreach (FontFamily font in FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }
            fontComboBox.SelectedIndex = 0; // Вибір першого шрифту за замовчуванням
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string host = hostTextBox.Text;
                int localPort = int.Parse(localPortTextBox.Text);
                int remotePort = int.Parse(remotePortTextBox.Text);
                int ttl = int.Parse(ttlTextBox.Text);
                Font font = new Font(fontComboBox.SelectedItem.ToString(), int.Parse(fontSizeTextBox.Text));

                mainForm.UpdateSettings(host, localPort, remotePort, ttl, font);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
