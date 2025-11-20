using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardSpawner : MonoBehaviour
{
    public GameObject cardPrefab; // Assign in Inspector
    public Transform spawnParent; // UI parent

    public void SpawnCard(string cardId)
    {
        CardDefinition def = CardDatabaseLoader.Instance.GetCard(cardId);

        if (def == null) return;

        CardInstance instance = new CardInstance(def);

        GameObject cardObject = Instantiate(cardPrefab, spawnParent);
        cardObject.GetComponent<CardView>().Initialize(instance);
    }
}
