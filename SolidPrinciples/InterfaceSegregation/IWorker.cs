namespace SolidPrinciples.InterfaceSegregation
{
    public interface IWorker
    {
        string Id { get; set; }
        
        string Name { get; set; }
        
        string Email { get; set; }
    }
}