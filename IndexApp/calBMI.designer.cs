namespace IndexApp
{
    partial class calBMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calBMI));
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBoxResult.Font = new System.Drawing.Font("Angsana New", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(171, 221);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(1010, 338);
            this.textBoxResult.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Angsana New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 65);
            this.label3.TabIndex = 12;
            this.label3.Text = "ผลลัพธ์";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Angsana New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 65);
            this.label2.TabIndex = 11;
            this.label2.Text = "ส่วนสูง";
            // 
            // textBoxH
            // 
            this.textBoxH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxH.Font = new System.Drawing.Font("Angsana New", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxH.Location = new System.Drawing.Point(171, 12);
            this.textBoxH.Multiline = true;
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(779, 64);
            this.textBoxH.TabIndex = 10;
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCal
            // 
            this.buttonCal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCal.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCal.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCal.Font = new System.Drawing.Font("Angsana New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCal.Location = new System.Drawing.Point(956, 12);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(225, 203);
            this.buttonCal.TabIndex = 9;
            this.buttonCal.Text = "คำนวณ";
            this.buttonCal.UseVisualStyleBackColor = false;
            this.buttonCal.Click += new System.EventHandler(this.ButtonCal_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Angsana New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "น้ำหนัก";
            // 
            // textBoxW
            // 
            this.textBoxW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxW.Font = new System.Drawing.Font("Angsana New", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxW.Location = new System.Drawing.Point(171, 81);
            this.textBoxW.Multiline = true;
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(779, 64);
            this.textBoxW.TabIndex = 14;
            this.textBoxW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxR.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBoxR.Font = new System.Drawing.Font("Angsana New", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR.Location = new System.Drawing.Point(171, 151);
            this.textBoxR.Multiline = true;
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(779, 64);
            this.textBoxR.TabIndex = 15;
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 576);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calBMI";
            this.Text = "calBMI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalBMI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxR;
    }
}