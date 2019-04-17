using InventoryManagementSystem.DBOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class BaseForm : Form
    {
        private string userID;
        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(string UserName)
        {            
            this.userID = UserName;
            
            InitializeComponent();
            Timer.Start();
            contextMenuBaseForm.Renderer = new MyRenderer();
           // MainMenuStrip.Renderer = new MyRendererMainMenuStrip();
           
         
        }

        private void setUserPanel()
        {
            using (DBConnect db = new DBConnect())
            {
                String q = "select FullName,email,jobRole,profilePicture from Users where Id = '" + userID + "'";
                SqlCommand cmd = new SqlCommand(q, db.con);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    lblUserName.Text = r["FullName"].ToString();
                    lblEmail.Text = r["email"].ToString();
                    lblJobRole.Text = r["jobRole"].ToString();

                    try
                    {
                        byte[] img = (byte[])r["profilePicture"];

                        if (img == null)
                        {
                            userProfilePic.Image = null;
                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            userProfilePic.Image = Image.FromStream(mstream);
                        }
                    }
                    catch (Exception)
                    {
                        //userProfilePic.Image = Image;
                        
                    }
                }
            }
           
            
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            setUserPanel();
            //MainMenuStrip.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void pnlBaseNavPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("yyyy MMM dd dddd");
            lblSeconds.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSeconds.Location.Y);
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void contextMenuBaseForm_Opening(object sender, CancelEventArgs e)
        {
            contextMenuBaseForm.ForeColor = Color.White;
           
      
        }

        private void contextMenuBaseForm_MouseEnter(object sender, EventArgs e)
        {
            //ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            ////TSMI.ForeColor = Color.Red;
            //TSMI.BackColor = Color.Red;
        }

        private void contextMenuBaseForm_MouseLeave(object sender, EventArgs e)
        {
            ////ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            ////TSMI.ForeColor = Color.Green;
            //contextMenuBaseForm.BackColor = Color.Green;
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(78, 184, 206); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Yellow; }
            }
        }

        private class MyRendererMainMenuStrip : ToolStripProfessionalRenderer
        {
            public MyRendererMainMenuStrip() : base(new MyColorsMainMenuStrip()) { }
        }

        private class MyColorsMainMenuStrip : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(78, 184, 206); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Yellow; }
            }
            public override Color MenuBorder
            {
                get
                {
                    return Color.FromArgb(78, 184, 206);
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com"); 
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SLIIT");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrudOperations.insert("employee", "name,age,address", "gihan,21,galle");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlSelected.Top = button2.Top;
            pnlSelected.Height = button2.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlSelected.Top = btnDashBoard.Top;
            pnlSelected.Height = btnDashBoard.Height;
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            pnlSelected.Top = btnViewInventory.Top;
            pnlSelected.Height = btnViewInventory.Height;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Text != "Login")
                    f.Close();
            }
            
            
       

        }

        private void tharinduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tahrindu clicked");
        }

  





    }
}
