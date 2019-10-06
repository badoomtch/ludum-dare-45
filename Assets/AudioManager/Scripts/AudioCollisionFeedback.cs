﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollisionFeedback : BaseAudioFeedback
{
    [SerializeField]
    [Tooltip("Will only play sound on collision with this layer")]
    LayerMask collidesWith;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Contains(collidesWith, collision.gameObject.layer))
        {
            if (soundFile != null)
            {
                am.PlaySoundOnce(soundFile, transform, priority, pitchShift);
            }
            else
            {
                am.PlaySoundOnce(sound, transform, priority, pitchShift);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Contains(collidesWith, collision.gameObject.layer))
        {
            if (soundFile != null)
            {
                am.PlaySoundOnce(soundFile, transform, priority, pitchShift);
            }
            else
            {
                am.PlaySoundOnce(sound, transform, priority, pitchShift);
            }
        }
    }

    /// <summary>
    /// Extension method to check if a layer is in a layermask
    /// </summary>
    /// <param name="mask"></param>
    /// <param name="layer"></param>
    /// <returns></returns>
    // With help from these lads
    // https://answers.unity.com/questions/50279/check-if-layer-is-in-layermask.html
    public static bool Contains(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }
}