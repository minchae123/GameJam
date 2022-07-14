using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeClickHP : MonoBehaviour
{
    public float maxHP = 20;
    public float currentHP;
    public float curTime;

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
            currentHP += Time.deltaTime * 1;
        }
        curTime += Time.deltaTime;
        if(curTime > 8)
        {
            heightt.height += 3f;
            NextCake();
            curTime = 0;
            Destroy(gameObject);
        }
    }
    
    public void Takedam(float click)
    {
        currentHP -= click;
        StopCoroutine("Hit");
        StartCoroutine("Hit");

        if(currentHP < 0)
        {
            heightt.height -= 1.5f;
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
