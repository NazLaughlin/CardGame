using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public void SetDeck (PlayerDeck d) {
        d.draw.AddListener(addCard);
    }

    private void addCard (Card c) {
    
    }
}
