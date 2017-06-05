using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model.Accessor
{
  public abstract class AdminAccessor : BaseAccessor
  {
    /// <summary>
    /// Возвращает информацию о доступе к пользовательским данным.
    /// </summary>
    /// <returns>Информация о доступе к пользовательским данным.</returns>
    public Task<AccessSettings> GetAccessSettingsAsync(int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
        {
          {"uid", userId.ToString()},
          {"access_token", authToken},
          {"v", version}
        };

      return CallAsync<AccessSettings>("getUserSettings", dictionary);
    }

    //public Task<bool> checkPhoneAsync()
    //{
    //}

    //public Task<bool> confirmAsync()
    //{
    //}

    //public Task<bool> RestoreAsync()
    //{
    //}

    //public Task<bool> RegistryUserByPhonAsync()
    //{
    //}
  }
}