namespace Bookify.Domain.Apartments;

public record Address(
    string Country,
    string State,
    string Zipcode,
    string City,
    string Street);