using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Parser.Html;
using OAuthVk.Core.Enums;

namespace OAuthVk
{
  public class AuthVk
  {
    /// <summary>
    /// Идентификатор приложения.
    /// </summary>
    private readonly int _appId;

    /// <summary>
    /// Url авторизации по умолчанию.
    /// </summary>
    private const string DefaultAuthorizeUrl = "https://oauth.vk.com/authorize";

    /// <summary>
		/// Версия API vk.com.
		/// </summary>
		private const string Version = "5.64";

    /// <summary>
    /// Url редирект.
    /// </summary>
    private readonly string _redirectUrl;

    private string _accessToken = null;
    private int _expireToken = 0; // Указывается в секундах
    private int _userId = 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthVk" /> class.
    /// </summary>
    public AuthVk(int appId, string redirectUrl = null)
    {
      if (!String.IsNullOrEmpty(redirectUrl))
      {
        _redirectUrl = "https://oauth.vk.com/blank.html";
      }

      _appId = appId;
      _redirectUrl = redirectUrl;
    }

    public async Task Authorize(AccessSettings accessSettings, string email, string pass)
    {
      var cookie = new CookieContainer();

      var requestUri = new Uri($"{DefaultAuthorizeUrl}?client_id={_appId}&redirect_uri={_redirectUrl}&scope={accessSettings}&response_type=token&v={Version}");

      var httpMessageHandler = new HttpClientHandler
      {
        UseCookies = true,
        CookieContainer = cookie,
        AllowAutoRedirect = true
      };

      using (HttpClient httpClient = new HttpClient(httpMessageHandler))
      {
        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)");
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));

        HttpResponseMessage response = await httpClient.GetAsync(requestUri);

        var parser = new HtmlParser();
        var html = parser.Parse(await response.Content.ReadAsStringAsync());
        var form = html.Forms.FirstOrDefault();

        requestUri = response.RequestMessage.RequestUri;
        cookie.Add(requestUri, cookie.GetCookies(requestUri));

        var dictionary = LoadContentRequest(form.GetElementsByTagName("input"), email, pass);

        var formUrlClient = new FormUrlEncodedContent(dictionary);
        formUrlClient.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

        response = await httpClient.PostAsync(new Uri(form.Action), formUrlClient);
        //var result = await response.Content.ReadAsStringAsync();

        LoadAccessToken(response.RequestMessage.RequestUri);

        response.Dispose();
      }
    }

    #region Вспомогательные методы

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
          _accessToken = str[1];
        }

        if (str[0] == "expires_in")
        {
          _expireToken = Convert.ToInt32(str[1]);
        }

        if (str[0] == "user_id")
        {
          _userId = Convert.ToInt32(str[1]);
        }
      });
    }

    /// <summary>
    /// Формирует список полей для формы запроса.
    /// </summary>
    /// <param name="collection">Список полей формы авторизации.</param>
    /// <param name="email">Логин пользователя под кем осуществляется авторизация.</param>
    /// <param name="pass">Пароль пользователя под кем осуществляется авторизация.</param>
    /// <returns>Возвращает коллекцию данных для запроса.</returns>
    private Dictionary<string, string> LoadContentRequest(IHtmlCollection<IElement> collection,
      string email, string pass)
    {
      var dictionary = new Dictionary<string, string>();

      foreach (var element in collection.Where(i => i.Attributes["name"] != null))
      {
        var name = element.Attributes["name"].Value;
        var value = element.Attributes["value"] == null ? String.Empty : element.Attributes["value"].Value;

        if (name == "email")
          value = email;

        if (name == "pass")
          value = pass;

        dictionary.Add(name, value);
      }

      return dictionary;
    }

    #endregion
  }
}