public class CardInstance
{
    public CardDefinition definition;

    public int currentHealth;
    public int currentDamage;
    public bool hasAttacked;

    public CardInstance(CardDefinition def)
    {
        definition = def;

        currentHealth = def.health;
        currentDamage = def.damage;
    }
}
