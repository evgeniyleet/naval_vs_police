using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWeapon : MonoBehaviour
{

    public void CreateWeaponFirstPlayer(GameObject objPrefab)
    {
        var weapon = Instantiate(objPrefab, objPrefab.transform.position, objPrefab.transform.rotation);
        weapon.GetComponent<Animator>().SetTrigger("trig");
    }

    public void CreateWeaponSecondPlayer(GameObject objPrefab)
    {
        var weapon = Instantiate(objPrefab, objPrefab.transform.position, objPrefab.transform.rotation);
        weapon.GetComponent<Animator>().SetTrigger("trig");
    }
}
