using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    [SerializeField] private Transform canvas;
    [SerializeField] private GameObject template;
    private CardDECK deck;
    private void Start()
    {
        deck = GetComponent<CardDECK>();
    }
    public void SpawnCardOnPosition()
    {
        CardsTemplates card = deck.RemoveRandomCard();
        if (card != null)
        {
            GameObject newCard = Instantiate(template, transform.position, Quaternion.identity, canvas);
            newCard.GetComponent<CardCreator>().SetValues(card);
        }
        else
        {
            Debug.Log("couldn't be spawned");
        }

    }
}
