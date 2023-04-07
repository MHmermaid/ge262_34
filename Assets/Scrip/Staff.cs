using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    private int id;
    public int ID { get { return id; } set { id = value; } }

    private int charSkinId;
    public int CharShinID { get { return charSkinId; } set { charSkinId = value; } }
    public GameObject[] charSkin;

    public string staffName;
    public int dailyWage;
}
