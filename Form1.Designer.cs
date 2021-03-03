namespace ADO_Basics
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUsersDrop = new System.Windows.Forms.Button();
            this.buttonUsersCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Products_Drop = new System.Windows.Forms.Button();
            this.button_Products_create = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Sales_Drop = new System.Windows.Forms.Button();
            this.button_Sales_Create = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUserInsert = new System.Windows.Forms.Button();
            this.buttonUserSelect = new System.Windows.Forms.Button();
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.buttonProductUpdate = new System.Windows.Forms.Button();
            this.buttonProductSelect = new System.Windows.Forms.Button();
            this.buttonProductInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUsersDrop);
            this.groupBox1.Controls.Add(this.buttonUsersCreate);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table [Users]";
            // 
            // buttonUsersDrop
            // 
            this.buttonUsersDrop.Location = new System.Drawing.Point(34, 125);
            this.buttonUsersDrop.Name = "buttonUsersDrop";
            this.buttonUsersDrop.Size = new System.Drawing.Size(75, 23);
            this.buttonUsersDrop.TabIndex = 1;
            this.buttonUsersDrop.Text = "Drop";
            this.buttonUsersDrop.UseVisualStyleBackColor = true;
            this.buttonUsersDrop.Click += new System.EventHandler(this.buttonUsersDrop_Click);
            // 
            // buttonUsersCreate
            // 
            this.buttonUsersCreate.Location = new System.Drawing.Point(34, 39);
            this.buttonUsersCreate.Name = "buttonUsersCreate";
            this.buttonUsersCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonUsersCreate.TabIndex = 0;
            this.buttonUsersCreate.Text = "Create";
            this.buttonUsersCreate.UseVisualStyleBackColor = true;
            this.buttonUsersCreate.Click += new System.EventHandler(this.buttonUsersCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(113, 36);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(0, 13);
            this.labelConnectionStatus.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Products_Drop);
            this.groupBox2.Controls.Add(this.button_Products_create);
            this.groupBox2.Location = new System.Drawing.Point(179, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table [Products]";
            // 
            // button_Products_Drop
            // 
            this.button_Products_Drop.Location = new System.Drawing.Point(33, 125);
            this.button_Products_Drop.Name = "button_Products_Drop";
            this.button_Products_Drop.Size = new System.Drawing.Size(75, 23);
            this.button_Products_Drop.TabIndex = 1;
            this.button_Products_Drop.Text = "Drop";
            this.button_Products_Drop.UseVisualStyleBackColor = true;
            this.button_Products_Drop.Click += new System.EventHandler(this.button_Products_Drop_Click);
            // 
            // button_Products_create
            // 
            this.button_Products_create.Location = new System.Drawing.Point(33, 39);
            this.button_Products_create.Name = "button_Products_create";
            this.button_Products_create.Size = new System.Drawing.Size(75, 23);
            this.button_Products_create.TabIndex = 0;
            this.button_Products_create.Text = "Create";
            this.button_Products_create.UseVisualStyleBackColor = true;
            this.button_Products_create.Click += new System.EventHandler(this.button_Products_create_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Sales_Drop);
            this.groupBox3.Controls.Add(this.button_Sales_Create);
            this.groupBox3.Location = new System.Drawing.Point(342, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 179);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table [Sales]";
            // 
            // button_Sales_Drop
            // 
            this.button_Sales_Drop.Location = new System.Drawing.Point(31, 125);
            this.button_Sales_Drop.Name = "button_Sales_Drop";
            this.button_Sales_Drop.Size = new System.Drawing.Size(75, 23);
            this.button_Sales_Drop.TabIndex = 3;
            this.button_Sales_Drop.Text = "Drop";
            this.button_Sales_Drop.UseVisualStyleBackColor = true;
            this.button_Sales_Drop.Click += new System.EventHandler(this.button_Sales_Drop_Click);
            // 
            // button_Sales_Create
            // 
            this.button_Sales_Create.Location = new System.Drawing.Point(31, 39);
            this.button_Sales_Create.Name = "button_Sales_Create";
            this.button_Sales_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Sales_Create.TabIndex = 2;
            this.button_Sales_Create.Text = "Create";
            this.button_Sales_Create.UseVisualStyleBackColor = true;
            this.button_Sales_Create.Click += new System.EventHandler(this.button_Sales_Create_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectToolStripMenuItem.Text = "Connection";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 3);
            this.label2.TabIndex = 5;
            // 
            // buttonUserInsert
            // 
            this.buttonUserInsert.Location = new System.Drawing.Point(34, 19);
            this.buttonUserInsert.Name = "buttonUserInsert";
            this.buttonUserInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonUserInsert.TabIndex = 6;
            this.buttonUserInsert.Text = "Insert";
            this.buttonUserInsert.UseVisualStyleBackColor = true;
            this.buttonUserInsert.Click += new System.EventHandler(this.buttonUserInsert_Click);
            // 
            // buttonUserSelect
            // 
            this.buttonUserSelect.Location = new System.Drawing.Point(34, 48);
            this.buttonUserSelect.Name = "buttonUserSelect";
            this.buttonUserSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSelect.TabIndex = 7;
            this.buttonUserSelect.Text = "Select";
            this.buttonUserSelect.UseVisualStyleBackColor = true;
            this.buttonUserSelect.Click += new System.EventHandler(this.buttonUserSelect_Click);
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.Location = new System.Drawing.Point(34, 77);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUserUpdate.TabIndex = 8;
            this.buttonUserUpdate.Text = "Update";
            this.buttonUserUpdate.UseVisualStyleBackColor = true;
            this.buttonUserUpdate.Click += new System.EventHandler(this.buttonUserUpdate_Click);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(34, 107);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonUserDelete.TabIndex = 9;
            this.buttonUserDelete.Text = "Delete";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DDL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DML";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonUserInsert);
            this.groupBox4.Controls.Add(this.buttonUserSelect);
            this.groupBox4.Controls.Add(this.buttonUserUpdate);
            this.groupBox4.Controls.Add(this.buttonUserDelete);
            this.groupBox4.Location = new System.Drawing.Point(12, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 138);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Table [Users]";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonProductInsert);
            this.groupBox5.Controls.Add(this.buttonProductSelect);
            this.groupBox5.Controls.Add(this.buttonProductDelete);
            this.groupBox5.Controls.Add(this.buttonProductUpdate);
            this.groupBox5.Location = new System.Drawing.Point(179, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 138);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Table [Products]";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(342, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(148, 138);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.Location = new System.Drawing.Point(33, 107);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonProductDelete.TabIndex = 9;
            this.buttonProductDelete.Text = "Delete";
            this.buttonProductDelete.UseVisualStyleBackColor = true;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // buttonProductUpdate
            // 
            this.buttonProductUpdate.Location = new System.Drawing.Point(33, 77);
            this.buttonProductUpdate.Name = "buttonProductUpdate";
            this.buttonProductUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonProductUpdate.TabIndex = 8;
            this.buttonProductUpdate.Text = "Update";
            this.buttonProductUpdate.UseVisualStyleBackColor = true;
            this.buttonProductUpdate.Click += new System.EventHandler(this.buttonProductUpdate_Click);
            // 
            // buttonProductSelect
            // 
            this.buttonProductSelect.Location = new System.Drawing.Point(33, 48);
            this.buttonProductSelect.Name = "buttonProductSelect";
            this.buttonProductSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonProductSelect.TabIndex = 7;
            this.buttonProductSelect.Text = "Select";
            this.buttonProductSelect.UseVisualStyleBackColor = true;
            this.buttonProductSelect.Click += new System.EventHandler(this.buttonProductSelect_Click);
            // 
            // buttonProductInsert
            // 
            this.buttonProductInsert.Location = new System.Drawing.Point(33, 19);
            this.buttonProductInsert.Name = "buttonProductInsert";
            this.buttonProductInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonProductInsert.TabIndex = 6;
            this.buttonProductInsert.Text = "Insert";
            this.buttonProductInsert.UseVisualStyleBackColor = true;
            this.buttonProductInsert.Click += new System.EventHandler(this.buttonProductInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 461);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ADO Basics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUsersDrop;
        private System.Windows.Forms.Button buttonUsersCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Products_Drop;
        private System.Windows.Forms.Button button_Products_create;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Sales_Drop;
        private System.Windows.Forms.Button button_Sales_Create;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUserInsert;
        private System.Windows.Forms.Button buttonUserSelect;
        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonProductInsert;
        private System.Windows.Forms.Button buttonProductSelect;
        private System.Windows.Forms.Button buttonProductDelete;
        private System.Windows.Forms.Button buttonProductUpdate;
    }
}

