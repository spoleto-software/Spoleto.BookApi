using System;
using Spoleto.BookApi.Interfaces.JsonConverters;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Элемент контейнера, который включает в себя бизнес документы вместе со всеми необходимыми справочниками.<br/>
    /// Этот элемент контейнера содержит информацию о своём состоянии (Создан/Изменён/Удалён).
    /// </summary>
    [JsonConverter(typeof(PersistentStateContainerItemConverter))]
    public class PersistentStateContainerItem : PersistentContainerItem
    {
        /// <summary>
        /// Конструктор с указанием типа объектов.
        /// </summary>
        public PersistentStateContainerItem(Type objectType) : base(objectType)
        {
        }

        /// <summary>
        /// Состояние объектов элемента.
        /// </summary>
        public ObjectState ObjectState { get; set; }

        /// <summary>
        /// Текстовое представление элемента.
        /// </summary>
        public override string ToString() => $"{QualifiedTypeName}, ObjectState = {ObjectState}, Objects.Count = {Objects.Count}";
    }
}
