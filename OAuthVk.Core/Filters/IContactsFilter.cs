namespace OAuthVk.Core.Filters
{
  public interface IContactsFilter
  {
    /// <summary>
    /// список email - контактов, разделенных через запятую.
    /// </summary>
    string Contacts { get; set; }

    /// <summary>
    /// строковой идентификатор сервиса, по контактам которого производится поиск.
    /// Может принимать следующие значения:
    ///   email;
    ///   phone
    ///   twitter;
    ///   facebook;
    ///   odnoklassniki;
    ///   instagram;
    ///   google.
    /// </summary>
    string Service { get; set; }

    /// <summary>
    /// Контакт текущего пользователя в заданном сервисе.
    /// </summary>
    string Mycontact { get; set; }

    /// <summary>
    /// Признак того, какие контакты требуется вернуть.
    /// True - возвращать также контакты, найденные ранее с использованием этого сервиса.
    /// False - возвращать только контакты, найденные с использованием поля <see cref="Contacts"/>.
    /// </summary>
    bool IsReturnAll { get; set; }

    /// <summary>
    /// Дополнительные поля, которые необходимо вернуть.
    /// Доступные значения:
    ///   nickname,
    ///   domain,
    ///   sex,
    ///   bdate,
    ///   city,
    ///   country,
    ///   timezone,
    ///   photo_50,
    ///   photo_100,
    ///   photo_200_orig,
    ///   has_mobile,
    ///   contacts,
    ///   education,
    ///   online,
    ///   relation,
    ///   last_seen,
    ///   status,
    ///   can_write_private_message,
    ///   can_see_all_posts,
    ///   can_post,
    ///   universities
    /// </summary>
    string Fields { get; set; }
  }
}