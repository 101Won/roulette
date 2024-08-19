using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControler : MonoBehaviour
{
    private float rotationSpeed = 0; // 룰렛 속도 제어 변수

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. 화면 감지
         bool isDown = Input.GetMouseButtonDown(0); //0 왼, 1오, 3휠
         bool isRihgtDown = Input.GetMouseButtonDown(1); //0 왼, 1오, 2휠
         bool isMiddleDown = Input.GetMouseButtonDown(2); //0 왼, 1오, 2휠

        if (isDown)
        {
            Debug.Log($"<color=red>왼쪽을 눌렀습니다.</color>");
            rotationSpeed += 100; //3.누르면 +로 회전 시키기
        }
        else if(isRihgtDown)
        {
            Debug.Log($"<color=red>오른쪽을 눌렀습니다.</color>");
            rotationSpeed -= 100; //3.누르면 -로 회전 시키기
        }
        //else
        //{
        //    Debug.Log("휠을 눌렀습니다.");
        //    rotationSpeed += 100; //3.누르면 회전 시키기
        //}

        //2. 회전하기
        this.transform.Rotate(0, 0, rotationSpeed); 

        //4.속도 줄이기
        rotationSpeed *= 0.96f;
        Debug.Log(rotationSpeed);

    }
}
