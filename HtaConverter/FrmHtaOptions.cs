using System;
using System.Windows.Forms;
using HtaConverter.Options;

namespace HtaConverter
{
    /// <summary>
    /// Sets the HTA:Application tag options.
    /// </summary>
  public partial class FrmHtaOptions : Form
  {
    private HtaOptions _ops = new HtaOptions();
    public HtaOptions FormData { get { return _ops; } }

    public FrmHtaOptions()
    {
      InitializeComponent();
      cmbBorder.SelectedIndex = 0;
      cmbBorderStyle.SelectedIndex = 0;
      cmbShowInTaskbar.SelectedIndex = 0;
      cmbSysMenu.SelectedIndex = 0;
      cmbNavigable.SelectedIndex = 0;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      _ops.Id = txtId.Text;
      _ops.AppName = txtAppName.Text;
      _ops.Border = cmbBorder.Text;
      _ops.BorderStyle = cmbBorderStyle.Text;
      _ops.ShowInTaskBar = cmbShowInTaskbar.Text;
      _ops.SysMenu = cmbSysMenu.Text;
      _ops.Navigable = cmbNavigable.Text;

      _ops.LocalJavaScript = chkLocalJScript.Checked;
      _ops.LocalVbScript = chkLocalVBScript.Checked;
      _ops.LocalStyleSheet = chkLocalStyleSheet.Checked;

      Close();
    }



   
  }
}
