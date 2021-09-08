
namespace TemperCore
{
    partial class Core
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Core));
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.topPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.miniBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.dreamWriterBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.topPnl;
            this.dragControl.TransparentWhileDrag = true;
            this.dragControl.UseTransparentDrag = true;
            // 
            // topPnl
            // 
            this.topPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.maxBtn);
            this.topPnl.Controls.Add(this.siticoneLabel1);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.ShadowDecoration.Parent = this.topPnl;
            this.topPnl.Size = new System.Drawing.Size(1093, 37);
            this.topPnl.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Animated = true;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.CustomClick = true;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.IconColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1045, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 29);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.Animated = true;
            this.maxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.maxBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.maxBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maxBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.maxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.maxBtn.HoverState.Parent = this.maxBtn;
            this.maxBtn.IconColor = System.Drawing.Color.White;
            this.maxBtn.Location = new System.Drawing.Point(994, 3);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.maxBtn.ShadowDecoration.Parent = this.maxBtn;
            this.maxBtn.Size = new System.Drawing.Size(45, 29);
            this.maxBtn.TabIndex = 26;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(3, 0);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(35, 26);
            this.siticoneLabel1.TabIndex = 24;
            this.siticoneLabel1.Text = "N/A";
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.Animated = true;
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.HoverState.Parent = this.miniBtn;
            this.miniBtn.IconColor = System.Drawing.Color.White;
            this.miniBtn.Location = new System.Drawing.Point(943, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 29);
            this.miniBtn.TabIndex = 25;
            // 
            // guna2ResizeForm1
            // 
            this.guna2ResizeForm1.TargetForm = this;
            // 
            // dreamWriterBtn
            // 
            this.dreamWriterBtn.BackColor = System.Drawing.Color.Transparent;
            this.dreamWriterBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.dreamWriterBtn.CheckedState.Parent = this.dreamWriterBtn;
            this.dreamWriterBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.dreamWriterBtn.HoverState.ImageSize = new System.Drawing.Size(150, 150);
            this.dreamWriterBtn.HoverState.Parent = this.dreamWriterBtn;
            this.dreamWriterBtn.Image = ((System.Drawing.Image)(resources.GetObject("dreamWriterBtn.Image")));
            this.dreamWriterBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.dreamWriterBtn.ImageRotate = 0F;
            this.dreamWriterBtn.ImageSize = new System.Drawing.Size(150, 150);
            this.dreamWriterBtn.Location = new System.Drawing.Point(0, 43);
            this.dreamWriterBtn.Name = "dreamWriterBtn";
            this.dreamWriterBtn.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.dreamWriterBtn.PressedState.ImageSize = new System.Drawing.Size(150, 150);
            this.dreamWriterBtn.PressedState.Parent = this.dreamWriterBtn;
            this.dreamWriterBtn.ShadowDecoration.Parent = this.dreamWriterBtn;
            this.dreamWriterBtn.Size = new System.Drawing.Size(175, 109);
            this.dreamWriterBtn.TabIndex = 3;
            this.dreamWriterBtn.UseTransparentBackground = true;
            this.dreamWriterBtn.Click += new System.EventHandler(this.dreamWriterBtn_Click);
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(22, 158);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(108, 26);
            this.siticoneLabel2.TabIndex = 25;
            this.siticoneLabel2.Text = "DreamWriter";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel3.Location = new System.Drawing.Point(443, 543);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(144, 18);
            this.siticoneLabel3.TabIndex = 26;
            this.siticoneLabel3.Text = "Made by BADTEMPER";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel4.Location = new System.Drawing.Point(443, 567);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(123, 18);
            this.siticoneLabel4.TabIndex = 27;
            this.siticoneLabel4.Text = "BADTEMPER#7472";
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1093, 591);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.dreamWriterBtn);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.siticoneLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Core";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemperCore";
            this.Load += new System.EventHandler(this.Core_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2ControlBox miniBtn;
        private Guna.UI2.WinForms.Guna2ControlBox maxBtn;
        private Guna.UI2.WinForms.Guna2Panel topPnl;
        private Guna.UI2.WinForms.Guna2ImageButton dreamWriterBtn;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
    }
}

