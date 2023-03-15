using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[RequireComponent(typeof(SpriteRenderer))]
public class Card : MonoBehaviour
{
    private Cost cost;
    private CardType type;

    public void Awake () {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        var LoadResources = Addressables.LoadAsset<Sprite>("Assets/Art/Card Templates/Creature");
        var result = LoadResources.WaitForCompletion();
        if(result != null)
        {
            spriteRenderer.sprite = result;
        }
    }

    public Cost GetCost () { return cost; }
    public CardType GetCardType () { return type; }
}

public struct Cost {
    CostType type;
    int value;
}

public enum CostType { Mana, Energy, Gold }

public enum CardType { Resource, Creature, Ability}