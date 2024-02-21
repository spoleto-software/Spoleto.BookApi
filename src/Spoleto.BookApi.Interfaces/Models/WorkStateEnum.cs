namespace Spoleto.BookApi.Interfaces.Models
{
    public enum WorkStateEnum
    {
        HoldDocument, //Провести документ
        SpreadDocument, //Распровести документ, если тот проведен
        Delete,
        Update,
        InsertIfNotExist,
        InsertOrUpdate,
        Insert
    }
}
