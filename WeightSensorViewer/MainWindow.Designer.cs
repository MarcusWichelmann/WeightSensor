namespace WeightSensorViewer
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.portSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portSelectionConnectButton = new System.Windows.Forms.Button();
            this.portSelectionScanButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portSelectionComboBox
            // 
            this.portSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelectionComboBox.FormattingEnabled = true;
            this.portSelectionComboBox.Location = new System.Drawing.Point(71, 13);
            this.portSelectionComboBox.Name = "portSelectionComboBox";
            this.portSelectionComboBox.Size = new System.Drawing.Size(157, 21);
            this.portSelectionComboBox.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(328, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(705, 23);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Nicht verbunden";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portSelectionConnectButton
            // 
            this.portSelectionConnectButton.Location = new System.Drawing.Point(234, 12);
            this.portSelectionConnectButton.Name = "portSelectionConnectButton";
            this.portSelectionConnectButton.Size = new System.Drawing.Size(88, 23);
            this.portSelectionConnectButton.TabIndex = 2;
            this.portSelectionConnectButton.Text = "Verbinden";
            this.portSelectionConnectButton.UseVisualStyleBackColor = true;
            this.portSelectionConnectButton.Click += new System.EventHandler(this.portSelectionConnectButton_Click);
            // 
            // portSelectionScanButton
            // 
            this.portSelectionScanButton.Location = new System.Drawing.Point(12, 12);
            this.portSelectionScanButton.Name = "portSelectionScanButton";
            this.portSelectionScanButton.Size = new System.Drawing.Size(53, 23);
            this.portSelectionScanButton.TabIndex = 3;
            this.portSelectionScanButton.Text = "Suchen";
            this.portSelectionScanButton.UseVisualStyleBackColor = true;
            this.portSelectionScanButton.Click += new System.EventHandler(this.portSelectionScanButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.valueLabel.Location = new System.Drawing.Point(12, 45);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(1021, 324);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = ";-)";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsLabel
            // 
            this.creditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.creditsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.creditsLabel.Location = new System.Drawing.Point(871, 362);
            this.creditsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(171, 13);
            this.creditsLabel.TabIndex = 5;
            this.creditsLabel.Text = "Entwickelt von Marcus Wichelmann";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 378);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.portSelectionScanButton);
            this.Controls.Add(this.portSelectionConnectButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.portSelectionComboBox);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Gewichtssensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelectionComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button portSelectionConnectButton;
        private System.Windows.Forms.Button portSelectionScanButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label creditsLabel;
    }
}

