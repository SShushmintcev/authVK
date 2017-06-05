namespace OAuthVk.Model.Accessor
{
  public class FriendAccessor
  {
    //public async Task<ListModel<User>> GetFriendsAsync()
    //{
    //  var culture = CultureInfo.CurrentCulture;

    //  using (var httpClient = new HttpClient())
    //  {
    //    httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
    //    httpClient.DefaultRequestHeaders.Add("Accept-Language", culture.Name);


    //    var fields = "deactivated," +
    //                 "hidden," +
    //                 "about," +
    //                 "activities," +
    //                 "bdate," +
    //                 "blacklisted," +
    //                 "blacklisted_by_me," +
    //                 "books," +
    //                 "can_post," +
    //                 "can_see_all_posts," +
    //                 "can_see_audio," +
    //                 "can_send_friend_request," +
    //                 "can_write_private_message," +
    //                 "career," +
    //                 "city," +
    //                 "common_count," +
    //                 "connections," +
    //                 "contacts," +
    //                 "counters," +
    //                 "country," +
    //                 "crop_photo," +
    //                 "domain," +
    //                 "education," +
    //                 "exports," +
    //                 //"first_name_{case}," +
    //                 "followers_count," +
    //                 "friend_status," +
    //                 "games," +
    //                 "has_mobile," +
    //                 "has_photo," +
    //                 "home_town," +
    //                 "interests," +
    //                 "is_favorite," +
    //                 "is_friend," +
    //                 "is_hidden_from_feed," +
    //                 //"last_name_{case}," +
    //                 "last_seen," +
    //                 "lists," +
    //                 "nickname," +
    //                 "sex" +
    //                 "photo_id," +
    //                 "verified," +
    //                 "photo_50," +
    //                 "photo_100," +
    //                 "photo_200_orig," +
    //                 "photo_200," +
    //                 "photo_400_orig," +
    //                 "photo_max," +
    //                 "photo_max_orig," +
    //                 "online," +
    //                 "site," +
    //                 "universities," +
    //                 "schools," +
    //                 "status," +
    //                 "occupation," +
    //                 "relatives," +
    //                 "relation," +
    //                 "personal," +
    //                 "wall_comments," +
    //                 "music," +
    //                 "movies," +
    //                 "tv," +
    //                 "quotes," +
    //                 "timezone," +
    //                 "screen_name," +
    //                 "maiden_name," +
    //                 "military";

    //    var dictionary = new Dictionary<string, string>
    //        {
    //          {"user_id", UserId.ToString()},
    //          {"fields", fields},
    //          {"count", "15"},
    //          //{"order", "name"},
    //          //{"lang", "4"},
    //          {"https", "1"},
    //          {"photo_sizes", "1"},
    //          {"access_token", AuthToken},
    //          {"v", "5.8"}
    //        };

    //    var formUrlClient = new FormUrlEncodedContent(dictionary);
    //    formUrlClient.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
    //    formUrlClient.Headers.ContentLanguage.Add(culture.Name);

    //    var users = await httpClient.PostAsync(new Uri("https://api.vk.com/method/friends.get"), formUrlClient);

    //    // TODO: [new] Добавить обработку на ошибку.
    //    var jObj = JObject.Parse(await users.Content.ReadAsStringAsync());

    //    return JsonConvert.DeserializeObject<ListModel<User>>(jObj["response"].ToString());
    //  }
    //}
  }
}