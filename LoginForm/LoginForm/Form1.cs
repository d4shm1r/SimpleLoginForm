using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            /*
                Simple Login Program Made by d4shm1r
                this is the easiest way to made a login
                form for an app.
             */
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Welcome " + textBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
