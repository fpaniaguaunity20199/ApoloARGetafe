using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MiTrackableEventHandler : DefaultTrackableEventHandler
{
    public VideoPlayer videoPlayer;
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        videoPlayer.Play();
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        videoPlayer.Pause();
    }
}
