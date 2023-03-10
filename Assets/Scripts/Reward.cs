using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public float Duration;
    private float _timeElapse;
    public Gradient gradient;
    public SpriteRenderer renderer;
    // Update is called once per frame
    void Update()
    {
        
        _timeElapse += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (_timeElapse > Duration)
        {
            Destroy(gameObject);
        }
        else
        {
            renderer.color = gradient.Evaluate((float)_timeElapse/(float)Duration);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Circle"))
        {
            Destroy(gameObject);
        }
    }
}
