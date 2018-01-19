namespace QuestradeAPI.Net.TestClient
{
    partial class ReplaceOrderDetailsDlg
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
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_chkIsLimitOffsetInDollar = new System.Windows.Forms.CheckBox();
            this.m_dtpGtdDate = new System.Windows.Forms.DateTimePicker();
            this.m_lblGtdDate = new System.Windows.Forms.Label();
            this.m_cmbTimeInForce = new System.Windows.Forms.ComboBox();
            this.m_lblTif = new System.Windows.Forms.Label();
            this.m_cmbOrderType = new System.Windows.Forms.ComboBox();
            this.m_lblOrderType = new System.Windows.Forms.Label();
            this.m_chkIsAnonymous = new System.Windows.Forms.CheckBox();
            this.m_chkIsAllOrNone = new System.Windows.Forms.CheckBox();
            this.m_txtStopPrice = new System.Windows.Forms.TextBox();
            this.m_lblStopPrice = new System.Windows.Forms.Label();
            this.m_txtLimitPrice = new System.Windows.Forms.TextBox();
            this.m_lblLimitPrice = new System.Windows.Forms.Label();
            this.m_txtMinSize = new System.Windows.Forms.TextBox();
            this.m_lblMinSize = new System.Windows.Forms.Label();
            this.m_txtIcebergSize = new System.Windows.Forms.TextBox();
            this.m_lblIcebergSize = new System.Windows.Forms.Label();
            this.m_txtSize = new System.Windows.Forms.TextBox();
            this.m_lblSize = new System.Windows.Forms.Label();
            this.m_txtOrderId = new System.Windows.Forms.TextBox();
            this.m_lblOrderId = new System.Windows.Forms.Label();
            this.m_chkAsync = new System.Windows.Forms.CheckBox();
            this.m_btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(105, 444);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 89;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // m_btnOK
            // 
            this.m_btnOK.Location = new System.Drawing.Point(14, 444);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 88;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.m_btnOK_Click);
            // 
            // m_chkIsLimitOffsetInDollar
            // 
            this.m_chkIsLimitOffsetInDollar.AutoSize = true;
            this.m_chkIsLimitOffsetInDollar.Location = new System.Drawing.Point(12, 409);
            this.m_chkIsLimitOffsetInDollar.Name = "m_chkIsLimitOffsetInDollar";
            this.m_chkIsLimitOffsetInDollar.Size = new System.Drawing.Size(131, 17);
            this.m_chkIsLimitOffsetInDollar.TabIndex = 87;
            this.m_chkIsLimitOffsetInDollar.Text = "Is Limit Offset In Dollar";
            this.m_chkIsLimitOffsetInDollar.UseVisualStyleBackColor = true;
            // 
            // m_dtpGtdDate
            // 
            this.m_dtpGtdDate.Location = new System.Drawing.Point(108, 363);
            this.m_dtpGtdDate.Name = "m_dtpGtdDate";
            this.m_dtpGtdDate.Size = new System.Drawing.Size(164, 20);
            this.m_dtpGtdDate.TabIndex = 86;
            this.m_dtpGtdDate.ValueChanged += new System.EventHandler(this.m_dtpGtdDate_ValueChanged);
            // 
            // m_lblGtdDate
            // 
            this.m_lblGtdDate.AutoSize = true;
            this.m_lblGtdDate.Location = new System.Drawing.Point(12, 369);
            this.m_lblGtdDate.Name = "m_lblGtdDate";
            this.m_lblGtdDate.Size = new System.Drawing.Size(53, 13);
            this.m_lblGtdDate.TabIndex = 85;
            this.m_lblGtdDate.Text = "Gtd Date:";
            // 
            // m_cmbTimeInForce
            // 
            this.m_cmbTimeInForce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbTimeInForce.FormattingEnabled = true;
            this.m_cmbTimeInForce.Location = new System.Drawing.Point(108, 329);
            this.m_cmbTimeInForce.Name = "m_cmbTimeInForce";
            this.m_cmbTimeInForce.Size = new System.Drawing.Size(164, 21);
            this.m_cmbTimeInForce.TabIndex = 84;
            // 
            // m_lblTif
            // 
            this.m_lblTif.AutoSize = true;
            this.m_lblTif.Location = new System.Drawing.Point(12, 332);
            this.m_lblTif.Name = "m_lblTif";
            this.m_lblTif.Size = new System.Drawing.Size(74, 13);
            this.m_lblTif.TabIndex = 83;
            this.m_lblTif.Text = "Time in Force:";
            // 
            // m_cmbOrderType
            // 
            this.m_cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbOrderType.FormattingEnabled = true;
            this.m_cmbOrderType.Location = new System.Drawing.Point(108, 292);
            this.m_cmbOrderType.Name = "m_cmbOrderType";
            this.m_cmbOrderType.Size = new System.Drawing.Size(164, 21);
            this.m_cmbOrderType.TabIndex = 82;
            // 
            // m_lblOrderType
            // 
            this.m_lblOrderType.AutoSize = true;
            this.m_lblOrderType.Location = new System.Drawing.Point(12, 295);
            this.m_lblOrderType.Name = "m_lblOrderType";
            this.m_lblOrderType.Size = new System.Drawing.Size(63, 13);
            this.m_lblOrderType.TabIndex = 81;
            this.m_lblOrderType.Text = "Order Type:";
            // 
            // m_chkIsAnonymous
            // 
            this.m_chkIsAnonymous.AutoSize = true;
            this.m_chkIsAnonymous.Location = new System.Drawing.Point(180, 254);
            this.m_chkIsAnonymous.Name = "m_chkIsAnonymous";
            this.m_chkIsAnonymous.Size = new System.Drawing.Size(92, 17);
            this.m_chkIsAnonymous.TabIndex = 80;
            this.m_chkIsAnonymous.Text = "Is Anonymous";
            this.m_chkIsAnonymous.UseVisualStyleBackColor = true;
            // 
            // m_chkIsAllOrNone
            // 
            this.m_chkIsAllOrNone.AutoSize = true;
            this.m_chkIsAllOrNone.Location = new System.Drawing.Point(12, 254);
            this.m_chkIsAllOrNone.Name = "m_chkIsAllOrNone";
            this.m_chkIsAllOrNone.Size = new System.Drawing.Size(91, 17);
            this.m_chkIsAllOrNone.TabIndex = 79;
            this.m_chkIsAllOrNone.Text = "Is All Or None";
            this.m_chkIsAllOrNone.UseVisualStyleBackColor = true;
            // 
            // m_txtStopPrice
            // 
            this.m_txtStopPrice.Location = new System.Drawing.Point(108, 214);
            this.m_txtStopPrice.Name = "m_txtStopPrice";
            this.m_txtStopPrice.Size = new System.Drawing.Size(164, 20);
            this.m_txtStopPrice.TabIndex = 78;
            // 
            // m_lblStopPrice
            // 
            this.m_lblStopPrice.AutoSize = true;
            this.m_lblStopPrice.Location = new System.Drawing.Point(12, 217);
            this.m_lblStopPrice.Name = "m_lblStopPrice";
            this.m_lblStopPrice.Size = new System.Drawing.Size(59, 13);
            this.m_lblStopPrice.TabIndex = 77;
            this.m_lblStopPrice.Text = "Stop Price:";
            // 
            // m_txtLimitPrice
            // 
            this.m_txtLimitPrice.Location = new System.Drawing.Point(108, 177);
            this.m_txtLimitPrice.Name = "m_txtLimitPrice";
            this.m_txtLimitPrice.Size = new System.Drawing.Size(164, 20);
            this.m_txtLimitPrice.TabIndex = 76;
            // 
            // m_lblLimitPrice
            // 
            this.m_lblLimitPrice.AutoSize = true;
            this.m_lblLimitPrice.Location = new System.Drawing.Point(12, 180);
            this.m_lblLimitPrice.Name = "m_lblLimitPrice";
            this.m_lblLimitPrice.Size = new System.Drawing.Size(58, 13);
            this.m_lblLimitPrice.TabIndex = 75;
            this.m_lblLimitPrice.Text = "Limit Price:";
            // 
            // m_txtMinSize
            // 
            this.m_txtMinSize.Location = new System.Drawing.Point(108, 140);
            this.m_txtMinSize.Name = "m_txtMinSize";
            this.m_txtMinSize.Size = new System.Drawing.Size(164, 20);
            this.m_txtMinSize.TabIndex = 74;
            // 
            // m_lblMinSize
            // 
            this.m_lblMinSize.AutoSize = true;
            this.m_lblMinSize.Location = new System.Drawing.Point(12, 143);
            this.m_lblMinSize.Name = "m_lblMinSize";
            this.m_lblMinSize.Size = new System.Drawing.Size(50, 13);
            this.m_lblMinSize.TabIndex = 73;
            this.m_lblMinSize.Text = "Min Size:";
            // 
            // m_txtIcebergSize
            // 
            this.m_txtIcebergSize.Location = new System.Drawing.Point(108, 103);
            this.m_txtIcebergSize.Name = "m_txtIcebergSize";
            this.m_txtIcebergSize.Size = new System.Drawing.Size(164, 20);
            this.m_txtIcebergSize.TabIndex = 72;
            // 
            // m_lblIcebergSize
            // 
            this.m_lblIcebergSize.AutoSize = true;
            this.m_lblIcebergSize.Location = new System.Drawing.Point(12, 106);
            this.m_lblIcebergSize.Name = "m_lblIcebergSize";
            this.m_lblIcebergSize.Size = new System.Drawing.Size(69, 13);
            this.m_lblIcebergSize.TabIndex = 71;
            this.m_lblIcebergSize.Text = "Iceberg Size:";
            // 
            // m_txtSize
            // 
            this.m_txtSize.Location = new System.Drawing.Point(108, 66);
            this.m_txtSize.Name = "m_txtSize";
            this.m_txtSize.Size = new System.Drawing.Size(164, 20);
            this.m_txtSize.TabIndex = 70;
            // 
            // m_lblSize
            // 
            this.m_lblSize.AutoSize = true;
            this.m_lblSize.Location = new System.Drawing.Point(12, 69);
            this.m_lblSize.Name = "m_lblSize";
            this.m_lblSize.Size = new System.Drawing.Size(30, 13);
            this.m_lblSize.TabIndex = 69;
            this.m_lblSize.Text = "Size:";
            // 
            // m_txtOrderId
            // 
            this.m_txtOrderId.Location = new System.Drawing.Point(108, 29);
            this.m_txtOrderId.Name = "m_txtOrderId";
            this.m_txtOrderId.Size = new System.Drawing.Size(164, 20);
            this.m_txtOrderId.TabIndex = 68;
            // 
            // m_lblOrderId
            // 
            this.m_lblOrderId.AutoSize = true;
            this.m_lblOrderId.Location = new System.Drawing.Point(12, 32);
            this.m_lblOrderId.Name = "m_lblOrderId";
            this.m_lblOrderId.Size = new System.Drawing.Size(50, 13);
            this.m_lblOrderId.TabIndex = 67;
            this.m_lblOrderId.Text = "Order ID:";
            // 
            // m_chkAsync
            // 
            this.m_chkAsync.AutoSize = true;
            this.m_chkAsync.Location = new System.Drawing.Point(12, 12);
            this.m_chkAsync.Name = "m_chkAsync";
            this.m_chkAsync.Size = new System.Drawing.Size(55, 17);
            this.m_chkAsync.TabIndex = 64;
            this.m_chkAsync.Text = "Async";
            this.m_chkAsync.UseVisualStyleBackColor = true;
            // 
            // m_btnPreview
            // 
            this.m_btnPreview.Location = new System.Drawing.Point(196, 444);
            this.m_btnPreview.Name = "m_btnPreview";
            this.m_btnPreview.Size = new System.Drawing.Size(75, 23);
            this.m_btnPreview.TabIndex = 90;
            this.m_btnPreview.Text = "Preview";
            this.m_btnPreview.UseVisualStyleBackColor = true;
            this.m_btnPreview.Click += new System.EventHandler(this.m_btnPreview_Click);
            // 
            // ReplaceOrderDetailsDlg
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 479);
            this.ControlBox = false;
            this.Controls.Add(this.m_btnPreview);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_chkIsLimitOffsetInDollar);
            this.Controls.Add(this.m_dtpGtdDate);
            this.Controls.Add(this.m_lblGtdDate);
            this.Controls.Add(this.m_cmbTimeInForce);
            this.Controls.Add(this.m_lblTif);
            this.Controls.Add(this.m_cmbOrderType);
            this.Controls.Add(this.m_lblOrderType);
            this.Controls.Add(this.m_chkIsAnonymous);
            this.Controls.Add(this.m_chkIsAllOrNone);
            this.Controls.Add(this.m_txtStopPrice);
            this.Controls.Add(this.m_lblStopPrice);
            this.Controls.Add(this.m_txtLimitPrice);
            this.Controls.Add(this.m_lblLimitPrice);
            this.Controls.Add(this.m_txtMinSize);
            this.Controls.Add(this.m_lblMinSize);
            this.Controls.Add(this.m_txtIcebergSize);
            this.Controls.Add(this.m_lblIcebergSize);
            this.Controls.Add(this.m_txtSize);
            this.Controls.Add(this.m_lblSize);
            this.Controls.Add(this.m_txtOrderId);
            this.Controls.Add(this.m_lblOrderId);
            this.Controls.Add(this.m_chkAsync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReplaceOrderDetailsDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.CheckBox m_chkIsLimitOffsetInDollar;
        private System.Windows.Forms.DateTimePicker m_dtpGtdDate;
        private System.Windows.Forms.Label m_lblGtdDate;
        private System.Windows.Forms.ComboBox m_cmbTimeInForce;
        private System.Windows.Forms.Label m_lblTif;
        private System.Windows.Forms.ComboBox m_cmbOrderType;
        private System.Windows.Forms.Label m_lblOrderType;
        private System.Windows.Forms.CheckBox m_chkIsAnonymous;
        private System.Windows.Forms.CheckBox m_chkIsAllOrNone;
        private System.Windows.Forms.TextBox m_txtStopPrice;
        private System.Windows.Forms.Label m_lblStopPrice;
        private System.Windows.Forms.TextBox m_txtLimitPrice;
        private System.Windows.Forms.Label m_lblLimitPrice;
        private System.Windows.Forms.TextBox m_txtMinSize;
        private System.Windows.Forms.Label m_lblMinSize;
        private System.Windows.Forms.TextBox m_txtIcebergSize;
        private System.Windows.Forms.Label m_lblIcebergSize;
        private System.Windows.Forms.TextBox m_txtSize;
        private System.Windows.Forms.Label m_lblSize;
        private System.Windows.Forms.TextBox m_txtOrderId;
        private System.Windows.Forms.Label m_lblOrderId;
        private System.Windows.Forms.CheckBox m_chkAsync;
        private System.Windows.Forms.Button m_btnPreview;
    }
}