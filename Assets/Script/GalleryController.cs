using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryController : MonoBehaviour
{

    public GameObject[] GalleryItem;
    private float lastX;
    private bool Ismoving = false;
    // Use this for initialization
    void Start()
    {

    }

    void OnMouseDown()
    {
        lastX = Input.mousePosition.x;

    }
    void OnMouseDrag()
    {
        if (Ismoving == true)
            return;
        else {
            Ismoving = true;
            float distance = Input.mousePosition.x - lastX;
            if (distance < -10f)
            {
                for (int i = 0; i < GalleryItem.Length; i++)
                {
                    if (GalleryItem[i].transform.position.x < 1f)
                    {
                        if (GalleryItem[i].transform.position.x > -0.5f)
                        {
                            GalleryItem[i].transform.position = new Vector3(1.27f, GalleryItem[i].transform.position.y, -2.9f);
                            GalleryItem[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
                        }
                        else
                        {
                            GalleryItem[i].transform.position = new Vector3(0f, GalleryItem[i].transform.position.y, -2.7f);
                            GalleryItem[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                        }
                    }
                    else
                    {
                        GalleryItem[i].transform.position = new Vector3(-1.27f, GalleryItem[i].transform.position.y, -2.9f);
                        GalleryItem[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
                    }
                }
            }
            if (distance > 10f)
            {
                for (int i = 0; i < GalleryItem.Length; i++)
                {
                    if (GalleryItem[i].transform.position.x > -1f)
                    {
                        if (GalleryItem[i].transform.position.x < 0.5f)
                        {
                            GalleryItem[i].transform.position = new Vector3(1.27f, GalleryItem[i].transform.position.y, -2.9f);
                            GalleryItem[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
                        }
                        else
                        {
                            GalleryItem[i].transform.position = new Vector3(0f, GalleryItem[i].transform.position.y, -2.7f);
                            GalleryItem[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                        }
                    }
                    else
                    {
                        GalleryItem[i].transform.position = new Vector3(1.27f, GalleryItem[i].transform.position.y, -2.9f);
                        GalleryItem[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
                    }
                }
            }
        }
        Ismoving = false;
    }
}
