﻿namespace Ewok.Machine.Emu {
    partial class FrmMemoryMap {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1=new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize=true;
            this.label1.BackColor=System.Drawing.Color.LightGreen;
            this.label1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor=System.Drawing.Color.Black;
            this.label1.Location=new System.Drawing.Point(12,9);
            this.label1.Name="label1";
            this.label1.Size=new System.Drawing.Size(21,15);
            this.label1.TabIndex=0;
            this.label1.Text="FF";
            // 
            // FrmMemoryMap
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(6F,13F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize=new System.Drawing.Size(559,478);
            this.Controls.Add(this.label1);
            this.Name="FrmMemoryMap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}