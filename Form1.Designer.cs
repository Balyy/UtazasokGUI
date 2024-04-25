
namespace UtazasokGUI
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewUtazas = new System.Windows.Forms.DataGridView();
            this.openFileDialogUtazas = new System.Windows.Forms.OpenFileDialog();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxOrszag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHonap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHossz = new System.Windows.Forms.TextBox();
            this.Hossz = new System.Windows.Forms.Label();
            this.textBoxNap = new System.Windows.Forms.TextBox();
            this.Nap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEllatas = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtazas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridViewUtazas
            // 
            this.dataGridViewUtazas.AllowUserToAddRows = false;
            this.dataGridViewUtazas.AllowUserToDeleteRows = false;
            this.dataGridViewUtazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtazas.Location = new System.Drawing.Point(173, 27);
            this.dataGridViewUtazas.Name = "dataGridViewUtazas";
            this.dataGridViewUtazas.ReadOnly = true;
            this.dataGridViewUtazas.Size = new System.Drawing.Size(627, 424);
            this.dataGridViewUtazas.TabIndex = 1;
            this.dataGridViewUtazas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUtazas_CellContentClick);
            // 
            // openFileDialogUtazas
            // 
            this.openFileDialogUtazas.FileName = "openFileDialogUtazas";
            this.openFileDialogUtazas.Filter = "Text files|*.txt*|All files|*.*";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(16, 45);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 3;
            this.textBoxId.Text = "0";
            // 
            // textBoxOrszag
            // 
            this.textBoxOrszag.Location = new System.Drawing.Point(16, 85);
            this.textBoxOrszag.Name = "textBoxOrszag";
            this.textBoxOrszag.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrszag.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ország";
            // 
            // textBoxHonap
            // 
            this.textBoxHonap.Location = new System.Drawing.Point(16, 125);
            this.textBoxHonap.Name = "textBoxHonap";
            this.textBoxHonap.Size = new System.Drawing.Size(100, 20);
            this.textBoxHonap.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hónap";
            // 
            // textBoxHossz
            // 
            this.textBoxHossz.Location = new System.Drawing.Point(16, 205);
            this.textBoxHossz.Name = "textBoxHossz";
            this.textBoxHossz.Size = new System.Drawing.Size(100, 20);
            this.textBoxHossz.TabIndex = 11;
            // 
            // Hossz
            // 
            this.Hossz.AutoSize = true;
            this.Hossz.Location = new System.Drawing.Point(13, 188);
            this.Hossz.Name = "Hossz";
            this.Hossz.Size = new System.Drawing.Size(36, 13);
            this.Hossz.TabIndex = 10;
            this.Hossz.Text = "Hossz";
            // 
            // textBoxNap
            // 
            this.textBoxNap.Location = new System.Drawing.Point(16, 165);
            this.textBoxNap.Name = "textBoxNap";
            this.textBoxNap.Size = new System.Drawing.Size(100, 20);
            this.textBoxNap.TabIndex = 9;
            // 
            // Nap
            // 
            this.Nap.AutoSize = true;
            this.Nap.Location = new System.Drawing.Point(13, 148);
            this.Nap.Name = "Nap";
            this.Nap.Size = new System.Drawing.Size(27, 13);
            this.Nap.TabIndex = 8;
            this.Nap.Text = "Nap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ellátás";
            // 
            // textBoxAr
            // 
            this.textBoxAr.Location = new System.Drawing.Point(16, 245);
            this.textBoxAr.Name = "textBoxAr";
            this.textBoxAr.Size = new System.Drawing.Size(100, 20);
            this.textBoxAr.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ár";
            // 
            // comboBoxEllatas
            // 
            this.comboBoxEllatas.FormattingEnabled = true;
            this.comboBoxEllatas.Items.AddRange(new object[] {
            "reggeli",
            "félpanzió",
            "all inclusive"});
            this.comboBoxEllatas.Location = new System.Drawing.Point(16, 285);
            this.comboBoxEllatas.Name = "comboBoxEllatas";
            this.comboBoxEllatas.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEllatas.TabIndex = 15;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(16, 312);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxEllatas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHossz);
            this.Controls.Add(this.Hossz);
            this.Controls.Add(this.textBoxNap);
            this.Controls.Add(this.Nap);
            this.Controls.Add(this.textBoxHonap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrszag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUtazas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtazas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewUtazas;
        private System.Windows.Forms.OpenFileDialog openFileDialogUtazas;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxOrszag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHonap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHossz;
        private System.Windows.Forms.Label Hossz;
        private System.Windows.Forms.TextBox textBoxNap;
        private System.Windows.Forms.Label Nap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEllatas;
        private System.Windows.Forms.Button buttonSave;
    }
}

