using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearDns
{
    public partial class DNSClear : Form
    {
        public DNSClear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ProcessStartInfo process1 = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = @"/k ipconfig/flushdns & ipconfig /registerdns & ipconfig/release & ipconfig/renew & netsh winsock reset",
                UseShellExecute = true,
                Verb = "runas" // Esto es para ejecutar como administrador

            };
            
                Process.Start(process1);
            
        }
    }
}
