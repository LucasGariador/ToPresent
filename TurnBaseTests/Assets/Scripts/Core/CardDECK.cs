using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDECK : MonoBehaviour
{
    public List<CardsTemplates> deck = new();

    public void AddCard(CardsTemplates card)
    {
        if (deck.Count < GameManager.Instance.MaxDeckCards)
        {
            deck.Add(card);
        }
        else
        {
            Debug.Log("Enough cards on the deck");
        }
    }

    public void AddAllCards(List<CardsTemplates> cards)
    {
        if (deck.Count == 0)
        {
            deck = cards;
        }
        else
        {
            Debug.Log("The deck is not empty");
        }
    }

    public void RemoveSpecificCard(CardsTemplates card)
    {
        if (deck.Contains(card))
        {
            deck.Remove(card);
        }
        else
        {
            Debug.Log("The card is not on the deck");
        }
    }

    public CardsTemplates RemoveRandomCard()
    {
        if (deck.Count > 0)
        {
            int index = Random.Range(0, deck.Count);
            return ExtractSpecificCard(deck[index]);
        }
        Debug.Log("Not enough cards on the deck");
        return null;
    }

    public CardsTemplates ExtractSpecificCard(CardsTemplates card)
    {
        if (deck.Contains(card))
        {
            deck.Remove(card);
        }
        else
        {
            Debug.Log("The card is not on the deck");
            return null;
        }
        return card;
    }
}
