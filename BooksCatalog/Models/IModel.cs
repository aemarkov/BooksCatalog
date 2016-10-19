namespace BooksCatalog.Models
{
    /// <summary>
    /// Interfacee for all models.
    /// This interface is used to uniform working
    /// with all of models in repository
    /// </summary>
    public interface IModel
    {
        int Id { get; set; } 
    }
}