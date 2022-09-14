using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> InnerAlertGameObject;

    public List<GameObject> InnerGoldsGameObject;

    public GameObject InnerGoldFrente;

    public GameObject InnerAlertFrente;

    public GameObject ButtonGameObjectAlert;

    public GameObject ButtonGameObjectGold;

    public RectTransform ContentAlert;

    public RectTransform ContentGold;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void ShowCardsInnerAlert()
    {
        ButtonGameObjectAlert.SetActive(false);
        var innerAlertFrente = Instantiate(InnerAlertFrente, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        innerAlertFrente.transform.SetParent(ContentAlert);
        innerAlertFrente.transform.SetAsLastSibling();
        innerAlertFrente.transform.localPosition = new Vector3(0, 0, 0);
        innerAlertFrente.transform.localScale = new Vector3(1, 1, 1);
        var innerAlert= Instantiate(InnerGoldsGameObject[Random.Range(0, InnerGoldsGameObject.Count)], new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        innerAlert.transform.SetParent(ContentAlert);
        innerAlert.transform.SetAsFirstSibling();
        innerAlert.transform.localPosition = new Vector3(0, 0, 0);
        innerAlert.transform.localScale = new Vector3(1, 1, 1);
        Invoke("ResetAlert", 7f);
    }

    public void ShowCardsInnerGold()
    {
        ButtonGameObjectGold.SetActive(false);
        var innerGoldFrente = Instantiate(InnerGoldFrente, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        innerGoldFrente.transform.SetParent(ContentGold);
        innerGoldFrente.transform.SetAsLastSibling();
        innerGoldFrente.transform.localPosition = new Vector3(0, 0, 0);
        innerGoldFrente.transform.localScale = new Vector3(1,1,1);
        var innerGold = Instantiate(InnerAlertGameObject[Random.Range(0, InnerAlertGameObject.Count)], new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        innerGold.transform.SetParent(ContentGold);
        innerGold.transform.SetAsFirstSibling();
        innerGold.transform.localPosition = new Vector3(0, 0, 0);
        innerGold.transform.localScale = new Vector3(1, 1, 1);
        Invoke("ResetGold", 5f);
    }

    public void ResetAlert()
    {
        ResetPanelAlert();
        ButtonGameObjectAlert.SetActive(true);
    }

    public void ResetGold()
    {
        ResetPanelGold();
        ButtonGameObjectGold.SetActive(true);
    }

    public void ResetPanelAlert()
    {
        int childCount = ContentAlert.childCount;
        Debug.Log(childCount);
        if(childCount > 0)
        {
            for(int i = 0; i < childCount; i++)
            {
                Destroy(ContentAlert.GetChild(i).gameObject);
                Debug.Log(childCount);
            }
        }
    }

    public void ResetPanelGold()
    {
        int childCount = ContentGold.childCount;
        Debug.Log(childCount);
        if (childCount > 0)
        {
            for (int i = 0; i < childCount; i++)
            {
                Destroy(ContentGold.GetChild(i).gameObject);
                Debug.Log(childCount);
            }
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenPage()
    {
        Application.OpenURL("https://www.tinamesa.com/");
    }
}