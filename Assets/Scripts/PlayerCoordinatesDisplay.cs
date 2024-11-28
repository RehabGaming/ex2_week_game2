using UnityEngine;
using TMPro;

public class PlayerCoordinatesDisplay : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public TMP_Text coordinatesText; // Reference to the TMP_Text component

    void Update()
    {
        if (player == null)
        {
            Debug.LogError("Player reference is missing!");
            return;
        }

        if (coordinatesText == null)
        {
            Debug.LogError("Coordinates Text reference is missing!");
            return;
        }

        // Update the text with the player's coordinates
        coordinatesText.text = "Player Position: (" +
            player.position.x.ToString("F2") + ", " +
            player.position.y.ToString("F2") + ")";
    }
}
