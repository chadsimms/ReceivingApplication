namespace CS493_Simms_ReceivingApplication.Presentation
{
    partial class DeliveryCheckForm
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
            this.dataTableView = new System.Windows.Forms.DataGridView();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pieceLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
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
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "label2";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(277, 359);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 16);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "label1";
            // 
            // dataTableView
            // 
            this.dataTableView.AllowUserToAddRows = false;
            this.dataTableView.AllowUserToDeleteRows = false;
            this.dataTableView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.UPC,
            this.product,
            this.size,
            this.perCase,
            this.itemCost});
            this.dataTableView.Location = new System.Drawing.Point(7, 7);
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.RowHeadersVisible = false;
            this.dataTableView.RowHeadersWidth = 20;
            this.dataTableView.Size = new System.Drawing.Size(351, 225);
            this.dataTableView.TabIndex = 8;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Qty";
            this.Amount.Name = "Amount";
            this.Amount.Width = 35;
            // 
            // UPC
            // 
            this.UPC.DataPropertyName = "UPC";
            this.UPC.HeaderText = "UPC";
            this.UPC.Name = "UPC";
            this.UPC.Width = 91;
            // 
            // product
            // 
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.Width = 82;
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.Width = 50;
            // 
            // perCase
            // 
            this.perCase.DataPropertyName = "perCase";
            this.perCase.HeaderText = "Per Case";
            this.perCase.Name = "perCase";
            this.perCase.Width = 40;
            // 
            // itemCost
            // 
            this.itemCost.DataPropertyName = "cost";
            this.itemCost.HeaderText = "Cost";
            this.itemCost.Name = "itemCost";
            this.itemCost.Width = 50;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(277, 297);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 42);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "&Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(277, 246);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 42);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "&Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Pieces:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Calculated Cost:";
            // 
            // pieceLbl
            // 
            this.pieceLbl.AutoSize = true;
            this.pieceLbl.Location = new System.Drawing.Point(127, 252);
            this.pieceLbl.Name = "pieceLbl";
            this.pieceLbl.Size = new System.Drawing.Size(13, 13);
            this.pieceLbl.TabIndex = 14;
            this.pieceLbl.Text = "0";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(127, 285);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(28, 13);
            this.costLbl.TabIndex = 15;
            this.costLbl.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vendor Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(127, 314);
            this.costTextBox.MaxLength = 8;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(84, 20);
            this.costTextBox.TabIndex = 17;
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // DeliveryCheckForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 381);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.pieceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.dataTableView);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Name = "DeliveryCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Check Form";
            this.Load += new System.EventHandler(this.DeliveryCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DataGridView dataTableView;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pieceLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCost;
    }
}