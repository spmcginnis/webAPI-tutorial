using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksAPI.Models
{
    public class Book
    {
        [BsonId] // Designates this property as the document's primary key
        [BsonRepresentation(BsonType.ObjectId)] // allows passing the parameter as type string instead of ObjectId structure. MongoDB handles the conversion to ObjectId.
        public string Id { get; set; }

        [BsonElement("Name")] // associates this property with the Name property in the DB collection.
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
