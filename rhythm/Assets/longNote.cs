using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class longNote : MonoBehaviour
{
    public float holdTime; //1 = 0.6667f

    public GameObject tail;
    public GameObject tailCap;

    public bool held;
    public string accuracy;


    public GameObject notefall;

    public float speedTemp;

    public GameObject pointManager;
    public GameObject comboManager;
    public GameObject accuracyText;

    public GameObject rightInput;
    public GameObject leftInput;
    public GameObject upInput;
    public GameObject downInput;

    public GameObject perfectflash;
    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("score");
        notefall = GameObject.Find("Level");
        comboManager = GameObject.Find("combo");
        accuracyText = GameObject.Find("accuracy");
        tail = gameObject.transform.Find("longNoteRightTail").gameObject;
        tailCap = gameObject.transform.Find("longNoteRightTailCap").gameObject;
        rightInput = GameObject.Find("rightInput");
        leftInput = GameObject.Find("leftInput");
        upInput = GameObject.Find("upInput");
        downInput = GameObject.Find("downInput");
        speedTemp = notefall.GetComponent<noteFall>().speed;
        holdTime = holdTime * speedTemp;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(held == true)
        {
            this.gameObject.transform.SetParent(null);
            holdTime -= 1f * speedTemp * 1.5f * Time.deltaTime;

        }
        if(holdTime <= 0f)
        {
            if(accuracy == "perfect")
            {
                pointManager.GetComponent<pointManager>().scoreUpdate(200f * comboManager.GetComponent<combomanager>().combo);
                accuracyText.GetComponent<accuracyText>().perfectAccuracy();
            }

            if(accuracy == "late")
            {
                pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo);
                accuracyText.GetComponent<accuracyText>().lateAccuracy();
                pointManager.GetComponent<Text>().color = Color.white;
            }

            if(accuracy == "early")
            {
                pointManager.GetComponent<pointManager>().scoreUpdate(100f * comboManager.GetComponent<combomanager>().combo);
                accuracyText.GetComponent<accuracyText>().earlyAccuracy();
                pointManager.GetComponent<Text>().color = Color.white;
            }

            GameObject flash = Instantiate(perfectflash);
            flash.transform.position = new Vector3(transform.position.x, 0f, 0f);

            Destroy(this.gameObject);
        }

        if(this.gameObject.transform.parent == null)
        {
            if(this.gameObject.tag == "longRightNote" && rightInput.GetComponent<rightInput>().held == false)
            {
                pointManager.GetComponent<pointManager>().miss();
                Destroy(this.gameObject);
            }

            if(this.gameObject.tag == "longLeftNote" && leftInput.GetComponent<leftInput>().held == false)
            {
                pointManager.GetComponent<pointManager>().miss();
                Destroy(this.gameObject);
            }

            if(this.gameObject.tag == "longUpNote" && upInput.GetComponent<upInput>().held == false)
            {
                pointManager.GetComponent<pointManager>().miss();
                Destroy(this.gameObject);
            }

            if(this.gameObject.tag == "longDownNote" && downInput.GetComponent<downInput>().held == false)
            {
                pointManager.GetComponent<pointManager>().miss();
                Destroy(this.gameObject);
            }
        }
        tailCap.transform.localPosition = new Vector3(0f, holdTime , 0f);
        tail.transform.position = Vector3.Lerp(this.transform.position, tailCap.transform.position, 0.5f);
        tail.transform.localScale = new Vector3(1f, tailCap.transform.localPosition.y * 2, 1f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "destroy")
        {
            pointManager.GetComponent<pointManager>().miss();
            Destroy(this.gameObject);
        }
    }

}
