using MongoDB.Bson;

namespace mla.ApiMusica.Model { 
    public class Audio
    {
        public ObjectId Id { get; set; }
        public string? IdSql { get; set; }
        public required string Name { get; set; }
        public required byte[] Content { get; set; }
    }
}
