namespace CS493_Simms_ReceivingApplication.Presentation
{
    partial class VendorMenu
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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.vendorLbl = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.correctBtn = new System.Windows.Forms.Button();
            this.retriveBtn = new System.Windows.Forms.Button();
            this.ediButton = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.deliveryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(277, 359);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(12, 359);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Vendor ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Vendor:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(15, 152);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(77, 16);
            this.idLbl.TabIndex = 33;
            this.idLbl.Text = "Vendor ID";
            // 
            // vendorLbl
            // 
            this.vendorLbl.AutoSize = true;
            this.vendorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLbl.Location = new System.Drawing.Point(15, 102);
            this.vendorLbl.Name = "vendorLbl";
            this.vendorLbl.Size = new System.Drawing.Size(103, 16);
            this.vendorLbl.TabIndex = 32;
            this.vendorLbl.Text = "Vendor Name";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(206, 253);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(143, 34);
            this.printBtn.TabIndex = 30;
            this.printBtn.Text = "Print an Invoice";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(206, 293);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 34);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // correctBtn
            // 
            this.correctBtn.Location = new System.Drawing.Point(206, 213);
            this.correctBtn.Name = "correctBtn";
            this.correctBtn.Size = new System.Drawing.Size(143, 34);
            this.correctBtn.TabIndex = 29;
            this.correctBtn.Text = "Correct an Invoice";
            this.correctBtn.UseVisualStyleBackColor = true;
            this.correctBtn.Click += new System.EventHandler(this.correctBtn_Click);
            // 
            // retriveBtn
            // 
            this.retriveBtn.Location = new System.Drawing.Point(206, 173);
            this.retriveBtn.Name = "retriveBtn";
            this.retriveBtn.Size = new System.Drawing.Size(143, 34);
            this.retriveBtn.TabIndex = 28;
            this.retriveBtn.Text = "Retrieve an Invoice";
            this.retriveBtn.UseVisualStyleBackColor = true;
            this.retriveBtn.Click += new System.EventHandler(this.retriveBtn_Click);
            // 
            // ediButton
            // 
            this.ediButton.Location = new System.Drawing.Point(206, 133);
            this.ediButton.Name = "ediButton";
            this.ediButton.Size = new System.Drawing.Size(143, 34);
            this.ediButton.TabIndex = 27;
            this.ediButton.Text = "EDI Delivery";
            this.ediButton.UseVisualStyleBackColor = true;
            this.ediButton.Click += new System.EventHandler(this.ediButton_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(206, 93);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(143, 34);
            this.returnBtn.TabIndex = 26;
            this.returnBtn.Text = "Manual Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // deliveryBtn
            // 
            this.deliveryBtn.Location = new System.Drawing.Point(206, 53);
            this.deliveryBtn.Name = "deliveryBtn";
            this.deliveryBtn.Size = new System.Drawing.Size(143, 34);
            this.deliveryBtn.TabIndex = 25;
            this.deliveryBtn.Text = "Manual Delivery";
            this.deliveryBtn.UseVisualStyleBackColor = true;
            this.deliveryBtn.Click += new System.EventHandler(this.deliveryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vendor Menu";
            // 
            // VendorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.vendorLbl);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.correctBtn);
            this.Controls.Add(this.retriveBtn);
            this.Controls.Add(this.ediButton);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.deliveryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Name = "VendorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Menu";
            this.Load += new System.EventHandler(this.VendorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label vendorLbl;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button correctBtn;
        private System.Windows.Forms.Button retriveBtn;
        private System.Windows.Forms.Button ediButton;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button deliveryBtn;
        private System.Windows.Forms.Label label1;
    }
}