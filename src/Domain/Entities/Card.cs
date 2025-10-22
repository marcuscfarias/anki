namespace Domain.Entities;

public class Card(int deckId, string front, string back, DateTimeOffset dueAt)
    : BaseEntity
{
    public int DeckId { get; private set; } = deckId;
    public string Front { get; private set; } = front;
    public string Back { get; private set; } = back;
    public DateTimeOffset DueAt { get; private set; } = dueAt;
}