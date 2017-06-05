using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;

namespace OAuthVk.Core.Exception
{
  // TODO: ПЕреписать Exception!!!!!
  public class RequestException : System.Exception
  {
    public override string Message
    {
      get
      {
        var strError = $"{Number}: {base.Message}";

        if (!string.IsNullOrEmpty(MethodError))
        {
          strError = $"{strError}; Method: {MethodError}";
        }

        if (!string.IsNullOrEmpty(UserId))
        {
          strError = $"{strError}; UserId: {UserId}";
        }

        return strError;
      }
    }

    public string Number { get; }

    public string MethodError { get; }

    public string VersionApi { get; }

    public string UserId { get; }

    /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
    public RequestException( System.Exception innerException, string errorNumber, string message, ICollection<KeyValuePair<string, string>> requestParams = null)
      : base(message, innerException)
    {
      if (string.IsNullOrEmpty(errorNumber))
      {
        errorNumber = "ER-1";
      }

      Number = errorNumber;

      if (requestParams == null)
        return;

      var dictionary = requestParams.ToDictionary(k => k.Key, v => v.Value);

      MethodError = dictionary["method"];
      VersionApi = dictionary["v"];
      UserId = dictionary["uid"];
    }

    /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
    public RequestException(string errorNumber, string message)
      : this((System.Exception)null, errorNumber, message)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
    public RequestException(ICollection<KeyValuePair<string, string>> requestParams)
      : this((System.Exception)null, null, null, requestParams)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
    public RequestException(string message)
      : this((System.Exception) null, null, message)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
    public RequestException(string errorNumber, string message, ICollection<KeyValuePair<string, string>> requestParams)
      : this((System.Exception)null, errorNumber, message, requestParams)
    {
    }
  }
}