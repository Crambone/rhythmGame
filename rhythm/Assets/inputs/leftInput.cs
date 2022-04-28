using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftInput : MonoBehaviour
{
    public GameObject backcircle;
    public GameObject leftArrow;
    public GameObject perfectHit1;
    public GameObject perfectHit2;
    public GameObject perfectHit3;
    public GameObject pointManager;
    public GameObject comboManager;
    public GameObject perfectflash;
    public GameObject accuracyText;
    public bool held;
    public GameObject noteFall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(backcircle.activeInHierarchy);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "finger")
        {
            held = true;
            leftArrow.transform.localPosition = new Vector3(-0.2f, transform.localPosition.y, transform.localPosition.z);
            backcircle.SetActive(true);

            if(perfectHit1.GetComponent<detector>().touchedNote != null && perfectHit1.GetComponent<detector>().touched == true)
            {
                if(perfectHit1.GetComponent<detector>().touchedNote.tag == "leftNote" && perfectHit1.GetComponent<detector>().noteDistance > -0.4f * noteFall.GetComponent<noteFall>().speed && perfectHit1.GetComponent<detector>().noteDistance < 0.4f * noteFall.GetComponent<noteFall>().speed)
                {
                    comboManager.GetComponent<combomanager>().comboUpdate();
                    
                    if(perfectHit1.GetComponent<detector>().noteDistance > 0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().earlyAccuracy();
                        pointManager.GetComponent<Text>().color = Color.white;
                        Destroy(perfectHit1.GetComponent<detector>().touchedNote);
                    }
                    
                    else if(perfectHit1.GetComponent<detector>().noteDistance < 0.2f * noteFall.GetComponent<noteFall>().speed && perfectHit1.GetComponent<detector>().noteDistance > -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(200f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().perfectAccuracy();
                        Destroy(perfectHit1.GetComponent<detector>().touchedNote);
                    }

                    else if(perfectHit1.GetComponent<detector>().noteDistance < -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().lateAccuracy();
                        pointManager.GetComponent<Text>().color = Color.white;
                        Destroy(perfectHit1.GetComponent<detector>().touchedNote);
                    }

                    GameObject flash = Instantiate(perfectflash);
                    flash.transform.position = perfectHit1.transform.position;
                }

                if(perfectHit1.GetComponent<detector>().touchedNote.tag == "longRightDown" && perfectHit1.GetComponent<detector>().noteDistance > -0.4f * noteFall.GetComponent<noteFall>().speed && perfectHit1.GetComponent<detector>().noteDistance < 0.4f * noteFall.GetComponent<noteFall>().speed)
                {
                    comboManager.GetComponent<combomanager>().comboUpdate();
                    
                    if(perfectHit1.GetComponent<detector>().noteDistance > 0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit1.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit1.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "early";
                    }
                    
                    else if(perfectHit1.GetComponent<detector>().noteDistance < 0.2f * noteFall.GetComponent<noteFall>().speed && perfectHit1.GetComponent<detector>().noteDistance > -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit1.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit1.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "perfect";
                    }

                    else if(perfectHit1.GetComponent<detector>().noteDistance < -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit1.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit1.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "late";
                    }
                }
            }

            if(perfectHit2.GetComponent<detector>().touchedNote != null && perfectHit2.GetComponent<detector>().touched == true)
            {
                if(perfectHit2.GetComponent<detector>().touchedNote.tag == "leftNote" && perfectHit2.GetComponent<detector>().noteDistance > -0.4f * noteFall.GetComponent<noteFall>().speed && perfectHit2.GetComponent<detector>().noteDistance < 0.4f * noteFall.GetComponent<noteFall>().speed)
                {
                    comboManager.GetComponent<combomanager>().comboUpdate();
                    
                    if(perfectHit2.GetComponent<detector>().noteDistance > 0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().earlyAccuracy();
                        pointManager.GetComponent<Text>().color = Color.white;
                        Destroy(perfectHit2.GetComponent<detector>().touchedNote);
                    }
                    
                    else if(perfectHit2.GetComponent<detector>().noteDistance < 0.2f * noteFall.GetComponent<noteFall>().speed && perfectHit2.GetComponent<detector>().noteDistance > -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(200f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().perfectAccuracy();
                        Destroy(perfectHit2.GetComponent<detector>().touchedNote);
                    }

                    else if(perfectHit2.GetComponent<detector>().noteDistance < -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().lateAccuracy();
                        pointManager.GetComponent<Text>().color = Color.white;
                        Destroy(perfectHit2.GetComponent<detector>().touchedNote);
                    }

                    GameObject flash = Instantiate(perfectflash);
                    flash.transform.position = perfectHit2.transform.position;
                }

                if(perfectHit2.GetComponent<detector>().touchedNote.tag == "longDownNote" && perfectHit2.GetComponent<detector>().noteDistance > -0.4f * noteFall.GetComponent<noteFall>().speed && perfectHit2.GetComponent<detector>().noteDistance < 0.4f * noteFall.GetComponent<noteFall>().speed)
                {
                    comboManager.GetComponent<combomanager>().comboUpdate();
                    
                    if(perfectHit2.GetComponent<detector>().noteDistance > 0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit2.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit2.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "early";
                    }
                    
                    else if(perfectHit2.GetComponent<detector>().noteDistance < 0.2f * noteFall.GetComponent<noteFall>().speed && perfectHit1.GetComponent<detector>().noteDistance > -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit2.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit2.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "perfect";
                    }

                    else if(perfectHit2.GetComponent<detector>().noteDistance < -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit2.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit2.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "late";
                    }
                }
            }

            if(perfectHit3.GetComponent<detector>().touchedNote != null && perfectHit3.GetComponent<detector>().touched == true)
            {
                if(perfectHit3.GetComponent<detector>().touchedNote.tag == "leftNote" && perfectHit3.GetComponent<detector>().noteDistance > -0.4f * noteFall.GetComponent<noteFall>().speed && perfectHit3.GetComponent<detector>().noteDistance < 0.4f * noteFall.GetComponent<noteFall>().speed)
                {
                    comboManager.GetComponent<combomanager>().comboUpdate();
                    
                    if(perfectHit3.GetComponent<detector>().noteDistance > 0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().earlyAccuracy();
                        pointManager.GetComponent<Text>().color = Color.white;
                        Destroy(perfectHit3.GetComponent<detector>().touchedNote);
                    }
                    
                    else if(perfectHit3.GetComponent<detector>().noteDistance < 0.2f * noteFall.GetComponent<noteFall>().speed && perfectHit3.GetComponent<detector>().noteDistance > -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(200f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().perfectAccuracy();
                        Destroy(perfectHit3.GetComponent<detector>().touchedNote);
                    }

                    else if(perfectHit3.GetComponent<detector>().noteDistance < -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo); //200 if perfect, 100 when late or early
                        accuracyText.GetComponent<accuracyText>().lateAccuracy();
                        pointManager.GetComponent<Text>().color = Color.white;
                        Destroy(perfectHit3.GetComponent<detector>().touchedNote);
                    }

                    GameObject flash = Instantiate(perfectflash);
                    flash.transform.position = perfectHit3.transform.position;
                }

                if(perfectHit3.GetComponent<detector>().touchedNote.tag == "longDownNote" && perfectHit3.GetComponent<detector>().noteDistance > -0.4f * noteFall.GetComponent<noteFall>().speed && perfectHit3.GetComponent<detector>().noteDistance < 0.4f * noteFall.GetComponent<noteFall>().speed)
                {
                    comboManager.GetComponent<combomanager>().comboUpdate();
                    
                    if(perfectHit3.GetComponent<detector>().noteDistance > 0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit3.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit3.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "early";
                    }
                    
                    else if(perfectHit3.GetComponent<detector>().noteDistance < 0.2f * noteFall.GetComponent<noteFall>().speed && perfectHit3.GetComponent<detector>().noteDistance > -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit3.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit3.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "perfect";
                    }

                    else if(perfectHit3.GetComponent<detector>().noteDistance < -0.2f * noteFall.GetComponent<noteFall>().speed)
                    {
                        perfectHit3.GetComponent<detector>().touchedNote.GetComponent<longNote>().held = true;
                        perfectHit3.GetComponent<detector>().touchedNote.GetComponent<longNote>().accuracy = "late";
                    }
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "finger")
        {
            held = false;
            leftArrow.transform.localPosition = new Vector3(0f, transform.localPosition.y, transform.localPosition.z);
            backcircle.SetActive(false);
        }
    }
}
