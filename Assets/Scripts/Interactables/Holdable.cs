using UnityEngine;

// Takes and handles input and movement for a player character
public class Holdable : BaseInteractable
{
    public TaskName taskName;
    public Sprite optionalSprite;
    protected override void OnInteract()
    {
        // called when player presses interact key


        // if empty hand, put object into hand
        if (GameManager.instance.held == null)
        {
            // add self to GameManager
            GameManager.instance.SetHeld(gameObject);
            playerHand.sprite = optionalSprite ?? GetComponent<SpriteRenderer>().sprite;
            playerHand.color = GetComponent<SpriteRenderer>().color;

            // sfx for picking up item
            switch (taskName)
            {
                case TaskName.FetchCoffee:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.pourDrink);
                    break;
                case TaskName.RefillCoffee:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.serveRefreshment);
                    break;
                case TaskName.FetchTea:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.pourDrink);
                    break;
                case TaskName.PrepRefreshment:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.serveRefreshment);
                    break;
                // temporary - sound for picking up meeting document
                case TaskName.PrepMeeting:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.showTaskDetails);
                    break;
                // temporary - sound for picking up photocopy document
                // case TaskName.FetchDoc:
                //     GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.showTaskDetails);
                //     break;
                case TaskName.Shred:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.showTaskDetails);
                    break;
                case TaskName.Laminate:
                    GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.showTaskDetails);
                    break;
            }
        }
    }

    protected override bool CanInteract()
    {
        return GameManager.instance.held == null;

    }
}
