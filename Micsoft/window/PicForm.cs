using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window
{
    public partial class PicForm : Form
    {
        public bool m_open = false;
        public PicForm()
        {
            InitializeComponent();
            m_open = true;
        }

        public void ShowImage(string picPath)
        {
            if (m_open)
            {
                this.BackgroundImage = Image.FromFile(picPath);
                this.Width = this.BackgroundImage.Width;
                this.Height = this.BackgroundImage.Height;

                this.Show();
            }
        }

        private void PicForm_Load(object sender, EventArgs e)
        {
            m_open = true;
        }

        private void PicForm_Closed(object sender, FormClosedEventArgs e)
        {
            m_open = false;
        }


    }
}
