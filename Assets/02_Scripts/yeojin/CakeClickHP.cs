using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeClickHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 20;
    private float currentHP;
    private Cake cake;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    GameObject hpslider;

    private void Start()
    {
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        hpslider = GameObject.Find("Clickslider");
    }

    private void Update()
    {
        hpslider.GetComponent<Slider>().value = currentHP;
    }
    
    public void Takedam(float click)
    {
        currentHP -= click;

        StopCoroutine("Hit");
        StartCoroutine("Hit");

        if(currentHP<=0)
        {
            cake.Ondie();
        }

    }

    private IEnumerator Hit()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);

        spriteRenderer.color = Color.white;
    }
}
