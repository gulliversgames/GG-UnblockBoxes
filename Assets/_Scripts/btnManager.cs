using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Linq;
public class btnManager : MonoBehaviour
{
    [SerializeField]
    public GameObject unblockBtn;
    public Sprite skin1Sprite;
    public Sprite skin2Sprite;
    public Sprite skin3Sprite;
    public Sprite skin4Sprite;
    public Sprite skin5Sprite;
    public Sprite skin6Sprite;
    public Sprite skin7Sprite;
    public Sprite skin8Sprite;
    public Sprite skin9Sprite;
    private List<int> randomList = new List<int>(10);
    private List<int> chosenList = new List<int>(10);
    private int counter = 0;
    private int skinCounter = 0;
    private int lengthOfSearch;

    private GameObject skin1;
    private GameObject skin2;
    private GameObject skin3;
    private GameObject skin4;
    private GameObject skin5;
    private GameObject skin6;
    private GameObject skin7;
    private GameObject skin8;
    private GameObject skin9;
    private GameObject tempSkin;
  
    string defaultFrameColor = "#808080";
    string activeFrameColor = "#29872D";
    Color newCol;

    public void unblockBox()
    {
        //bütün skinler açıldığında durması için
        if (skinCounter < 9)
        {
            skin1 = GameObject.Find("Skin1");
            skin2 = GameObject.Find("Skin2");
            skin3 = GameObject.Find("Skin3");
            skin4 = GameObject.Find("Skin4");
            skin5 = GameObject.Find("Skin5");
            skin6 = GameObject.Find("Skin6");
            skin7 = GameObject.Find("Skin7");
            skin8 = GameObject.Find("Skin8");
            skin9 = GameObject.Find("Skin9");

            //her zaman 10 tane random seçim yapması için
            lengthOfSearch = 10;

            if (ColorUtility.TryParseHtmlString(defaultFrameColor, out newCol))
            {
                skin1.GetComponent<Image>().color = newCol;
                skin1.GetComponent<Button>().interactable = false;
            }
            randomList.Clear();
            for (int i = 0; i < lengthOfSearch; i++)
            {
                int randomNum = Random.Range(1, 10);
                if (!chosenList.Contains(randomNum))
                {
                    randomList.Add(randomNum);
                }
                else
                {
                    lengthOfSearch++;
                    Debug.Log("bu sayı chosenListte yer alıyor:" + randomNum);
                }
            }

            StartCoroutine(Delay(randomList));

        }

    }

    IEnumerator Delay(List<int> randomList)
    {
        if (counter == 0)
        {
            tempSkin = skin1;
        }

        // random kutular arasında çerçevenin gezinmesi için
        foreach (var item in randomList)
        {
            counter++;
            yield return new WaitForSecondsRealtime(0.2f);

            if (ColorUtility.TryParseHtmlString(defaultFrameColor, out newCol))
            {
                tempSkin.GetComponent<Image>().color = newCol;
                tempSkin.GetComponent<Button>().interactable = false;
            }

            if (item == 1)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin1.GetComponent<Image>().color = newCol;
                    skin1.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin1.transform.Find("SkinImage").GetComponent<Image>().sprite = skin1Sprite;
                    }
                }
                tempSkin = skin1;

            }
            else if (item == 2)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin2.GetComponent<Image>().color = newCol;
                    skin2.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin2.transform.Find("SkinImage").GetComponent<Image>().sprite = skin2Sprite;
                    }
                }
                tempSkin = skin2;
            }
            else if (item == 3)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin3.GetComponent<Image>().color = newCol;
                    skin3.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin3.transform.Find("SkinImage").GetComponent<Image>().sprite = skin3Sprite;
                    }
                }
                tempSkin = skin3;
            }
            else if (item == 4)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin4.GetComponent<Image>().color = newCol;
                    skin4.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin4.transform.Find("SkinImage").GetComponent<Image>().sprite = skin4Sprite;
                    }
                }
                tempSkin = skin4;
            }
            else if (item == 5)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin5.GetComponent<Image>().color = newCol;
                    skin5.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin5.transform.Find("SkinImage").GetComponent<Image>().sprite = skin5Sprite;
                    }
                }
                tempSkin = skin5;
            }
            else if (item == 6)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin6.GetComponent<Image>().color = newCol;
                    skin6.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin6.transform.Find("SkinImage").GetComponent<Image>().sprite = skin6Sprite;
                    }
                }
                tempSkin = skin6;
            }
            else if (item == 7)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin7.GetComponent<Image>().color = newCol;
                    skin7.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin7.transform.Find("SkinImage").GetComponent<Image>().sprite = skin7Sprite;
                    }
                }
                tempSkin = skin7;
            }
            else if (item == 8)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin8.GetComponent<Image>().color = newCol;
                    skin8.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin8.transform.Find("SkinImage").GetComponent<Image>().sprite = skin8Sprite;
                    }
                }
                tempSkin = skin8;
            }
            else if (item == 9)
            {
                if (ColorUtility.TryParseHtmlString(activeFrameColor, out newCol))
                {
                    skin9.GetComponent<Image>().color = newCol;
                    skin9.GetComponent<Button>().interactable = true;
                    if ((counter) % 10 == 0)
                    {
                        skin9.transform.Find("SkinImage").GetComponent<Image>().sprite = skin9Sprite;
                    }
                }
                tempSkin = skin9;
            }
            Debug.Log(item);

            // seçilen kutunun tekrar aramaya dahil olmaması için
            if ((counter) % 10 == 0)
            {
                chosenList.Add(item);
                skinCounter++;

                Debug.Log("seçilen: " + item);
            }
        }
    }

}
