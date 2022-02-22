namespace RCloneTray
{
    partial class frmRCloneTray
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRCloneTray));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMountRemote1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMountRemote2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMountRemote3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnmount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnmountRemote1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnmountRemote2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnmountRemote3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenRCloneConfigDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenRCloneTrayDir = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RCloneTray";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMount,
            this.tsmiUnmount,
            this.tsmiOpenRCloneTrayDir,
            this.tsmiOpenRCloneConfigDir,
            this.tsmiAbout,
            this.tsmiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 158);
            this.contextMenuStrip1.Text = "RCloneTray";
            // 
            // tsmiMount
            // 
            this.tsmiMount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMountRemote1,
            this.tsmiMountRemote2,
            this.tsmiMountRemote3});
            this.tsmiMount.Name = "tsmiMount";
            this.tsmiMount.Size = new System.Drawing.Size(198, 22);
            this.tsmiMount.Text = "Mount";
            // 
            // tsmiMountRemote1
            // 
            this.tsmiMountRemote1.Enabled = false;
            this.tsmiMountRemote1.Name = "tsmiMountRemote1";
            this.tsmiMountRemote1.Size = new System.Drawing.Size(127, 22);
            this.tsmiMountRemote1.Text = "[unset #1]";
            this.tsmiMountRemote1.Click += new System.EventHandler(this.tsmiMountRemote1_Click);
            // 
            // tsmiMountRemote2
            // 
            this.tsmiMountRemote2.Enabled = false;
            this.tsmiMountRemote2.Name = "tsmiMountRemote2";
            this.tsmiMountRemote2.Size = new System.Drawing.Size(127, 22);
            this.tsmiMountRemote2.Text = "[unset #2]";
            this.tsmiMountRemote2.Click += new System.EventHandler(this.tsmiMountRemote2_Click);
            // 
            // tsmiMountRemote3
            // 
            this.tsmiMountRemote3.Enabled = false;
            this.tsmiMountRemote3.Name = "tsmiMountRemote3";
            this.tsmiMountRemote3.Size = new System.Drawing.Size(127, 22);
            this.tsmiMountRemote3.Text = "[unset #3]";
            this.tsmiMountRemote3.Click += new System.EventHandler(this.tsmiMountRemote3_Click);
            // 
            // tsmiUnmount
            // 
            this.tsmiUnmount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUnmountRemote1,
            this.tsmiUnmountRemote2,
            this.tsmiUnmountRemote3});
            this.tsmiUnmount.Name = "tsmiUnmount";
            this.tsmiUnmount.Size = new System.Drawing.Size(198, 22);
            this.tsmiUnmount.Text = "Unmount";
            // 
            // tsmiUnmountRemote1
            // 
            this.tsmiUnmountRemote1.Enabled = false;
            this.tsmiUnmountRemote1.Name = "tsmiUnmountRemote1";
            this.tsmiUnmountRemote1.Size = new System.Drawing.Size(127, 22);
            this.tsmiUnmountRemote1.Text = "[unset #1]";
            this.tsmiUnmountRemote1.Click += new System.EventHandler(this.tsmiUnmountRemote1_Click);
            // 
            // tsmiUnmountRemote2
            // 
            this.tsmiUnmountRemote2.Enabled = false;
            this.tsmiUnmountRemote2.Name = "tsmiUnmountRemote2";
            this.tsmiUnmountRemote2.Size = new System.Drawing.Size(127, 22);
            this.tsmiUnmountRemote2.Text = "[unset #2]";
            this.tsmiUnmountRemote2.Click += new System.EventHandler(this.tsmiUnmountRemote2_Click);
            // 
            // tsmiUnmountRemote3
            // 
            this.tsmiUnmountRemote3.Enabled = false;
            this.tsmiUnmountRemote3.Name = "tsmiUnmountRemote3";
            this.tsmiUnmountRemote3.Size = new System.Drawing.Size(127, 22);
            this.tsmiUnmountRemote3.Text = "[unset #3]";
            this.tsmiUnmountRemote3.Click += new System.EventHandler(this.tsmiUnmountRemote3_Click);
            // 
            // tsmiOpenRCloneConfigDir
            // 
            this.tsmiOpenRCloneConfigDir.Name = "tsmiOpenRCloneConfigDir";
            this.tsmiOpenRCloneConfigDir.Size = new System.Drawing.Size(198, 22);
            this.tsmiOpenRCloneConfigDir.Text = "Open RClone config dir";
            this.tsmiOpenRCloneConfigDir.Click += new System.EventHandler(this.tsmiOpenRCloneConfigDir_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(198, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(198, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiOpenRCloneTrayDir
            // 
            this.tsmiOpenRCloneTrayDir.Name = "tsmiOpenRCloneTrayDir";
            this.tsmiOpenRCloneTrayDir.Size = new System.Drawing.Size(198, 22);
            this.tsmiOpenRCloneTrayDir.Text = "Open RCloneTray dir";
            this.tsmiOpenRCloneTrayDir.Click += new System.EventHandler(this.tsmiOpenRCloneTrayDir_Click);
            // 
            // frmRCloneTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRCloneTray";
            this.Text = "RCloneTray";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiMount;
        private ToolStripMenuItem tsmiUnmount;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiMountRemote1;
        private ToolStripMenuItem tsmiMountRemote2;
        private ToolStripMenuItem tsmiMountRemote3;
        private ToolStripMenuItem tsmiUnmountRemote1;
        private ToolStripMenuItem tsmiUnmountRemote2;
        private ToolStripMenuItem tsmiUnmountRemote3;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripMenuItem tsmiOpenRCloneConfigDir;
        private ToolStripMenuItem tsmiOpenRCloneTrayDir;
    }
}