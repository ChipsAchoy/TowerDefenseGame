using UnityEngine;

public class DeckTestSpawner : MonoBehaviour
{
    public GameObject cardPrefab; // assign in Inspector
    public Transform parentArea;  // UI area to spawn cards into

    private void Start()
{
    DeckData deck = DeckLoader.LoadDeck("Data/Decks/Deck");

    if (deck == null || deck.deck == null)
    {
        Debug.LogError("Deck not loaded or deck list is null!");
        return;
    }


    foreach (string cardId in deck.deck)
    {
        Debug.Log("Spawning card id: " + cardId);

        CardDefinition def = CardDatabaseLoader.Instance.GetCard(cardId);
        if (def == null)
        {
            Debug.LogError("CardDefinition is NULL for id: " + cardId);
            continue;
        }

        CardInstance instance = new CardInstance(def);

        GameObject cardObj = Instantiate(cardPrefab, parentArea);
        if (cardObj == null)
        {
            Debug.LogError("cardObj is NULL after Instantiate!");
            continue;
        }

        CardView view = cardObj.GetComponent<CardView>();
        if (view == null)
        {
            Debug.LogError("CardView component missing on cardPrefab!");
            continue;
        }

        view.Initialize(instance);
    }
}
}
