using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;


public class ButtonAnimations : MonoBehaviour, IPointerClickHandler
{

    [SerializeField] private float _hoverScale = 1.2f;
    [SerializeField] private float _animationDuration = 0.2f;
    private Vector3 _originalScale; 

    private void Start()
    {
        _originalScale = transform.localScale;
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        transform.DOScale(_originalScale * _hoverScale, _animationDuration).SetEase(Ease.Linear)
                .onComplete = () => {
                transform.DOScale(_originalScale, _animationDuration).SetEase(Ease.Linear);
        }
        ;
    }

}
