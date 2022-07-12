using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardsTemplates : ScriptableObject
{
    public Sprite sprite;

    public CardTypes type;

    public string cardName;

    public int damage;
    public int health;
    public int speed;

    public int cost;
    public string descrition;
}
