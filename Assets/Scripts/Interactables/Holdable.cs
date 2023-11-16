using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

// Takes and handles input and movement for a player character
public class Holdable : BaseInteractable
{
    public InteractableType holdableType;
    public void OnInteract(SpriteRenderer heldSprite)
    {
        // called when player presses interact key


        // if empty hand, put object into hand
        if (GameManager.instance.held == null)
        {
            Debug.Log("Held me!");
            // add self to GameManager
            GameManager.instance.held = gameObject;
            heldSprite.sprite = GetComponent<SpriteRenderer>().sprite;
            heldSprite.color = GetComponent<SpriteRenderer>().color;

        }
    }
}
