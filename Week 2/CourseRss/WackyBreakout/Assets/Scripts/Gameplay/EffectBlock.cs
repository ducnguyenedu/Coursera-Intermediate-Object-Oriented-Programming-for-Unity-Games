using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An effect block
/// </summary>	
public class EffectBlock : Block
{
    #region Fields

    [SerializeField]
    Sprite freezerSprite;
    [SerializeField]
    Sprite speedupSprite;

    // effect-specific values
    EffectName effect;

    #endregion

    #region Properties

    /// <summary>
    /// Sets the effect for the pickup
    /// </summary>
    /// <value>pickup effect</value>
    public EffectName Effect
    {
        set
        {
            effect = value;

            // set sprite
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (effect == EffectName.Freezer)
            {
                spriteRenderer.sprite = freezerSprite;
            }
            else
            {
                spriteRenderer.sprite = speedupSprite;
            }
        }
    }

    #endregion

    #region Unity methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        Points = ConfigurationUtils.EffectBlockPoints;
    }

    /// <summary>
	/// Update is called once per frame
	/// </summary>	
    void Update()
    {
        
    }

    #endregion
}
