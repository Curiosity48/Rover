using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rover
{
    public partial class Form1 : Form
    {
        private SerialPort s;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
