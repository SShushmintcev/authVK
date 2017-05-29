using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OAuthVk.Core;
using OAuthVk.Model;

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


    public async Task<Result<User>> GetFriendsAsync()
    {
      var culture = CultureInfo.CurrentCulture;

      using (var httpClient = new HttpClient())
      {
        httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        httpClient.DefaultRequestHeaders.Add("Accept-Language", culture.Name);


        var fields = "deactivated," +
                     "hidden," +
                     "about," +
                     "activities," +
                     "bdate," +
                     "blacklisted," +
                     "blacklisted_by_me," +
                     "books," +
                     "can_post," +
                     "can_see_all_posts," +
                     "can_see_audio," +
                     "can_send_friend_request," +
                     "can_write_private_message," +
                     "career," +
                     "city," +
                     "common_count," +
                     "connections," +
                     "contacts," +
                     "counters," +
                     "country," +
                     "crop_photo," +
                     "domain," +
                     "education," +
                     "exports," +
                     //"first_name_{case}," +
                     "followers_count," +
                     "friend_status," +
                     "games," +
                     "has_mobile," +
                     "has_photo," +
                     "home_town," +
                     "interests," +
                     "is_favorite," +
                     "is_friend," +
                     "is_hidden_from_feed," +
                     //"last_name_{case}," +
                     "last_seen," +
                     "lists," +
                     "nickname," +
                     "sex" +
                     "photo_id," +
                     "verified," +
                     "photo_50," +
                     "photo_100," +
                     "photo_200_orig," +
                     "photo_200," +
                     "photo_400_orig," +
                     "photo_max," +
                     "photo_max_orig," +
                     "online," +
                     "site," +
                     "universities," +
                     "schools," +
                     "status," +
                     "occupation," +
                     "relatives," +
                     "relation," +
                     "personal," +
                     "wall_comments," +
                     "music," +
                     "movies," +
                     "tv," +
                     "quotes," +
                     "timezone," +
                     "screen_name," +
                     "maiden_name," +
                     "military";

        var dictionary = new Dictionary<string, string>
            {
              {"user_id", UserId.ToString()},
              {"fields", fields},
              {"count", "15"},
              //{"order", "name"},
              //{"lang", "4"},
              {"https", "1"},
              {"photo_sizes", "1"},
              {"access_token", AuthToken},
              {"v", "5.8"}
            };

        var formUrlClient = new FormUrlEncodedContent(dictionary);
        formUrlClient.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
        formUrlClient.Headers.ContentLanguage.Add(culture.Name);


        //var users = await httpClient.PostAsync(new Uri("https://api.vk.com/method/users.get"), formUrlClient);
        var users = await httpClient.PostAsync(new Uri("https://api.vk.com/method/friends.get"), formUrlClient);

        var response = await users.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<Result<User>>(response);

      }
    }

    public async Task<Result<Message>> GetDialogsAsync()
    {
      var culture = CultureInfo.CurrentCulture;



      using (var httpClient = new HttpClient())
      {
        httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        httpClient.DefaultRequestHeaders.Add("Accept-Language", culture.Name);

        var dictionary = new Dictionary<string, string>
            {
              {"uid", UserId.ToString()},
              //{"fields", fields},
              //{"count", "15"},
              //{"order", "name"},
              //{"lang", "4"},
              //{"https", "1"},
              //{"photo_sizes", "1"},
              {"access_token", AuthToken},
              //{"oauth", AuthToken},
              {"v", Version}
            };

        var formUrlClient = new FormUrlEncodedContent(dictionary);
        formUrlClient.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
        formUrlClient.Headers.ContentLanguage.Add(culture.Name);

        var users = await httpClient.PostAsync(new Uri("https://api.vk.com/method/getUserSettings"), formUrlClient);

        var response = await users.Content.ReadAsStringAsync();

        var jObj = JObject.Parse(response);

      }




      using (var httpClient = new HttpClient())
      {
        httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        httpClient.DefaultRequestHeaders.Add("Accept-Language", culture.Name);

        var dictionary = new Dictionary<string, string>
            {
              //{"user_id", UserId.ToString()},
              //{"fields", fields},
              {"count", "15"},
              //{"order", "name"},
              //{"lang", "4"},
              //{"https", "1"},
              //{"photo_sizes", "1"},
              {"access_token", AuthToken},
              //{"oauth", AuthToken},
              {"v", Version}
            };

        var formUrlClient = new FormUrlEncodedContent(dictionary);
        formUrlClient.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
        formUrlClient.Headers.ContentLanguage.Add(culture.Name);
        //formUrlClient.Headers.Add("access_token", AuthToken);


        //var users = await httpClient.PostAsync(new Uri("https://api.vk.com/method/users.get"), formUrlClient);
        var users = await httpClient.PostAsync(new Uri("https://api.vk.com/method/messages.getDialogs"), formUrlClient);

        var response = await users.Content.ReadAsStringAsync();

        var jObj = JObject.Parse(response);

        

        return JsonConvert.DeserializeObject<Result<Message>>(response);

      }
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