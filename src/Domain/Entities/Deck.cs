namespace Domain.Entities;

public class Deck(int ownerId, string title) : BaseEntity
{
    public int OwnerId { get; private set; } = ownerId;
    public string Title { get; private set; } = title;
}