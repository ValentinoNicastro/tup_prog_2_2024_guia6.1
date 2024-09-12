using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_1.Models;

namespace Actividad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            List<string> patentes = new List<string>()
            {
                "OXY333", "OYZ 013", "AAA 123", "BCD 456", "AB 123 CD", "YZ5432EF", "QW 3456 AB"
            };

            IProcesar procesar = null;

            if (rbString.Checked)
            {

            }
            else if (rbRegex.Checked)
            {
                 procesar = new 
            }
        }
    }
}
