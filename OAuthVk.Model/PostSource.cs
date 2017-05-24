using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class PostSource : IPostSource
  {
    /// <summary>
    /// Тип источника.
    /// </summary>
    /// <value>
    /// vk — запись создана через основной интерфейс сайта;
    /// widget — запись создана через виджет на стороннем сайте;
    /// api — запись создана приложением через API;
    /// rss— запись создана посредством импорта RSS-ленты со стороннего сайта;
    /// sms — запись создана посредством отправки SMS-сообщения на специальный номер.
    /// </value>
    public string Type { get; set; }

    /// <summary>
    /// Название платформы, если оно доступно.
    /// </summary>
    /// <value>
    /// android;
    /// iphone;
    /// wphone.
    /// </value>
    public string Platform { get; set; }

    /// <summary>
    /// Тип действия (только для type = vk или widget).
    /// </summary>
    /// <value>
    /// profile_activity — изменение статуса под именем пользователя(для type = vk);
    /// profile_photo — изменение профильной фотографии пользователя(для type = vk);
    /// comments — виджет комментариев(для type = widget);
    /// like — виджет «Мне нравится» (для type = widget);
    /// poll — виджет опросов(для type = widget);
    /// </value>
    public string Data { get; set; }

    /// <summary>
    /// URL ресурса, с которого была опубликована запись.
    /// </summary>
    public string Url { get; set; }
  }
}