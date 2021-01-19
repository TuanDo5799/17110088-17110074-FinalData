namespace CARO
{
    partial class Form1
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
            this.panelchessboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureAVATARcaro = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtboxStep = new System.Windows.Forms.TextBox();
            this.txtboxLoseGame = new System.Windows.Forms.TextBox();
            this.txtboxWingame = new System.Windows.Forms.TextBox();
            this.prchcooldown = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureboxTeam = new System.Windows.Forms.PictureBox();
            this.textboxPLname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeCoolD = new System.Windows.Forms.Timer(this.components);
            this.cOLORSETTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHESSBOARDCOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHESSCOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAVATARcaro)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTeam)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelchessboard
            // 
            this.panelchessboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelchessboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelchessboard.Location = new System.Drawing.Point(0, 31);
            this.panelchessboard.Name = "panelchessboard";
            this.panelchessboard.Size = new System.Drawing.Size(764, 634);
            this.panelchessboard.TabIndex = 0;
            this.panelchessboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchessboard_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureAVATARcaro);
            this.panel2.Location = new System.Drawing.Point(762, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 346);
            this.panel2.TabIndex = 1;
            // 
            // PictureAVATARcaro
            // 
            this.PictureAVATARcaro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureAVATARcaro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureAVATARcaro.BackgroundImage = global::CARO.Properties.Resources.caro2;
            this.PictureAVATARcaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureAVATARcaro.ErrorImage = null;
            this.PictureAVATARcaro.Location = new System.Drawing.Point(0, 0);
            this.PictureAVATARcaro.Name = "PictureAVATARcaro";
            this.PictureAVATARcaro.Size = new System.Drawing.Size(346, 345);
            this.PictureAVATARcaro.TabIndex = 0;
            this.PictureAVATARcaro.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Controls.Add(this.txtboxStep);
            this.panel3.Controls.Add(this.txtboxLoseGame);
            this.panel3.Controls.Add(this.txtboxWingame);
            this.panel3.Controls.Add(this.prchcooldown);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureboxTeam);
            this.panel3.Controls.Add(this.textboxPLname);
            this.panel3.Location = new System.Drawing.Point(764, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 307);
            this.panel3.TabIndex = 2;
            // 
            // txtboxStep
            // 
            this.txtboxStep.Location = new System.Drawing.Point(-2, 93);
            this.txtboxStep.Name = "txtboxStep";
            this.txtboxStep.Size = new System.Drawing.Size(175, 22);
            this.txtboxStep.TabIndex = 9;
            // 
            // txtboxLoseGame
            // 
            this.txtboxLoseGame.Location = new System.Drawing.Point(-2, 65);
            this.txtboxLoseGame.Name = "txtboxLoseGame";
            this.txtboxLoseGame.Size = new System.Drawing.Size(175, 22);
            this.txtboxLoseGame.TabIndex = 8;
            // 
            // txtboxWingame
            // 
            this.txtboxWingame.Location = new System.Drawing.Point(-2, 37);
            this.txtboxWingame.Name = "txtboxWingame";
            this.txtboxWingame.Size = new System.Drawing.Size(175, 22);
            this.txtboxWingame.TabIndex = 7;
            // 
            // prchcooldown
            // 
            this.prchcooldown.Location = new System.Drawing.Point(-2, 121);
            this.prchcooldown.Name = "prchcooldown";
            this.prchcooldown.Size = new System.Drawing.Size(175, 23);
            this.prchcooldown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Have a good time to play";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureboxTeam
            // 
            this.pictureboxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxTeam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureboxTeam.Location = new System.Drawing.Point(176, 3);
            this.pictureboxTeam.Name = "pictureboxTeam";
            this.pictureboxTeam.Size = new System.Drawing.Size(164, 141);
            this.pictureboxTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxTeam.TabIndex = 2;
            this.pictureboxTeam.TabStop = false;
            // 
            // textboxPLname
            // 
            this.textboxPLname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPLname.Location = new System.Drawing.Point(0, 9);
            this.textboxPLname.Name = "textboxPLname";
            this.textboxPLname.ReadOnly = true;
            this.textboxPLname.Size = new System.Drawing.Size(173, 22);
            this.textboxPLname.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aBOUTGAMEToolStripMenuItem,
            this.cOLORSETTINGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem.Text = "MENU";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aBOUTGAMEToolStripMenuItem
            // 
            this.aBOUTGAMEToolStripMenuItem.Name = "aBOUTGAMEToolStripMenuItem";
            this.aBOUTGAMEToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.aBOUTGAMEToolStripMenuItem.Text = "ABOUT GAME";
            this.aBOUTGAMEToolStripMenuItem.Click += new System.EventHandler(this.aBOUTGAMEToolStripMenuItem_Click);
            // 
            // TimeCoolD
            // 
            this.TimeCoolD.Tick += new System.EventHandler(this.TimeCoolD_Tick);
            // 
            // cOLORSETTINGToolStripMenuItem
            // 
            this.cOLORSETTINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHESSBOARDCOLORToolStripMenuItem,
            this.cHESSCOLORToolStripMenuItem});
            this.cOLORSETTINGToolStripMenuItem.Name = "cOLORSETTINGToolStripMenuItem";
            this.cOLORSETTINGToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.cOLORSETTINGToolStripMenuItem.Text = "COLOR SETTING";
            // 
            // cHESSBOARDCOLORToolStripMenuItem
            // 
            this.cHESSBOARDCOLORToolStripMenuItem.Name = "cHESSBOARDCOLORToolStripMenuItem";
            this.cHESSBOARDCOLORToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.cHESSBOARDCOLORToolStripMenuItem.Text = "CHESSBOARD COLOR";
            this.cHESSBOARDCOLORToolStripMenuItem.Click += new System.EventHandler(this.cHESSBOARDCOLORToolStripMenuItem_Click);
            // 
            // cHESSCOLORToolStripMenuItem
            // 
            this.cHESSCOLORToolStripMenuItem.Name = "cHESSCOLORToolStripMenuItem";
            this.cHESSCOLORToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.cHESSCOLORToolStripMenuItem.Text = "CHESS COLOR";
            this.cHESSCOLORToolStripMenuItem.Click += new System.EventHandler(this.cHESSCOLORToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelchessboard);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Caro Team OOP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureAVATARcaro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTeam)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelchessboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PictureAVATARcaro;
        private System.Windows.Forms.PictureBox pictureboxTeam;
        private System.Windows.Forms.TextBox textboxPLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer TimeCoolD;
        private System.Windows.Forms.ProgressBar prchcooldown;
        private System.Windows.Forms.TextBox txtboxStep;
        private System.Windows.Forms.TextBox txtboxLoseGame;
        private System.Windows.Forms.TextBox txtboxWingame;
        private System.Windows.Forms.ToolStripMenuItem aBOUTGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORSETTINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHESSBOARDCOLORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHESSCOLORToolStripMenuItem;
    }
}

