using UnityEngine;
public class ChangeColor : MonoBehaviour
{

    // Reference to Sprite Renderer component
    private SpriteRenderer rend;

    // Color value that we can set it Inspector
    // It's White by default
    [SerializeField]
    private Color colorToTurnTo = Color.white;

    // Use this for Initialization
    private void Start()
    {

        // Assign Sprite Renderer Component to rend variable
        rend = GetComponent<SpriteRenderer>();

        // Change sprite color to selected color
        rend.color = colorToTurnTo;
    }
}



