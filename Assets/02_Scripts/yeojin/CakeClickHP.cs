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

    private void Start()
    {
        cakeManager = GameObject.Find("CakeManage").GetComponent<CakeManager>();
        cakeSpawner = GameObject.Find("CakeSpawner").GetComponent<CakeSpawner>();
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        cakeManager.hpSlider.value = currentHP;

        if (cakeManager.hpSlider.value < 20)
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
        cakeManager.hpSlider.value = maxHP;
        cakeManager.sslider.SetActive(false);
    }
}
