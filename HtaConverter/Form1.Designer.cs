namespace HtaConverter
{
  partial class FrmHtaConverter
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
      this.btnBrowse = new System.Windows.Forms.Button();
      this.txtFolder = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.btnConvert = new System.Windows.Forms.Button();
      this.chkExtraFolders = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // btnBrowse
      // 
      this.btnBrowse.Location = new System.Drawing.Point(12, 12);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(75, 23);
      this.btnBrowse.TabIndex = 0;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // txtFolder
      // 
      this.txtFolder.Location = new System.Drawing.Point(93, 12);
      this.txtFolder.Name = "txtFolder";
      this.txtFolder.ReadOnly = true;
      this.txtFolder.Size = new System.Drawing.Size(562, 20);
      this.txtFolder.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 51);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Web Address:";
      // 
      // txtURL
      // 
      this.txtURL.Location = new System.Drawing.Point(93, 48);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(562, 20);
      this.txtURL.TabIndex = 3;
      // 
      // btnConvert
      // 
      this.btnConvert.Location = new System.Drawing.Point(15, 132);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(75, 23);
      this.btnConvert.TabIndex = 6;
      this.btnConvert.Text = "Convert";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // chkExtraFolders
      // 
      this.chkExtraFolders.AutoSize = true;
      this.chkExtraFolders.Location = new System.Drawing.Point(15, 89);
      this.chkExtraFolders.Name = "chkExtraFolders";
      this.chkExtraFolders.Size = new System.Drawing.Size(210, 17);
      this.chkExtraFolders.TabIndex = 7;
      this.chkExtraFolders.Text = "Create a local Scripts and Styles Folder";
      this.chkExtraFolders.UseVisualStyleBackColor = true;
      // 
      // FrmHtaConverter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(667, 181);
      this.Controls.Add(this.chkExtraFolders);
      this.Controls.Add(this.btnConvert);
      this.Controls.Add(this.txtURL);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtFolder);
      this.Controls.Add(this.btnBrowse);
      this.Name = "FrmHtaConverter";
      this.Text = "HTA-Converter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.TextBox txtFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtURL;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.CheckBox chkExtraFolders;
  }
}

