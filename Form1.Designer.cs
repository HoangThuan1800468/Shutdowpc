
namespace shutdowpc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnshutdown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.nmgio = new System.Windows.Forms.NumericUpDown();
            this.nmphut = new System.Windows.Forms.NumericUpDown();
            this.nmgiay = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.thoigianbar = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmgio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmphut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiay)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnshutdown
            // 
            this.btnshutdown.Location = new System.Drawing.Point(12, 59);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Size = new System.Drawing.Size(91, 49);
            this.btnshutdown.TabIndex = 3;
            this.btnshutdown.Text = "Shutdown";
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giờ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giây";
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(116, 59);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(91, 49);
            this.btnrestart.TabIndex = 9;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(218, 59);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 49);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // nmgio
            // 
            this.nmgio.Location = new System.Drawing.Point(12, 12);
            this.nmgio.Name = "nmgio";
            this.nmgio.Size = new System.Drawing.Size(60, 23);
            this.nmgio.TabIndex = 11;
            // 
            // nmphut
            // 
            this.nmphut.Location = new System.Drawing.Point(109, 12);
            this.nmphut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmphut.Name = "nmphut";
            this.nmphut.Size = new System.Drawing.Size(60, 23);
            this.nmphut.TabIndex = 12;
            this.nmphut.ValueChanged += new System.EventHandler(this.nmphut_ValueChanged);
            // 
            // nmgiay
            // 
            this.nmgiay.Location = new System.Drawing.Point(213, 12);
            this.nmgiay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmgiay.Name = "nmgiay";
            this.nmgiay.Size = new System.Drawing.Size(60, 23);
            this.nmgiay.TabIndex = 13;
            this.nmgiay.ValueChanged += new System.EventHandler(this.nmgiay_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelbar,
            this.thoigianbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 114);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(324, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelbar
            // 
            this.labelbar.Name = "labelbar";
            this.labelbar.Size = new System.Drawing.Size(57, 17);
            this.labelbar.Text = "Waiting...";
            // 
            // thoigianbar
            // 
            this.thoigianbar.Name = "thoigianbar";
            this.thoigianbar.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(324, 136);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nmgiay);
            this.Controls.Add(this.nmphut);
            this.Controls.Add(this.nmgio);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshutdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Time";
            ((System.ComponentModel.ISupportInitialize)(this.nmgio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmphut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiay)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnshutdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.NumericUpDown nmgio;
        private System.Windows.Forms.NumericUpDown nmphut;
        private System.Windows.Forms.NumericUpDown nmgiay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelbar;
        private System.Windows.Forms.ToolStripStatusLabel thoigianbar;
    }
}

