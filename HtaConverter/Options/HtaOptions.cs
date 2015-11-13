using System;

namespace HtaConverter.Options
{
    /// <summary>
    /// class stores the HTA:Application Tag options.
    /// </summary>
    public class HtaOptions
    {
    public String Id { get; set; }
    public String AppName { get; set; }
    public String Border { get; set; }
    public String BorderStyle { get; set; }
    public String SysMenu { get; set; }
    public String ShowInTaskBar { get; set; }
    public String Navigable { get; set; }
    public bool LocalJavaScript { get; set; }
    public bool LocalVbScript { get; set; }
    public bool LocalStyleSheet { get; set; }
  }
}
