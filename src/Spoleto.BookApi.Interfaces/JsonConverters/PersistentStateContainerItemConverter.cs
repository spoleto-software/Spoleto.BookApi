using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces.JsonConverters
{
    public class PersistentStateContainerItemConverter : JsonConverter<PersistentStateContainerItem>
    {
        public override PersistentStateContainerItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var type = default(Type);
            var objectState = default(ObjectState);
            var objects = new List<PersistentObjectBase>();

            // Read properties until we reach the end object token
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException($"Expected a property but found {reader.TokenType}.");
                }

                var propertyName = reader.GetString();

                switch (propertyName)
                {
                    case nameof(PersistentStateContainerItem.QualifiedTypeName):
                        {
                            reader.Read();
                            var qualifiedTypeName = reader.GetString();
                            type = Type.GetType(qualifiedTypeName, false)
                                ?? throw new JsonException($"Deserialization exception. Could not find a type by the qualified name: {qualifiedTypeName}.");
                        }
                        break;

                    case nameof(PersistentStateContainerItem.ObjectState):
                        {
                            reader.Read();
                            var objectStateString = reader.GetString();
                            if(!Enum.TryParse(objectStateString,  out objectState))
                                throw new JsonException($"Deserialization exception. Could not parse the string '{objectStateString}' into 'ObjectState' type.");
                        }
                        break;

                    case nameof(PersistentStateContainerItem.Objects):
                        {
                            if (type == null)
                            {
                                throw new JsonException("'QualifiedTypeName' should be before 'Objects' in JSON.");
                            }

                            // Read the "Object" property as an array
                            reader.Read();
                            if (reader.TokenType != JsonTokenType.StartArray)
                            {
                                throw new JsonException($"Expected an array but found {reader.TokenType}.");
                            }

                            while (reader.Read())
                            {
                                if (reader.TokenType == JsonTokenType.EndArray)
                                {
                                    break;
                                }

                                var obj = JsonSerializer.Deserialize(ref reader, type, options);
                                objects.Add((PersistentObjectBase)obj);
                            }


                        }
                        break;

                    default:
                        reader.Skip();
                        break;
                }
            }

            var item = new PersistentStateContainerItem(type)
            {
                Objects = objects,
                ObjectState = objectState
            };

            return item;
        }

        public override void Write(Utf8JsonWriter writer, PersistentStateContainerItem value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            var type = Type.GetType(value.QualifiedTypeName, false)
                ?? throw new JsonException($"Serialization exception. Could not find a type by the qualified name: {value.QualifiedTypeName}.");

            // Write each item as a JSON object with "QualifiedTypeName", "ObjectState", and "Objects" properties:
            writer.WriteStartObject();

            writer.WritePropertyName(nameof(value.QualifiedTypeName));
            writer.WriteStringValue(value.QualifiedTypeName);

            writer.WritePropertyName(nameof(value.ObjectState));
            writer.WriteStringValue(value.ObjectState.ToString());

            writer.WritePropertyName(nameof(value.Objects));
            writer.WriteStartArray();
            foreach (var obj in value.Objects)
            {
                JsonSerializer.Serialize(writer, obj, type, options);
            }

            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
