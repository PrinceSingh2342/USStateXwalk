﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USStateXwalk
{
    public partial class USStateXwalk : Form
    {
        string lstr;
        HttpWebRequest request;
        HttpWebResponse response = null/* TODO Change to default(_) if this is not a reference type */;
        StreamReader reader;
        string strSiteUrlFromAppConfig = ConfigurationManager.AppSettings["SiteUrlFromAppConfig"];
        public USStateXwalk()
        {
            InitializeComponent();
        }

        private void ProcessXwalkCrawl_Click(object sender, EventArgs e)
        {
            request = (HttpWebRequest)WebRequest.Create(strSiteUrlFromAppConfig);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            lstr = reader.ReadToEnd();
        }

        private void StateCDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string StateCDName = ConfigurationManager.AppSettings["StateName"];

        }
    }
}
