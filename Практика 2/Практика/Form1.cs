using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent( );
            var db = new Работа_индивидEntities();
            dataGridView1.DataSource = db.инженеры.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
