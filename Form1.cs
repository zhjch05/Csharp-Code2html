using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Code2Html
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            txt_bot.Enabled = false;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File";
            dlg.Filter = "All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = dlg.OpenFile()) != null)
                {
                    string strFileName = dlg.FileName;
                    StreamReader myReader = new StreamReader(strFileName);
                    txt_top.Text = myReader.ReadToEnd();
                }
            }
        }

        private void btn_to_Click(object sender, EventArgs e)
        {
            char[] f = txt_top.Text.ToCharArray();
            String result = "<pre><code>";
            for(int i=0;i<f.Length;i++)
            {
                switch (f[i])
                {
                    case '<':
                        result += "&lt;";
                        break;
                    case '>':
                        result += "&gt;";
                        break;
                    case '\t':
                        result += "&nbsp;&nbsp;&nbsp;&nbsp;";
                        break;
                    case ' ':
                        result += "&nbsp;";
                        break;
                    case '\"':
                        result += "&quot;";
                        break;
                    case '&':
                        result += "&amp;";
                        break;
                    default:
                        result += f[i];
                        break;
                }
            }
            result += "</code></pre>";
            txt_bot.Enabled = true;
            txt_bot.Text = result;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (txt_bot.Enabled) txt_bot.Text = "";
            if (txt_top.Enabled) txt_top.Text = "";
        }
    }
}
