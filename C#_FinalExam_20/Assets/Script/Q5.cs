using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

//[ExecuteAlways]
public class Q5 : MonoBehaviour
{
    public Button but;

    public List<GameObject> cards = new List<GameObject>();
    public string[] type = { "Spades", "Heart", "Diamond", "Club" };

    void GetAllCard()
    {
        if (cards.Count == 52) return;
        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 1; j < 14; j++)
            {
                string number = j.ToString();       

                switch (j)
                {

                    case 1:
                        number = "A";               
                        break;
                    case 11:
                        number = "J";               
                        break;
                    case 12:
                        number = "Q";               
                        break;
                    case 13:
                        number = "K";               
                        break;
                }

                GameObject card = Resources.Load<GameObject>("PlayingCards_" + number + type[i]);
                cards.Add(card);
            }

        }
    }

    private void Start()
    {
        GetAllCard();
        Sort();
    }

    private IEnumerator SetChildPosition()
    {
        yield return new WaitForSeconds(0.1F);                  

        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);            
            child.eulerAngles = new Vector3(180, 0, 0);         
            child.localScale = Vector3.one * 20;                

            float x = i % 13;                                   
            int y = i / 13;                                     
            child.position = new Vector3((x - 6) * 1.3f, 5 - y * 2F, 0);   

            yield return null;
        }
    }

    public void DeleltAllChild()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }

    public void Sort()
    {
        DeleltAllChild();            
        var sort = from card in cards
                   where card.name.Contains(type[0]) || card.name.Contains(type[1]) || card.name.Contains(type[2]) || card.name.Contains(type[3])
                   select card;

        foreach (var item in sort)
        {
            Instantiate(item, transform);
            StartCoroutine(SetChildPosition());
        }
    }

    public void DeleteEvenChild()
    {
        for (int i = 0; i <transform.childCount ; i++)
        {
            if (i ==1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11
                || i == 14 || i == 16 || i == 18 || i == 20 || i == 22 || i == 24
                || i == 27 || i == 29 || i == 31 || i == 33 || i == 35 || i == 37
                || i == 40 || i == 42 || i == 44 || i == 46 || i == 48 || i == 50)
            {
                Destroy(transform.GetChild(i).gameObject);
                but.interactable = false;
            }
        }
        
    }
}
