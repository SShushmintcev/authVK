using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Accessor
{
  public class MessageAccessor : BaseAccessor
  {
    #region Chat

    /// <summary>
    /// Возвращает информацию о беседе.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<Chat> GetChatAsync(IChatFilter filter, string authToken, string version)
    {
      return RequestChatAsync<Chat>(filter, authToken, version);
    }

    /// <summary>
    /// Возвращает список бесед.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<List<Chat>> GetChatsAsync(IChatFilter filter, string authToken, string version)
    {
      return RequestChatAsync<List<Chat>>(filter, authToken, version);
    }

    /// <summary>
    /// Добавляет в диалог нового пользователя.
    /// </summary>
    /// <param name="chatId">Идентификатор беседы.</param>
    /// <param name="userId">Идентификатор пользователя, которого необходимо включить в беседу.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    /// <remarks>Чтобы пользователю вернуться в беседу, которую он сам покинул, достаточно отправить сообщение в неё (если есть свободные места),
    /// либо вызвать этот метод, передав свой идентификатор.</remarks>
    public Task<bool> AddChatUserAsync(int chatId, int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
        {
          { "chat_id", chatId.ToString()},
          { "user_id", userId.ToString()},
          {"access_token", authToken},
          {"v", version}
        };

      return CallAsync<bool>("messages.addChatUser", dictionary);
    }

    /// <summary>
    /// Исключает из беседы пользователя.
    /// </summary>
    /// <param name="chatId">Идентификатор беседы.</param>
    /// <param name="userId">Идентификатор пользователя, которого необходимо исключить в беседу.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> DeleteChatAsync(int chatId, int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"user_id", userId.ToString()},
        {"chat_id", chatId.ToString() },
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("messages.removeChatUser", dictionary);
    }

    /// <summary>
    /// Изменяет заголовок диалога.
    /// </summary>
    /// <param name="chatId">Идентификатор беседы.</param>
    /// <param name="title"></param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    public Task<bool> ChangeTitleChat(int chatId, string title, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"chat_id", chatId.ToString() },
        {"title", title },
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("messages.editChat", dictionary);
    }

    #endregion

    #region Dialog

    /// <summary>
    /// Возвращает список диалогов текущего пользователя или сообщества.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Список диалогов или сообществ.</returns>
    /// <remarks>Если количество не задано, по умолчанию 20.</remarks>
    public Task<ListModel<Dialog>> GetDialogsAsync(IDialogFilter filter, string authToken, string version)
    {
      if (filter == null)
      {
        throw new Exception();
      }

      filter.Count = filter.Count ?? 20;

      var dictionary = new Dictionary<string, string>
      {
        { "offset", filter.Offset.ToString()},
        { "count", filter.Count.ToString()},
        { "start_message_id", filter.StartMessageId.ToString()},
        { "preview_length", filter.PreviewLength.ToString()},
        { "unread", Convert.ToInt32(filter.Unread).ToString()},
        { "important", Convert.ToInt32(filter.Important).ToString()},
        { "unanswered", Convert.ToInt32(filter.Unanswered).ToString()},
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<ListModel<Dialog>>("messages.getDialogs", dictionary);
    }

    /// <summary>
    /// Удаляет все личные сообщения в диалоге.
    /// </summary>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="userId">Идентификатор пользователя, которого необходимо исключить в беседу.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    // TODO: Изменить фильтр!!!!
    public Task<bool> DeleteMessagesInDialogAsync(IDialogFilter filter, int userId, string authToken, string version)
    {
      var dictionary = new Dictionary<string, string>
      {
        {"user_id", userId.ToString()},
        {"peer_id", filter.ForCommunities ? filter.ChatId.ToString() : (2000000000 + filter.ChatId).ToString() },
        {"offset", filter.Offset.ToString() },
        {"count", filter.Count.ToString() },
        {"access_token", authToken},
        {"v", version}
      };

      return CallAsync<bool>("messages.deleteDialog", dictionary);
    }

    #endregion

    #region Вспомогательные методы

    /// <summary>
    /// Вспомогательный метод для работы с получением данных Диалога.
    /// </summary>
    /// <typeparam name="T">Возвращаемые данные.</typeparam>
    /// <param name="filter">Фильтр данных.</param>
    /// <param name="authToken">Токен авторизации.</param>
    /// <param name="version">Текущая версия VK.</param>
    /// <returns>Результат выполнения.</returns>
    private Task<T> RequestChatAsync<T>(IChatFilter filter, string authToken, string version)
    {
      if (filter == null)
      {
        throw new Exception();
      }

      var dictionary = new Dictionary<string, string>
      {
        {"fields", filter.Fields},
        {"name_case", filter.NameCase},
        {"access_token", authToken},
        {"v", version}
      };

      if (filter.ChatId == null && (filter.ChatIds == null || filter.ChatIds.Length == 0))
      {
        throw new Exception();
      }

      if (filter.ChatId != null && (filter.ChatIds != null && filter.ChatIds.Length > 0))
      {
        throw new Exception();
      }

      if (filter.ChatIds != null && filter.ChatIds.Length > 0)
      {
        dictionary.Add("chat_ids", string.Join(",", filter.ChatIds));
      }
      else
      {
        dictionary.Add("chat_id", filter.ChatId.ToString());
      }

      return CallAsync<T>("messages.getChat", dictionary);
    }

    #endregion
  }
}