namespace Leakuino
{
    partial class Options
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSensor = new System.Windows.Forms.GroupBox();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.lstAllSensors = new System.Windows.Forms.ListView();
            this.colIDSensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameSensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPortSensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThreshold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDNode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIDNode = new System.Windows.Forms.TextBox();
            this.txtPortSensor = new System.Windows.Forms.TextBox();
            this.lblPortSensor = new System.Windows.Forms.Label();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.lblIDNode = new System.Windows.Forms.Label();
            this.txtNameSensor = new System.Windows.Forms.TextBox();
            this.lblNameSensor = new System.Windows.Forms.Label();
            this.grpNode = new System.Windows.Forms.GroupBox();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.lstAllNodes = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBaudrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNode = new System.Windows.Forms.Button();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.txtPortNode = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtNameNode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpSensor.SuspendLayout();
            this.grpNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(727, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSensor
            // 
            this.grpSensor.Controls.Add(this.txtThreshold);
            this.grpSensor.Controls.Add(this.lblThreshold);
            this.grpSensor.Controls.Add(this.lstAllSensors);
            this.grpSensor.Controls.Add(this.txtIDNode);
            this.grpSensor.Controls.Add(this.txtPortSensor);
            this.grpSensor.Controls.Add(this.lblPortSensor);
            this.grpSensor.Controls.Add(this.btnAddSensor);
            this.grpSensor.Controls.Add(this.lblIDNode);
            this.grpSensor.Controls.Add(this.txtNameSensor);
            this.grpSensor.Controls.Add(this.lblNameSensor);
            this.grpSensor.Location = new System.Drawing.Point(12, 283);
            this.grpSensor.Name = "grpSensor";
            this.grpSensor.Size = new System.Drawing.Size(790, 265);
            this.grpSensor.TabIndex = 21;
            this.grpSensor.TabStop = false;
            this.grpSensor.Text = "Sensors";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(429, 19);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(133, 20);
            this.txtThreshold.TabIndex = 32;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(370, 22);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(57, 13);
            this.lblThreshold.TabIndex = 31;
            this.lblThreshold.Text = "Threshold:";
            // 
            // lstAllSensors
            // 
            this.lstAllSensors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDSensor,
            this.colNameSensor,
            this.colPortSensor,
            this.colThreshold,
            this.colIDNode});
            this.lstAllSensors.Location = new System.Drawing.Point(11, 46);
            this.lstAllSensors.Name = "lstAllSensors";
            this.lstAllSensors.Size = new System.Drawing.Size(769, 213);
            this.lstAllSensors.TabIndex = 30;
            this.lstAllSensors.UseCompatibleStateImageBehavior = false;
            this.lstAllSensors.View = System.Windows.Forms.View.Details;
            // 
            // colIDSensor
            // 
            this.colIDSensor.Text = "ID";
            // 
            // colNameSensor
            // 
            this.colNameSensor.Text = "Name";
            this.colNameSensor.Width = 269;
            // 
            // colPortSensor
            // 
            this.colPortSensor.Text = "Port";
            // 
            // colThreshold
            // 
            this.colThreshold.Text = "Threshold";
            this.colThreshold.Width = 121;
            // 
            // colIDNode
            // 
            this.colIDNode.Text = "ID Node";
            // 
            // txtIDNode
            // 
            this.txtIDNode.Location = new System.Drawing.Point(621, 19);
            this.txtIDNode.Name = "txtIDNode";
            this.txtIDNode.Size = new System.Drawing.Size(78, 20);
            this.txtIDNode.TabIndex = 29;
            // 
            // txtPortSensor
            // 
            this.txtPortSensor.Location = new System.Drawing.Point(292, 19);
            this.txtPortSensor.Name = "txtPortSensor";
            this.txtPortSensor.Size = new System.Drawing.Size(72, 20);
            this.txtPortSensor.TabIndex = 28;
            // 
            // lblPortSensor
            // 
            this.lblPortSensor.AutoSize = true;
            this.lblPortSensor.Location = new System.Drawing.Point(257, 22);
            this.lblPortSensor.Name = "lblPortSensor";
            this.lblPortSensor.Size = new System.Drawing.Size(29, 13);
            this.lblPortSensor.TabIndex = 27;
            this.lblPortSensor.Text = "Port:";
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Location = new System.Drawing.Point(705, 16);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(75, 23);
            this.btnAddSensor.TabIndex = 26;
            this.btnAddSensor.Text = "Add Sensor";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // lblIDNode
            // 
            this.lblIDNode.AutoSize = true;
            this.lblIDNode.Location = new System.Drawing.Point(568, 22);
            this.lblIDNode.Name = "lblIDNode";
            this.lblIDNode.Size = new System.Drawing.Size(47, 13);
            this.lblIDNode.TabIndex = 25;
            this.lblIDNode.Text = "ID Node";
            // 
            // txtNameSensor
            // 
            this.txtNameSensor.Location = new System.Drawing.Point(46, 19);
            this.txtNameSensor.Name = "txtNameSensor";
            this.txtNameSensor.Size = new System.Drawing.Size(205, 20);
            this.txtNameSensor.TabIndex = 24;
            // 
            // lblNameSensor
            // 
            this.lblNameSensor.AutoSize = true;
            this.lblNameSensor.Location = new System.Drawing.Point(6, 22);
            this.lblNameSensor.Name = "lblNameSensor";
            this.lblNameSensor.Size = new System.Drawing.Size(38, 13);
            this.lblNameSensor.TabIndex = 23;
            this.lblNameSensor.Text = "Name:";
            // 
            // grpNode
            // 
            this.grpNode.Controls.Add(this.txtBaudrate);
            this.grpNode.Controls.Add(this.lstAllNodes);
            this.grpNode.Controls.Add(this.btnAddNode);
            this.grpNode.Controls.Add(this.lblBaudrate);
            this.grpNode.Controls.Add(this.txtPortNode);
            this.grpNode.Controls.Add(this.lblPort);
            this.grpNode.Controls.Add(this.txtNameNode);
            this.grpNode.Controls.Add(this.lblName);
            this.grpNode.Location = new System.Drawing.Point(12, 12);
            this.grpNode.Name = "grpNode";
            this.grpNode.Size = new System.Drawing.Size(790, 265);
            this.grpNode.TabIndex = 22;
            this.grpNode.TabStop = false;
            this.grpNode.Text = "Nodes";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(621, 19);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(78, 20);
            this.txtBaudrate.TabIndex = 29;
            // 
            // lstAllNodes
            // 
            this.lstAllNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colPort,
            this.colBaudrate});
            this.lstAllNodes.Location = new System.Drawing.Point(9, 46);
            this.lstAllNodes.Name = "lstAllNodes";
            this.lstAllNodes.Size = new System.Drawing.Size(771, 213);
            this.lstAllNodes.TabIndex = 28;
            this.lstAllNodes.UseCompatibleStateImageBehavior = false;
            this.lstAllNodes.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 25;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 300;
            // 
            // colPort
            // 
            this.colPort.Text = "Port";
            // 
            // colBaudrate
            // 
            this.colBaudrate.Text = "Baudrate";
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(705, 17);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 27;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(562, 22);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(53, 13);
            this.lblBaudrate.TabIndex = 26;
            this.lblBaudrate.Text = "Baudrate:";
            // 
            // txtPortNode
            // 
            this.txtPortNode.Location = new System.Drawing.Point(484, 19);
            this.txtPortNode.Name = "txtPortNode";
            this.txtPortNode.Size = new System.Drawing.Size(72, 20);
            this.txtPortNode.TabIndex = 25;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(449, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 24;
            this.lblPort.Text = "Port:";
            // 
            // txtNameNode
            // 
            this.txtNameNode.Location = new System.Drawing.Point(46, 19);
            this.txtNameNode.Name = "txtNameNode";
            this.txtNameNode.Size = new System.Drawing.Size(397, 20);
            this.txtNameNode.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name:";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(646, 554);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 589);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpNode);
            this.Controls.Add(this.grpSensor);
            this.Controls.Add(this.btnClose);
            this.Name = "Options";
            this.Text = "Config";
            this.grpSensor.ResumeLayout(false);
            this.grpSensor.PerformLayout();
            this.grpNode.ResumeLayout(false);
            this.grpNode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSensor;
        private System.Windows.Forms.ListView lstAllSensors;
        private System.Windows.Forms.TextBox txtIDNode;
        private System.Windows.Forms.TextBox txtPortSensor;
        private System.Windows.Forms.Label lblPortSensor;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.Label lblIDNode;
        private System.Windows.Forms.TextBox txtNameSensor;
        private System.Windows.Forms.Label lblNameSensor;
        private System.Windows.Forms.GroupBox grpNode;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.ListView lstAllNodes;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.TextBox txtPortNode;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtNameNode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPort;
        private System.Windows.Forms.ColumnHeader colBaudrate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.ColumnHeader colIDSensor;
        private System.Windows.Forms.ColumnHeader colNameSensor;
        private System.Windows.Forms.ColumnHeader colPortSensor;
        private System.Windows.Forms.ColumnHeader colThreshold;
        private System.Windows.Forms.ColumnHeader colIDNode;
    }
}