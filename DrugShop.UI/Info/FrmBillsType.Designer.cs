﻿namespace DrugShop.UI.Info
{
    partial class FrmBillsType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillsType));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.ckbActived = new System.Windows.Forms.CheckBox();
            this.ckbIsOut = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(260, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定（&S）";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(385, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消（&C）";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.txtRemark, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 171);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.Location = new System.Drawing.Point(94, 83);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(360, 85);
            this.txtRemark.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(94, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 35);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别编码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "备注信息：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point(94, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(360, 35);
            this.txtCode.TabIndex = 3;
            // 
            // ckbActived
            // 
            this.ckbActived.AutoSize = true;
            this.ckbActived.Checked = true;
            this.ckbActived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbActived.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbActived.Location = new System.Drawing.Point(139, 232);
            this.ckbActived.Name = "ckbActived";
            this.ckbActived.Size = new System.Drawing.Size(66, 23);
            this.ckbActived.TabIndex = 3;
            this.ckbActived.Text = "激活";
            this.ckbActived.UseVisualStyleBackColor = true;
            // 
            // ckbIsOut
            // 
            this.ckbIsOut.AutoSize = true;
            this.ckbIsOut.Checked = true;
            this.ckbIsOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIsOut.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbIsOut.Location = new System.Drawing.Point(48, 232);
            this.ckbIsOut.Name = "ckbIsOut";
            this.ckbIsOut.Size = new System.Drawing.Size(66, 23);
            this.ckbIsOut.TabIndex = 4;
            this.ckbIsOut.Text = "出库";
            this.ckbIsOut.UseVisualStyleBackColor = true;
            // 
            // FrmBillsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 277);
            this.Controls.Add(this.ckbIsOut);
            this.Controls.Add(this.ckbActived);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBillsType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "票据类别管理【{0}】";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.CheckBox ckbActived;
        private System.Windows.Forms.CheckBox ckbIsOut;
    }
}