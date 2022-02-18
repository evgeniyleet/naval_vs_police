using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BothPlayer : MonoBehaviour
{
    [SerializeField] List <GameObject> SWAT;
    [SerializeField] List <GameObject> GaysAndAnime;
    [SerializeField] GameObject wins1;
    [SerializeField] GameObject wins2;
    [SerializeField] 
    private double coinFirst;
    [SerializeField] 
    private double coinSecond;
    [SerializeField] 
    private int scoreFirst;
    [SerializeField] 
    private int scoreSecond;
    [SerializeField]
    private GameObject prefabWeaponFirstPlayer;
    [SerializeField]
    private GameObject prefabWeaponSecondPlayer;
    private CreateWeapon crW = new CreateWeapon();
    [SerializeField]
    private Image image;
    public Text moneyFirstPlayer;
    public Text moneySecondPlayer;
    private int PointPerClick1 = 1;
    private int PointPerClick2 = 1;
    [SerializeField] Button GameField1;
    [SerializeField] Button GameField2;
    public Text scoreFirstPlayer;
    public Text scoreSecondPlayer;
    [SerializeField] GameObject Draw;
    public Image imageFirst;
    public Image imageSecond;
    public Button btnFirst;
    public Button btnSecond;
    public Button btnFirst_2;
    public Button btnSecond_2;
    public Image imageFirst_2;
    public Image imageSecond_2;
    private bool fl1_1 = true;
    private bool fl1_2 = true;
    private bool fl1_3 = true;
    private bool fl1_4 = true;
    private bool fl2_1 = true;
    private bool fl2_2 = true;
    private bool fl2_3 = true;
    private bool fl2_4 = true;

    public void BuffClickFirst_2()
    {
        if(coinFirst >= 3 && scoreSecond >=25)
        {
            imageFirst_2.color = new Color32(123, 123, 123, 255);
            coinFirst -= 3;
            scoreSecond -= 25;
        }
    }

    public void BuffClickSecond_2()
    {
        if (coinSecond >= 3 && scoreFirst >= 25)
        {
            imageSecond_2.color = new Color32(123, 123, 123, 255);
            coinSecond -= 3;
            scoreFirst -= 25;
        }
    }

    public void BuffClickFirst()
    {
        if (coinFirst >= 10)
        {
            imageFirst.color = new Color32(123, 123, 123, 255);
            coinFirst -= 10;
            StartCoroutine(PointPerClickUp(5));
        }
        return;
    }
    
    IEnumerator PointPerClickUp(float t)
    {
        PointPerClick1 += 5;
        yield return new WaitForSeconds(t);
        PointPerClick1 -= 5;
    }

    IEnumerator PointPerClickUp2(float t)
    {
        PointPerClick2 += 5;
        yield return new WaitForSeconds(t);
        PointPerClick2 -= 5;
    }
    void SherengaBuff1()
    {
        PointPerClick1++;
    }
    void SherengaBuff2()
    {
        PointPerClick2++;
    }
    public void BuffClickSecond()
    {
        if(coinSecond >=10)
        {
            imageSecond.color = new Color32(123, 123, 123, 255);
            coinSecond -= 10;
            StartCoroutine(PointPerClickUp2(5));
        }
        return;
    }

    public void ButtonClickFirstPlayer()
    {
        crW.CreateWeaponFirstPlayer(prefabWeaponFirstPlayer);
        image.fillAmount += 0.01f;
        scoreFirst += PointPerClick1;
    }

    public void ButtonClickSecondPlayer()
    {
        crW.CreateWeaponSecondPlayer(prefabWeaponSecondPlayer);
        image.fillAmount -= 0.01f;
        scoreSecond += PointPerClick2;
    }
    void Start()
    {
        Draw.SetActive(false);
        wins1.SetActive(false);
        wins2.SetActive(false);
        InvokeRepeating("TimeStartGame", 1.0f, 1f);
        Invoke("Draw1", 600f);
        for(int i = 0; i< SWAT.Count; i++)
        {
            SWAT[i].SetActive(false);
            GaysAndAnime[i].SetActive(false);
        }
        
    }
    void Update()
    {

        //if((scoreFirst - scoreSecond) >= 500)

        btnFirst.interactable = false;
        btnSecond.interactable = false;
        btnFirst_2.interactable = false;
        btnSecond_2.interactable = false;
        if(coinFirst >=3)
        {
            btnFirst_2.interactable = true;
            imageFirst_2.color = new Color32(0, 255, 0, 255);
        }

        if(coinSecond >= 3)
        {
            btnSecond_2.interactable = true;
            imageSecond_2.color = new Color32(0, 255, 0, 255);
        }

        if (coinFirst >=10)
        {
            btnFirst.interactable = true;
            imageFirst.color = new Color32(0, 255, 0, 255);
        }
        
        if (coinSecond >= 10)
        {
            btnSecond.interactable = true;
            imageSecond.color = new Color32(0, 255, 0, 255);
        }

        if ((scoreFirst - scoreSecond) >= 500)
        {
            //FIRST PLAYER WIN
            wins1.SetActive(true);
            GameField1.interactable = false;
            GameField2.interactable = false;

        }
        if((scoreSecond - scoreFirst) >= 500)
        {
            //SECOND PLAYER WIN
            wins2.SetActive(true);
            GameField1.interactable = false;
            GameField2.interactable = false;
        }
        int returnTextFirst = (int)(coinFirst + 0.1);
        moneyFirstPlayer.text = returnTextFirst.ToString();
        int returnTextSecond = (int)(coinSecond + 0.1);
        moneySecondPlayer.text = returnTextSecond.ToString();

        scoreFirstPlayer.text = scoreFirst.ToString();
        scoreSecondPlayer.text = scoreSecond.ToString();
        
        if(scoreFirst >= 50)
        {
            SWAT[0].SetActive(true);
            if (fl1_1)
            {
                PointPerClick1++;
                fl1_1 = false;
            } 
        }
        if(scoreFirst >= 200)
        {
            SWAT[1].SetActive(true);
            if (fl1_2)
            {
                PointPerClick1++;
                fl1_2 = false;
            } 
        }
        if(scoreFirst >= 1000)
        {
            SWAT[2].SetActive(true);
            if (fl1_3)
            {
                PointPerClick1++;
                fl1_3 = false;
            }
        }
        if(scoreFirst >= 5000)
        {
            SWAT[3].SetActive(true);
            if (fl1_4)
            {
                PointPerClick1++;
                fl1_4 = false;
            } 
        }
        if(scoreSecond >= 50)
        {
            GaysAndAnime[0].SetActive(true);
            if (fl2_1)
            {
                PointPerClick2++;
                fl2_1 = false;
            } 
        }
        if(scoreSecond >= 200)
        {
            GaysAndAnime[1].SetActive(true);
            if (fl2_2)
            {
                PointPerClick2++;
                fl2_2 = false;
            }
        }
        if(scoreSecond >= 1000)
        {
            GaysAndAnime[2].SetActive(true);
            if (fl2_3)
            {
                PointPerClick2++;
                fl2_3 = false;
            } 
        }
        if(scoreSecond >= 5000)
        {
            GaysAndAnime[3].SetActive(true);
            if (fl2_4)
            {
                PointPerClick2++;
                fl2_4 = false;
            }
        }
    }
    public void TimeStartGame()
    {
        if((scoreFirst - scoreSecond) >= 10)
        {
            coinFirst += 1;
        }
        if((scoreSecond - scoreFirst) >= 10)
        {
            coinSecond += 1;
        }
    }
    public void Draw1()
    {
        Draw.SetActive(true);
        GameField1.interactable = false;
        GameField2.interactable = false;
    }
}
