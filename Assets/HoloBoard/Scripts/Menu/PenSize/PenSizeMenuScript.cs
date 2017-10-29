﻿using Assets.HoloBoard.Scripts.EventManager;
using Assets.HoloBoard.Scripts.EventManager.Menu;
using HoloToolkit.Unity.InputModule;

namespace Assets.HoloBoard.Scripts.Menu.PenSize
{
    public class PenSizeMenuScript : SubsetMenu, IInputClickHandler
    {
        /// <summary>
        /// When user tap on color menu
        /// </summary>
        /// <param name="eventData"></param>
        public void OnInputClicked(InputClickedEventData eventData)
        {
            HoloBoardEventManager.Instance.EventManager<MenuEventManager>().SubsetMenuClicked(gameObject);
        }
    }
}