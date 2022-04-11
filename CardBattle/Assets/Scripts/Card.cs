using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : CardBehavior
{

    public AudioClip flipSound;
    SpriteRenderer mySpriteRend;
    Sprite newSprite;

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        GetComponent<Animator>().SetTrigger("doBounce");
    }

    protected override void SelectedChanges()
    {
        base.SelectedChanges();
        GetComponent<AudioSource>().PlayOneShot(flipSound);
    }
}
