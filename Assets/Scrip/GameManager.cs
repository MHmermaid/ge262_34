using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateCandidate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateCandidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();
            
            s.InitCharID(i);
            s.ChangeCharSkin();
        }
    }
}
