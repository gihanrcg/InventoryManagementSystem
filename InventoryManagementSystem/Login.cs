using InventoryManagementSystem.DBOperations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserNameLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNameLogin.Text == "User ID")
            {
                txtUserNameLogin.Clear();
                txtPasswordLogin.Clear();
            }
        }

        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.BringToFront();
        }

        private void btnSignUpLogin_Click(object sender, EventArgs e)
        {
            pnlSignUp.BringToFront();
        }

        private void pnlSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFullNameSignUp_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = txtFullNameSignUp.Text;
        }

        private void txtEmailSignUp_TextChanged(object sender, EventArgs e)
        {
            lblEmail.Text = txtEmailSignUp.Text;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_MouseHover(object sender, EventArgs e)
        {
            btnSelectImage.ForeColor = Color.White;
            btnSelectImage.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnSelectImage_MouseLeave(object sender, EventArgs e)
        {
            btnSelectImage.ForeColor = Color.FromArgb(78, 184, 206);
            btnSelectImage.BackColor = Color.FromArgb(34, 36, 49);

        }

        private void txtConfirmPassSignUp_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.Text != txtConfirmPassSignUp.Text)
            {
                txtConfirmPassSignUp.ForeColor = Color.Maroon;
            }
            else
            {
                txtConfirmPassSignUp.ForeColor = Color.FromArgb(78, 184, 206);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.BringToFront();

        }

        private void btnSelectImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png)";

            if (d.ShowDialog() == DialogResult.OK)
            {
                String picpath = d.FileName.ToString();
                //txtpicpath.Text = picpath;
                //picpath = txtpicpath.Text;
                profilePicSignUp.Visible = true;
                profilePicSignUp.ImageLocation = picpath;
            }
        }

        private void btnSignUpSignUp_Click(object sender, EventArgs e)
        {
            signUp();
        }

        private void signUp()
        {
            String name = txtFullNameSignUp.Text;
            String email = txtEmailSignUp.Text;
            String mobile = txtMobileNoSignUp.Text;
            String password = txtPasswordSignUp.Text;
            String confPass = txtConfirmPassSignUp.Text;
            byte[] imageBt = null;
            if (profilePicSignUp.ImageLocation != null)
            {
                MemoryStream ms = new MemoryStream();
                profilePicSignUp.Image.Save(ms, ImageFormat.Jpeg);
                imageBt = ms.ToArray();


                //FileStream fstream = new FileStream(profilePicSignUp.ImageLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader br = new BinaryReader(fstream);
                //imageBt = br.ReadBytes((int)fstream.Length);
            }

            if (validateSignUp())
            {
                DialogResult d = MessageBox.Show("Are you sure you want to sign-up ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    try
                    {
                        Dictionary<String,Object> paramDictionary = new Dictionary<string,object>();
                        paramDictionary.Add("image", imageBt);

                        ResultObject r = DBOperations.CrudOperations.insert("Users", "FullName,email,mobile,password,profilePicture", "'" + name + "','" + email + "','" + mobile + "','" + password + "','@image'", paramDictionary, true);
                        String id = r.primaryKey;
                        
                        //DBConnect db = new DBConnect();
                        //String q = "Insert into Users(FullName,email,mobile,password,profilePicture) OUTPUT INSERTED.ID values('" + name + "','" + email + "','" + mobile + "','" + password + "','@image')";

                        //SqlCommand cmd = new SqlCommand(q, db.con);
                        //cmd.Parameters.AddWithValue("image", imageBt);
                        //int id = (int)cmd.ExecuteScalar();
                        MessageBox.Show("Account created successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult di = MessageBox.Show("Collect your Employee ID from the Manager \n Use " + id + " as your login UserID", "IMPORTANT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (di == DialogResult.OK)
                        {
                            pnlLogin.BringToFront();
                        }
                    
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Values you have entered appeared to be invalid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                    }
                }
            }


        }
        private Boolean validateSignUp()
        {
            bool result = false;



            if (String.IsNullOrEmpty(txtFullNameSignUp.Text))
            {
                ErrorProvider.Clear();
                ErrorProvider.SetError(txtFullNameSignUp, "Name can not be empty");
            }
            else if (!Validations.isValidEmail(txtEmailSignUp.Text))
            {
                ErrorProvider.Clear();
                ErrorProvider.SetError(txtEmailSignUp, "Invalid Email Address");
            }
            else if (!Validations.isValidMobile(txtMobileNoSignUp.Text))
            {
                ErrorProvider.Clear();
                ErrorProvider.SetError(txtMobileNoSignUp, "Invalid Mobile No");
            }
            else if (!Validations.isLengthValid(txtPasswordSignUp.Text, 4))
            {
                ErrorProvider.Clear();
                ErrorProvider.SetError(txtPasswordSignUp, "Password length should be more than 4");
            }
            else if (!txtPasswordSignUp.Text.Equals(txtConfirmPassSignUp.Text))
            {
                ErrorProvider.Clear();
                ErrorProvider.SetError(txtConfirmPassSignUp, "Passwords do not match");
            }
            else
            {
                ErrorProvider.Clear();
                result = true;
            }
            return result;

        }




        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPasswordLogin.PasswordChar = '\0';
            txtPasswordLogin.UseSystemPasswordChar = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLoginValid())
            {
                try
                {
                    DBConnect db = new DBConnect();
                    String q = "select password from Users where Id = '" + txtUserNameLogin.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, db.con);
                    SqlDataReader r = cmd.ExecuteReader();
                    String dbPass = null;
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            dbPass = r["password"].ToString();
                            if (dbPass.Equals(txtPasswordLogin.Text))
                            {
                                BaseForm b = new BaseForm(txtUserNameLogin.Text);
                                b.Show();

                            }
                            else
                            {
                                MessageBox.Show("Login Failed");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Data);

                }
            }
        }
        private bool isLoginValid()
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtUserNameLogin.Text) || String.IsNullOrEmpty(txtPasswordLogin.Text))
            {
                ErrorProvider.Clear();
                ErrorProvider.SetError(btnLogin, "User ID or Password Cannot be empty");
            }
            else
            {
                result = true;
            }
            return result;
        }





    }
}
