namespace SuggestionAppLibrary.Models;
public class StatusModel
{
   [BsonId]
   [BsonRepresentation(BsonType.String)]
   public string Id { get; set; }
   public string StatusName { get; set; }
   public string StatusDescription { get; set; }
}
