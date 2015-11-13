using System;
using System.Xml;
using HtaConverter.Options;
using HtmlAgilityPack;

namespace HtaConverter.Web
{
  public class HtaParser
  {
    private HtmlDocument _hta = new HtmlDocument();
    private String _html;
    private String _baseUrl;
    private XmlNode _htaHeader;

    private Uri _url;
  
    public String Hta {get { return _hta.DocumentNode.OuterHtml; }}
    //constructor
    public HtaParser(HtaOptions htaops, String html, String baseUrl)
    {
      _html = html;
      _baseUrl = baseUrl;
      _hta.LoadHtml(_html);
      _HtaHeader(htaops);
      _HtaStyles(htaops);
      _HtaScripts(htaops);
      _FixUrls();
    }
    //to fix broken links
    private void _FixUrls()
    {
      _url = new Uri(_baseUrl);
      foreach (HtmlNode script in _hta.DocumentNode.SelectNodes("//script"))
      {
        if (script.Attributes.Contains("src") && script.Id != "local")
        {
           Uri srcUri = new Uri(script.Attributes["src"].Value, UriKind.RelativeOrAbsolute);
          if (!srcUri.IsAbsoluteUri)
          {
            Uri newUri = new Uri(_url,srcUri);
            script.Attributes["src"].Value = newUri.ToString();
          }
        }
      }
      foreach (HtmlNode link in _hta.DocumentNode.SelectNodes("//link"))
      {
        if (link.Attributes.Contains("href") && link.Id != "local")
        {
          Uri srcUri = new Uri(link.Attributes["href"].Value,UriKind.RelativeOrAbsolute);
          if (!srcUri.IsAbsoluteUri)
          {
            Uri newUri = new Uri(_url, srcUri);
            link.Attributes["href"].Value = newUri.ToString();
          }
        }
      }
      foreach (HtmlNode a in _hta.DocumentNode.SelectNodes("//a"))
      {
        if (a.Attributes.Contains("href"))
        {
          Uri srcUri = new Uri(a.Attributes["href"].Value, UriKind.RelativeOrAbsolute);
          if (!srcUri.IsAbsoluteUri)
          {
            Uri newUri = new Uri(_url, srcUri);
            a.Attributes["href"].Value = newUri.ToString();
          }
        }
      }
      foreach (HtmlNode img in _hta.DocumentNode.SelectNodes("//img"))
      {
        if (img.Attributes.Contains("src"))
        {
          Uri srcUri = new Uri(img.Attributes["src"].Value, UriKind.RelativeOrAbsolute);
          if (!srcUri.IsAbsoluteUri)
          {
            Uri newUri = new Uri(_url, srcUri);
            img.Attributes["src"].Value = newUri.ToString();
          }
        }
      }
      foreach (HtmlNode form in _hta.DocumentNode.SelectNodes("//form"))
      {
        if (form.Attributes.Contains("action"))
        {
          Uri srcUri = new Uri(form.Attributes["action"].Value, UriKind.RelativeOrAbsolute);
          if (!srcUri.IsAbsoluteUri)
          {
            Uri newUri = new Uri(_url, srcUri);
            form.Attributes["action"].Value = newUri.ToString();
          }
        }
      }
    }
    //add local scripts.
    private void _HtaScripts(HtaOptions htaops)
    {
      if (htaops.LocalJavaScript)
      {
        HtmlNode jscriptElement = _hta.CreateElement("script");
        jscriptElement.SetAttributeValue("id", "local");
        jscriptElement.SetAttributeValue("language", "Javascript");
        jscriptElement.SetAttributeValue("src", "scripts/main.js");
        HtmlNode headNode = _hta.DocumentNode.SelectSingleNode("//head");
        headNode.AppendChild(jscriptElement.Clone());
      }

      if (htaops.LocalVbScript)
      {
        HtmlNode vScriptElement = _hta.CreateElement("script");
        vScriptElement.SetAttributeValue("id", "local");
        vScriptElement.SetAttributeValue("language", "VBScript");
        vScriptElement.SetAttributeValue("src", "scripts/main.vbs");
        HtmlNode headNode = _hta.DocumentNode.SelectSingleNode("//head");
        headNode.AppendChild(vScriptElement.Clone());
      }

    }
    //add a local stylsheet.
    private void _HtaStyles(HtaOptions htaops)
    {
      if (htaops.LocalStyleSheet)
      {
        HtmlNode styleElement = _hta.CreateElement("link");
        styleElement.SetAttributeValue("id", "local");
        styleElement.SetAttributeValue("rel", "stylesheet");
        styleElement.SetAttributeValue("type", "text/css");
        styleElement.SetAttributeValue("href", "styles/theme.css");
        HtmlNode headNode = _hta.DocumentNode.SelectSingleNode("//head");
        headNode.AppendChild(styleElement.Clone());

      }
    }
    //add hta:application header.
    private void _HtaHeader(HtaOptions htaops)
    {
      
      HtmlNode htaElement = _hta.CreateElement("HTA:APPLICATION");
      htaElement.SetAttributeValue("id", htaops.Id);
      htaElement.SetAttributeValue("AppName", htaops.AppName);
      htaElement.SetAttributeValue("border", htaops.Border);
      htaElement.SetAttributeValue("borderStyle", htaops.BorderStyle);
      htaElement.SetAttributeValue("showInTaskbar", htaops.ShowInTaskBar);
      htaElement.SetAttributeValue("sysMenu", htaops.SysMenu);
      //add hta tag to html string.
      HtmlNode headNode = _hta.DocumentNode.SelectSingleNode("//head");
      headNode.AppendChild(htaElement.Clone());

    }
  }
}
