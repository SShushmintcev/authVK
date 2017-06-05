using OAuthVk.Core.Filters;

namespace OAuthVk.Model.Filter
{
  public class ChatFilter : IChatFilter
  {
    /// <summary>
    /// Идентификатор беседы.
    /// </summary>
    /// <remarks>Максимальное значение 100000000.</remarks>
    public int? ChatId {get;set;}

    /// <summary>
    /// Список идентификаторов бесед.
    /// </summary>
    public int[] ChatIds {get;set;}

    /// <summary>
    /// Список дополнительных полей.
    /// </summary>
    /// <remarks>
    /// Доступные значения:
    /// nickname,
    /// screen_name,
    /// sex,
    /// bdate,
    /// city,
    /// country,
    /// timezone,
    /// photo_50,
    /// photo_100,
    /// photo_200_orig,
    /// has_mobile,
    /// contacts,
    /// education,
    /// online,
    /// counters,
    /// relation,
    /// last_seen,
    /// status,
    /// can_write_private_message,
    /// can_see_all_posts,
    /// can_post, universities
    /// </remarks>
    // TODO: Нужно изменить!!!
    public string Fields {get;set;}

    /// <summary>
    /// Падеж для склонения имени и фамилии пользователя.
    /// По умолчанию: nom.
    /// </summary>
    /// <remarks>
    /// Возможные значения:
    /// nom — именительный;
    /// gen — родительный;
    /// dat — дательный;
    /// acc — винительный;
    /// ins — творительный;
    /// abl — предложный.
    /// </remarks>
    public string NameCase {get;set;}
  }
}