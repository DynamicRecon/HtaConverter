using System;
using System.IO;
using System.Windows.Forms;
using HtaConverter.Web;

namespace HtaConverter
{
  public partial class FrmHtaConverter : Form
  {
    public FrmHtaConverter()
    {
      InitializeComponent();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderDlg = new FolderBrowserDialog();
      folderDlg.ShowNewFolderButton = true;
      DialogResult result = folderDlg.ShowDialog();
      if (result == DialogResult.OK)
      {
        txtFolder.Text = folderDlg.SelectedPath;
      }
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
      Directory.SetCurrentDirectory(txtFolder.Text);
      Client cl = new Client(txtURL.Text);

      if (chkExtraFolders.Checked)
      {
        Directory.CreateDirectory("scripts");
        Directory.CreateDirectory("styles");
      }

      bool statusOk = cl.Get();

      if (statusOk || txtURL.Text != "")
      {
        FrmHtaOptions frmops = new FrmHtaOptions();
        frmops.ShowDialog(this);
        var hp = new HtaParser(frmops.FormData,cl.Data,txtURL.Text);
        if (frmops.FormData.LocalJavaScript)
        {
          File.Create("scripts/main.js");
        }
        if (frmops.FormData.LocalVbScript)
        {
          File.Create("scripts/main.vbs");
        }
        if (frmops.FormData.LocalStyleSheet)
        {
          File.Create("styles/theme.css");
        }
        File.WriteAllText(@"default.hta",hp.Hta);
        MessageBox.Show(this, "Process Complete!");
      }
      else
      {
        MessageBox.Show(this, "Page Not Found: Cannot copy!", "404");
      }



    }
  }
}
