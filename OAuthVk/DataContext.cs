using System;
using System.Linq;
using System.Threading.Tasks;
using OAuthVk.Core;
using OAuthVk.Core.Enums;
using OAuthVk.Model.Accessor;

namespace OAuthVk
{
  public class DataContext
  {
    /// <summary>
    /// Ключ доступа к API.
    /// </summary>
    public string AuthToken { get; private set; }

    /// <summary>
    /// Время жизни <see cref="AuthToken"/> в секундах.
    /// </summary>
    public int Expire { get; private set; }

    /// <summary>
    /// Идентификатор авторизовавшегося пользователя.
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Email авторизовавшегося пользователя (Опционально).
    /// </summary>
    public string Mail { get; private set; }

    /// <summary>
    /// Hash авторизации.
    /// </summary>
    public string Hash { get; private set; }

    /// <summary>
    /// Версия API vk.com
    /// </summary>
    private const string Version = "5.64";

    public DataContext(Uri authUrl, string qHash)
    {
      if (authUrl == null)
      {
        throw new Exception();
      }

      Hash = qHash;

      LoadAccessToken(authUrl);

      // TODO: ????
      //Model = new DataModelRequest();

    }

    public IDataModelRequest Model { get; }

    public void TestMethod()
    {
      var a = new AccountAccessor();

     // var t = Task.Run(() => a.registerDevice())

      //var t = new AdminAccessor();
      //var wer = Task.Run(() => t.GetAccessSettingsAsync(UserId, "", Version)).ListModel;

      //var m = new MessageAccessor();
    }


    /// <summary>
    /// Парсит токен авторизации из ответа сервера.
    /// </summary>
    /// <param name="uri">Url у котором содержится токен.</param>
    private void LoadAccessToken(Uri uri)
    {
      uri.Fragment.Substring(1).Split('&').ToList().ForEach(i =>
      {
        var str = i.Split('=');

        if (str[0] == "access_token")
        {
          AuthToken = str[1];
        }

        if (str[0] == "expires_in")
        {
          Expire = Convert.ToInt32(str[1]);
        }

        if (str[0] == "user_id")
        {
          UserId = Convert.ToInt32(str[1]);
        }

        if (str[0] == "email")
        {
          Mail = Convert.ToString(str[1]);
        }
      });
    }
  }
}