namespace ShutterTester
{
    partial class ShutterTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.PortButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonSetDelay = new System.Windows.Forms.Button();
            this.delaynumberBox = new System.Windows.Forms.TextBox();
            this.ButtonProbe = new System.Windows.Forms.Button();
            this.ButtonCloseAll = new System.Windows.Forms.Button();
            this.ButtonOpenAll = new System.Windows.Forms.Button();
            this.ButtonLaser = new System.Windows.Forms.Button();
            this.labelStatusLaser = new System.Windows.Forms.Label();
            this.labelStatusProbe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Controls.Add(this.PortButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM ports";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRefresh.Location = new System.Drawing.Point(18, 55);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh Ports";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(141, 26);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 1;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // PortButton
            // 
            this.PortButton.BackColor = System.Drawing.Color.Lime;
            this.PortButton.Location = new System.Drawing.Point(18, 26);
            this.PortButton.Name = "PortButton";
            this.PortButton.Size = new System.Drawing.Size(81, 23);
            this.PortButton.TabIndex = 0;
            this.PortButton.Text = "Open Port";
            this.PortButton.UseVisualStyleBackColor = false;
            this.PortButton.Click += new System.EventHandler(this.PortButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ButtonSetDelay);
            this.groupBox3.Controls.Add(this.delaynumberBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 86);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "milliseconds";
            // 
            // ButtonSetDelay
            // 
            this.ButtonSetDelay.Location = new System.Drawing.Point(25, 31);
            this.ButtonSetDelay.Name = "ButtonSetDelay";
            this.ButtonSetDelay.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetDelay.TabIndex = 7;
            this.ButtonSetDelay.Text = "Set Delay";
            this.ButtonSetDelay.UseVisualStyleBackColor = true;
            this.ButtonSetDelay.Click += new System.EventHandler(this.SetdelayButton_Click);
            // 
            // delaynumberBox
            // 
            this.delaynumberBox.Location = new System.Drawing.Point(133, 34);
            this.delaynumberBox.Name = "delaynumberBox";
            this.delaynumberBox.Size = new System.Drawing.Size(61, 20);
            this.delaynumberBox.TabIndex = 8;
            this.delaynumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonProbe
            // 
            this.ButtonProbe.Location = new System.Drawing.Point(25, 49);
            this.ButtonProbe.Name = "ButtonProbe";
            this.ButtonProbe.Size = new System.Drawing.Size(75, 23);
            this.ButtonProbe.TabIndex = 4;
            this.ButtonProbe.Text = "Probe Light";
            this.ButtonProbe.UseVisualStyleBackColor = true;
            this.ButtonProbe.Click += new System.EventHandler(this.ButtonProbe_Click);
            // 
            // ButtonCloseAll
            // 
            this.ButtonCloseAll.Location = new System.Drawing.Point(179, 49);
            this.ButtonCloseAll.Name = "ButtonCloseAll";
            this.ButtonCloseAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseAll.TabIndex = 6;
            this.ButtonCloseAll.Text = "Close All";
            this.ButtonCloseAll.UseVisualStyleBackColor = true;
            this.ButtonCloseAll.Click += new System.EventHandler(this.ButtonCloseAll_Click);
            // 
            // ButtonOpenAll
            // 
            this.ButtonOpenAll.Location = new System.Drawing.Point(179, 20);
            this.ButtonOpenAll.Name = "ButtonOpenAll";
            this.ButtonOpenAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenAll.TabIndex = 5;
            this.ButtonOpenAll.Text = "Open All";
            this.ButtonOpenAll.UseVisualStyleBackColor = true;
            this.ButtonOpenAll.Click += new System.EventHandler(this.ButtonOpenAll_Click);
            // 
            // ButtonLaser
            // 
            this.ButtonLaser.Location = new System.Drawing.Point(25, 20);
            this.ButtonLaser.Name = "ButtonLaser";
            this.ButtonLaser.Size = new System.Drawing.Size(75, 23);
            this.ButtonLaser.TabIndex = 3;
            this.ButtonLaser.Text = "Laser";
            this.ButtonLaser.UseVisualStyleBackColor = true;
            this.ButtonLaser.Click += new System.EventHandler(this.ButtonLaser_Click);
            // 
            // labelStatusLaser
            // 
            this.labelStatusLaser.BackColor = System.Drawing.Color.Red;
            this.labelStatusLaser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatusLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusLaser.Location = new System.Drawing.Point(48, 47);
            this.labelStatusLaser.Margin = new System.Windows.Forms.Padding(3);
            this.labelStatusLaser.MinimumSize = new System.Drawing.Size(27, 0);
            this.labelStatusLaser.Name = "labelStatusLaser";
            this.labelStatusLaser.Size = new System.Drawing.Size(68, 23);
            this.labelStatusLaser.TabIndex = 8;
            this.labelStatusLaser.Text = "Closed";
            this.labelStatusLaser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusProbe
            // 
            this.labelStatusProbe.BackColor = System.Drawing.Color.Red;
            this.labelStatusProbe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatusProbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusProbe.Location = new System.Drawing.Point(164, 47);
            this.labelStatusProbe.Margin = new System.Windows.Forms.Padding(3);
            this.labelStatusProbe.MinimumSize = new System.Drawing.Size(27, 0);
            this.labelStatusProbe.Name = "labelStatusProbe";
            this.labelStatusProbe.Size = new System.Drawing.Size(68, 23);
            this.labelStatusProbe.TabIndex = 9;
            this.labelStatusProbe.Text = "Closed";
            this.labelStatusProbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonLaser);
            this.groupBox2.Controls.Add(this.ButtonOpenAll);
            this.groupBox2.Controls.Add(this.ButtonCloseAll);
            this.groupBox2.Controls.Add(this.ButtonProbe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 82);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shutter Toggles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Laser:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.labelStatusLaser);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.labelStatusProbe);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 86);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shutter Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Probe Light:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(274, 377);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(274, 262);
            this.splitContainer2.SplitterDistance = 82;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(274, 176);
            this.splitContainer3.SplitterDistance = 86;
            this.splitContainer3.TabIndex = 0;
            // 
            // ShutterTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 377);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "ShutterTest";
            this.Text = "ShutterTestApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PortButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox delaynumberBox;
        private System.Windows.Forms.Button ButtonSetDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonProbe;
        private System.Windows.Forms.Button ButtonCloseAll;
        private System.Windows.Forms.Button ButtonOpenAll;
        private System.Windows.Forms.Button ButtonLaser;
        private System.Windows.Forms.Label labelStatusLaser;
        private System.Windows.Forms.Label labelStatusProbe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}

