namespace CS493_Simms_ReceivingApplication.Presentation
{
    partial class ManualDelivery
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.upcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.suspendButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deliveryTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.productLbl = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.ohLbl = new System.Windows.Forms.Label();
            this.weekLbl = new System.Windows.Forms.Label();
            this.monthLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deliveredLbl = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.invoiceTextBox = new System.Windows.Forms.TextBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(12, 359);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 16);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "label2";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(277, 359);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 16);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vendor:";
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLabel.Location = new System.Drawing.Point(79, 17);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(94, 15);
            this.vendorLabel.TabIndex = 5;
            this.vendorLabel.Text = "Vendor Name";
            // 
            // upcTextBox
            // 
            this.upcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcTextBox.Location = new System.Drawing.Point(93, 82);
            this.upcTextBox.MaxLength = 12;
            this.upcTextBox.Name = "upcTextBox";
            this.upcTextBox.Size = new System.Drawing.Size(164, 22);
            this.upcTextBox.TabIndex = 1;
            this.upcTextBox.TextChanged += new System.EventHandler(this.upcTextBox_TextChanged);
            this.upcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.upcTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "UPC:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(271, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 42);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // suspendButton
            // 
            this.suspendButton.Location = new System.Drawing.Point(271, 140);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(75, 42);
            this.suspendButton.TabIndex = 9;
            this.suspendButton.Text = "&Suspend Order";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(271, 236);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 42);
            this.doneButton.TabIndex = 10;
            this.doneButton.Text = "&Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "On Hand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sales History";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "This Week:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "This Month:";
            // 
            // deliveryTextBox
            // 
            this.deliveryTextBox.Location = new System.Drawing.Point(157, 326);
            this.deliveryTextBox.MaxLength = 4;
            this.deliveryTextBox.Name = "deliveryTextBox";
            this.deliveryTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryTextBox.TabIndex = 2;
            this.deliveryTextBox.TextChanged += new System.EventHandler(this.deliveryTextBox_TextChanged);
            this.deliveryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deliveryTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Delivery Amount:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(271, 306);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 42);
            this.enterButton.TabIndex = 19;
            this.enterButton.Text = "&Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLbl.Location = new System.Drawing.Point(90, 114);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(42, 15);
            this.productLbl.TabIndex = 20;
            this.productLbl.Text = "NAME";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Location = new System.Drawing.Point(90, 138);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(31, 13);
            this.sizeLbl.TabIndex = 21;
            this.sizeLbl.Text = "SIZE";
            // 
            // ohLbl
            // 
            this.ohLbl.AutoSize = true;
            this.ohLbl.Location = new System.Drawing.Point(90, 182);
            this.ohLbl.Name = "ohLbl";
            this.ohLbl.Size = new System.Drawing.Size(13, 13);
            this.ohLbl.TabIndex = 22;
            this.ohLbl.Text = "0";
            // 
            // weekLbl
            // 
            this.weekLbl.AutoSize = true;
            this.weekLbl.Location = new System.Drawing.Point(117, 224);
            this.weekLbl.Name = "weekLbl";
            this.weekLbl.Size = new System.Drawing.Size(72, 13);
            this.weekLbl.TabIndex = 23;
            this.weekLbl.Text = "Weekly Sales";
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Location = new System.Drawing.Point(117, 243);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(73, 13);
            this.monthLbl.TabIndex = 24;
            this.monthLbl.Text = "Monthly Sales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Current Delivered Amount:";
            // 
            // deliveredLbl
            // 
            this.deliveredLbl.AutoSize = true;
            this.deliveredLbl.Location = new System.Drawing.Point(190, 304);
            this.deliveredLbl.Name = "deliveredLbl";
            this.deliveredLbl.Size = new System.Drawing.Size(13, 13);
            this.deliveredLbl.TabIndex = 26;
            this.deliveredLbl.Text = "0";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.clearButton.Location = new System.Drawing.Point(271, 188);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 42);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear Item";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Status:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(90, 284);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(50, 13);
            this.statusLbl.TabIndex = 29;
            this.statusLbl.Text = "STATUS";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(90, 160);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(28, 13);
            this.costLbl.TabIndex = 31;
            this.costLbl.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Invoice Number:";
            // 
            // invoiceTextBox
            // 
            this.invoiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTextBox.Location = new System.Drawing.Point(136, 48);
            this.invoiceTextBox.MaxLength = 10;
            this.invoiceTextBox.Name = "invoiceTextBox";
            this.invoiceTextBox.Size = new System.Drawing.Size(121, 21);
            this.invoiceTextBox.TabIndex = 0;
            this.invoiceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invoiceTextBox_KeyPress);
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(117, 262);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(65, 13);
            this.yearLbl.TabIndex = 35;
            this.yearLbl.Text = "Yearly Sales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "This Year:";
            // 
            // ManualDelivery
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 381);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.invoiceTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deliveredLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.weekLbl);
            this.Controls.Add(this.ohLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deliveryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.suspendButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upcTextBox);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Name = "ManualDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor: Manual Delivery";
            this.Load += new System.EventHandler(this.ManualDelivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.TextBox upcTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox deliveryTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label ohLbl;
        private System.Windows.Forms.Label weekLbl;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label deliveredLbl;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox invoiceTextBox;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label label15;
    }
}