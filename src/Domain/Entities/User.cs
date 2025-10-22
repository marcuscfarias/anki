using Domain.ValueObjects;

namespace Domain.Entities;

//TODO: property validation
public class User(
    string username,
    string password,
    Email email,
    DateOnly birthDate,
    bool isActive,
    DateTimeOffset createdAt)
    : BaseEntity
{
    public string Username { get; private set; } = username;
    public string Password { get; private set; } = password;
    public Email Email { get; private set; } = email;
    public DateOnly BirthDate { get; private set; } = birthDate;
    public bool IsActive { get; private set; } = isActive;
    public DateTimeOffset CreatedAt { get; private set; } = createdAt;
}