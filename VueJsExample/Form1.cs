using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VueJsExample.backends;

namespace VueJsExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e) {

            webBrowser1.ObjectForScripting = new BridgeFunctionsClass();

            var html = File.ReadAllText("resources\\index.html", Encoding.UTF8);
            html = html.Replace("{# inject-path #}", Path.Combine(Directory.GetCurrentDirectory(), "resources"));

            webBrowser1.DocumentText = html;
        }

        private void button1_Click(object sender, EventArgs e) {
            webBrowser1.Document.InvokeScript("clickFromOutSide", null);
        }
    }
}
