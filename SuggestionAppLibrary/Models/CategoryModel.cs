namespace SuggestionAppLibrary.Models;
public class CategoryModel
{
   [BsonId]
   [BsonRepresentation(BsonType.String)]
   public string Id { get; set; }
   public string CategoryName { get; set; }
   public string CategoryDescription { get; set; }
}
