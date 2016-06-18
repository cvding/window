using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace window
{
    public partial class winMain : Form
    {
        int m_picNumb = 0;
        int m_picType = 0;
        string[] m_path;
        private string m_picInfo;
        PicForm m_picForm;

        public winMain()
        {
            InitializeComponent();
        }

        private string getHostIp()
        {
            string hostname = Dns.GetHostName();//得到本机名   
             //IPHostEntry localhost = Dns.GetHostByName(hostname);//方法已过期，只得到IPv4的地址   
             IPHostEntry localhost = Dns.GetHostEntry(hostname);  
             IPAddress localaddr = localhost.AddressList[0];
             return hostname;//localaddr.ToString();  
        }

        private void bntReadImgs_Click(object sender, EventArgs e)
        {
            if (this.rdoFile.Checked)
            {
                OpenFileDialog fdlg = new OpenFileDialog();

                fdlg.ShowHelp = true;
                
                fdlg.Filter = "所有文件|*.bmp;*.pcx;*.png;*.jpg;*.gif;" +
                            "*.tif;*.ico;*.dcx;*.cgm;*.cdr;*.wmf;*.eps;*.emf;|" +
                            "位图(*.bmp;*.jpg;*.png;...)|*.bmp;*.pcx;*.png;*.jpg;*.gif;*.tif;*.ico|" +
                           "矢量图(*.wmf;*.eps;*.emf;...)|*.dcf;*.cgm;*.cdr;*.wmf;*.eps;*.emf";
                fdlg.Title = "打开图像文件";
                
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    
                    if(m_picForm == null || m_picForm.m_open == false)
                    {
                        m_picForm = new PicForm();
                    }
                    m_picType = 0;
                    m_picInfo = fdlg.FileName;
                    this.txtPath.Text = fdlg.FileName;

                    m_picForm.ShowImage(m_picInfo);
                    this.txtPath.Text = getHostIp();
                    
                    
                }
            }
            else
            {
                FolderBrowserDialog fdlg = new FolderBrowserDialog();
                
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    m_picType = 1;
                    m_picInfo = fdlg.SelectedPath;
                    this.txtPath.Text = fdlg.SelectedPath;

                    m_path = System.IO.Directory.GetFiles(m_picInfo);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_picType == 1)
            {
                m_picNumb++;
                if (m_picNumb == m_path.Length) m_picNumb = 0;
                if (m_picForm == null || m_picForm.m_open == false)
                {
                    m_picForm = new PicForm();
                }
                m_picForm.ShowImage(m_path[m_picNumb]);
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            this.colorDialog1 = new ColorDialog();
            this.colorDialog1.ShowDialog();
        }

    }
}
