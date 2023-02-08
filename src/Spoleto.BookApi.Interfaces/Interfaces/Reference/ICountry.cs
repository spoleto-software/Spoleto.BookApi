namespace Spoleto.BookApi.Interfaces
{

    /// <summary>
    /// Справочник стран
    /// </summary>
    public interface ICountry : IPersistentReference
    {

        string Name { get; set; }

        /// <summary>
        /// Двузначный код страны (альфа-2)
        /// </summary>
        string CodeAlpha2 { get; set; }

        /// <summary>
        /// Трехзначный код страны (альфа-3)
        /// </summary>
        string CodeAlpha3 { get; set; }

        /// <summary>
        /// Является участником ЕАЭС
        /// </summary>
        bool EAEUMember { get; set; }

        /// <summary>
        /// Международное наименование
        /// </summary>
        string InternationalName { get; set; }
    }
}
