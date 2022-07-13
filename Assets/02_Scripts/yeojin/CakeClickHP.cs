using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeClickHP : MonoBehaviour
{
  
    public float maxHP = 20;
    public float currentHP;

    private SpriteRenderer spriteRenderer;
    CakeManager cakeManager;
    CakeSpawner cakeSpawner;
    Height heightt;

    private Slider hpBar;

    private void Start()
    {
        heightt = GameObject.Find("Manager").GetComponent<Height>();
        cakeManager = GameObject.Find("CakeManage").GetComponent<CakeManager>();
        cakeSpawner = GameObject.Find("CakeSpawner").GetComponent<CakeSpawner>();
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(hpBar == null)
        {
            return;
        }

        hpBar.value = currentHP;

        if (hpBar.value < 20)
        {
            currentHP += Time.deltaTime * 2;
        }
    }
    
    public void Takedam(float click)
    {
        currentHP -= click;
        StopCoroutine("Hit");
        StartCoroutine("Hit");

        if(currentHP < 0)
        {
            heightt.height -= 2.5f;
            NextCake();
            Destroy(gameObject);
        }
    }

    private IEnumerator Hit()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);

        spriteRenderer.color = Color.white;
    }

    private void NextCake()
    {
        hpBar.value = maxHP;
        Destroy(hpBar.gameObject);
    }

    public void SetHpBar(Slider hpBar)
    {
        this.hpBar = hpBar;
    }
}
