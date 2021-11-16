using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleElemenScript : MonoBehaviour
{
    public GameObject toggler;
    private Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle = this.GetComponent<Toggle>();
        if (toggle.isOn)
        {
            toggler.SetActive(true);
        }
        else {
            toggler.SetActive(false);
        }
        toggle.onValueChanged.AddListener(delegate { HandleChange(); });
    }

    private void HandleChange() {
        if (toggle.isOn)
        {
            toggler.SetActive(true);
        }
        else
        {
            toggler.SetActive(false);
        }
    }

}
