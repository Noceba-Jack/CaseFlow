
namespace CaseFlowUI
{
    partial class AddCase
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
            this.lblCaseNumber = new System.Windows.Forms.Label();
            this.lblMASNumber = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblInvetigatingOfficer = new System.Windows.Forms.Label();
            this.lblFirstAppearanceDate = new System.Windows.Forms.Label();
            this.lblReasonForPostponement = new System.Windows.Forms.Label();
            this.lblPostponementDate = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.TextBox();
            this.txtMASNumber = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtIO = new System.Windows.Forms.TextBox();
            this.txtPostponementReason = new System.Windows.Forms.TextBox();
            this.dtpFirstAppearnce = new System.Windows.Forms.DateTimePicker();
            this.dtpPostponement = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblAccSurname = new System.Windows.Forms.Label();
            this.chbCasePostponed = new System.Windows.Forms.CheckBox();
            this.txtAccSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaseNumber
            // 
            this.lblCaseNumber.AutoSize = true;
            this.lblCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblCaseNumber.Location = new System.Drawing.Point(40, 61);
            this.lblCaseNumber.Name = "lblCaseNumber";
            this.lblCaseNumber.Size = new System.Drawing.Size(137, 24);
            this.lblCaseNumber.TabIndex = 0;
            this.lblCaseNumber.Text = "Case Number :";
            // 
            // lblMASNumber
            // 
            this.lblMASNumber.AutoSize = true;
            this.lblMASNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMASNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblMASNumber.Location = new System.Drawing.Point(42, 132);
            this.lblMASNumber.Name = "lblMASNumber";
            this.lblMASNumber.Size = new System.Drawing.Size(135, 24);
            this.lblMASNumber.TabIndex = 1;
            this.lblMASNumber.Text = "MAS Number :";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblAccName.Location = new System.Drawing.Point(40, 197);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(151, 24);
            this.lblAccName.TabIndex = 2;
            this.lblAccName.Text = "Accused Name :";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblCharge.Location = new System.Drawing.Point(40, 333);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(82, 24);
            this.lblCharge.TabIndex = 3;
            this.lblCharge.Text = "Charge :";
            // 
            // lblInvetigatingOfficer
            // 
            this.lblInvetigatingOfficer.AutoSize = true;
            this.lblInvetigatingOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvetigatingOfficer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblInvetigatingOfficer.Location = new System.Drawing.Point(40, 400);
            this.lblInvetigatingOfficer.Name = "lblInvetigatingOfficer";
            this.lblInvetigatingOfficer.Size = new System.Drawing.Size(182, 24);
            this.lblInvetigatingOfficer.TabIndex = 4;
            this.lblInvetigatingOfficer.Text = "Investigating Officer :";
            // 
            // lblFirstAppearanceDate
            // 
            this.lblFirstAppearanceDate.AutoSize = true;
            this.lblFirstAppearanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstAppearanceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblFirstAppearanceDate.Location = new System.Drawing.Point(42, 477);
            this.lblFirstAppearanceDate.Name = "lblFirstAppearanceDate";
            this.lblFirstAppearanceDate.Size = new System.Drawing.Size(207, 24);
            this.lblFirstAppearanceDate.TabIndex = 5;
            this.lblFirstAppearanceDate.Text = "First Appearance Date :";
            // 
            // lblReasonForPostponement
            // 
            this.lblReasonForPostponement.AutoSize = true;
            this.lblReasonForPostponement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonForPostponement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblReasonForPostponement.Location = new System.Drawing.Point(723, 116);
            this.lblReasonForPostponement.Name = "lblReasonForPostponement";
            this.lblReasonForPostponement.Size = new System.Drawing.Size(238, 24);
            this.lblReasonForPostponement.TabIndex = 6;
            this.lblReasonForPostponement.Text = "Reason for Postponement :";
            // 
            // lblPostponementDate
            // 
            this.lblPostponementDate.AutoSize = true;
            this.lblPostponementDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostponementDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblPostponementDate.Location = new System.Drawing.Point(723, 287);
            this.lblPostponementDate.Name = "lblPostponementDate";
            this.lblPostponementDate.Size = new System.Drawing.Size(175, 24);
            this.lblPostponementDate.TabIndex = 7;
            this.lblPostponementDate.Text = "Postponement Date";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseNumber.Location = new System.Drawing.Point(200, 61);
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(466, 28);
            this.txtCaseNumber.TabIndex = 8;
            // 
            // txtMASNumber
            // 
            this.txtMASNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASNumber.Location = new System.Drawing.Point(200, 129);
            this.txtMASNumber.Name = "txtMASNumber";
            this.txtMASNumber.Size = new System.Drawing.Size(466, 28);
            this.txtMASNumber.TabIndex = 9;
            // 
            // txtAccName
            // 
            this.txtAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccName.Location = new System.Drawing.Point(200, 197);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(466, 28);
            this.txtAccName.TabIndex = 10;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(161, 329);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(505, 28);
            this.txtCharge.TabIndex = 11;
            // 
            // txtIO
            // 
            this.txtIO.BackColor = System.Drawing.SystemColors.Window;
            this.txtIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIO.Location = new System.Drawing.Point(237, 397);
            this.txtIO.Name = "txtIO";
            this.txtIO.Size = new System.Drawing.Size(429, 28);
            this.txtIO.TabIndex = 12;
            // 
            // txtPostponementReason
            // 
            this.txtPostponementReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostponementReason.Location = new System.Drawing.Point(727, 155);
            this.txtPostponementReason.Multiline = true;
            this.txtPostponementReason.Name = "txtPostponementReason";
            this.txtPostponementReason.Size = new System.Drawing.Size(340, 116);
            this.txtPostponementReason.TabIndex = 13;
            // 
            // dtpFirstAppearnce
            // 
            this.dtpFirstAppearnce.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstAppearnce.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.dtpFirstAppearnce.CustomFormat = "yyyy-MM-dd";
            this.dtpFirstAppearnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstAppearnce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFirstAppearnce.Location = new System.Drawing.Point(281, 477);
            this.dtpFirstAppearnce.Name = "dtpFirstAppearnce";
            this.dtpFirstAppearnce.Size = new System.Drawing.Size(385, 30);
            this.dtpFirstAppearnce.TabIndex = 14;
            this.dtpFirstAppearnce.ValueChanged += new System.EventHandler(this.dtpFirstAppearnce_ValueChanged);
            // 
            // dtpPostponement
            // 
            this.dtpPostponement.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.dtpPostponement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPostponement.Location = new System.Drawing.Point(727, 327);
            this.dtpPostponement.Name = "dtpPostponement";
            this.dtpPostponement.Size = new System.Drawing.Size(351, 30);
            this.dtpPostponement.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(951, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 39);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(951, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 39);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAccSurname
            // 
            this.lblAccSurname.AutoSize = true;
            this.lblAccSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblAccSurname.Location = new System.Drawing.Point(40, 262);
            this.lblAccSurname.Name = "lblAccSurname";
            this.lblAccSurname.Size = new System.Drawing.Size(177, 24);
            this.lblAccSurname.TabIndex = 18;
            this.lblAccSurname.Text = "Accused Surname :";
            // 
            // chbCasePostponed
            // 
            this.chbCasePostponed.AutoSize = true;
            this.chbCasePostponed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chbCasePostponed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.chbCasePostponed.Location = new System.Drawing.Point(727, 62);
            this.chbCasePostponed.Name = "chbCasePostponed";
            this.chbCasePostponed.Size = new System.Drawing.Size(181, 28);
            this.chbCasePostponed.TabIndex = 20;
            this.chbCasePostponed.Text = "Postponed Case?";
            this.chbCasePostponed.UseVisualStyleBackColor = true;
            // 
            // txtAccSurname
            // 
            this.txtAccSurname.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccSurname.Location = new System.Drawing.Point(237, 258);
            this.txtAccSurname.Name = "txtAccSurname";
            this.txtAccSurname.Size = new System.Drawing.Size(429, 28);
            this.txtAccSurname.TabIndex = 21;
            // 
            // AddCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1134, 584);
            this.Controls.Add(this.txtAccSurname);
            this.Controls.Add(this.chbCasePostponed);
            this.Controls.Add(this.lblAccSurname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpPostponement);
            this.Controls.Add(this.dtpFirstAppearnce);
            this.Controls.Add(this.txtPostponementReason);
            this.Controls.Add(this.txtIO);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtMASNumber);
            this.Controls.Add(this.txtCaseNumber);
            this.Controls.Add(this.lblPostponementDate);
            this.Controls.Add(this.lblReasonForPostponement);
            this.Controls.Add(this.lblFirstAppearanceDate);
            this.Controls.Add(this.lblInvetigatingOfficer);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.lblMASNumber);
            this.Controls.Add(this.lblCaseNumber);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCase";
            this.Text = "AddCase";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaseNumber;
        private System.Windows.Forms.Label lblMASNumber;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblInvetigatingOfficer;
        private System.Windows.Forms.Label lblFirstAppearanceDate;
        private System.Windows.Forms.Label lblReasonForPostponement;
        private System.Windows.Forms.Label lblPostponementDate;
        private System.Windows.Forms.TextBox txtCaseNumber;
        private System.Windows.Forms.TextBox txtMASNumber;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtIO;
        private System.Windows.Forms.TextBox txtPostponementReason;
        private System.Windows.Forms.DateTimePicker dtpFirstAppearnce;
        private System.Windows.Forms.DateTimePicker dtpPostponement;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblAccSurname;
        private System.Windows.Forms.CheckBox chbCasePostponed;
        private System.Windows.Forms.TextBox txtAccSurname;
    }
}