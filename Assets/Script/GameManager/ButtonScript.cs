using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
    private PlayerMove player;
    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMove>();
    }
	public void OnPointerDown(PointerEventData data)
    {
        if(gameObject.name == "Left")
        {
            player.setMoveLeft(true);
        }
        if (gameObject.name == "Right")
        {
            player.setMoveRight(true);
        }
        if (gameObject.name == "Up")
        {
            player.setMoveUp(true);
        }
        if (gameObject.name == "Down")
        {
            player.setMoveDown(true);
        }
    }
    public void OnPointerUp(PointerEventData data)
    {
        player.stopMove();
    }
}
