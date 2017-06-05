using System;
using Newtonsoft.Json;
using OAuthVk.Core.Enums;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Page : IPage
  {
    /// <summary>
    /// Идентификатор вики-страницы.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор сообщества.
    /// </summary>
    [JsonProperty("group_id")]
    public int GroupId { get; set; }

    /// <summary>
    /// Идентификатор создателя вики-страницы.
    /// </summary>
    [JsonProperty("creator_id")]
    public int CreatorId { get; set; }

    /// <summary>
    /// Название вики-страницы.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Признак того, что текущий пользователь может редактировать текст вики-страницы.
    /// </summary>
    [JsonProperty("current_user_can_edit")]
    public bool CurrentUserCanEdit { get; set; }

    /// <summary>
    /// Признак того, что текущий пользователь может изменять права доступа на вики-страницу.
    /// </summary>
    [JsonProperty("current_user_can_edit_access")]
    public bool CurrentUserCanEditAccess { get; set; }

    /// <summary>
    /// Информация о том, кто может просматривать вики-страницу.
    /// </summary>
    [JsonProperty("who_can_view")]
    public AccessViewType WhoCanView { get; set; }

    /// <summary>
    /// Информация о том, кто может редактировать вики-страницу.
    /// </summary>
    [JsonProperty("who_can_edit")]
    public AccessViewType WhoCanEdit { get; set; }

    /// <summary>
    /// Дата последнего изменения вики-страницы в формате Unixtime.
    /// </summary>
    public int Edited { get; set; }

    /// <summary>
    /// Дата создания вики-страницы в формате Unixtime.
    /// </summary>
    public int Created { get; set; }

    /// <summary>
    /// Идентификатор пользователя, который редактировал вики-страницу последним.
    /// </summary>
    [JsonProperty("editor_id")]
    public int EditorId { get; set; }

    /// <summary>
    /// Количество просмотров вики-страницы.
    /// </summary>
    public int Views { get; set; }

    /// <summary>
    /// Заголовок родительской страницы для навигации.
    /// </summary>
    public string Parent { get; set; }

    /// <summary>
    /// Заголовок второй родительской страницы для навигации.
    /// </summary>
    [JsonProperty("parent2")]
    public string SecondParent { get; set; }

    /// <summary>
    /// Текст страницы в вики-формате, если был запрошен.
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Текст страницы в html-формате, если был запрошен.
    /// </summary>
    public string Html { get; set; }

    /// <summary>
    /// Адрес страницы для отображения вики-страницы.
    /// </summary>
    [JsonProperty("view_url")]
    public string ViewUrl { get; set; }
  }
}