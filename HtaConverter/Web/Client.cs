using System;
using System.IO;
using System.Net;
using System.Text;

namespace HtaConverter.Web
{
    /// <summary>
    /// Client object gets html from website.
    /// </summary>
  class Client
  {
    private String _uri;
    private StreamReader _readStream;
    private Stream _recieveStream;
    private HttpWebRequest _request;
    private HttpWebResponse _response;
    private String _data;

    public String Data { get { return _data; }}
    /// <summary>
    /// Client constuctor establishes connections.
    /// </summary>
    /// <param name="uri"></param>
    public Client(String uri)
    {
      try
      {
        _uri = uri;
        _request = (HttpWebRequest)WebRequest.Create(_uri);
        _response = (HttpWebResponse)_request.GetResponse();
      }
      catch (WebException ex)
      {
        Console.WriteLine("Error Processing Request {0}",ex.Message);
        throw;
      }
    }
    /// <summary>
    /// gets html content.
    /// </summary>
    /// <returns>True if OK. False if not found.</returns>
    public bool Get()
    {
       bool status = false;
       if (_response.StatusCode == HttpStatusCode.OK)
      {
        _recieveStream = _response.GetResponseStream();
        _readStream = null;
        if (_response.CharacterSet == null)
        {
          _readStream = new StreamReader(_recieveStream);
        }
        else
        {
          _readStream = new StreamReader(_recieveStream, Encoding.GetEncoding(_response.CharacterSet));
        }
        _data = _readStream.ReadToEnd();
        _response.Close();
        _readStream.Close();
        status = true;
        
      }
      return status;
    }
    
     
   

  }
}
