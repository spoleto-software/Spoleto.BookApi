using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Spoleto.BookApi.Interfaces.Helpers;
using Spoleto.BookApi.Interfaces.JsonConverters;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Элемент контейнера, который включает в себя бизнес документы вместе со всеми необходимыми справочниками.
    /// </summary>
    [JsonConverter(typeof(PersistentContainerItemConverter))]
    public class PersistentContainerItem
    {
        /// <summary>
        /// Конструктор с указанием типа объектов.
        /// </summary>
        /// <param name="objectType"></param>
        public PersistentContainerItem(Type objectType)
        {
            QualifiedTypeName = TypeHelper.BuildTypeName(objectType);
        }

        /// <summary>
        /// Имя типа объектов с указанием сборки.
        /// </summary>
        public string QualifiedTypeName { get; }

        /// <summary>
        /// Объекты элемента контейнера.
        /// </summary>
        public List<PersistentObjectBase> Objects { get; set; }

        /// <summary>
        /// Тип объектов, которые содержатся в этом элементе контейнера.
        /// </summary>
        public Type GetObjectType() => Type.GetType(QualifiedTypeName, false);

        /// <summary>
        /// Текстовое представление элемента.
        /// </summary>
        public override string ToString() => $"{QualifiedTypeName}, Objects.Count = {Objects.Count}";
    }
}
