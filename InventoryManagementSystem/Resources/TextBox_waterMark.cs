using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Resources
{
    public partial class TextBox_waterMark : TextBox
    {
        public TextBox_waterMark()
        {
            InitializeComponent();
        }

        private String WaterMark;
        private Boolean multiLine_ = false;

        public String WaterMarkText
        {
            get
            {
                return WaterMark;
            }
            set
            {
                WaterMark = value;
                GetSetWaterMark();
            }
        }
        [Browsable(false)]
        public new bool multiLine
        {
            get
            {
                return multiLine_;
            }
            set
            {
                multiLine_ = false;
            }
        }

        private void GetSetWaterMark()
        {
            if ((this.Text == this.WaterMark) || (this.Text != string.Empty))
            {
                this.ForeColor = Color.Gray;
                this.Text = WaterMark;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }

        private void TextBox_waterMark_Load(object sender, EventArgs e)
        {

        }
    }
}
