namespace SuggestionAppLibrary.Models;
public class BasicSuggestionModel
{
   [BsonRepresentation(BsonType.String)]
   public string Id { get; set; }
   public string Suggestion { get; set; }

   public BasicSuggestionModel()
   {

   }

   public BasicSuggestionModel(SuggestionModel suggestion)
   {
      Id = suggestion.Id;
      Suggestion = suggestion.Suggestion;
   }
}
