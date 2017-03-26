using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryController : MonoBehaviour {

    public GameObject[] GalleryItem;
    private float lastX;
	// Use this for initialization
	void Start () {
    }

    void OnMouseDown() {
        lastX = Input.mousePosition.x;
        Debug.Log(lastX);

        if (GameInfo.gameState == 1) {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
        if (GameInfo.gameState == 2)
        {
            Application.LoadLevel(Application.loadedLevel + 2);
        }
    }
    void OnMouseDrag()
    {
        float distance = Input.mousePosition.x - lastX;
        Debug.Log(distance);
        if (distance < -0.5f) {
            for (int i = 0; i < GalleryItem.Length; i++) {
                if (GalleryItem[i].transform.rotation.y < 45f)
                {
                    GalleryItem[i].transform.Rotate(0, 45f, 0);
                    if (GalleryItem[i].transform.rotation.y == 90f)
                        GalleryItem[i].transform.position = new Vector3(GalleryItem[i].transform.position.x + 0.6f, GalleryItem[i].transform.position.y, GalleryItem[i].transform.position.z + 0.2f);
                    else
                        GalleryItem[i].transform.position = new Vector3(GalleryItem[i].transform.position.x + 0.6f, GalleryItem[i].transform.position.y, GalleryItem[i].transform.position.z);
                }
                else
                {
                    GalleryItem[i].transform.Rotate(0, -90f, 0);
                    GalleryItem[i].transform.position = new Vector3(GalleryItem[i].transform.position.x - 1.2f, GalleryItem[i].transform.position.y, GalleryItem[i].transform.position.z);
                }
            }
        }
        if (distance > 0.5f)
        {
            for (int i = 0; i < GalleryItem.Length; i++)
            {
                if (GalleryItem[i].transform.rotation.y > -45f)
                {
                    GalleryItem[i].transform.Rotate(0, -45f, 0);
                    if (GalleryItem[i].transform.rotation.y == 90f)
                        GalleryItem[i].transform.position = new Vector3(GalleryItem[i].transform.position.x + 0.6f, GalleryItem[i].transform.position.y, GalleryItem[i].transform.position.z + 0.2f);
                    else
                        GalleryItem[i].transform.position = new Vector3(GalleryItem[i].transform.position.x + 0.6f, GalleryItem[i].transform.position.y, GalleryItem[i].transform.position.z);
                }
                else
                {
                    GalleryItem[i].transform.Rotate(0, 90f, 0);
                    GalleryItem[i].transform.position = new Vector3(GalleryItem[i].transform.position.x + 1.2f, GalleryItem[i].transform.position.y, GalleryItem[i].transform.position.z);
                }
            }
        }
    }
}
