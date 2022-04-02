using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemstone
{
    public partial class Gemsvana : Form
    {
        public Gemsvana()
        {
            InitializeComponent();
        }

        private void Gemsvana_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AccountManagement account  = new AccountManagement();
            account.TopLevel = false;
            account.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(account);
            account.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Store store = new Store();
            store.TopLevel = false;
            store.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(store);
            store.Show();
        }
    }
}
