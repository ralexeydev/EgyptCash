using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : MonoBehaviour
{
    [Header("Symbol Data")]
    public int symbolId;
    
    [Header("References")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject winFrame;

    /// <summary>
    /// Sets the symbol ID and updates the visual representation.
    /// </summary>
    /// <param name="id">Unique ID for the symbol.</param>
    /// <param name="sprite">Sprite to display.</param>
    public void SetSymbol(int id, Sprite sprite)
    {
        symbolId = id;
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = sprite;
        }
    }

    /// <summary>
    /// Plays a symbol animation using a trigger name.
    /// </summary>
    /// <param name="triggerName">The name of the animation trigger.</param>
    public void PlaySymbolAnimation(string triggerName)
    {
        if (animator != null)
        {
            animator.SetTrigger(triggerName);
        }
    }

    /// <summary>
    /// Shows or hides the win frame (highlight) for this symbol.
    /// </summary>
    /// <param name="show">True to show, false to hide.</param>
    public void ShowFrame(bool show)
    {
        if (winFrame != null)
        {
            winFrame.SetActive(show);
        }
    }
}
