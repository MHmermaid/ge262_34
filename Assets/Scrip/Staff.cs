using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum UnitState
{
    Idle,
    Walk
}

public class Staff : MonoBehaviour
{
    private int _id;
    public int ID { get { return _id; } set { _id = value; } }

    private int charSkinId;
    public int CharShinID { get { return charSkinId; } set { charSkinId = value; } }
    public GameObject[] charSkin;

    public string staffName;
    public int dailyWage;
    
    //Aimation
    [SerializeField] private UnitState state;
    public UnitState State { get { return state; } set { state = value; } }

    public void InitCharID(int id)
    {
        _id = id;
        charSkinId = Random.Range(0, charSkin.Length - 1);
        staffName = "XXXX";
        dailyWage = Random.Range(80, 125);
    }

    public void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if ( i == CharShinID)
                charSkin[i].SetActive(true);
            else 
                charSkin[i].SetActive(false);
        }
    }
}
