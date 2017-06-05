using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class ContactsFilter : IContactsFilter
  {
    /// <summary>
    /// список email - контактов, разделенных через запятую.
    /// </summary>
    public string Contacts { get; set; }

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
    public string Service { get; set; }

    /// <summary>
    /// Контакт текущего пользователя в заданном сервисе.
    /// </summary>
    public string Mycontact { get; set; }

    /// <summary>
    /// Признак того, какие контакты требуется вернуть.
    /// True - возвращать также контакты, найденные ранее с использованием этого сервиса.
    /// False - возвращать только контакты, найденные с использованием поля <see cref="IContactsFilter.Contacts"/>.
    /// </summary>
    public bool IsReturnAll { get; set; }

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
    public string Fields { get; set; }
  }
}