using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;

namespace OAuthVk.Model
{
  public class Profile : IProfile
  {
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
    /// Девичья фамилия.
    /// </summary>
    [JsonProperty("maiden_name")]
    public string MaidenName { get; set; }

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
    /// Семейное положение пользователя.
    /// </summary>
    public UserRelationType Relation { get; set; }

    /// <summary>
    /// Пользователь с которым связано семейное положение.
    /// </summary>
    [JsonProperty("relation_partner")]
    public IUser RelationPartner { get; set; }

    /// <summary>
    /// Передается 1, если пользователь, указанный в <see cref="IProfile.RelationPartner"/>, не подтвердил отношения.
    /// </summary>
    [JsonProperty("relation_pending")]
    public int? RelationPending { get; set; }

    /// <summary>
    /// Список пользователей, которые указали, что состоят в отношениях с данным пользователем.
    /// </summary>
    [JsonProperty("relation_requests")]
    public IEnumerable<IUser> RelationRequests { get; set; }

    /// <summary>
    /// Дата рождения.
    /// Возвращается в формате D.M.YYYY или D.M (если год рождения скрыт). 
    /// Если дата рождения скрыта целиком, поле отсутствует в ответе.
    /// </summary>
    public string Bdate { get; set; }

    /// <summary>
    /// Тип видимости даты рождения.
    /// </summary>
    [JsonProperty("bdate_visibility")]
    public VisibilityDateType BdateVisibilityType { get; set; }

    /// <summary>
    /// Название родного города.
    /// </summary>
    [JsonProperty("home_town")]
    public string Hometown { get; set; }

    /// <summary>
    /// Информация о стране, указанной на странице пользователя в разделе «Контакты».
    /// </summary>
    [JsonProperty]
    public City Country { get; set; }

    /// <summary>
    /// Информация о стране, указанной на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity IProfile.Country => Country;

    /// <summary>
    /// Информация о городе, указанном на странице пользователя в разделе «Контакты».
    /// </summary>
    [JsonProperty]
    public City City { get; set; }

    /// <summary>
    /// Информация о городе, указанном на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity IProfile.City => City;

    /// <summary>
    /// Статус пользователя.
    /// Возвращается строка, содержащая текст статуса, расположенного в профиле под именем пользователя.
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    public string Phone { get; set; }
  }
}