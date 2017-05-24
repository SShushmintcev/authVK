using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;
using OAuthVk.Core.FileType;
using OAuthVk.Model.Coverter;
using OAuthVk.Model.FileType;

namespace OAuthVk.Model
{
  [Serializable]
  public class User : IUser
  {
    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public User()
    {
      Lists = new List<int>();
      Relatives = new List<Relative>();
      Schools = new List<School>();
      Universities = new List<University>();
      Work = new List<UserCompany>();
    }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия.
    /// </summary>
    [JsonProperty("last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Поле возвращается, если страница пользователя удалена или заблокирована,
    /// содержит значение deleted или banned. В этом случае опциональные поля не возвращаются.
    /// </summary>
    public string Deactivated { get; set; }

    /// <summary>
    /// Возвращается 1 при вызове без access_token, 
    /// если пользователь установил настройку «Кому в интернете видна моя страница»
    /// — «Только пользователям ВКонтакте». В этом случае опциональные поля не возвращаются.
    /// </summary>
    public int? Hidden { get; set; }

    #region Optional------- A-L

    /// <summary>
    /// О себе
    /// </summary>
    public string About { get; set; }

    /// <summary>
    /// Деятельность
    /// </summary>
    public string Activities { get; set; }

    /// <summary>
    /// Дата рождения.
    /// Возвращается в формате D.M.YYYY или D.M (если год рождения скрыт). 
    /// Если дата рождения скрыта целиком, поле отсутствует в ответе.
    /// </summary>
    public string Bdate { get; set; }

    /// <summary>
    /// Информация о том, находится ли текущий пользователь в черном списке.
    /// </summary>
    public BlackList Blacklisted { get; set; }

    /// <summary>
    /// Информация о том, находится ли пользователь в черном списке у текущего пользователя.
    /// </summary>
    [JsonProperty("blacklisted_by_me")]
    public BlackList BlacklistedByMe { get; set; }

    /// <summary>
    /// Содержимое поля «Любимые книги» из профиля пользователя.
    /// </summary>
    public string Books { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь оставлять записи на стене.
    /// </summary>
    [JsonProperty("can_post")]
    public UserAccessType CanPost { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь видеть чужие записи на стене.
    /// </summary>
    [JsonProperty("can_see_all_posts")]
    public UserAccessType CanSeeAllPosts { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь видеть аудиозаписи.
    /// </summary>
    [JsonProperty("can_see_audio")]
    public UserAccessType CanSeeAudio { get; set; }

    /// <summary>
    /// Информация о том, будет ли отправлено уведомление пользователю о заявке в друзья от текущего пользователя.
    /// </summary>
    [JsonProperty("can_send_friend_request")]
    public UserAccessType CanSendFriendRequest { get; set; }

    /// <summary>
    /// Информация о том, может ли текущий пользователь отправить личное сообщение.
    /// </summary>
    [JsonProperty("can_write_private_message")]
    public UserAccessType CanWritePrivateMessage { get; set; }

    /// <summary>
    /// Информация о карьере пользователя.
    /// </summary>
    IEnumerable<IUserCompany> IUser.Work
    {
      get { return Work; }
    }

    /// <summary>
    /// Информация о карьере пользователя.
    /// </summary>
    [JsonProperty("career")]
    public List<UserCompany> Work { get; set; }

    /// <summary>
    /// Информация о городе, указанном на странице пользователя в разделе «Контакты».
    /// </summary>
    [JsonProperty]
    public City City { get; set; }

    /// <summary>
    /// Информация о городе, указанном на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity IUser.City
    {
      get { return City; }
    }

    /// <summary>
    /// Количество общих друзей с текущим пользователем.
    /// </summary>
    [JsonProperty("common_count")]
    public int CommonCount { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    public string Skype { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    public string Facebook { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    public string Twitter { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    public string Livejournal { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram.
    /// </summary>
    public string Instagram { get; set; }

    /// <summary>
    /// Возвращает данные об указанных в профиле сервисах пользователя, 
    /// таких как: skype, facebook, twitter, livejournal, instagram. 
    /// Для каждого сервиса возвращается отдельное поле с типом string,
    ///  содержащее никнем пользователя. Например, "instagram": "username".
    /// </summary>
    public string Connections { get; set; }

    /// <summary>
    /// Информация о телефонных номерах пользователя.
    /// Если данные указаны и не скрыты настройками приватности.
    /// </summary>
    public IContact Contacts { get; set; }

    /// <summary>
    /// Количество различных объектов у пользователя. Возвращается только в методе users.get c передачей access_token. 
    /// </summary>
    [JsonProperty]
    public Counters Counters { get; set; }

    /// <summary>
    /// Количество различных объектов у пользователя.
    /// Возвращается только в методе users.get c передачей access_token.
    /// </summary>
    ICounters IUser.Counters
    {
      get { return Counters; }
    }

    /// <summary>
    /// Информация о стране, указанной на странице пользователя в разделе «Контакты».
    /// </summary>
    public City Country { get; set; }

    /// <summary>
    /// Информация о стране, указанной на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity IUser.Country
    {
      get { return Country; }
    }

    /// <summary>
    /// Возвращает данные о точках, по которым вырезаны профильная и миниатюрная фотографии пользователя.
    /// </summary>
    [JsonProperty("crop_photo")]
    public Crop CropPhoto { get; set; }

    /// <summary>
    /// Возвращает данные о точках, по которым вырезаны профильная и миниатюрная фотографии пользователя.
    /// </summary>
    ICrop IUser.CropPhoto
    {
      get { return CropPhoto; }
    }

    /// <summary>
    /// Короткий адрес страницы.
    /// Возвращается строка, содержащая короткий адрес
    /// страницы (например, andrew). Если он не назначен, возвращается "id"+user_id.
    /// </summary>
    public string Domain { get; set; }

    #region University

    /// <summary>
    /// Идентификатор университета.
    /// </summary>
    [JsonProperty("university")]
    public int UniversityId { get; set; }

    /// <summary>
    /// Название университета.
    /// </summary>
    [JsonProperty("university_name")]
    public string UniversityName { get; set; }

    /// <summary>
    /// Идентификатор факультета.
    /// </summary>
    [JsonProperty("faculty")]
    public int FacultyId { get; set; }

    /// <summary>
    /// Название факультета.
    /// </summary>
    [JsonProperty("faculty_name")]
    public string FacultyName { get; set; }

    /// <summary>
    /// Год окончания.
    /// </summary>
    public int Graduation { get; set; }

    /// <summary>
    /// Внешние сервисы, в которые настроен экспорт из ВК (twitter, facebook, livejournal, instagram).
    /// </summary>
    /// TODO: пока не известно.
    public object Exports { get; set; }

    #endregion

    /// <summary>
    /// Количество подписчиков пользователя.
    /// </summary>
    [JsonProperty("followers_count")]
    public int FollowersCount { get; set; }

    /// <summary>
    /// Статус дружбы с пользователем.
    /// </summary>
    [JsonProperty("friend_status")]
    public FriendType FriendStatus { get; set; }

    /// <summary>
    /// Содержимое поля «Любимые игры» из профиля.
    /// </summary>
    public string Games { get; set; }

    /// <summary>
    /// Информация о том, известен ли номер мобильного телефона пользователя.
    /// </summary>
    [JsonProperty("has_mobile")]
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool HasMobile { get; set; }

    /// <summary>
    /// Информация о том, установил ли пользователь фотографию для профиля.
    /// </summary>
    [JsonProperty("has_photo")]
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool HasPhoto { get; set; }

    /// <summary>
    /// Название родного города.
    /// </summary>
    [JsonProperty("home_town")]
    public string Hometown { get; set; }

    /// <summary>
    /// Содержимое поля «Интересы» из профиля.
    /// </summary>
    public string Interests { get; set; }

    /// <summary>
    /// Информация о том, есть ли пользователь в закладках у текущего пользователя.
    /// </summary>
    [JsonProperty("is_favorite")]
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool IsFavorite { get; set; }

    /// <summary>
    /// Информация о том, является ли пользователь другом текущего пользователя.
    /// </summary>
    [JsonProperty("is_friend")]
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool IsFriend { get; set; }

    /// <summary>
    /// Информация о том, скрыт ли пользователь из ленты новостей текущего пользователя.
    /// </summary>
    [JsonProperty("is_hidden_from_feed")]
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool IsHiddenFromFeed { get; set; }

    /// <summary>
    /// Время последнего посещения.
    /// </summary>
    [JsonProperty("last_seen")]
    public LastVisit LastSeen { get; set; }

    /// <summary>
    /// Время последнего посещения.
    /// </summary>
    ILastVisit IUser.LastSeen
    {
      get { return LastSeen; }
    }

    /// <summary>
    /// Разделенные запятой идентификаторы списков друзей, в которых состоит пользователь.
    /// </summary>
    public List<int> Lists { get; set; }

    /// <summary>
    /// Разделенные запятой идентификаторы списков друзей, в которых состоит пользователь.
    /// </summary>
    IEnumerable<int> IUser.Lists
    {
      get { return Lists; }
    }

    #endregion

    #region Optional------- M-W

    /// <summary>
    /// Девичья фамилия.
    /// </summary>
    [JsonProperty("maiden_name")]
    public string MaidenName { get; set; }

    /// <summary>
    /// Информация о военной службе пользователя.
    /// </summary>
    [JsonProperty]
    public Military Military { get; set; }

    /// <summary>
    /// Информация о военной службе пользователя.
    /// </summary>
    IMilitary IUser.Military
    {
      get { return Military; }
    }

    /// <summary>
    /// Содержимое поля «Любимые фильмы» из профиля пользователя.
    /// </summary>
    public string Movies { get; set; }

    /// <summary>
    /// Содержимое поля «Любимая музыка» из профиля пользователя.
    /// </summary>
    public string Music { get; set; }

    /// <summary>
    /// Никнем (отчество) пользователя. 
    /// </summary>
    public string Nickname { get; set; }

    /// <summary>
    /// Информация о текущем роде занятия пользователя.
    /// </summary>
    [JsonProperty]
    public Occupation Occupation { get; set; }

    /// <summary>
    /// Информация о текущем роде занятия пользователя.
    /// </summary>
    IOccupation IUser.Occupation
    {
      get { return Occupation; }
    }

    /// <summary>
    /// Информация о том, находится ли пользователь сейчас на сайте.
    /// </summary>
    /// <remarks>Если пользователь использует мобильное приложение либо 
    /// мобильную версию сайта, возвращается дополнительное поле online_mobile, 
    /// содержащее 1. При этом, если используется именно приложение, дополнительно 
    /// возвращается поле online_app, содержащее его идентификатор.</remarks>
    /// TODO:
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool Online { get; set; }

    /// <summary>
    /// Информация о полях из раздела «Жизненная позиция».
    /// </summary>
    [JsonProperty]
    public Personal Personal { get; set; }

    /// <summary>
    /// Информация о полях из раздела «Жизненная позиция».
    /// </summary>
    IPersonal IUser.Personal
    {
      get { return Personal; }
    }

    /// <summary>
    /// Url квадратной фотографии пользователя, имеющей ширину 50 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_c.gif.
    /// </summary>
    [JsonProperty("photo_50")]
    public string Photo50 { get; set; }

    /// <summary>
    /// Url квадратной фотографии пользователя, имеющей ширину 100 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_b.gif.
    /// </summary>
    [JsonProperty("photo_100")]
    public string Photo100 { get; set; }

    /// <summary>
    /// Url фотографии пользователя, имеющей ширину 200 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_a.gif.
    /// </summary>
    [JsonProperty("photo_200_orig")]
    public string Photo200Orig { get; set; }

    /// <summary>
    /// Url квадратной фотографии пользователя, имеющей ширину 200 пикселей.
    /// Если у пользователя отсутствует фотография таких размеров, в ответе вернется https://vk.com/images/camera_200.png
    /// </summary>
    [JsonProperty("photo_200")]
    public string Photo200 { get; set; }

    /// <summary>
    /// Url фотографии пользователя, имеющей ширину 400 пикселей.
    /// Если у пользователя отсутствует фотография такого размера, в ответе вернется https://vk.com/images/camera_400.png.
    /// </summary>
    [JsonProperty("photo_400_orig")]
    public string Photo400Orig { get; set; }

    /// <summary>
    /// Строковый идентификатор главной фотографии профиля пользователя в формате {user_id}_{photo_id}.
    /// </summary>
    /// <remarks>Обратите внимание, это поле может отсутствовать в ответе.</remarks>
    [JsonProperty("photo_id")]
    public string PhotoId { get; set; }

    /// <summary>
    /// Url квадратной фотографии пользователя с максимальной шириной.
    /// Может быть возвращена фотография, имеющая ширину как 200, так и 100 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_b.gif.
    /// </summary>
    [JsonProperty("photo_max")]
    public string PhotoMax { get; set; }

    /// <summary>
    /// Url фотографии пользователя максимального размера.
    /// Может быть возвращена фотография, имеющая ширину как 400, так и 200 пикселей.
    /// В случае отсутствия у пользователя фотографии возвращается http://vk.com/images/camera_a.gif.
    /// </summary>
    [JsonProperty("photo_max_orig")]
    public string PhotoMaxOrig { get; set; }

    /// <summary>
    /// Любимые цитаты.
    /// </summary>
    public string Quotes { get; set; }

    /// <summary>
    /// Список родственников текущего пользователя.
    /// </summary>
    [JsonProperty]
    public List<Relative> Relatives { get; set; }

    /// <summary>
    /// Список родственников текущего пользователя.
    /// </summary>
    IEnumerable<IRelative> IUser.Relatives
    {
      get { return Relatives; }
    }

    /// <summary>
    /// Семейное положение пользователя.
    /// </summary>
    /// <remarks>Если в семейном положении указан другой пользователь, 
    /// дополнительно возвращается объект relation_partner, содержащий id и имя этого человека.</remarks>
    /// TODO:
    [JsonProperty("relation")]
    public UserRelationType MaritalType { get; set; }

    /// <summary>
    /// Список школ, в которых учился пользователь.
    /// </summary>
    [JsonProperty]
    public List<School> Schools { get; set; }

    /// <summary>
    /// Список школ, в которых учился пользователь.
    /// </summary>
    IEnumerable<ISchool> IUser.Schools
    {
      get { return Schools; }
    }

    /// <summary>
    /// Короткое имя страницы пользователя.
    /// </summary>
    [JsonProperty("screen_name")]
    public string ScreenName { get; set; }

    /// <summary>
    /// Пол пользователя. 
    /// </summary>
    public SexType Sex { get; set; }

    /// <summary>
    /// Адрес сайта, указанный в профиле сайт пользователя.
    /// </summary>
    public string Site { get; set; }

    /// <summary>
    /// Статус пользователя.
    /// Возвращается строка, содержащая текст статуса, расположенного в профиле под именем пользователя.
    /// </summary>
    /// <remarks>Если у пользователя включена опция «Транслировать в статус играющую музыку», 
    /// будет возвращено дополнительное поле status_audio, содержащее информацию о транслируемой композиции. </remarks>
    /// TODO: 
    public string Status { get; set; }

    /// <summary>
    /// Временная зона пользователя.
    /// </summary>
    /// <remarks>Возвращается только при запросе информации о текущем пользователе.</remarks>
    public int? Timezone { get; set; }

    /// <summary>
    /// Любимые телешоу.
    /// </summary>
    public string Tv { get; set; }

    /// <summary>
    /// список вузов, в которых учился пользователь.
    /// </summary>
    [JsonProperty]
    public List<University> Universities { get; set; }

    /// <summary>
    /// список вузов, в которых учился пользователь.
    /// </summary>
    IEnumerable<IUniversity> IUser.Universities
    {
      get { return Universities; }
    }

    /// <summary>
    /// Признак верификации страницы пользователя.
    /// </summary>
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool Verified { get; set; }

    /// <summary>
    /// Признак включенности комментариев на стене.
    /// </summary>
    [JsonProperty("wall_comments")]
    [JsonConverter(typeof(BoolConverterAttribute))]
    public bool WallComments { get; set; }

    #endregion
  }
}