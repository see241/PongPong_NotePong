using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float up;
    bool isSharp;
    public GameObject sharp;
    public GameObject drt;

    public ParticleSystem ptc;

    public GameObject C4;
    public GameObject D4;
    public GameObject E4;
    public GameObject F4;
    public GameObject G4;
    public GameObject A4;
    public GameObject B4;
    public GameObject C5;
    public GameObject D5;
    public GameObject E5;
    public GameObject F5;
    public GameObject G5;
    public GameObject A5;
    public GameObject B5;
    public GameObject C4S;
    public GameObject C5S;
    public GameObject D4S;
    public GameObject D5S;
    public GameObject F4S;
    public GameObject F5S;
    public GameObject G4S;
    public GameObject G5S;
    public GameObject A4S;
    public GameObject A5S;


    int curSound;
    // Use this for initialization
    void Start()
    {
        isSharp = false;
        curSound = 1;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Sharp_visible();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
            MoveUp();
        if (Input.GetKeyDown(KeyCode.S))
            MoveDown();
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (isSharp)
            {
                MoveUp();
            }
            isSharp = !isSharp;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!isSharp)
            {
                MoveDown();
            }
            isSharp = !isSharp;
        }
    }
    public void MoveUp()
    {
        if (curSound < 11)
        {
            curSound += 1;
            transform.Translate(new Vector3(0, up, 0));
        }
    }
    public void MoveDown()
    {
        if (curSound > 1)
        {
            transform.Translate(new Vector3(0, -up, 0));
            curSound -= 1;
        }
    }

    void Sharp_visible()
    {
        sharp.SetActive(isSharp);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Sharp")
        {
            if (isSharp)
            {
                switch (curSound)
                {
                    case 1:
                        C4S.GetComponent<AudioSource>().Play();
                        break;
                    case 2:
                        D4S.GetComponent<AudioSource>().Play();
                        break;
                    case 4:
                        F4S.GetComponent<AudioSource>().Play();
                        break;
                    case 5:
                        G4S.GetComponent<AudioSource>().Play();
                        break;
                    case 6:
                        A4S.GetComponent<AudioSource>().Play();
                        break;
                    case 8:
                        C5S.GetComponent<AudioSource>().Play();
                        break;
                    case 9:
                        D5S.GetComponent<AudioSource>().Play();
                        break;
                    case 11:
                        F5S.GetComponent<AudioSource>().Play();
                        break;
                    case 12:
                        G5S.GetComponent<AudioSource>().Play();
                        break;
                    case 13:
                        A5S.GetComponent<AudioSource>().Play();
                        break;
                }
                drt.GetComponent<Parse>().ProsessNote();
                Destroy(col.gameObject);
            }
        }
        else
        {
            if (!isSharp)
            {
                switch (curSound)
                {
                    case 1:
                        C4.GetComponent<AudioSource>().Play();
                        break;
                    case 2:
                        D4.GetComponent<AudioSource>().Play();
                        break;
                    case 3:
                        F5.GetComponent<AudioSource>().Play();
                        break;
                    case 4:
                        G5.GetComponent<AudioSource>().Play();
                        break;
                    case 5:
                        A4.GetComponent<AudioSource>().Play();
                        break;
                    case 6:
                        A4.GetComponent<AudioSource>().Play();
                        break;
                    case 7:
                        B4.GetComponent<AudioSource>().Play();
                        break;
                    case 8:
                        C5.GetComponent<AudioSource>().Play();
                        break;
                    case 9:
                        D5.GetComponent<AudioSource>().Play();
                        break;
                    case 10:
                        E5.GetComponent<AudioSource>().Play();
                        break;
                    case 11:
                        F5.GetComponent<AudioSource>().Play();
                        break;
                    case 12:
                        G5.GetComponent<AudioSource>().Play();
                        break;
                    case 13:
                        A5.GetComponent<AudioSource>().Play();
                        break;
                    case 14:
                        B5.GetComponent<AudioSource>().Play();
                        break;
                }
                drt.GetComponent<SoundManager>().PlaySound(curSound - 1);
                drt.GetComponent<Parse>().ProsessNote();
                Destroy(col.gameObject);
            }
        }
        ptc.Play();
    }
}
