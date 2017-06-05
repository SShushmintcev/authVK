using OAuthVk.Core.Enums;

namespace OAuthVk.Core.FileType
{
  public interface IPage
  {
    /// <summary>
    /// Идентификатор вики-страницы.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор сообщества.
    /// </summary>
    int GroupId { get; set; }

    /// <summary>
    /// Идентификатор создателя вики-страницы.
    /// </summary>
    int CreatorId { get; set; }

    /// <summary>
    /// Название вики-страницы.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Признак того, что текущий пользователь может редактировать текст вики-страницы.
    /// </summary>
    bool CurrentUserCanEdit { get; set; }

    /// <summary>
    /// Признак того, что текущий пользователь может изменять права доступа на вики-страницу.
    /// </summary>
    bool CurrentUserCanEditAccess { get; set; }

    /// <summary>
    /// Информация о том, кто может просматривать вики-страницу.
    /// </summary>
    AccessViewType WhoCanView { get; set; }

    /// <summary>
    /// Информация о том, кто может редактировать вики-страницу.
    /// </summary>
    AccessViewType WhoCanEdit { get; set; }

    /// <summary>
    /// Дата последнего изменения вики-страницы в формате Unixtime.
    /// </summary>
    int Edited { get; set; }

    /// <summary>
    /// Дата создания вики-страницы в формате Unixtime.
    /// </summary>
    int Created { get; set; }

    /// <summary>
    /// Идентификатор пользователя, который редактировал вики-страницу последним.
    /// </summary>
    int EditorId { get; set; }

    /// <summary>
    /// Количество просмотров вики-страницы.
    /// </summary>
    int Views { get; set; }

    /// <summary>
    /// Заголовок родительской страницы для навигации.
    /// </summary>
    string Parent { get; set; }

    /// <summary>
    /// Заголовок второй родительской страницы для навигации.
    /// </summary>
    string SecondParent { get; set; }

    /// <summary>
    /// Текст страницы в вики-формате, если был запрошен.
    /// </summary>
    string Source { get; set; }

    /// <summary>
    /// Текст страницы в html-формате, если был запрошен.
    /// </summary>
    string Html { get; set; }

    /// <summary>
    /// Адрес страницы для отображения вики-страницы.
    /// </summary>
    string ViewUrl { get; set; }
  }
}