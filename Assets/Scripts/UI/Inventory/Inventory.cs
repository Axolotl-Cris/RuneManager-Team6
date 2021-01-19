using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject inventory;
    private bool inventoryEnabled;

    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;

    public GameObject slotHolder;

    void Start ()
    {

    }


    void Update()
    {
       // if (Input.GetKeyDown(KeyCode, I))
            inventoryEnabled = !inventoryEnabled;
       //
        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);

        }
        else
        {
            inventory.SetActive(false);
        }

    }


}
