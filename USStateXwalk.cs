using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace USStateXwalk
{
    public partial class USStateXwalk : Form
    {
        string lstr;
        string selectedpath;
        HttpWebRequest request;
        HttpWebResponse response = null/* TODO Change to default(_) if this is not a reference type */;
        StreamReader reader;
        string strSiteUrlFromAppConfig = ConfigurationManager.AppSettings["SiteUrlFromAppConfig"];
        public USStateXwalk()
        {
            InitializeComponent();
            StateCDcomboBox_SelectedIndexChanged(reader, null);
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
            string USStateValue = ConfigurationManager.AppSettings["USStateList"];
            if (!string.IsNullOrEmpty(USStateValue))
            {
                string[] values = USStateValue.Split(',');
                StateCDcomboBox.Items.AddRange(values);
            }
            else
            {
                // Handle the case where the key is not found in the App.config
                MessageBox.Show("ComboBoxValues key not found in App.config");
            }
        }

        private void btnbrowsefolder_Click(object sender, EventArgs e)
        {
            fdbbrowsefolder.ShowDialog();
            DownloadXwalkPath.Text = fdbbrowsefolder.SelectedPath;
            selectedpath = DownloadXwalkPath.Text;
        }

        private void DownloadXwalkPath_TextChanged(object sender, EventArgs e)
        {
            selectedpath = DownloadXwalkPath.Text;
        }
    }
}
