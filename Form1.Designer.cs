
namespace Kursovaya
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miResetGame = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.miGameThree = new System.Windows.Forms.ToolStripMenuItem();
            this.miGameFour = new System.Windows.Forms.ToolStripMenuItem();
            this.miGameFive = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.14837F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.85163F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miResetGame,
            this.miNewGame});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 2;
            // 
            // miResetGame
            // 
            this.miResetGame.Name = "miResetGame";
            this.miResetGame.Size = new System.Drawing.Size(124, 24);
            this.miResetGame.Text = "Сбросить игру";
            // 
            // miNewGame
            // 
            this.miNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGameThree,
            this.miGameFour,
            this.miGameFive});
            this.miNewGame.Name = "miNewGame";
            this.miNewGame.Size = new System.Drawing.Size(184, 24);
            this.miNewGame.Text = "Смешать и начать игру";
            // 
            // miGameThree
            // 
            this.miGameThree.Name = "miGameThree";
            this.miGameThree.Size = new System.Drawing.Size(153, 26);
            this.miGameThree.Text = "Игра 3х3";
            this.miGameThree.Click += new System.EventHandler(this.miGameThree_Click);
            // 
            // miGameFour
            // 
            this.miGameFour.Name = "miGameFour";
            this.miGameFour.Size = new System.Drawing.Size(153, 26);
            this.miGameFour.Text = "Игра 4х4";
            this.miGameFour.Click += new System.EventHandler(this.miGameFour_Click);
            // 
            // miGameFive
            // 
            this.miGameFive.Name = "miGameFive";
            this.miGameFive.Size = new System.Drawing.Size(153, 26);
            this.miGameFive.Text = "Игра 5х5";
            this.miGameFive.Click += new System.EventHandler(this.miGameFive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem miResetGame;
        private System.Windows.Forms.ToolStripMenuItem miNewGame;
        private System.Windows.Forms.ToolStripMenuItem miGameThree;
        private System.Windows.Forms.ToolStripMenuItem miGameFour;
        private System.Windows.Forms.ToolStripMenuItem miGameFive;
    }
}

