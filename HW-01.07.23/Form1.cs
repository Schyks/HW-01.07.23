using HW_01._07._23.Properties;
using System.Globalization;
using System.Resources;

namespace HW_01._07._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-UA");
            Controls.Clear();
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
            Controls.Clear();
            InitializeComponent();
        }
    }
}