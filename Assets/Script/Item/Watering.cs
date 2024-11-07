using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watering : MonoBehaviour
{
    public Transform original_Pos;

    //드래그 중
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, -0.5f);
    }
    //드래그 종료
    private void OnMouseUp()
    {
        transform.position = new Vector3(-6, -1, -0.5f);
    }

    public float spray_time;
    public SpriteRenderer Farm_floor;
    public Sprite Wet_farmSprite;
    private void Update()
    {
        if (isFarmTileTrigger)
        {
            spray_time += Time.deltaTime;
            if (spray_time >= 2f)
            {
                Farm_floor.sprite = Wet_farmSprite;
                spray_time = 0;
            }
        }
    }

    public bool isFarmTileTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Contains("Farm"))
        {
            spray_time = 0;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Farm"))
        {
            Farm_floor = collision.gameObject.GetComponent<SpriteRenderer>();
            transform.rotation = Quaternion.Euler(0, 0, -25);
            isFarmTileTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name.Contains("Farm"))
        {
            isFarmTileTrigger = false;
            Farm_floor = null;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
