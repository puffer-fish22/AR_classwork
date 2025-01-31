using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARUnitLab : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _stateText;
    private void OnARSessionStateChanged(
    ARSessionStateChangedEventArgs args)
    {
    // Do something with args ...
    // e . g . _stateText . text = args .[ XXX ]
    // Hint : you may want to look at what
    //properties the object args have.Once you
    //found the interesting property, look at
    //what functions that property has.
    }
void Start()
    {
     ARSession.stateChanged +=
        OnARSessionStateChanged;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
