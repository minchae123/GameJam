using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeSpawner : MonoBehaviour
{
    public GameObject ClickText;
    public GameObject[] CakePref;
    public GameObject CakeHPslider;
    public Transform canvasTrans;

    public int minST = 10; // 최소 스폰 시간
    public int maxST = 25; // 최대 스폰 시간
    
    // 케이크 스폰
    float posX = 11f; 
    float posY = -3.835135f;

    // 텍스트 스폰
    //float posX2 = -3.6f;
    //float posY2 = -1.2f;
    public Transform pos;
    CakeManager cakeManager;

    public bool isSpawn = true;

    private GameObject cakeClone = null;
    private CakeClickHP currentCakeClickHP = null;

    private void Start()
    {
        cakeManager = GameObject.Find("CakeManage").GetComponent<CakeManager>();
        StartCoroutine("SpawnCake");
        
    }

    private void Update()
    {
        if(cakeClone == null && isSpawn)
        {
            StartCoroutine(SpawnCake());
        }
    }

    private IEnumerator SpawnCake()
    {
        isSpawn = false;
        int r = Random.Range(0, 3);
        // 케이크 생성
        Vector3 CakeSpawn = new Vector3(posX, posY, 0);
        cakeClone = Instantiate(CakePref[r], CakeSpawn, Quaternion.identity);
        pos=cakeClone.transform.GetChild(0);
        currentCakeClickHP = cakeClone.GetComponent<CakeClickHP>();
        currentCakeClickHP.SetHpBar(SpawnCakeHPSlider(cakeClone));

        yield return new WaitForSeconds(0.5f); // 4초간 대기

        cakeManager.sslider.SetActive(true);
       //cakeManager.sslider.GetComponent<SliderAuto>().Setup(cakeClone.transform);

        yield return new WaitForSeconds(3.0f); // 3초간 대기

       // Destroy(CakeText); // 텍스트 오브젝트 삭제

        // 기다림 + 재생성
        float spawnT = Random.Range(minST, maxST);
        yield return new WaitForSeconds(spawnT);
        isSpawn = true;

    }

    private Slider SpawnCakeHPSlider(GameObject Cake)
    {
        GameObject sliderClone = Instantiate(CakeHPslider);

        sliderClone.transform.SetParent(canvasTrans);
        //sliderClone.transform.localScale = Vector3.one;
        sliderClone.GetComponent<SliderAuto>().Setup(Cake.transform);
        return sliderClone.GetComponent<Slider>();
    }

}
