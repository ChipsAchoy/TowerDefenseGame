using UnityEngine;

public static class DeckLoader
{
    public static DeckData LoadDeck(string deckName)
    {
        TextAsset json = Resources.Load<TextAsset>(deckName);

        if (json == null)
        {
            Debug.LogError("Deck JSON not found: " + deckName);
            return null;
        }

        return JsonUtility.FromJson<DeckData>(json.text);
    }
}
