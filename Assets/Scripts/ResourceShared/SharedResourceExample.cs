using UnityEngine;

public class SharedResourceExample : MonoBehaviour
{
    private Sprite nonStaticSprite;
    private static Sprite staticSprite;
    void Awake()
    {
        nonStaticSprite = Resources.Load<Sprite>("Non Static Sprite");

        if (staticSprite == null)
            staticSprite = Resources.Load<Sprite>("Static Sprite");
    }
}

