
namespace CaseFlowUI
{
    partial class CaseFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseFlow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnShowCases = new FontAwesome.Sharp.IconButton();
            this.btnSearchCases = new FontAwesome.Sharp.IconButton();
            this.btnAddCase = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconMinimise = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximise = new FontAwesome.Sharp.IconPictureBox();
            this.iconCloseForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.panelMenu.Controls.Add(this.btnShowCases);
            this.panelMenu.Controls.Add(this.btnSearchCases);
            this.panelMenu.Controls.Add(this.btnAddCase);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 658);
            this.panelMenu.TabIndex = 0;
            // 
            // btnShowCases
            // 
            this.btnShowCases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCases.FlatAppearance.BorderSize = 0;
            this.btnShowCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCases.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowCases.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnShowCases.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowCases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowCases.IconSize = 32;
            this.btnShowCases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCases.Location = new System.Drawing.Point(0, 240);
            this.btnShowCases.Name = "btnShowCases";
            this.btnShowCases.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShowCases.Size = new System.Drawing.Size(200, 60);
            this.btnShowCases.TabIndex = 3;
            this.btnShowCases.Text = "Show Cases";
            this.btnShowCases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCases.UseVisualStyleBackColor = true;
            this.btnShowCases.Click += new System.EventHandler(this.ShowCases_Click);
            // 
            // btnSearchCases
            // 
            this.btnSearchCases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchCases.FlatAppearance.BorderSize = 0;
            this.btnSearchCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCases.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchCases.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchCases.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearchCases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCases.IconSize = 32;
            this.btnSearchCases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCases.Location = new System.Drawing.Point(0, 180);
            this.btnSearchCases.Name = "btnSearchCases";
            this.btnSearchCases.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearchCases.Size = new System.Drawing.Size(200, 60);
            this.btnSearchCases.TabIndex = 2;
            this.btnSearchCases.Text = "Search Cases";
            this.btnSearchCases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCases.UseVisualStyleBackColor = true;
            this.btnSearchCases.Click += new System.EventHandler(this.SearchCases_Click);
            // 
            // btnAddCase
            // 
            this.btnAddCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCase.FlatAppearance.BorderSize = 0;
            this.btnAddCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCase.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCase.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddCase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCase.IconSize = 32;
            this.btnAddCase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCase.Location = new System.Drawing.Point(0, 120);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddCase.Size = new System.Drawing.Size(200, 60);
            this.btnAddCase.TabIndex = 1;
            this.btnAddCase.Text = "Add Case";
            this.btnAddCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCase.UseVisualStyleBackColor = true;
            this.btnAddCase.Click += new System.EventHandler(this.AddCase_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.panelLogo.Controls.Add(this.pictureHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(12, 12);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(175, 102);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 1;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.panelTitleBar.Controls.Add(this.iconMinimise);
            this.panelTitleBar.Controls.Add(this.iconMaximise);
            this.panelTitleBar.Controls.Add(this.iconCloseForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1134, 74);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconMinimise
            // 
            this.iconMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.iconMinimise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconMinimise.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimise.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimise.IconSize = 26;
            this.iconMinimise.Location = new System.Drawing.Point(1035, 3);
            this.iconMinimise.Name = "iconMinimise";
            this.iconMinimise.Size = new System.Drawing.Size(29, 26);
            this.iconMinimise.TabIndex = 6;
            this.iconMinimise.TabStop = false;
            this.iconMinimise.Click += new System.EventHandler(this.iconMinimise_Click);
            // 
            // iconMaximise
            // 
            this.iconMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.iconMaximise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconMaximise.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximise.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconMaximise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximise.IconSize = 26;
            this.iconMaximise.Location = new System.Drawing.Point(1070, 3);
            this.iconMaximise.Name = "iconMaximise";
            this.iconMaximise.Size = new System.Drawing.Size(29, 26);
            this.iconMaximise.TabIndex = 5;
            this.iconMaximise.TabStop = false;
            this.iconMaximise.Click += new System.EventHandler(this.iconMaximise_Click);
            // 
            // iconCloseForm
            // 
            this.iconCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.iconCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconCloseForm.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconCloseForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCloseForm.IconSize = 26;
            this.iconCloseForm.Location = new System.Drawing.Point(1105, 3);
            this.iconCloseForm.Name = "iconCloseForm";
            this.iconCloseForm.Size = new System.Drawing.Size(29, 26);
            this.iconCloseForm.TabIndex = 4;
            this.iconCloseForm.TabStop = false;
            this.iconCloseForm.Click += new System.EventHandler(this.iconCloseForm_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(72, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(64, 25);
            this.lblTitleChildForm.TabIndex = 3;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(190)))), ((int)(((byte)(16)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 42;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(24, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 44);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1134, 584);
            this.panelDesktop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CaseFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 658);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Name = "CaseFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnShowCases;
        private FontAwesome.Sharp.IconButton btnSearchCases;
        private FontAwesome.Sharp.IconButton btnAddCase;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconMaximise;
        private FontAwesome.Sharp.IconPictureBox iconCloseForm;
        private FontAwesome.Sharp.IconPictureBox iconMinimise;
    }
}

