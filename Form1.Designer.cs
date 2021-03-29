
namespace DBAS5206_GRP1_MVCH
{
    partial class frmMVCHReport
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
            this.roomUtilizationViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // roomUtilizationViewer
            // 
            this.roomUtilizationViewer.ActiveViewIndex = -1;
            this.roomUtilizationViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomUtilizationViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.roomUtilizationViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomUtilizationViewer.Location = new System.Drawing.Point(0, 0);
            this.roomUtilizationViewer.Name = "roomUtilizationViewer";
            this.roomUtilizationViewer.Size = new System.Drawing.Size(800, 450);
            this.roomUtilizationViewer.TabIndex = 0;
            // 
            // frmMVCHReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomUtilizationViewer);
            this.Name = "frmMVCHReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer roomUtilizationViewer;
    }
}

