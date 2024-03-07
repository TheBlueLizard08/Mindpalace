using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    private Timer timer;
    private Animation FlickerAnim;

    private void Awake()
    {
        System.Action onTimerExpired = LightFlicker;
        timer = new Timer(2.0f, onTimerExpired, true, true);
    }

    private void Start()
    {
        FlickerAnim = gameObject.GetComponent<Animation>();
        FlickerAnim["Flicker"].layer = 123;
    }

    private void Update()
    {
        timer.RunTimer();
    }

    void LightFlicker()
    {
        timer.SetLength(Random.Range(0.5f, 5.0f));
        FlickerAnim.Play("Flicker");
    }
}
