namespace ScriptLauncher
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
            button1 = new Button();
            button2 = new Button();
            tabControl = new TabControl();
            SysAdminTools = new TabPage();
            QualysTools = new TabPage();
            tabControl.SuspendLayout();
            SysAdminTools.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 6);
            button1.Name = "button1";
            button1.Size = new Size(197, 29);
            button1.TabIndex = 0;
            button1.Text = "Get \"Enabled\" AD Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += get_EnabledADUSers;
            // 
            // button2
            // 
            button2.Location = new Point(0, 41);
            button2.Name = "button2";
            button2.Size = new Size(197, 29);
            button2.TabIndex = 1;
            button2.Text = "Get AD Servers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += get_ADServers;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(SysAdminTools);
            tabControl.Controls.Add(QualysTools);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(444, 448);
            tabControl.TabIndex = 2;
            // 
            // SysAdminTools
            // 
            SysAdminTools.Controls.Add(button1);
            SysAdminTools.Controls.Add(button2);
            SysAdminTools.Location = new Point(4, 29);
            SysAdminTools.Name = "SysAdminTools";
            SysAdminTools.Padding = new Padding(3);
            SysAdminTools.Size = new Size(436, 415);
            SysAdminTools.TabIndex = 0;
            SysAdminTools.Text = "System Admin";
            SysAdminTools.UseVisualStyleBackColor = true;
            // 
            // QualysTools
            // 
            QualysTools.Location = new Point(4, 29);
            QualysTools.Name = "QualysTools";
            QualysTools.Padding = new Padding(3);
            QualysTools.Size = new Size(436, 415);
            QualysTools.TabIndex = 1;
            QualysTools.Text = "Qualys";
            QualysTools.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 448);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Script Launcher";
            tabControl.ResumeLayout(false);
            SysAdminTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TabControl tabControl;
        private TabPage SysAdminTools;
        private TabPage QualysTools;
    }
}
