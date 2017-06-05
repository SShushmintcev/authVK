using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OAuthVk.Core;
using OAuthVk.Core.Exception;

namespace OAuthVk.Model.Accessor
{
  // TODO: Нужно как-то сюда передавать Версию и Токен
  public class BaseAccessor
  {
    protected static readonly CultureInfo CurrentCulture = CultureInfo.CurrentCulture;

    protected async Task<T> CallAsync<T>(string method, Dictionary<string, string> dictionary)
    {
      using (var httpClient = new HttpClient())
      {
        httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        httpClient.DefaultRequestHeaders.Add("Accept-Language", CurrentCulture.Name);

        var users = await httpClient.PostAsync(new Uri($"https://api.vk.com/method/{method}"), LoadEncodedContent(dictionary));

        var jObject = JObject.Parse(await users.Content.ReadAsStringAsync());

        if (jObject["error"] == null)
          return JsonConvert.DeserializeObject<T>(jObject["response"].ToString());

        var error = JsonConvert.DeserializeObject<Error>(jObject["error"].ToString());

        // TODO: Наверное нужно передавать оригинальное сообщение?
        var message = Errors.ResourceManager.GetString($"ER{error.Code}") ?? Errors.ER1;

        //var message = string.IsNullOrEmpty(Errors.ResourceManager.GetString($"ER{error.Code}"))
        //  ? Errors.ER1 // TODO: Наверное нужно передавать оригинальное сообщение?
        //  : Errors.ResourceManager.GetString($"ER{error.Code}");

        throw new RequestException($"ER-{error.Code}", message, error.Params);
      }
    }

    protected FormUrlEncodedContent LoadEncodedContent(Dictionary<string, string> dictionary)
    {
      var formUrlClient = new FormUrlEncodedContent(dictionary);
      formUrlClient.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
      formUrlClient.Headers.ContentLanguage.Add(CurrentCulture.Name);

      return formUrlClient;
    }
  }
}