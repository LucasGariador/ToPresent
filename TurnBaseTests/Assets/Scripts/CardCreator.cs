using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardCreator : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private TMP_Text cardName;
    [SerializeField] private TMP_Text damage;
    [SerializeField] private TMP_Text health;
    [SerializeField] private TMP_Text speed;

    [Header("Images and Description")]
    [SerializeField] private Image spriteImage;
    [SerializeField] private Image stats;
    [SerializeField] private TMP_Text description;
    [Tooltip("green=0, lightblue=1, gray=2, blue=3")]
    [SerializeField] private Sprite[] statsTemplates;

    public void SetValues(CardsTemplates card)
    {
        cardName.text = card.cardName;
        damage.text = card.damage.ToString();
        health.text = card.health.ToString();
        speed.text = card.speed.ToString();

        spriteImage.sprite = card.sprite;
        description.text = card.descrition;
        stats.sprite = statsTemplates[(int)card.type];
    }
}
