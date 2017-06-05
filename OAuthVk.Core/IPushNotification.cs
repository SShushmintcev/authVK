namespace OAuthVk.Core
{
  public interface IPushNotification
  {
    /// <summary>
    /// Личные сообщения.Может принимать массив значений:
    /// no_sound - отключить звук;
    /// no_text - не передавать текст сообщения.
    /// </summary>
    string Msg {get;set;}

    /// <summary>
    /// Групповые чаты. Может принимать массив значений:
    /// no_sound - отключить звук;
    /// no_text - не передавать текст сообщения.
    /// </summary>
    string Chat {get;set;}

    /// <summary>
    /// Запрос на добавления в друзья.Может принимать массив значений:
    /// mutual - уведомлять только при наличии общих друзей.
    /// </summary>
    string Friend {get;set;}

    /// <summary>
    /// Регистрация импортированного контакта.
    /// </summary>
    string FriendFound {get;set;}

    /// <summary>
    /// Подтверждение заявки в друзья.
    /// </summary>
    string FriendAccepted {get;set;}

    /// <summary>
    /// Ответы.
    /// </summary>
    string Reply {get;set;}

    /// <summary>
    /// Комментарии. Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    string Comment {get;set;}

    /// <summary>
    /// Упоминания.Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    string Mention {get;set;}

    /// <summary>
    /// Отметки "Мне нравится". Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    string Like {get;set;}

    /// <summary>
    /// Действия "Рассказать друзьям". Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    string Repost {get;set;}

    /// <summary>
    /// Новая запись на стене пользователя.
    /// </summary>
    string WallPost {get;set;}

    /// <summary>
    /// Размещение предложенной новости.
    /// </summary>
    string WallPublish {get;set;}

    /// <summary>
    /// Приглашение в сообщество.
    /// </summary>
    string GroupInvite {get;set;}

    /// <summary>
    /// Подтверждение заявки на вступление в группу.
    /// </summary>
    string GroupAccepted {get;set;}

    /// <summary>
    /// Ближайшие мероприятия.
    /// </summary>
    string EventSoon {get;set;}

    /// <summary>
    /// Отметки на фотографиях.Может принимать массив значений:
    /// fr_of_fr - уведомления только от друзей и друзей друзей.
    /// </summary>
    string TagPhoto {get;set;}

    /// <summary>
    /// Запросы в приложениях.
    /// </summary>
    string AppRequest {get;set;}

    /// <summary>
    /// Установка приложения.
    /// </summary>
    string SdkOpen {get;set;}

    /// <summary>
    /// Записи выбранных людей и сообществ.
    /// </summary>
    string NewPost {get;set;}

    /// <summary>
    /// Уведомления о днях рождениях на текущую дату.
    /// </summary>
    string Birthday {get;set;}
  }
}