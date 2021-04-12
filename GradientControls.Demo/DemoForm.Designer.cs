
namespace GradientControls.Demo
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new GradientControls.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientButton2 = new GradientControls.GradientButton();
            this.gradientButton1 = new GradientControls.GradientButton();
            this.gradientPanel2 = new GradientControls.GradientPanel();
            this.gradientButton6 = new GradientControls.GradientButton();
            this.gradientButton5 = new GradientControls.GradientButton();
            this.gradientButton4 = new GradientControls.GradientButton();
            this.gradientButton3 = new GradientControls.GradientButton();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gradientButton2);
            this.panel1.Controls.Add(this.gradientButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(14, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 69);
            this.panel1.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel1.BackgroundImage")));
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.GradientColorA = System.Drawing.Color.White;
            this.gradientPanel1.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gradientPanel1.Location = new System.Drawing.Point(14, 108);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(668, 254);
            this.gradientPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12);
            this.label1.Size = new System.Drawing.Size(668, 254);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // gradientButton2
            // 
            this.gradientButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientButton2.BackgroundImage")));
            this.gradientButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientButton2.GradientColorA = System.Drawing.Color.White;
            this.gradientButton2.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientButton2.Location = new System.Drawing.Point(547, 24);
            this.gradientButton2.Name = "gradientButton2";
            this.gradientButton2.Size = new System.Drawing.Size(105, 27);
            this.gradientButton2.TabIndex = 1;
            this.gradientButton2.Text = "Cancel";
            this.gradientButton2.UseVisualStyleBackColor = true;
            // 
            // gradientButton1
            // 
            this.gradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientButton1.BackgroundImage")));
            this.gradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientButton1.GradientColorA = System.Drawing.Color.White;
            this.gradientButton1.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientButton1.Location = new System.Drawing.Point(427, 24);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.Size = new System.Drawing.Size(105, 27);
            this.gradientButton1.TabIndex = 0;
            this.gradientButton1.Text = "Ok";
            this.gradientButton1.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel2.BackgroundImage")));
            this.gradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel2.Controls.Add(this.gradientButton6);
            this.gradientPanel2.Controls.Add(this.gradientButton5);
            this.gradientPanel2.Controls.Add(this.gradientButton4);
            this.gradientPanel2.Controls.Add(this.gradientButton3);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.GradientColorA = System.Drawing.Color.White;
            this.gradientPanel2.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel2.Location = new System.Drawing.Point(14, 14);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.gradientPanel2.Size = new System.Drawing.Size(668, 94);
            this.gradientPanel2.TabIndex = 3;
            // 
            // gradientButton6
            // 
            this.gradientButton6.BackColor = System.Drawing.Color.Transparent;
            this.gradientButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientButton6.BackgroundImage")));
            this.gradientButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientButton6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.gradientButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradientButton6.GradientColorA = System.Drawing.Color.White;
            this.gradientButton6.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientButton6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientButton6.Image = global::GradientControls.Demo.Properties.Resources.keyboard;
            this.gradientButton6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradientButton6.Location = new System.Drawing.Point(256, 4);
            this.gradientButton6.Name = "gradientButton6";
            this.gradientButton6.Size = new System.Drawing.Size(84, 86);
            this.gradientButton6.TabIndex = 3;
            this.gradientButton6.Text = "Keyboard";
            this.gradientButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradientButton6.UseVisualStyleBackColor = false;
            // 
            // gradientButton5
            // 
            this.gradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.gradientButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientButton5.BackgroundImage")));
            this.gradientButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientButton5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.gradientButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradientButton5.GradientColorA = System.Drawing.Color.White;
            this.gradientButton5.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientButton5.Image = global::GradientControls.Demo.Properties.Resources.usb_connected;
            this.gradientButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradientButton5.Location = new System.Drawing.Point(172, 4);
            this.gradientButton5.Name = "gradientButton5";
            this.gradientButton5.Size = new System.Drawing.Size(84, 86);
            this.gradientButton5.TabIndex = 2;
            this.gradientButton5.Text = "USB";
            this.gradientButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradientButton5.UseVisualStyleBackColor = false;
            // 
            // gradientButton4
            // 
            this.gradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.gradientButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientButton4.BackgroundImage")));
            this.gradientButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientButton4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.gradientButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradientButton4.GradientColorA = System.Drawing.Color.White;
            this.gradientButton4.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientButton4.Image = global::GradientControls.Demo.Properties.Resources.sd;
            this.gradientButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradientButton4.Location = new System.Drawing.Point(88, 4);
            this.gradientButton4.Name = "gradientButton4";
            this.gradientButton4.Size = new System.Drawing.Size(84, 86);
            this.gradientButton4.TabIndex = 1;
            this.gradientButton4.Text = "Flash";
            this.gradientButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradientButton4.UseVisualStyleBackColor = false;
            // 
            // gradientButton3
            // 
            this.gradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.gradientButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientButton3.BackgroundImage")));
            this.gradientButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientButton3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.gradientButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradientButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gradientButton3.GradientColorA = System.Drawing.Color.White;
            this.gradientButton3.GradientColorB = System.Drawing.Color.Gainsboro;
            this.gradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientButton3.Image = global::GradientControls.Demo.Properties.Resources.laptop;
            this.gradientButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradientButton3.Location = new System.Drawing.Point(4, 4);
            this.gradientButton3.Name = "gradientButton3";
            this.gradientButton3.Size = new System.Drawing.Size(84, 86);
            this.gradientButton3.TabIndex = 0;
            this.gradientButton3.Text = "Computer";
            this.gradientButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradientButton3.UseVisualStyleBackColor = false;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 431);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DemoForm";
            this.Padding = new System.Windows.Forms.Padding(14, 14, 14, 0);
            this.Text = "DemoForm";
            this.panel1.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GradientButton gradientButton2;
        private GradientButton gradientButton1;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private GradientButton gradientButton3;
        private GradientButton gradientButton6;
        private GradientButton gradientButton5;
        private GradientButton gradientButton4;
    }
}

