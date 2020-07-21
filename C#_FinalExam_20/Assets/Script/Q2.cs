using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;


[ExecuteAlways]
public class Q2 : MonoBehaviour
{
    [Header("開抽")]
    public Button but;
    public Image Priz;
    public Sprite[] PrizImages;

    /*public List<GameObject> priz = new List<GameObject>();
    public string[] type = { "apple", "armor", "axe", "b_t_01","bag","belts","book","boots",
    "bracers","cloaks","coins","gem","gloves","helmets","hp","ingots","Meat","mp","necklace",
    "pants","rings","scroll","shield","shoulders","sword"};*/



    public void Gacha()
    {

        int r = Random.Range(0, PrizImages.Length);
        Priz.sprite = PrizImages[r];



    }
    
    

    

    /*void GetAllImag()
    {
        for (int i = 0; i < type.Length; i++)
        {
            GameObject prop = Resources.Load<GameObject>(""+type[i]);
            priz.Add(prop);
        }
    }*/

}
