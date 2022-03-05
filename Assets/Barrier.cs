using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField]
    private GameObject barrierPrefab;

    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }


    // Start is called before the first frame update
    void Start()
    {
        Vector3 topPosition = camera.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height, camera.nearClipPlane));
        Vector3 bottomPosition = camera.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, camera.nearClipPlane));
        Vector3 leftPosition = camera.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, camera.nearClipPlane));
        Vector3 rightPosition = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, camera.nearClipPlane));
        GameObject topBarrier = Instantiate(barrierPrefab, new Vector3(topPosition.x, topPosition.y + 0.5f, 0), Quaternion.identity);
        GameObject bottomBarrier = Instantiate(barrierPrefab, new Vector3(bottomPosition.x, bottomPosition.y - 0.5f, 0), Quaternion.identity);
        GameObject leftBarrier = Instantiate(barrierPrefab, new Vector3(leftPosition.x - 0.5f, leftPosition.y, 0), Quaternion.identity);
        GameObject rightBarrier = Instantiate(barrierPrefab, new Vector3(rightPosition.x + 0.5f, rightPosition.y + 0.5f, 0), Quaternion.identity);
        float screenWidth = leftPosition.x - rightPosition.x;
        float screenHeight = topPosition.y - bottomPosition.y;
        topBarrier.transform.localScale = new Vector3(screenWidth, 1, 1);
        bottomBarrier.transform.localScale = new Vector3(screenWidth, 1, 1);
        leftBarrier.transform.localScale = new Vector3(1, screenHeight, 1);
        rightBarrier.transform.localScale = new Vector3(1, screenHeight, 1);
        topBarrier.name = "topBarrier";
        bottomBarrier.name = "bottomBarrier";
        leftBarrier.name = "leftBarrier";
        rightBarrier.name = "rightBarrier";

    }

    // Update is called once per frame
    void Update()
    {

    }
}
