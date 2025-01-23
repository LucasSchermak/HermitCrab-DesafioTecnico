using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpriteReflect :  MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private float _animationDuration = 0.3f;
    private float _originalValue;
    
    public float triggerChance = 0.1f;
    [SerializeField]private bool _isAnimating;
    
    [SerializeField]private List<Image> _targetImages;
    
    void Start()
    {
        if (_targetImages == null || _targetImages.Count == 0)
        {
            _targetImages = FindObjectsOfType<Image>()
                .Where(img => img.material.HasProperty("_Slider"))
                .ToList();
        }
    }

    private void Update()
    {
        if (!_isAnimating && Random.value < triggerChance)
        {
            ReflectAnimation();
        }
    }

    void ReflectAnimation()
    {
        _isAnimating = true;

        foreach (var image in _targetImages)
        {
            if (image != null)
            {
                image.material.DOFloat(2f, "_Slider", _animationDuration).onComplete += () =>
                {
                    image.material.SetFloat("_Slider", 0);
                    _isAnimating = false;
                };
            }
        }
    }
}
    
    