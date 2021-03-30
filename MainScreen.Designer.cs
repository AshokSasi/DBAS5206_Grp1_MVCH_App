
namespace DBAS5206_GRP1_MVCH
{
    partial class frmMainScreen
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
            this.btnRmUtilRprt = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomUtilizationViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnCloseRprt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRmUtilRprt
            // 
            this.btnRmUtilRprt.Location = new System.Drawing.Point(754, 97);
            this.btnRmUtilRprt.Name = "btnRmUtilRprt";
            this.btnRmUtilRprt.Size = new System.Drawing.Size(120, 36);
            this.btnRmUtilRprt.TabIndex = 0;
            this.btnRmUtilRprt.Text = "Room Utilization Report";
            this.btnRmUtilRprt.UseVisualStyleBackColor = true;
            this.btnRmUtilRprt.Click += new System.EventHandler(this.btnRmUtilRprt_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(323, 47);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(113, 20);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "Welcome User";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(233, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(290, 24);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Mountain View Hospital Database";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Physician Patient Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(794, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(754, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Patient Bill";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(754, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Daily Revenue Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(754, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Physician Display";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(754, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Patient Display";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(754, 349);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 36);
            this.button7.TabIndex = 10;
            this.button7.Text = "Revenue Analysis";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roomUtilizationViewer);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 445);
            this.panel1.TabIndex = 11;
            // 
            // roomUtilizationViewer
            // 
            this.roomUtilizationViewer.ActiveViewIndex = -1;
            this.roomUtilizationViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomUtilizationViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.roomUtilizationViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomUtilizationViewer.Location = new System.Drawing.Point(0, 0);
            this.roomUtilizationViewer.Name = "roomUtilizationViewer";
            this.roomUtilizationViewer.Size = new System.Drawing.Size(717, 445);
            this.roomUtilizationViewer.TabIndex = 0;
            this.roomUtilizationViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.roomUtilizationViewer.Visible = false;
            // 
            // btnCloseRprt
            // 
            this.btnCloseRprt.Enabled = false;
            this.btnCloseRprt.Location = new System.Drawing.Point(754, 391);
            this.btnCloseRprt.Name = "btnCloseRprt";
            this.btnCloseRprt.Size = new System.Drawing.Size(120, 36);
            this.btnCloseRprt.TabIndex = 12;
            this.btnCloseRprt.Text = "Close Report";
            this.btnCloseRprt.UseVisualStyleBackColor = true;
            this.btnCloseRprt.Click += new System.EventHandler(this.btnCloseRprt_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 534);
            this.Controls.Add(this.btnCloseRprt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.btnRmUtilRprt);
            this.Name = "frmMainScreen";
            this.Text = "MainScreen";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRmUtilRprt;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer roomUtilizationViewer;
        private System.Windows.Forms.Button btnCloseRprt;
    }
}