using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    // https://www.youtube.com/watch?v=Dn_BUIVdAPg
    // video link
    public int selectedWeapon = 0;

    void Start()
    {
        SelectWeapon();
    }

    void Update()
    {

    }

    void SelectWeapon()
    {
        // make sure i is = to knife or starting pistol
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;

        }
    }
}
