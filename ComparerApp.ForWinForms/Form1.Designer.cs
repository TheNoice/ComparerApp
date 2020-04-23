namespace ComparerApp.ForWinForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersus = new System.Windows.Forms.Label();
            this.labelNameLeft = new System.Windows.Forms.Label();
            this.labelNameRight = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullRestartToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fullRestartToolStripMenuItem
            // 
            this.fullRestartToolStripMenuItem.Name = "fullRestartToolStripMenuItem";
            this.fullRestartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fullRestartToolStripMenuItem.Text = "Full Restart";
            this.fullRestartToolStripMenuItem.Click += new System.EventHandler(this.fullRestartToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(603, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(469, 461);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.AnyPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 461);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.AnyPictureBox_Click);
            // 
            // labelVersus
            // 
            this.labelVersus.AutoSize = true;
            this.labelVersus.Font = new System.Drawing.Font("Candara", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersus.ForeColor = System.Drawing.Color.Coral;
            this.labelVersus.Location = new System.Drawing.Point(487, 267);
            this.labelVersus.Name = "labelVersus";
            this.labelVersus.Size = new System.Drawing.Size(110, 91);
            this.labelVersus.TabIndex = 3;
            this.labelVersus.Text = "Vs";
            // 
            // labelNameLeft
            // 
            this.labelNameLeft.AutoSize = true;
            this.labelNameLeft.Font = new System.Drawing.Font("Candara", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameLeft.Location = new System.Drawing.Point(167, 40);
            this.labelNameLeft.Name = "labelNameLeft";
            this.labelNameLeft.Size = new System.Drawing.Size(230, 41);
            this.labelNameLeft.TabIndex = 4;
            this.labelNameLeft.Text = "labelNameLeft";
            // 
            // labelNameRight
            // 
            this.labelNameRight.AutoSize = true;
            this.labelNameRight.Font = new System.Drawing.Font("Candara", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameRight.Location = new System.Drawing.Point(771, 40);
            this.labelNameRight.Name = "labelNameRight";
            this.labelNameRight.Size = new System.Drawing.Size(248, 41);
            this.labelNameRight.TabIndex = 5;
            this.labelNameRight.Text = "labelNameRight";
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStage.Location = new System.Drawing.Point(499, 24);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(107, 24);
            this.labelStage.TabIndex = 6;
            this.labelStage.Text = "Stage: Final";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRound.Location = new System.Drawing.Point(475, 55);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(146, 22);
            this.labelRound.TabIndex = 7;
            this.labelRound.Text = "Round: 1 out of 16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 567);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.labelStage);
            this.Controls.Add(this.labelNameRight);
            this.Controls.Add(this.labelNameLeft);
            this.Controls.Add(this.labelVersus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVersus;
        private System.Windows.Forms.Label labelNameLeft;
        private System.Windows.Forms.Label labelNameRight;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelRound;
    }
}

