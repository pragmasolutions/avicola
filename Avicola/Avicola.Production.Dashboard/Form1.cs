﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win.Forms;
using Telerik.WinControls.UI;

namespace Avicola.Production.Dashboard
{
    public partial class Form1 : FrmBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlDocument doc = this.webBrowser.Document;
            webBrowser.Navigate(new Uri(ConfigurationManager.AppSettings["ProductionDashboardUrl"]));
        }
    }
}
