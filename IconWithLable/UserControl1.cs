using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IconWithLable
{
    
    public partial class IconWithlb: UserControl
    {

        private Image Src;
        private String LableTxt;
        public Image src
        {
            get
            {
                return Src;
            }
            set
            {
                Src = value;
                SetImage();
            }
        }

        public String lableTxt
        {
            get
            {
                return LableTxt;
            }
            set
            {
                LableTxt = value;
                SetText();
            }
        }

        private void SetText()
        {
            lbName.Text = LableTxt;
        }

        private void SetImage()
        {
            picBox.Image = src;
        }

        public IconWithlb()
        {
            InitializeComponent();
        }

        private void IconWithlb_Load(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
