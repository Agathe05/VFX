using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayVFX : MonoBehaviour
{
    [SerializeField] VisualEffect ExplosionVFX;

    // Start is called before the first frame update
    void Start()
    {
        startVFX();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void startVFX()
    {
        ExplosionVFX.Play();
        Debug.Log("VFX is started");
    }
}
