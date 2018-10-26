namespace booking
{
    partial class Home
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
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.checkIN_button = new System.Windows.Forms.Button();
            this.checkOut_button = new System.Windows.Forms.Button();
            this.room_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchCUST_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.Location = new System.Drawing.Point(44, 50);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(178, 23);
            this.addCustomer_button.TabIndex = 0;
            this.addCustomer_button.Text = "ADD CUSTOMER";
            this.addCustomer_button.UseVisualStyleBackColor = true;
            this.addCustomer_button.Click += new System.EventHandler(this.addCustomer_button_Click);
            // 
            // checkIN_button
            // 
            this.checkIN_button.Location = new System.Drawing.Point(44, 91);
            this.checkIN_button.Name = "checkIN_button";
            this.checkIN_button.Size = new System.Drawing.Size(178, 23);
            this.checkIN_button.TabIndex = 1;
            this.checkIN_button.Text = "CHECK IN";
            this.checkIN_button.UseVisualStyleBackColor = true;
            this.checkIN_button.Click += new System.EventHandler(this.checkIN_button_Click);
            // 
            // checkOut_button
            // 
            this.checkOut_button.Location = new System.Drawing.Point(44, 131);
            this.checkOut_button.Name = "checkOut_button";
            this.checkOut_button.Size = new System.Drawing.Size(178, 23);
            this.checkOut_button.TabIndex = 2;
            this.checkOut_button.Text = "CHECK OUT";
            this.checkOut_button.UseVisualStyleBackColor = true;
            this.checkOut_button.Click += new System.EventHandler(this.checkOut_button_Click);
            // 
            // room_button
            // 
            this.room_button.Location = new System.Drawing.Point(44, 181);
            this.room_button.Name = "room_button";
            this.room_button.Size = new System.Drawing.Size(178, 23);
            this.room_button.TabIndex = 3;
            this.room_button.Text = "ROOM STATUS";
            this.room_button.UseVisualStyleBackColor = true;
            this.room_button.Click += new System.EventHandler(this.room_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchCUST_button
            // 
            this.searchCUST_button.Location = new System.Drawing.Point(44, 13);
            this.searchCUST_button.Name = "searchCUST_button";
            this.searchCUST_button.Size = new System.Drawing.Size(178, 23);
            this.searchCUST_button.TabIndex = 5;
            this.searchCUST_button.Text = "SEARCH CUSTOMER";
            this.searchCUST_button.UseVisualStyleBackColor = true;
            this.searchCUST_button.Click += new System.EventHandler(this.searchCUST_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchCUST_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.room_button);
            this.Controls.Add(this.checkOut_button);
            this.Controls.Add(this.checkIN_button);
            this.Controls.Add(this.addCustomer_button);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCustomer_button;
        private System.Windows.Forms.Button checkIN_button;
        private System.Windows.Forms.Button checkOut_button;
        private System.Windows.Forms.Button room_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchCUST_button;
    }
}