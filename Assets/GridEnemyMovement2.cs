using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridEnemyMovement2 : MonoBehaviour
{
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 1f;
    int cek = 0;


    // Update is called once per frame
    void Update()
    {   
        while(cek != 1 && !isMoving){
            StartCoroutine(MovePlayer(Vector3.down));
            cek++;
        }
        while(cek != 0 && !isMoving){
                StartCoroutine(MovePlayer(Vector3.up));
            cek--;
        }

    }

    private IEnumerator MovePlayer(Vector3 direction){
    isMoving = true;
    float elapsedTime = 0;

    origPos = transform.position;
    targetPos = origPos + (direction*10);

    while (elapsedTime < timeToMove){
        transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
        elapsedTime += Time.deltaTime;
        yield return null;

    }
    
    transform.position = targetPos;
    isMoving = false;
    
    }
}
