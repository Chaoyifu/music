using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class toggleToGameScene1 : MonoBehaviour
    {
        [SerializeField]
        private VRInteractiveItem m_InteractiveItem;

        private AudioSource Sound;
        private void Awake()
        {
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
            GameInfo.gameState = 1;
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }

}
