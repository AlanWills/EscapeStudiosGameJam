using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class WaitForKeysPressedWithSpriteSwap : WaitForKeysPressed
{
    public Sprite SuccessSprite;
    
    protected override void OnCorrect()
    {
        base.OnCorrect();

        gameObject.GetComponent<Image>().sprite = SuccessSprite;
    }
}
