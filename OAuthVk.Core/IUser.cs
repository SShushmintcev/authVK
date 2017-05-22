using System.Collections.Generic;
using OAuthVk.Core.Enums;
using OAuthVk.Core.FileType;

namespace OAuthVk.Core
{
  public interface IUser
  {
    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    long Id { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    string FirstName { get; set; }

    /// <summary>
    /// Фамилия.
    /// </summary>
    string LastName { get; set; }

    /// <summary>
    /// Поле возвращается, если страница пользователя удалена или заблокирована,
    /// содержит значение deleted или banned. В этом случае опциональные поля не возвращаются.
    /// </summary>
    string Deactivated { get; set; }

    /// <summary>
    /// Возвращается 1 при вызове без access_token, 
    /// если пользователь установил настройку «Кому в интернете видна моя страница»
    /// — «Только пользователям ВКонтакте». В этом случае опциональные поля не возвращаются.
    /// </summary>
    int? Hidden { get; set; }

    #region Optional------- A-L

    /// <summary>
    /// О себе
    /// </summary>
    string About { get; set; }

    /// <summary>
    /// Деятельность
    /// </summary>
    string Activities { get; set; }

    /// <summary>
    /// Дата рождения.
    /// Возвращается в формате D.M.YYYY или D.M (если год рождения скрыт). 
    /// Если дата рождения скрыта целиком, поле отсутствует в ответе.
    /// </summary>
    string Bdate { get; set; }

    /// <summary>
    /// Информация о том, находится ли текущий пользователь в черном списке.
    /// </summary>
    BlackList Blacklisted { get; set; }

    /// <summary>
    /// Информация о том, находится ли пользователь в черном списке у текущего пользователя.
    /// </summary>
    BlackList BlacklistedByMe { get; set; }

    /// <summary>
    /// Содержимое поля «Любимые книги» из профиля пользователя.
    /// </summary>
    string Books { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь оставлять записи на стене.
    /// </summary>
    UserAccessType CanPost { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь видеть чужие записи на стене.
    /// </summary>
    UserAccessType CanSeeAllPosts { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь видеть аудиозаписи.
    /// </summary>
    UserAccessType CanSeeAudio { get; set; }

    /// <summary>
    /// Информация о том, будет ли отправлено уведомление пользователю о заявке в друзья от текущего пользователя.
    /// </summary>
    UserAccessType CanSendFriendRequest { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь отправить личное сообщение.
    /// </summary>
    UserAccessType CanWritePrivateMessage { get; set; }

    /// <summary>
    /// Информация о карьере пользователя.
    /// </summary>
    IEnumerable<IUserCompany> Work { get; }

    /// <summary>
    /// Информация о городе, указанном на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity City { get; }

    /// <summary>
    /// Количество общих друзей с текущим пользователем.
    /// </summary>
    int CommonCount { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    string Skype { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    string Facebook { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    string Twitter { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    string Livejournal { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    string Instagram { get; set; }

    /// <summary>
    /// Информация о телефонных номерах пользователя.
    /// Если данные указаны и не скрыты настройками приватности.
    /// </summary>
    IContact Contacts { get; }

    /// <summary>
    /// Количество различных объектов у пользователя.
    /// Возвращается только в методе users.get c передачей access_token.
    /// </summary>
    ICounters Counters { get; }

    /// <summary>
    /// Информация о стране, указанной на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity Country { get; }

    /// <summary>
    /// Возвращает данные о точках, по которым вырезаны профильная и миниатюрная фотографии пользователя.
    /// </summary>
    ICrop CropPhoto { get; }

    /// <summary>
    /// Короткий адрес страницы.
    /// Возвращается строка, содержащая короткий адрес
    /// страницы (например, andrew). Если он не назначен, возвращается "id"+user_id.
    /// </summary>
    string Domain { get; set; }

    #region University

    /// <summary>
    /// Идентификатор университета.
    /// </summary>
    int UniversityId { get; set; }

    /// <summary>
    /// Название университета.
    /// </summary>
    string UniversityName { get; set; }

    /// <summary>
    /// Идентификатор факультета.
    /// </summary>
    int FacultyId { get; set; }

    /// <summary>
    /// Название факультета.
    /// </summary>
    string FacultyName { get; set; }

    /// <summary>
    /// Год окончания.
    /// </summary>
    int Graduation { get; set; }

    #endregion

    /// <summary>
    /// Внешние сервисы, в которые настроен экспорт из ВК (twitter, facebook, livejournal, instagram).
    /// </summary>
    /// TODO: пока не известно.
    object Exports { get; set; }

    // first_name_{case} string имя в заданном падеже.Возможные значения для {case}:

    /// <summary>
    /// Количество подписчиков пользователя.
    /// </summary>
    int FollowersCount { get; set; }

    /// <summary>
    /// Статус дружбы с пользователем.
    /// </summary>
    FriendType FriendStatus { get; set; }

    /// <summary>
    /// Содержимое поля «Любимые игры» из профиля.
    /// </summary>
    string Games { get; set; }

    /// <summary>
    /// Информация о том, известен ли номер мобильного телефона пользователя.
    /// </summary>
    bool HasMobile { get; set; }

    /// <summary>
    /// Информация о том, установил ли пользователь фотографию для профиля.
    /// </summary>
    bool HasPhoto { get; set; }

    /// <summary>
    /// Название родного города.
    /// </summary>
    string Hometown { get; set; }

    /// <summary>
    /// Содержимое поля «Интересы» из профиля.
    /// </summary>
    string Interests { get; set; }

    /// <summary>
    /// Информация о том, есть ли пользователь в закладках у текущего пользователя.
    /// </summary>
    bool IsFavorite { get; set; }

    /// <summary>
    /// Информация о том, является ли пользователь другом текущего пользователя.
    /// </summary>
    bool IsFriend { get; set; }

    /// <summary>
    /// Информация о том, скрыт ли пользователь из ленты новостей текущего пользователя.
    /// </summary>
    bool IsHiddenFromFeed { get; set; }

    //last_name_{case} фамилия в заданном падеже.

    /// <summary>
    /// Время последнего посещения.
    /// </summary>
    ILastVisit LastSeen { get; }

    /// <summary>
    /// Разделенные запятой идентификаторы списков друзей, в которых состоит пользователь.
    /// </summary>
    IEnumerable<int> Lists { get; }

    #endregion

    #region Optional------- M-W

    /// <summary>
    /// Девичья фамилия.
    /// </summary>
    string MaidenName { get; set; }

    /// <summary>
    /// Информация о военной службе пользователя.
    /// </summary>
    IMilitary Military { get; }

    /// <summary>
    /// Содержимое поля «Любимые фильмы» из профиля пользователя.
    /// </summary>
    string Movies { get; set; }

    /// <summary>
    /// Содержимое поля «Любимая музыка» из профиля пользователя.
    /// </summary>
    string Music { get; set; }

    /// <summary>
    /// Никнем (отчество) пользователя. 
    /// </summary>
    string Nickname { get; set; }

    /// <summary>
    /// Информация о текущем роде занятия пользователя.
    /// </summary>
    IOccupation Occupation { get; }

    /// <summary>
    /// Информация о том, находится ли пользователь сейчас на сайте.
    /// </summary>
    /// <remarks>Если пользователь использует мобильное приложение либо 
    /// мобильную версию сайта, возвращается дополнительное поле online_mobile, 
    /// содержащее 1. При этом, если используется именно приложение, дополнительно 
    /// возвращается поле online_app, содержащее его идентификатор.</remarks>
    /// TODO:
    bool Online { get; set; }

    /// <summary>
    /// Информация о полях из раздела «Жизненная позиция».
    /// </summary>
    IPersonal Personal { get; }

    /// <summary>
    /// Url квадратной фотографии пользователя, имеющей ширину 50 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_c.gif.
    /// </summary>
    string Photo50 { get; set; }

    /// <summary>
    /// Url квадратной фотографии пользователя, имеющей ширину 100 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_b.gif.
    /// </summary>
    string Photo100 { get; set; }

    /// <summary>
    /// Url фотографии пользователя, имеющей ширину 200 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_a.gif.
    /// </summary>
    string Photo200Orig { get; set; }

    /// <summary>
    /// Url квадратной фотографии пользователя, имеющей ширину 200 пикселей.
    /// Если у пользователя отсутствует фотография таких размеров, в ответе вернется https://vk.com/images/camera_200.png
    /// </summary>
    string Photo200 { get; set; }

    /// <summary>
    /// Url фотографии пользователя, имеющей ширину 400 пикселей.
    /// Если у пользователя отсутствует фотография такого размера, в ответе вернется https://vk.com/images/camera_400.png.
    /// </summary>
    string Photo400Orig { get; set; }

    /// <summary>
    /// Строковый идентификатор главной фотографии профиля пользователя в формате {user_id}_{photo_id}.
    /// </summary>
    /// <remarks>Обратите внимание, это поле может отсутствовать в ответе.</remarks>
    string PhotoId { get; set; }

    /// <summary>
    /// Url квадратной фотографии пользователя с максимальной шириной.
    /// Может быть возвращена фотография, имеющая ширину как 200, так и 100 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_b.gif.
    /// </summary>
    string PhotoMax { get; set; }

    /// <summary>
    /// Url фотографии пользователя максимального размера.
    /// Может быть возвращена фотография, имеющая ширину как 400, так и 200 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_a.gif.
    /// </summary>
    string PhotoMaxOrig { get; set; }

    /// <summary>
    /// Любимые цитаты.
    /// </summary>
    string Quotes { get; set; }

    /// <summary>
    /// Список родственников текущего пользователя.
    /// </summary>
    IEnumerable<IRelative> Relatives { get; }

    /// <summary>
    /// Семейное положение пользователя.
    /// </summary>
    /// <remarks>Если в семейном положении указан другой пользователь, 
    /// дополнительно возвращается объект relation_partner, содержащий id и имя этого человека.</remarks>
    /// TODO:
    UserRelationType MaritalType { get; set; }

    /// <summary>
    /// Список школ, в которых учился пользователь.
    /// </summary>
    IEnumerable<ISchool> Schools { get; }

    /// <summary>
    /// Короткое имя страницы пользователя.
    /// </summary>
    string ScreenName { get; set; }

    /// <summary>
    /// Пол пользователя. 
    /// </summary>
    SexType Sex { get; set; }

    /// <summary>
    /// Адрес сайта, указанный в профиле сайт пользователя.
    /// </summary>
    string Site { get; set; }

    /// <summary>
    /// Статус пользователя.
    /// Возвращается строка, содержащая текст статуса, расположенного в профиле под именем пользователя.
    /// </summary>
    /// <remarks>Если у пользователя включена опция «Транслировать в статус играющую музыку», 
    /// будет возвращено дополнительное поле status_audio, содержащее информацию о транслируемой композиции. </remarks>
    /// TODO: 
    string Status { get; set; }

    /// <summary>
    /// Временная зона пользователя.
    /// </summary>
    /// <remarks>Возвращается только при запросе информации о текущем пользователе.</remarks>
    int? Timezone { get; set; }

    /// <summary>
    /// Любимые телешоу.
    /// </summary>
    string Tv { get; set; }

    /// <summary>
    /// список вузов, в которых учился пользователь.
    /// </summary>
    IEnumerable<IUniversity> Universities { get; }

    /// <summary>
    /// Признак верификации страницы пользователя.
    /// </summary>
    bool Verified { get; set; }

    /// <summary>
    /// Признак включенности комментариев на стене.
    /// </summary>
    bool WallComments { get; set; }

    #endregion
  }
}