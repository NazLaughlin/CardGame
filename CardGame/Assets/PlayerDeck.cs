using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeck : MonoBehaviour
{
    public void Awake () {
        GameObject hand = new GameObject("Hand");
        hand.AddComponent<PlayerHand>().SetDeck(this);
    }

    public UnityEvent<Card> draw;
}
