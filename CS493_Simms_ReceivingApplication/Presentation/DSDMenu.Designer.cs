namespace CS493_Simms_ReceivingApplication
{
    partial class DSDMenu
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
            this.checkinButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.receivedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.switchButton = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(117, 58);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(130, 62);
            this.checkinButton.TabIndex = 0;
            this.checkinButton.Text = "Vendor &Check-In";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(117, 126);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(130, 62);
            this.listButton.TabIndex = 1;
            this.listButton.Text = "Vendor &List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // receivedButton
            // 
            this.receivedButton.Location = new System.Drawing.Point(117, 194);
            this.receivedButton.Name = "receivedButton";
            this.receivedButton.Size = new System.Drawing.Size(130, 62);
            this.receivedButton.TabIndex = 2;
            this.receivedButton.Text = "Vendor &Orders Received";
            this.receivedButton.UseVisualStyleBackColor = true;
            this.receivedButton.Click += new System.EventHandler(this.receivedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "DSD Menu";
            // 
            // switchButton
            // 
            this.switchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.switchButton.Location = new System.Drawing.Point(117, 285);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(130, 62);
            this.switchButton.TabIndex = 4;
            this.switchButton.Text = "Switch &User";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(277, 359);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(39, 16);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(12, 359);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 16);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DSDMenu
            // 
            this.AcceptButton = this.checkinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.switchButton;
            this.ClientSize = new System.Drawing.Size(364, 381);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receivedButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.checkinButton);
            this.KeyPreview = true;
            this.Name = "DSDMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSD Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button receivedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
    }
}