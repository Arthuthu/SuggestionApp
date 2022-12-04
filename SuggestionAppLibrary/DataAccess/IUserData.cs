namespace SuggestionAppLibrary.DataAccess;

public interface IUserData
{
   Task CreateUser(UserModel user);
   Task<List<UserModel>> GerUsersAsync();
   Task<UserModel> GetUser(string id);
   Task<UserModel> GetUserFromAuthentication(string objectId);
   Task UpdateUser(UserModel user);
}