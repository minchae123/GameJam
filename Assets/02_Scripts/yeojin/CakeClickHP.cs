using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeClickHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 20;
    private float currentHP;

    private SpriteRenderer spriteRenderer;
    CakeMove cakeMove;

    CakeManager cakeManager;

    private void Start()
    {
        cakeManager = GameObject.Find("UIManager").GetComponent<CakeManager>();
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        cakeMove = FindObjectOfType<CakeMove>();
    }

    private void Update()
    {
        cakeManager.hpSlider.value = currentHP;
    }
    
    public void Takedam(float click)
    {
        currentHP -= click;

        StopCoroutine("Hit");
        StartCoroutine("Hit");

        if(currentHP<=0)
        {
            Destroy(gameObject);
            cakeManager.hpSlider.value = maxHP;
        }
    }

    private IEnumerator Hit()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);

        spriteRenderer.color = Color.white;
    }
}
