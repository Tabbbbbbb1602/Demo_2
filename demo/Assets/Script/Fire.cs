using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject projectile;
    private float xInput;
    private float zInput;
    [Range(0, 10000)]
    [SerializeField]
    private float speed;
    [Range(50, 200)]
    [SerializeField]
    private float rotationSpeed;
    private Rigidbody rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.DrawRay(firePosition.transform.position, firePosition.transform.transform.forward * 100, Color.red);*/
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Transform firePoint = firePosition.transform;
            Rigidbody rb = Instantiate(projectile, firePoint.position, Quaternion.Euler(new Vector3(90, 0, 0))).GetComponent<Rigidbody>();

            Debug.DrawRay(firePoint.position, firePoint.transform.forward * 100, Color.red);

            rb.AddForce((firePosition.transform.transform.forward) * 100f, ForceMode.Impulse);
            rb.AddForce((firePosition.transform.transform.right) * 20f, ForceMode.Impulse);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        // Xoay theo truc y
        var angle = xInput * Vector3.up;

        // Tuy chinh toc do xoay
        var lastAngle = angle * rotationSpeed;
        var moveDistance = zInput * speed;
        rigidbody.AddTorque(lastAngle);
        rigidbody.AddForce(moveDistance * transform.forward);
    }
}
