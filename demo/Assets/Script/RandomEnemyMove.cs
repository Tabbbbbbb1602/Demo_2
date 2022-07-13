using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemyMove : MonoBehaviour
{
    [Range(0, 100)]
    [SerializeField]
    private float speed;
    private GameObject player;
    public GameObject firePosition;
    private RaycastHit vision;

    private float speedMove;

    private Rigidbody rigidbody;

    private int count = 0;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        speedMove = 0.2f;
        StartCoroutine(OnRandomMove());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(firePosition.transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.red);
        /* Debug.DrawRay(firePosition.transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.red);
         Debug.Log(gameObject.name + " : " + gameObject.transform.position);*/
        /*if(count < 3)
        {*/
        /*    transform.Translate(10 * Vector3.forward);
            Debug.Log(transform.transform.position);*/
        /* count++;*/
        /*}*/
        /*    var randomAngle = Random.Range(0, 360) * Vector3.forward;
            if (Physics.Raycast(firePosition.transform.position, transform.TransformDirection(Vector3.forward), out vision, 30))
            {
                if (vision.collider.CompareTag("wallRed"))
                {
                    transform.Rotate(randomAngle);
                    transform.Translate(10 * Time.deltaTime * Vector3.forward);
                }

            }
            else
            {
                transform.Translate(100 * Time.deltaTime * Vector3.forward);
            }*/

    }

    private void FixedUpdate()
    {
        
    }

    private IEnumerator OnRandomMove()
    {
        yield return new WaitForSeconds(3f);
        var randomAngle = Random.Range(0, 360) * Vector3.forward;

        /*Debug.Log(Physics.Raycast(firePosition.transform.position, transform.TransformDirection(Vector3.forward), out vision, 30));*/
        transform.Translate(0.2f * Vector3.forward);
        if (Physics.Raycast(firePosition.transform.position, transform.TransformDirection(Vector3.forward), out vision, 30))
        {
           
            if (vision.collider.CompareTag("wallRed") || vision.collider.CompareTag("wallGreen") || vision.collider.CompareTag("Ground"))
            {
                /*Debug.Log("12312311");*/
                transform.Rotate(randomAngle);
                transform.Translate(1f * Vector3.forward);
            }

        }
        else
        {
            /*Debug.Log("dasdasdasd");*/
            transform.Translate(1f * Vector3.forward);
        }
        StartCoroutine(OnRandomMove());
    }

}
