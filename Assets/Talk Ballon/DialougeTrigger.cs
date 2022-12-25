using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour {

    [SerializeField] private DialougeManager dialougeManager;

    private bool triggered;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            dialougeManager.TriggerStartDialouge();
            triggered = true;
        }
    }
}
