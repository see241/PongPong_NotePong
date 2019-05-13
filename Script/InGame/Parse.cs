using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;

public class Parse : MonoBehaviour
{
    public TextAsset song;
    public GameObject lowDo;
    public GameObject lowRe;
    public GameObject lowMi;
    public GameObject lowPa;
    public GameObject lowSol;
    public GameObject lowRa;
    public GameObject lowSi;
    public GameObject higtDo;
    public GameObject higtRe;
    public GameObject higtMi;
    public GameObject higtPa;

    public Text t_SCCPST;

    bool isParse;
    public float turm;

    public int num_Note;

    public int sccPst;

    int scc_Note;
    // Use this for initialization
    void Start()
    {
        num_Note = 0;
        scc_Note = 0;
        sccPst = 0;
        ParseSongFile();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ParseSongFile()
    {
        List<string> list = new List<string>(song.text.Split('\n'));
        for (int i = 0; i < list.Count; i++)
        {
            Process(list[i]);
        }
    }
    void Process(string list)
    {
        if (list.StartsWith("#"))
        {
            string[] keyList = list.Split(':');
            string temp_1 = keyList[0];
            string inFo = temp_1 + " = " + keyList[1];
            Debug.Log(inFo);
        }
        else if (list.StartsWith("@"))
            noteProcess(list);
    }
    void noteProcess(string list)
    {
        num_Note += 1;
        list = list.Replace("@", "");
        char[] step = new char[] { '@', '/' };

        string[] keylist = list.Split(step);
        int rhythem = int.Parse(keylist[0]);
        int note = int.Parse(keylist[1]);
        bool isSharp = false;
        if (int.Parse(keylist[2]) == 1)
            isSharp = true;
        switch (note)
        {
            case 1:
                if (isSharp)
                {
                    lowDo.gameObject.tag = "Sharp";
                }
                lowDo.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowDo);
                break;

            case 2:
                if (isSharp)
                {
                    lowRe.gameObject.tag = "Sharp";
                }
                lowRe.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowRe);
                break;

            case 3:
                if (isSharp)
                {
                    lowMi.gameObject.tag = "Sharp";
                }
                lowMi.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowMi);
                break;

            case 4:
                if (isSharp)
                {
                    lowPa.gameObject.tag = "Sharp";
                }
                lowPa.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowPa);
                break;

            case 5:
                if (isSharp)
                {
                    lowSol.gameObject.tag = "Sharp";
                }
                lowSol.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowSol);
                break;

            case 6:
                if (isSharp)
                {
                    lowRa.gameObject.tag = "Sharp";
                }
                lowRa.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowRa);
                break;

            case 7:
                if (isSharp)
                {
                    lowSi.gameObject.tag = "Sharp";
                }
                lowSi.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(lowSi);
                break;

            case 8:
                if (isSharp)
                {
                    higtDo.gameObject.tag = "Sharp";
                }
                higtDo.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(higtDo);
                break;

            case 9:
                if (isSharp)
                {
                    higtRe.gameObject.tag = "Sharp";
                }
                higtRe.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(higtRe);
                break;

            case 10:
                if (isSharp)
                {
                    higtMi.gameObject.tag = "Sharp";
                }
                higtMi.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(higtMi);
                break;

            case 11:
                if (isSharp)
                {
                    higtPa.gameObject.tag = "Sharp";
                }
                higtPa.transform.position = new Vector3(11 + rhythem * turm, 0, 0);
                Instantiate(higtPa);
                break;

        }


    }

    // 노트 먹었냐?
    public void ProsessNote()  
    {
        scc_Note += 1;
        sccPst = (sccPst / scc_Note)*100;


    }
}
