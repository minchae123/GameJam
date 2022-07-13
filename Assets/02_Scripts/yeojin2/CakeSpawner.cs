using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeSpawner : MonoBehaviour
{
    public GameObject ClickText;
    public GameObject CakePref;
    public GameObject CakeHPslider;
    public Transform canvasTrans;

    public int minST = 10; // �ּ� ���� �ð�
    public int maxST = 25; // �ִ� ���� �ð�
    
    // ����ũ ����
    float posX = 11f; 
    float posY = -3.835135f;

    // �ؽ�Ʈ ����
    float posX2 = -3.6f;
    float posY2 = -1.2f;

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
        // ����ũ ����
        Vector3 CakeSpawn = new Vector3(posX, posY, 0);
        cakeClone = Instantiate(CakePref, CakeSpawn, Quaternion.identity);
        currentCakeClickHP = cakeClone.GetComponent<CakeClickHP>();
        //SpawnCakeHPSlider(cakeClone);

        yield return new WaitForSeconds(2.5f); // 4�ʰ� ���

        // �ؽ�Ʈ ����
        Vector3 TextSpawn = new Vector3(posX2, posY2, 0);
        GameObject CakeText = Instantiate(ClickText, TextSpawn, Quaternion.identity);
        cakeManager.sslider.SetActive(true);
        yield return new WaitForSeconds(3.0f); // 3�ʰ� ���

        Destroy(CakeText); // �ؽ�Ʈ ������Ʈ ����

        // ��ٸ� + �����
        float spawnT = Random.Range(minST, maxST);
        yield return new WaitForSeconds(spawnT);
        isSpawn = true;

    }

/*    private void SpawnCakeHPSlider(GameObject Cake)
    {
        GameObject sliderClone = Instantiate(CakeHPslider);

        sliderClone.transform.SetParent(canvasTrans);
        sliderClone.transform.localScale = Vector3.one;

        sliderClone.GetComponent<SliderAuto>().Setup(Cake.transform);

    }
*/
}
