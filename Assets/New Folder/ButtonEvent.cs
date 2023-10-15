using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public GameObject miusc;
    public bool isopen = true;
    public GameObject[] obj;
    private int i = 0;
    private int s = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TZ(int index)
    {
        obj[i].SetActive(false);

        i = index;
        obj[i].SetActive(true);

    }
    public void jia()
    {
        if (i < obj.Length-1)
        {
            obj[i].SetActive(false);
            obj[i + 1].SetActive(true);
            i++;
        }
    }  public void jian()
    {
        if (i > 0)
        {
            obj[i].SetActive(false);
            obj[i - 1].SetActive(true);
            i--;
        }
    }
    
     public void Exit()
    {
        Application.Quit();
    }
    public void again()
    {
        SceneManager.LoadScene(0);
    }
    public void audios()
    {
        isopen = !isopen;
        if (isopen)
        {
            AudioListener.volume = 1;
            //miusc.GetComponent<AudioSource>().Play();

        }
        else
        {
            AudioListener.volume = 0;

        }
    }
 
}
