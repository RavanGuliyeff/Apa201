namespace CsRepeat.Models.Common;

public abstract class BaseEntity
{
    private static int _idCounter = 0;
    public int Id { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public BaseEntity()
    {
        Id = ++_idCounter;
        CreatedAt = DateTime.Now;
    }
}
