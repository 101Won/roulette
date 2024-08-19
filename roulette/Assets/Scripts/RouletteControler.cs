using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControler : MonoBehaviour
{
    private float rotationSpeed = 0; // �귿 �ӵ� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. ȭ�� ����
         bool isDown = Input.GetMouseButtonDown(0); //0 ��, 1��, 3��
         bool isRihgtDown = Input.GetMouseButtonDown(1); //0 ��, 1��, 2��
         bool isMiddleDown = Input.GetMouseButtonDown(2); //0 ��, 1��, 2��

        if (isDown)
        {
            Debug.Log($"<color=red>������ �������ϴ�.</color>");
            rotationSpeed += 100; //3.������ +�� ȸ�� ��Ű��
        }
        else if(isRihgtDown)
        {
            Debug.Log($"<color=red>�������� �������ϴ�.</color>");
            rotationSpeed -= 100; //3.������ -�� ȸ�� ��Ű��
        }
        //else
        //{
        //    Debug.Log("���� �������ϴ�.");
        //    rotationSpeed += 100; //3.������ ȸ�� ��Ű��
        //}

        //2. ȸ���ϱ�
        this.transform.Rotate(0, 0, rotationSpeed); 

        //4.�ӵ� ���̱�
        rotationSpeed *= 0.96f;
        Debug.Log(rotationSpeed);

    }
}
