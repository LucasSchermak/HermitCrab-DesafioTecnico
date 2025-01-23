using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteLocalCoord : MonoBehaviour
{
    private Image _spriteImage;
    
    void Start() {
        _spriteImage = GetComponent<Image>();

        _spriteImage.material = new Material(_spriteImage.material);

        Sprite sprite = _spriteImage.sprite;
        Rect rect = sprite.textureRect;
        
        Vector2 texelSize = sprite.texture.texelSize;
        Vector4 uvRemap = new (
            rect.x * texelSize.x,
            rect.y * texelSize.y,
            rect.width * texelSize.x,
            rect.height * texelSize.y
        );
            _spriteImage.material.SetVector("_Rect", uvRemap);
    }
}

