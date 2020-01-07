namespace MSA
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.txtErwartungswert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOSG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSG = new System.Windows.Forms.TextBox();
            this.lstData = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnRandomData = new System.Windows.Forms.Button();
            this.txtRndMean = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRndStdDev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtErwartungswert
            // 
            this.txtErwartungswert.Location = new System.Drawing.Point(238, 12);
            this.txtErwartungswert.Name = "txtErwartungswert";
            this.txtErwartungswert.Size = new System.Drawing.Size(184, 35);
            this.txtErwartungswert.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Erwartungswert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oberer Grenzwert";
            // 
            // txtOSG
            // 
            this.txtOSG.Location = new System.Drawing.Point(238, 53);
            this.txtOSG.Name = "txtOSG";
            this.txtOSG.Size = new System.Drawing.Size(184, 35);
            this.txtOSG.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unterer Grenzwert";
            // 
            // txtUSG
            // 
            this.txtUSG.Location = new System.Drawing.Point(238, 94);
            this.txtUSG.Name = "txtUSG";
            this.txtUSG.Size = new System.Drawing.Size(184, 35);
            this.txtUSG.TabIndex = 4;
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 29;
            this.lstData.Location = new System.Drawing.Point(238, 135);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(441, 497);
            this.lstData.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Daten";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(437, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(242, 117);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Berechnen";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(699, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(601, 688);
            this.propertyGrid1.TabIndex = 9;
            // 
            // btnRandomData
            // 
            this.btnRandomData.Location = new System.Drawing.Point(17, 218);
            this.btnRandomData.Name = "btnRandomData";
            this.btnRandomData.Size = new System.Drawing.Size(204, 45);
            this.btnRandomData.TabIndex = 10;
            this.btnRandomData.Text = "Zufallsdaten";
            this.btnRandomData.UseVisualStyleBackColor = true;
            this.btnRandomData.Click += new System.EventHandler(this.btnRandomData_Click);
            // 
            // txtRndMean
            // 
            this.txtRndMean.Location = new System.Drawing.Point(17, 322);
            this.txtRndMean.Name = "txtRndMean";
            this.txtRndMean.Size = new System.Drawing.Size(184, 35);
            this.txtRndMean.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mittelwert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stdabweichung";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRndStdDev
            // 
            this.txtRndStdDev.Location = new System.Drawing.Point(17, 405);
            this.txtRndStdDev.Name = "txtRndStdDev";
            this.txtRndStdDev.Size = new System.Drawing.Size(184, 35);
            this.txtRndStdDev.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 712);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRndStdDev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRndMean);
            this.Controls.Add(this.btnRandomData);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOSG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtErwartungswert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErwartungswert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOSG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSG;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnRandomData;
        private System.Windows.Forms.TextBox txtRndMean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRndStdDev;
    }
}

