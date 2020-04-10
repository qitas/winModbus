namespace IoTClient.Tool
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ModBusTcp = new System.Windows.Forms.TabPage();
            this.ModBusRtu = new System.Windows.Forms.TabPage();
            this.ModBusAscii = new System.Windows.Forms.TabPage();
/*            this.Siemens = new System.Windows.Forms.TabPage();
            this.SiemensS7300 = new System.Windows.Forms.TabPage();*/
/*            this.MitsubishiMC = new System.Windows.Forms.TabPage();*/
/*            this.OmronFinsTcp = new System.Windows.Forms.TabPage();*/
            this.BACnet = new System.Windows.Forms.TabPage();
            this.Ports = new System.Windows.Forms.TabPage();
            this.Other = new System.Windows.Forms.TabPage();
            this.modBusTcpControl1 = new IoTClient.Tool.ModBusTcpControl();
            this.tabControl1.SuspendLayout();
            this.ModBusTcp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ModBusTcp);
            this.tabControl1.Controls.Add(this.ModBusRtu);
            this.tabControl1.Controls.Add(this.ModBusAscii);
/*            this.tabControl1.Controls.Add(this.Siemens);
            this.tabControl1.Controls.Add(this.SiemensS7300);*/
/*            this.tabControl1.Controls.Add(this.MitsubishiMC);*/
/*            this.tabControl1.Controls.Add(this.OmronFinsTcp);*/
            this.tabControl1.Controls.Add(this.BACnet);
            this.tabControl1.Controls.Add(this.Ports);
            this.tabControl1.Controls.Add(this.Other);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 493);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ModBusTcp
            // 
            this.ModBusTcp.Controls.Add(this.modBusTcpControl1);
            this.ModBusTcp.Location = new System.Drawing.Point(4, 22);
            this.ModBusTcp.Name = "ModBusTcp";
            this.ModBusTcp.Padding = new System.Windows.Forms.Padding(3);
            this.ModBusTcp.Size = new System.Drawing.Size(886, 467);
            this.ModBusTcp.TabIndex = 0;
            this.ModBusTcp.Text = "ModBusTcp";
            this.ModBusTcp.UseVisualStyleBackColor = true;
            this.ModBusTcp.Click += new System.EventHandler(this.ModBusTcp_Click);
            // 
            // ModBusRtu
            // 
            this.ModBusRtu.Location = new System.Drawing.Point(4, 22);
            this.ModBusRtu.Name = "ModBusRtu";
            this.ModBusRtu.Padding = new System.Windows.Forms.Padding(3);
            this.ModBusRtu.Size = new System.Drawing.Size(886, 477);
            this.ModBusRtu.TabIndex = 4;
            this.ModBusRtu.Text = "ModBusRtu";
            this.ModBusRtu.UseVisualStyleBackColor = true;
            // 
            // ModBusAscii
            // 
            this.ModBusAscii.Location = new System.Drawing.Point(4, 22);
            this.ModBusAscii.Name = "ModBusAscii";
            this.ModBusAscii.Padding = new System.Windows.Forms.Padding(3);
            this.ModBusAscii.Size = new System.Drawing.Size(886, 467);
            this.ModBusAscii.TabIndex = 7;
            this.ModBusAscii.Text = "ModBusAscii";
            this.ModBusAscii.UseVisualStyleBackColor = true;
            // 
            // Siemens
            // 
/*            this.Siemens.Location = new System.Drawing.Point(4, 22);
            this.Siemens.Name = "Siemens";
            this.Siemens.Padding = new System.Windows.Forms.Padding(3);
            this.Siemens.Size = new System.Drawing.Size(886, 477);
            this.Siemens.TabIndex = 1;
            this.Siemens.Text = "西门子S7-200Smart";
            this.Siemens.UseVisualStyleBackColor = true;*/
            // 
            // SiemensS7300
            // 
/*            this.SiemensS7300.Location = new System.Drawing.Point(4, 22);
            this.SiemensS7300.Name = "SiemensS7300";
            this.SiemensS7300.Padding = new System.Windows.Forms.Padding(3);
            this.SiemensS7300.Size = new System.Drawing.Size(886, 477);
            this.SiemensS7300.TabIndex = 8;
            this.SiemensS7300.Text = "西门子S7-300 Beta";
            this.SiemensS7300.UseVisualStyleBackColor = true;*/
            // 
            // MitsubishiMC
            // 
/*            this.MitsubishiMC.Location = new System.Drawing.Point(4, 22);
            this.MitsubishiMC.Name = "MitsubishiMC";
            this.MitsubishiMC.Padding = new System.Windows.Forms.Padding(3);
            this.MitsubishiMC.Size = new System.Drawing.Size(886, 467);
            this.MitsubishiMC.TabIndex = 5;
            this.MitsubishiMC.Text = " 三菱MC Beta";
            this.MitsubishiMC.UseVisualStyleBackColor = true;*/
            // 
            // OmronFinsTcp
            // 
/*            this.OmronFinsTcp.Location = new System.Drawing.Point(4, 22);
            this.OmronFinsTcp.Name = "OmronFinsTcp";
            this.OmronFinsTcp.Padding = new System.Windows.Forms.Padding(3);
            this.OmronFinsTcp.Size = new System.Drawing.Size(886, 467);
            this.OmronFinsTcp.TabIndex = 6;
            this.OmronFinsTcp.Text = "欧姆龙FinsTcp Beta";
            this.OmronFinsTcp.UseVisualStyleBackColor = true;*/
            // 
            // BACnet
            // 
            this.BACnet.Location = new System.Drawing.Point(4, 22);
            this.BACnet.Name = "BACnet";
            this.BACnet.Padding = new System.Windows.Forms.Padding(3);
            this.BACnet.Size = new System.Drawing.Size(886, 467);
            this.BACnet.TabIndex = 2;
            this.BACnet.Text = " BACnet ";
            this.BACnet.UseVisualStyleBackColor = true;
            // 
            // Ports
            // 
            this.Ports.Location = new System.Drawing.Point(4, 22);
            this.Ports.Name = "Ports";
            this.Ports.Padding = new System.Windows.Forms.Padding(3);
            this.Ports.Size = new System.Drawing.Size(886, 477);
            this.Ports.TabIndex = 3;
            this.Ports.Text = "  串口  ";
            this.Ports.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.Location = new System.Drawing.Point(4, 22);
            this.Other.Name = "Other";
            this.Other.Padding = new System.Windows.Forms.Padding(3);
            this.Other.Size = new System.Drawing.Size(886, 477);
            this.Other.TabIndex = 9;
            this.Other.Text = "工具";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // modBusTcpControl1
            // 
            this.modBusTcpControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modBusTcpControl1.Location = new System.Drawing.Point(3, 3);
            this.modBusTcpControl1.Name = "modBusTcpControl1";
            this.modBusTcpControl1.Size = new System.Drawing.Size(880, 461);
            this.modBusTcpControl1.TabIndex = 0;
            this.modBusTcpControl1.Load += new System.EventHandler(this.modBusTcpControl1_Load);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 505);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IndexForm";
            this.Text = "IoTClient Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndexForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.ModBusTcp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ModBusTcp;
        private System.Windows.Forms.TabPage Siemens;
        private ModBusTcpControl modBusTcpControl1;
        private System.Windows.Forms.TabPage BACnet;
        private System.Windows.Forms.TabPage Ports;
        private System.Windows.Forms.TabPage ModBusRtu;
/*        private System.Windows.Forms.TabPage MitsubishiMC;*/
        private System.Windows.Forms.TabPage OmronFinsTcp;
        private System.Windows.Forms.TabPage ModBusAscii;
/*        private System.Windows.Forms.TabPage SiemensS7300;*/
        private System.Windows.Forms.TabPage Other;
    }
}