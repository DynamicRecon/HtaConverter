namespace HtaConverter
{
  partial class FrmHtaOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.cmbBorder = new System.Windows.Forms.ComboBox();
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.cmbSysMenu = new System.Windows.Forms.ComboBox();
            this.cmbShowInTaskbar = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkLocalJScript = new System.Windows.Forms.CheckBox();
            this.chkLocalStyleSheet = new System.Windows.Forms.CheckBox();
            this.chkLocalVBScript = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNavigable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "App Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Border:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Border Style:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sys Menu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Show In Taskbar:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(349, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Text = "Untitled";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(134, 49);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(349, 20);
            this.txtAppName.TabIndex = 7;
            this.txtAppName.Text = "Untitled";
            // 
            // cmbBorder
            // 
            this.cmbBorder.FormattingEnabled = true;
            this.cmbBorder.Items.AddRange(new object[] {
            "thin",
            "dialog",
            "none",
            "thick"});
            this.cmbBorder.Location = new System.Drawing.Point(134, 72);
            this.cmbBorder.Name = "cmbBorder";
            this.cmbBorder.Size = new System.Drawing.Size(121, 21);
            this.cmbBorder.TabIndex = 8;
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "complex",
            "normal",
            "raised",
            "static",
            "sunken"});
            this.cmbBorderStyle.Location = new System.Drawing.Point(134, 99);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbBorderStyle.TabIndex = 9;
            // 
            // cmbSysMenu
            // 
            this.cmbSysMenu.FormattingEnabled = true;
            this.cmbSysMenu.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cmbSysMenu.Location = new System.Drawing.Point(134, 124);
            this.cmbSysMenu.Name = "cmbSysMenu";
            this.cmbSysMenu.Size = new System.Drawing.Size(121, 21);
            this.cmbSysMenu.TabIndex = 10;
            // 
            // cmbShowInTaskbar
            // 
            this.cmbShowInTaskbar.FormattingEnabled = true;
            this.cmbShowInTaskbar.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cmbShowInTaskbar.Location = new System.Drawing.Point(134, 151);
            this.cmbShowInTaskbar.Name = "cmbShowInTaskbar";
            this.cmbShowInTaskbar.Size = new System.Drawing.Size(121, 21);
            this.cmbShowInTaskbar.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkLocalJScript
            // 
            this.chkLocalJScript.AutoSize = true;
            this.chkLocalJScript.Location = new System.Drawing.Point(330, 77);
            this.chkLocalJScript.Name = "chkLocalJScript";
            this.chkLocalJScript.Size = new System.Drawing.Size(127, 17);
            this.chkLocalJScript.TabIndex = 13;
            this.chkLocalJScript.Text = "Add Local JavaScript";
            this.chkLocalJScript.UseVisualStyleBackColor = true;
            // 
            // chkLocalStyleSheet
            // 
            this.chkLocalStyleSheet.AutoSize = true;
            this.chkLocalStyleSheet.Location = new System.Drawing.Point(329, 124);
            this.chkLocalStyleSheet.Name = "chkLocalStyleSheet";
            this.chkLocalStyleSheet.Size = new System.Drawing.Size(128, 17);
            this.chkLocalStyleSheet.TabIndex = 14;
            this.chkLocalStyleSheet.Text = "Add Local StyleSheet";
            this.chkLocalStyleSheet.UseVisualStyleBackColor = true;
            // 
            // chkLocalVBScript
            // 
            this.chkLocalVBScript.AutoSize = true;
            this.chkLocalVBScript.Location = new System.Drawing.Point(329, 101);
            this.chkLocalVBScript.Name = "chkLocalVBScript";
            this.chkLocalVBScript.Size = new System.Drawing.Size(121, 17);
            this.chkLocalVBScript.TabIndex = 15;
            this.chkLocalVBScript.Text = "Add Local VB Script";
            this.chkLocalVBScript.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Navigable: ";
            // 
            // cmbNavigable
            // 
            this.cmbNavigable.FormattingEnabled = true;
            this.cmbNavigable.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cmbNavigable.Location = new System.Drawing.Point(134, 178);
            this.cmbNavigable.Name = "cmbNavigable";
            this.cmbNavigable.Size = new System.Drawing.Size(121, 21);
            this.cmbNavigable.TabIndex = 17;
            // 
            // FrmHtaOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.cmbNavigable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkLocalVBScript);
            this.Controls.Add(this.chkLocalStyleSheet);
            this.Controls.Add(this.chkLocalJScript);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbShowInTaskbar);
            this.Controls.Add(this.cmbSysMenu);
            this.Controls.Add(this.cmbBorderStyle);
            this.Controls.Add(this.cmbBorder);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHtaOptions";
            this.Text = "HTA File Options";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtAppName;
    private System.Windows.Forms.ComboBox cmbBorder;
    private System.Windows.Forms.ComboBox cmbBorderStyle;
    private System.Windows.Forms.ComboBox cmbSysMenu;
    private System.Windows.Forms.ComboBox cmbShowInTaskbar;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.CheckBox chkLocalJScript;
    private System.Windows.Forms.CheckBox chkLocalStyleSheet;
    private System.Windows.Forms.CheckBox chkLocalVBScript;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNavigable;
    }
}