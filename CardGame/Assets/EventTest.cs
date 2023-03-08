using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventTest : MonoBehaviour
{
    public EventTest (CardEventManager cm) {
        cm.Draw.AddListener(draw);
    }

    [SerializeField]
    UnityEvent<Card> Draw;

    private void draw (Card c) {
    }
}

public class CardEventManager{
    public UnityEvent<Card> Draw;
}