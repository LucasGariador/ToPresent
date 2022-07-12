using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int MaxDeckCards
    { get; private set; }

private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        MaxDeckCards = GameInfo.maxDeckCards;
    }
}
