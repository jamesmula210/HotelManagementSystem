namespace WindowsFormsApplication4
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdditems = new System.Windows.Forms.Button();
            this.btnRemoveitems = new System.Windows.Forms.Button();
            this.btnUpdateitems = new System.Windows.Forms.Button();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            //this.UHola = new WindowsFormsApplication4.UserControls.UHola();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAdditems);
            this.panel1.Controls.Add(this.btnRemoveitems);
            this.panel1.Controls.Add(this.btnUpdateitems);
            this.panel1.Controls.Add(this.btnPlaceorder);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 102);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.LinkColor = System.Drawing.Color.Yellow;
            this.btnLogout.Location = new System.Drawing.Point(862, 73);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 21);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdditems
            // 
            this.btnAdditems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdditems.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdditems.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditems.Location = new System.Drawing.Point(266, 58);
            this.btnAdditems.Name = "btnAdditems";
            this.btnAdditems.Size = new System.Drawing.Size(125, 36);
            this.btnAdditems.TabIndex = 3;
            this.btnAdditems.Text = "Add Items";
            this.btnAdditems.UseVisualStyleBackColor = false;
            // 
            // btnRemoveitems
            // 
            this.btnRemoveitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemoveitems.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveitems.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveitems.Location = new System.Drawing.Point(595, 58);
            this.btnRemoveitems.Name = "btnRemoveitems";
            this.btnRemoveitems.Size = new System.Drawing.Size(125, 36);
            this.btnRemoveitems.TabIndex = 2;
            this.btnRemoveitems.Text = "Remove Items";
            this.btnRemoveitems.UseVisualStyleBackColor = false;
            // 
            // btnUpdateitems
            // 
            this.btnUpdateitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateitems.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateitems.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateitems.Location = new System.Drawing.Point(430, 58);
            this.btnUpdateitems.Name = "btnUpdateitems";
            this.btnUpdateitems.Size = new System.Drawing.Size(125, 36);
            this.btnUpdateitems.TabIndex = 1;
            this.btnUpdateitems.Text = "Update Items";
            this.btnUpdateitems.UseVisualStyleBackColor = false;
            this.btnUpdateitems.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlaceorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaceorder.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceorder.Location = new System.Drawing.Point(104, 58);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(125, 36);
            this.btnPlaceorder.TabIndex = 0;
            this.btnPlaceorder.Text = "Place Your Order";
            this.btnPlaceorder.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.uWelcome2);
            this.panel2.Location = new System.Drawing.Point(22, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 485);
            this.panel2.TabIndex = 1;
            // 
            // uWelcome2
            // 
            this.uWelcome2.BackColor = System.Drawing.Color.Green;
            this.uWelcome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uWelcome2.BackgroundImage")));
            this.uWelcome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uWelcome2.Location = new System.Drawing.Point(645, 131);
            this.uWelcome2.Name = "uWelcome2";
            this.uWelcome2.Size = new System.Drawing.Size(8, 8);
            this.uWelcome2.TabIndex = 1;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Board";
            this.Text = "Board";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdditems;
        private System.Windows.Forms.Button btnRemoveitems;
        private System.Windows.Forms.Button btnUpdateitems;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel btnLogout;
        private WindowsFormsApplication4.UserControls.UWelcome uWelcome2;
    }
}