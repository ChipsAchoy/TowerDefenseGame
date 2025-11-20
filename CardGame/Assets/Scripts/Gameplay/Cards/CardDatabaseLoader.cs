using System.Collections.Generic;
using UnityEngine;

public class CardDatabaseLoader : MonoBehaviour
{
    public static CardDatabaseLoader Instance;

    public Dictionary<string, CardDefinition> CardById { get; private set; }

    private void Awake()
    {
        Debug.Log("CardDatabaseLoader Awake");

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadCardDatabase();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoadCardDatabase()
    {
        const string path = "Data/Cards/cards";
        Debug.Log("Loading card database from Resources path: " + path);

        TextAsset jsonFile = Resources.Load<TextAsset>(path);

        if (jsonFile == null)
        {
            Debug.LogError("Card database JSON not found in " + path);
            return;
        }

        CardDatabase database = JsonUtility.FromJson<CardDatabase>(jsonFile.text);

        CardById = new Dictionary<string, CardDefinition>();
        foreach (var card in database.cards)
        {
            CardById[card.id] = card;
        }

        Debug.Log($"Loaded {CardById.Count} cards into the database.");
    }

    public CardDefinition GetCard(string id)
    {
        if (CardById != null && CardById.TryGetValue(id, out CardDefinition card))
            return card;

        Debug.LogError($"Card with ID '{id}' not found!");
        return null;
    }
}
