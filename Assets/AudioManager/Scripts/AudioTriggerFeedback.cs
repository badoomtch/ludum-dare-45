﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerFeedback : BaseAudioFeedback
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    private void OnTriggerEnter(Collider collision)
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

    private void OnTriggerEnter2D(Collider2D collision)
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