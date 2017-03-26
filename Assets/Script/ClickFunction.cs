/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class ClickFunction : MonoBehaviour
{

    private AudioSource Sound;
    // Use this for initialization
    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    void Update()
    {
    }

    private void HandleClick() {
        Sound.Play();
    }
}*/
using UnityEngine;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class ClickFunction : MonoBehaviour
    {
        [SerializeField]
        private VRInteractiveItem m_InteractiveItem;

        private AudioSource Sound;
        private void Awake()
        {
            Sound = GetComponent<AudioSource>();
        }


        private void OnEnable()
        {
            m_InteractiveItem.OnClick += HandleClick;
        }


        private void OnDisable()
        {
            m_InteractiveItem.OnClick -= HandleClick;
        }


        //Handle the Click event
        private void HandleClick()
        {
            Sound.Play();
        }
    }

}