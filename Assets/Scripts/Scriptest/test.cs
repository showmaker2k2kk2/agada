﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed;
    public Vector3 a=new Vector3(-1,0,0);
    public Vector3 d= new Vector3(1,0,0);

    

    public Vector3 w = new Vector3(0, 0, 1);
    public Vector3 s = new Vector3(0, 0, -1);

    Vector3 hhh = new Vector3(4f, 0, 4f);


    private Vector3 huo_di_chuyen = Vector3.zero;
    private CharacterController characterController;


    private Rigidbody rb;
    public Transform enemy;
    private Vector3 ha;
    //float w;
    //float s;
    //float a;
    //float d;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
       characterController = GetComponent<CharacterController>();
       
        



        //if (Input.GetKey(KeyCode.Space))
        //{
        //    rb.velocity = a;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    rb.velocity = Vector3.zero;
        //}

        //if (Input.GetKey(KeyCode.T))
        //{
        //    rb.velocity = new Vector3(0, 0, 1);

        //}
        //if (Input.GetKey(KeyCode.P))
        //{
        //    changepos12();
        //}




        //Vector3 t = transform.position - enemy.transform.position;
        ////Debug.Log(t);
        //float do_lon_cua_vecto = t.magnitude;// căn cua x bình +ybinh + z bình
        //float g = t.sqrMagnitude;

        //Debug.Log(do_lon_cua_vecto);

        //Debug.Log("vec tor right la"+yu);

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //   rb.velocity=d*10;

        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.velocity = transform.right * -10;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.velocity = transform.forward * 10;

        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.velocity = transform.forward * -10;
        //}

        float ad = Input.GetAxisRaw("Horizontal");// ad :-1  -> 1
        float ws = Input.GetAxisRaw("Vertical");// ws :-1  -> 1

        Vector3 huong_dichuyen_cucbo = new Vector3(ad, 0, ws);

        ///        Rigidbody
        //1.rb.velocity = dichuyen;
        //2.  rb.AddForce(dichuyen * speed,ForceMode.Impulse);//truyền vào 1 vector lực
        //3. rb.MovePosition(transform.position + dichuyen * speed * Time.deltaTime);


        // transform
        //4.transform.Translate(hhh);



        //5. sử dụng character controler để di chuyển 
        Vector3 huong_dichuyentoan_cuc = transform.TransformDirection(huong_dichuyen_cucbo);
        huong_dichuyentoan_cuc *= speed;
        characterController.Move(huong_dichuyen_cucbo);

    }
    void changepos1()
    {
        transform.position = new Vector3(1, 1, 1);
    }
    void changepos12()
    {
        transform.Translate(new Vector3(0, 0, 1));
    } 
    
   void MOveTranslate()
    {
        transform.Translate(transform.forward * speed*Time.deltaTime);
    }
    //void moveRigidAddfore()
    //{
    //    rb.AddForce() 
    //}    

}
