namespace _6.Custom_Enum_Attribute.Enums
{
    using _6.Custom_Enum_Attribute.Attributes;

    [Type("Enumeration", "Suit", "Provides suit constants for a Card class.")]
    public enum Suit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}