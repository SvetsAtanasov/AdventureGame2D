using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture;

    [SerializeField] Vector2 textureCenter;

    void Start()
    {
        textureCenter = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, textureCenter, CursorMode.ForceSoftware);
    }
}
