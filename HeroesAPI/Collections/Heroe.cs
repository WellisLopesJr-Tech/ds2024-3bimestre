using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson; // permite Serialização, Deserialização, Documentos BSON, Tipos de dados, Manipulação de dados, Suporte a tipos complexos, Integração com MongoDB.
using MongoDB.Bson.Serialization.Attributes;

namespace HeroesAPI.Collections;

[Table("heroes")]
[BsonIgnoreExtraElements]
public class Heroe
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("descrição")]
    public string Descricao { get; set; }

    [BsonElement("")]




}

