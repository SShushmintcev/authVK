using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthVk.Core;
using OAuthVk.Core.Enums;
using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Accessor
{
  public class AccountAccessor : BaseAccessor
  {
    /// <summary>
    /// Добавляет пользователя в черный список.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя, которого необходимо включить в беседу.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> BlockUserAsync(int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
        {
          { "user_id", userId.ToString()},
          {"access_token", authToken},
          {"v", version}
        };

      return CallAsync<bool>("account.banUser", dictionary);
    }

    /// <summary>
    /// Позволяет сменить пароль пользователя после успешного 
    /// восстановления доступа к аккаунту через СМС, используя метод <see cref="AdminAccessor.RestoreAsync"/>.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Возвращает новый токен.</returns>
    public Task<string> ChangePasswordAsync(IPasswordFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"restore_sid", filter.sessionId},
        {"change_password_hash", filter.hash},
        {"old_password", filter.oldPassword},
        {"new_password", filter.newPassword},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<string>("account.changePassword", dictionary);
    }

    /// <summary>
    /// Возвращает список активных рекламных предложений (офферов),
    /// выполнив которые пользователь сможет получить соответствующее
    /// количество голосов на свой счёт внутри приложения.
    /// </summary>
    /// <param name="offset">смещение, необходимое для выборки определенного подмножества офферов.</param>
    /// <param name="count">Количество, которое необходимо получить.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <remarks>По умолчанию 100, максимальное значение 100.</remarks>
    /// <returns>Список с информацией о предложениях.</returns>
    public Task<ListModel<Offer>> GetActiveOffersAsync(int? offset, int? count, string authToken, string version)
    {
      var defaultCount = "100";

      var dictionary = new Dictionary<string, string>
      {
        {"offset", offset.ToString()},
        {"count", count == null ? defaultCount : count.ToString()},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<ListModel<Offer>>("account.getActiveOffers", dictionary);
    }

    /// <summary>
    /// Возвращает настройки (<see cref="AccessSettings"/>) текущего пользователя в данном приложении.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Настройки (<see cref="AccessSettings"/>) текущего пользователя.</returns>
    public Task<AccessSettings> GetAppPermissionsAsync(int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"user_id", userId.ToString()},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<AccessSettings>("account.getAppPermissions", dictionary);
    }

    /// <summary>
    /// Возвращает список пользователей, находящихся в черном списке.
    /// </summary>
    /// <param name="offset">смещение, необходимое для выборки определенного подмножества черного списка.</param>
    /// <param name="count">Количество, которое необходимо получить.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Список пользователей, находящихся в черном списке.</returns>
    public Task<ListModel<User>> GetBlockUsersAsync(int? offset, int? count, string authToken, string version)
    {
      var defaultCount = "20";

      var dictionary = new Dictionary<string, string>
      {
        {"offset", offset.ToString()},
        {"count", count == null ? defaultCount : count.ToString()},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<ListModel<User>>("account.getBanned", dictionary);
    }

    /// <summary>
    /// Возвращает ненулевые значения счетчиков пользователя.
    /// </summary>
    /// <param name="fields">
    /// Счетчики, информацию о которых нужно вернуть.
    /// Может включать следующие значения:
    /// friends — новые заявки в друзья;
    /// friends_suggestions — предлагаемые друзья;
    /// messages — новые сообщения;
    /// photos — новые отметки на фотографиях;
    /// videos — новые отметки на видеозаписях;
    /// gifts — подарки;
    /// events — события;
    /// groups — сообщества;
    /// notifications — ответы;
    /// sdk — запросы в мобильных играх;
    /// app_requests — уведомления от приложений.
    /// список слов, разделенных через запятую
    /// </param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Ненулевые значения счетчиков пользователя.</returns>
    public Task<Counters> GetBlockUsersAsync(string fields, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"fields", fields},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<Counters>("account.getCounters", dictionary);
    }

    /// <summary>
    /// Возвращает ненулевые значения счетчиков пользователя.
    /// </summary>
    /// <param name="fields">
    /// Поля, которые необходимо вернуть.
    /// Возможные значения:
    /// country — новые заявки в друзья;
    /// https_required — предлагаемые друзья;
    /// own_posts_default — новые сообщения;
    /// no_wall_replies — новые отметки на фотографиях;
    /// intro — новые отметки на видеозаписях;
    /// lang — подарки.
    /// По умолчанию будут возвращены все поля.
    /// Список слов, разделенных через запятую.
    /// </param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Ненулевые значения счетчиков пользователя.</returns>
    public Task<Account> GetInfoAsync(string fields, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"fields", fields},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<Account>("account.getInfo", dictionary);
    }

    /// <summary>
    /// Возвращает информацию о текущем профиле.
    /// </summary>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Информация о текущем профиле.</returns>
    public Task<Profile> GetCurrentProfileAsync(string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<Profile>("account.getProfileInfo", dictionary);
    }

    /// <summary>
    /// Возвращает настройки Push-уведомлений.
    /// Требуются права доступа: <see cref="AccessSettings.Messages"/>.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Настройки Push-уведомлений.</returns>
    public Task<AccountPushSettings> GetPushSettingsAsync(IAccountPushSettingsFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"device_id", filter.DeviceId.ToString()},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<AccountPushSettings>("account.getPushSettings", dictionary);
    }

    /// <summary>
    /// Позволяет искать пользователей ВКонтакте, используя телефонные номера, 
    /// email-адреса, и идентификаторы пользователей в других сервисах.
    /// Требуются права доступа: <see cref="AccessSettings.Friends"/>.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Возвращает пользователей согласно фильтру.</returns>
    public Task<LookupUser> FindContactsAsunc(IContactsFilter filter, string authToken, string version)
    {
      if (string.IsNullOrEmpty(filter.Service))
      {
        throw new Exception("");
      }

      var dictionary = new Dictionary<string, string>
      {
        {"contacts", filter.Contacts},
        {"service", filter.Service},
        {"mycontact", filter.Mycontact},
        {"return_all", filter.IsReturnAll ? "1" : "0"},
        {"fields", filter.Fields},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<LookupUser>("account.lookupContacts", dictionary);
    }

    /// <summary>
    /// Регистрирует устройство на базе iOS, Android или Windows Phone на получение Push-уведомлений.
    /// Требуются права доступа: <see cref="AccessSettings.Messages"/>.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    /// <remarks>Требуются права доступа: <see cref="AccessSettings.Messages"/></remarks>
    public Task<bool> RegisterDeviceAsync(IDeviceFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"token", filter.Token},
        {"device_model", filter.DeviceModel},
        {"device_year", filter.DeviceYear.ToString()},
        {"device_id", filter.DeviceId.ToString()},
        {"system_version", filter.SystemVersion},
        {"settings", filter.SettingsJson},
        {"sandbox", filter.Sandbox ? "1" : "0"},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.registerDevice", dictionary);
    }

    /// <summary>
    /// Редактирует информацию текущего профиля.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns></returns>
    public Task<ProfileChangeResponse> SaveProfileInfo(IProfileInfoFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"first_name", filter.FirstName},
        {"last_name", filter.LastName},
        {"maiden_name", filter.MaidenName},
        {"screen_name", filter.ScreenName},
        {"cancel_request_id", filter.CancelRequestId.ToString()},
        {"sex", filter.Sex.ToString("D")},
        {"relation", filter.Relation.ToString("D")},
        {"relation_partner_id", filter.RelationPartnerId.ToString()},
        {"bdate", filter.Bdate},
        {"bdate_visibility", filter.BdateVisibilityType.ToString("D")},
        {"home_town", filter.Hometown},
        {"country_id", filter.CountryId.ToString()},
        {"city_id", filter.CityId.ToString()},
        {"status", filter.Status},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<ProfileChangeResponse>("account.saveProfileInfo", dictionary);
    }

    /// <summary>
    /// Редактирует информацию о текущем аккаунте.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> EditCurrentAccountInfoAsync(ICurrentAccountInfoFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"name", filter.Name},
        {"value", filter.Value},
        {"intro", filter.Intro.ToString()},
        {"own_posts_default", filter.IsPostsDefault ? "1" : "0"},
        {"no_wall_replies", filter.IsNoWallReplies ? "1" : "0"},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.setInfo", dictionary);
    }

    /// <summary>
    /// Устанавливает короткое название приложения, 
    /// которое выводится пользователю в левом меню.
    /// Доступно только в том случае, если пользователь 
    /// добавил приложение в левое меню со страницы приложения, 
    /// списка приложений или настроек.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="name">Короткое название приложения (до 17 символов).</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> EditShortNameInMenuAsync(int userId, string name, string authToken, string version)
    {
      if (string.IsNullOrEmpty(name))
      {
        throw new Exception("");
      }

      if (name.Length > 17)
      {
        throw new Exception("");
      }

      if (userId <= 0)
      {
        throw new Exception("");
      }

      var dictionary = new Dictionary<string, string>
      {
        {"user_id", userId.ToString()},
        {"name", name},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.setNameInMenu", dictionary);
    }

    /// <summary>
    /// Помечает текущего пользователя как offline (только в текущем приложении).
    /// </summary>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> SetOfflineAsync(string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.setOffline", dictionary);
    }

    /// <summary>
    /// Помечает текущего пользователя как online на 5 минут.
    /// </summary>
    /// <param name="isVoip">Возможны ли видеозвонки для данного устройства.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> SetOnlineAsync(bool isVoip, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"voip", isVoip ? "1" : "0"},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.setOffline", dictionary);
    }

    /// <summary>
    /// Изменяет настройку Push-уведомлений.
    /// Требуются права доступа: <see cref="AccessSettings.Messages"/>.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<AccountPushSettings> SetPushSettingsAsync(IAccountPushSettingsFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"device_id", filter.DeviceId.ToString()},
        {"settings", filter.SettingsJson},
        {"key", filter.Key},
        {"value", filter.ValueJson},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<AccountPushSettings>("account.getPushSettings", dictionary);
    }

    /// <summary>
    /// Отключает push-уведомления на заданный промежуток времени.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> SetSilenceMode(IAccountPushFilter filter, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"device_id", filter.DeviceId.ToString()},
        {"time", filter.Time.ToString()},
        {"peer_id", filter.PeerId.ToString()},
        {"sound", filter.Sound ? "1" : "0"},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.setSilenceMode", dictionary);

    }

    /// <summary>
    /// Убирает пользователя из черного списка.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> UnblockUserAsync(int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"user_id", userId.ToString()},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.unbanUser", dictionary);
    }

    /// <summary>
    /// Отписывает устройство от Push уведомлений.
    /// Требуются права доступа: <see cref="AccessSettings.Messages"/>.
    /// </summary>
    /// <param name="deviceId">уникальный идентификатор устройства.</param>
    /// <param name="sandbox">
    /// Признак предназначен для iOS устройств.
    /// Использовать sandbox сервер для отправки push-уведомлений иначе не использовать.
    /// </param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> UnregisterDeviceAsync(int deviceId, bool sandbox,  string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"device_id", deviceId.ToString()},
        {"sandbox", sandbox ? "1" : "0"},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("account.unregisterDevice", dictionary);
    }
  }
}