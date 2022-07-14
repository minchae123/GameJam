using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Talking : MonoBehaviour, IPointerDownHandler
{
    public Text dialog;
    public GameObject nextText;
    public CanvasGroup dialonggroup;
    private SpriteRenderer spriteRenderer;

    public Queue<string> sentences;
    public string CurrentSentence;

    private bool istype;
    public float a=0.0f;

    public float typingSpeed = 0.1f;
    public int maxDialogue=13;

    public string b;

    public static Talking instance;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        instance = this;
    }

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void Ondialogue(string[] lines)
    {
        
        sentences.Clear();
        

        foreach (string line in lines)
        {
            sentences.Enqueue(line);
        }

        dialonggroup.alpha = 1;
        dialonggroup.blocksRaycasts = true;

        Nextsentences();
    }

    public void Nextsentences()
    {
        if(sentences.Count!=0)
        {
            CurrentSentence = sentences.Dequeue();
            istype = true;

            nextText.SetActive(false);
            // ÄÚ·çÆ¾
            StartCoroutine(Typing(CurrentSentence));
            a++;
            Debug.Log(a);
        }    

        else
        {
            dialonggroup.alpha = 0;
            dialonggroup.blocksRaycasts = false;
        }
    }

    IEnumerator Typing(string line)
    {
        dialog.text = "";

        foreach(char letter in line.ToCharArray())
        {
            dialog.text += letter;
            
            yield return new WaitForSeconds(typingSpeed);
        }

    }

    void Update()
    {
        if(dialog.text.Equals(CurrentSentence))
        {
            nextText.SetActive(true);
            istype = false;
        }

        if (a > maxDialogue)
        {
            SceneLoader(b);
            a = 0;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!istype)
        {
            Nextsentences();
            
        }
    }
    public void SceneLoader(string b)
    {
        SceneManager.LoadScene(b);
    }

}
