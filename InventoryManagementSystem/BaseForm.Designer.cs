namespace InventoryManagementSystem
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.userProfilePic = new OvalPictureBox();
            this.pnlBaseNavPanel = new System.Windows.Forms.Panel();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuBaseForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tharinduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).BeginInit();
            this.pnlBaseNavPanel.SuspendLayout();
            this.contextMenuBaseForm.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.lblSeconds);
            this.pnlUser.Controls.Add(this.lblDate);
            this.pnlUser.Controls.Add(this.lblTime);
            this.pnlUser.Controls.Add(this.lblEmail);
            this.pnlUser.Controls.Add(this.lblJobRole);
            this.pnlUser.Controls.Add(this.panel8);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.userProfilePic);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1505, 108);
            this.pnlUser.TabIndex = 0;
            this.pnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUser_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::InventoryManagementSystem.Properties.Resources.icons8_exit_30;
            this.btnLogout.Location = new System.Drawing.Point(1418, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 75);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblSeconds.Location = new System.Drawing.Point(155, 52);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(29, 19);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblDate.Location = new System.Drawing.Point(190, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblTime.Location = new System.Drawing.Point(12, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(154, 59);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(1172, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Employee";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJobRole
            // 
            this.lblJobRole.AutoSize = true;
            this.lblJobRole.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobRole.ForeColor = System.Drawing.Color.White;
            this.lblJobRole.Location = new System.Drawing.Point(1172, 74);
            this.lblJobRole.Name = "lblJobRole";
            this.lblJobRole.Size = new System.Drawing.Size(59, 17);
            this.lblJobRole.TabIndex = 1;
            this.lblJobRole.Text = "Employee";
            this.lblJobRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel8.Location = new System.Drawing.Point(3, 105);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1497, 1);
            this.panel8.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblUserName.Location = new System.Drawing.Point(1171, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(146, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Gihan Siriwardhana";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userProfilePic
            // 
            this.userProfilePic.BackColor = System.Drawing.Color.DarkGray;
            this.userProfilePic.Image = global::InventoryManagementSystem.Properties.Resources._33714978_1759290014132062_6418444945853513728_n;
            this.userProfilePic.Location = new System.Drawing.Point(1336, 6);
            this.userProfilePic.Name = "userProfilePic";
            this.userProfilePic.Size = new System.Drawing.Size(72, 97);
            this.userProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfilePic.TabIndex = 1;
            this.userProfilePic.TabStop = false;
            // 
            // pnlBaseNavPanel
            // 
            this.pnlBaseNavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBaseNavPanel.AutoSize = true;
            this.pnlBaseNavPanel.Controls.Add(this.pnlSelected);
            this.pnlBaseNavPanel.Controls.Add(this.button7);
            this.pnlBaseNavPanel.Controls.Add(this.panel10);
            this.pnlBaseNavPanel.Controls.Add(this.panel9);
            this.pnlBaseNavPanel.Controls.Add(this.panel6);
            this.pnlBaseNavPanel.Controls.Add(this.panel5);
            this.pnlBaseNavPanel.Controls.Add(this.panel4);
            this.pnlBaseNavPanel.Controls.Add(this.panel3);
            this.pnlBaseNavPanel.Controls.Add(this.panel2);
            this.pnlBaseNavPanel.Controls.Add(this.button8);
            this.pnlBaseNavPanel.Controls.Add(this.panel1);
            this.pnlBaseNavPanel.Controls.Add(this.button6);
            this.pnlBaseNavPanel.Controls.Add(this.button5);
            this.pnlBaseNavPanel.Controls.Add(this.button4);
            this.pnlBaseNavPanel.Controls.Add(this.button3);
            this.pnlBaseNavPanel.Controls.Add(this.button2);
            this.pnlBaseNavPanel.Controls.Add(this.btnDashBoard);
            this.pnlBaseNavPanel.Controls.Add(this.btnViewInventory);
            this.pnlBaseNavPanel.Location = new System.Drawing.Point(4, 131);
            this.pnlBaseNavPanel.Name = "pnlBaseNavPanel";
            this.pnlBaseNavPanel.Size = new System.Drawing.Size(247, 837);
            this.pnlBaseNavPanel.TabIndex = 1;
            this.pnlBaseNavPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBaseNavPanel_Paint);
            // 
            // pnlSelected
            // 
            this.pnlSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlSelected.Location = new System.Drawing.Point(233, 5);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(5, 95);
            this.pnlSelected.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button7.Location = new System.Drawing.Point(178, 778);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 31);
            this.button7.TabIndex = 2;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel10.Location = new System.Drawing.Point(10, 739);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(230, 1);
            this.panel10.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel9.Location = new System.Drawing.Point(9, 650);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(230, 1);
            this.panel9.TabIndex = 3;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel6.Location = new System.Drawing.Point(6, 564);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 1);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel5.Location = new System.Drawing.Point(9, 471);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 1);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel4.Location = new System.Drawing.Point(6, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 1);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel3.Location = new System.Drawing.Point(6, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 1);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.Location = new System.Drawing.Point(6, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::InventoryManagementSystem.Properties.Resources.icons8_internet_filled_30;
            this.button8.Location = new System.Drawing.Point(9, 657);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(228, 83);
            this.button8.TabIndex = 2;
            this.button8.Text = "       Website";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::InventoryManagementSystem.Properties.Resources.empID30;
            this.button6.Location = new System.Drawing.Point(8, 568);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 83);
            this.button6.TabIndex = 2;
            this.button6.Text = "       Employees";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::InventoryManagementSystem.Properties.Resources.graph30;
            this.button5.Location = new System.Drawing.Point(8, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 83);
            this.button5.TabIndex = 2;
            this.button5.Text = "       Reports";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::InventoryManagementSystem.Properties.Resources.icons8_user_group_30;
            this.button4.Location = new System.Drawing.Point(8, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 83);
            this.button4.TabIndex = 2;
            this.button4.Text = "       Customers";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::InventoryManagementSystem.Properties.Resources.icons8_shopping_cart_filled_30;
            this.button3.Location = new System.Drawing.Point(8, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "       Orders";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::InventoryManagementSystem.Properties.Resources.icons8_pos_terminal_filled_30;
            this.button2.Location = new System.Drawing.Point(8, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 83);
            this.button2.TabIndex = 2;
            this.button2.Text = "       POS";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = global::InventoryManagementSystem.Properties.Resources.icons8_speed_filled_30;
            this.btnDashBoard.Location = new System.Drawing.Point(8, 103);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(228, 83);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "       Dashboard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.FlatAppearance.BorderSize = 0;
            this.btnViewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInventory.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInventory.ForeColor = System.Drawing.Color.White;
            this.btnViewInventory.Image = global::InventoryManagementSystem.Properties.Resources.box30;
            this.btnViewInventory.Location = new System.Drawing.Point(8, 10);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(228, 83);
            this.btnViewInventory.TabIndex = 2;
            this.btnViewInventory.Text = "       View Inventory";
            this.btnViewInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.viewOrdersToolStripMenuItem.Text = "View Orders";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuBaseForm
            // 
            this.contextMenuBaseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.contextMenuBaseForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuBaseForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuBaseForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOrdersToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.tharinduToolStripMenuItem});
            this.contextMenuBaseForm.Name = "contextMenuStrip1";
            this.contextMenuBaseForm.ShowImageMargin = false;
            this.contextMenuBaseForm.ShowItemToolTips = false;
            this.contextMenuBaseForm.Size = new System.Drawing.Size(133, 98);
            this.contextMenuBaseForm.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuBaseForm_Opening);
            this.contextMenuBaseForm.MouseEnter += new System.EventHandler(this.contextMenuBaseForm_MouseEnter);
            this.contextMenuBaseForm.MouseLeave += new System.EventHandler(this.contextMenuBaseForm_MouseLeave);
            // 
            // tharinduToolStripMenuItem
            // 
            this.tharinduToolStripMenuItem.Name = "tharinduToolStripMenuItem";
            this.tharinduToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tharinduToolStripMenuItem.Text = "Tharindu";
            this.tharinduToolStripMenuItem.Click += new System.EventHandler(this.tharinduToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 108);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1505, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = global::InventoryManagementSystem.Properties.Resources.icons8_eye_filled_20;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 24);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1505, 966);
            this.ContextMenuStrip = this.contextMenuBaseForm;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlBaseNavPanel);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePic)).EndInit();
            this.pnlBaseNavPanel.ResumeLayout(false);
            this.contextMenuBaseForm.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private OvalPictureBox userProfilePic;
        private System.Windows.Forms.Label lblJobRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlBaseNavPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuBaseForm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel pnlSelected;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem tharinduToolStripMenuItem;
    }
}