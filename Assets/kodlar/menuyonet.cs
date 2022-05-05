using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuyonet : MonoBehaviour
{
    public int seviye;
    gereken grkn;
    
    // Start is called before the first frame update
    void Start()
    {
        grkn = GameObject.Find("gerekentophesapla").GetComponent<gereken>();
    }
    public void oyna()
    {
        
        int kayitlevel = PlayerPrefs.GetInt("kayit");
        if (kayitlevel == 0)
        {
            SceneManager.LoadScene("1");
        }
        else 
        {
            SceneManager.LoadScene("1");
        }
    }
    public void menugit()
    {
        PlayerPrefs.SetInt("bolumgecildi", 0);
        SceneManager.LoadScene("menu");
        
    }
    public void bolumgec()
    {
        seviye = PlayerPrefs.GetInt("kayit") + 1;
        PlayerPrefs.SetInt("kayit", seviye);
        
        PlayerPrefs.SetInt("bolumgecildi", 1);
        PlayerPrefs.SetInt("para", grkn.para);
SceneManager.LoadScene((SceneManager.GetActiveScene().name));
    }
    public void tekrardene()
    {
        PlayerPrefs.SetInt("bolumgecildi", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
