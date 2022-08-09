using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    enum PlayerClass
    { 
        WARRIOR,
        SKELETON,
        CAT
    }
    
    public GameObject Warrior;
    public GameObject Skeleton;
    public GameObject Cat;

    public int SelectClass = 0;

    void Update()
    {
        ActiveClass();
        RotateClass();
    }

    void ActiveClass()
    {
        if (SelectClass == (int)PlayerClass.WARRIOR)
        {
            Warrior.SetActive(true);
        }
        else
        {
            Warrior.SetActive(false);
        }
        if (SelectClass == (int)PlayerClass.SKELETON)
        {
            Skeleton.SetActive(true);
        }
        else
        {
            Skeleton.SetActive(false);
        }
        if (SelectClass == (int)PlayerClass.CAT)
        {
            Cat.SetActive(true);
        }
        else
        {
            Cat.SetActive(false);
        }

    }

    void RotateClass()
    {
        if (SelectClass == (int)PlayerClass.WARRIOR)
        {
            Skeleton.transform.Rotate(Vector3.up * Time.deltaTime * 20);
            Skeleton.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            Cat.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (SelectClass == (int)PlayerClass.SKELETON)
        {

            Warrior.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            Cat.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (SelectClass == (int)PlayerClass.CAT)
        {

            Skeleton.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            Warrior.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

    }

    

}
