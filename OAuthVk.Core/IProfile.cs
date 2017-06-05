using System.Collections.Generic;
using OAuthVk.Core.Enums;

namespace OAuthVk.Core
{
  public interface IProfile
  {
    /// <summary>
    /// Имя.
    /// </summary>
    string FirstName { get; set; }

    /// <summary>
    /// Фамилия.
    /// </summary>
    string LastName { get; set; }

    /// <summary>
    /// Девичья фамилия.
    /// </summary>
    string MaidenName { get; set; }

    /// <summary>
    /// Короткое имя страницы пользователя.
    /// </summary>
    string ScreenName { get; set; }

    /// <summary>
    /// Пол пользователя. 
    /// </summary>
    SexType Sex { get; set; }

    /// <summary>
    /// Семейное положение пользователя.
    /// </summary>
    UserRelationType Relation { get; set; }

    /// <summary>
    /// Пользователь с которым связано семейное положение.
    /// </summary>
    IUser RelationPartner { get; set; }

    /// <summary>
    /// Передается 1, если пользователь, указанный в <see cref="RelationPartner"/>, не подтвердил отношения.
    /// </summary>
    int? RelationPending { get; set; }

    /// <summary>
    /// Список пользователей, которые указали, что состоят в отношениях с данным пользователем.
    /// </summary>
    IEnumerable<IUser> RelationRequests { get; set; }

    /// <summary>
    /// Дата рождения.
    /// Возвращается в формате D.M.YYYY или D.M (если год рождения скрыт). 
    /// Если дата рождения скрыта целиком, поле отсутствует в ответе.
    /// </summary>
    string Bdate { get; set; }

    /// <summary>
    /// Тип видимости даты рождения.
    /// </summary>
    VisibilityDateType BdateVisibilityType { get; set; }

    /// <summary>
    /// Название родного города.
    /// </summary>
    string Hometown { get; set; }

    /// <summary>
    /// Информация о стране, указанной на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity Country { get; }

    /// <summary>
    /// Информация о городе, указанном на странице пользователя в разделе «Контакты».
    /// </summary>
    ICity City { get; }

    /// <summary>
    /// Статус пользователя.
    /// Возвращается строка, содержащая текст статуса, расположенного в профиле под именем пользователя.
    /// </summary>
    string Status { get; set; }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    string Phone { get; set; }
  }
}