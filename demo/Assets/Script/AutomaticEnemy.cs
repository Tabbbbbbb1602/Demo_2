using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticEnemy : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject projecttitle;
    private float xInput;
    private float zInput;
    [Range(0, 1000)]
    [SerializeField]
    private float speed;
    [Range(50, 200)]
    [SerializeField]
    private float rotationSpeed;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(OnRamdomFire());
    }

    private void Update()
    {
        /*Transform firePoint = firePosition.transform;
        Rigidbody rb = Instantiate(projecttitle, firePoint.position, Quaternion.Euler(new Vector3(90, 0, 0))).GetComponent<Rigidbody>();

        rb.AddForce((firePosition.transform.transform.forward) * 10f, ForceMode.Impulse);
        rb.AddTorque((firePosition.transform.transform.right) * 5f, ForceMode.Impulse);*/
        /*StartCoroutine(OnRamdomFire());*/
    }

    private void FixedUpdate()
    {
        /*StartCoroutine(OnRamdomFire());*/
        /*var angle = xInput * Vector3.up;
        var lastAngle = angle * rotationSpeed;
        var moveDistance = zInput * speed;
        rigidbody.AddTorque(lastAngle);
        rigidbody.AddForce(moveDistance * transform.forward);*/
    }

    private IEnumerator OnRamdomFire()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Transform firePoint = firePosition.transform;
            Rigidbody rb = Instantiate(projecttitle, firePoint.position, Quaternion.Euler(new Vector3(90, 0, 0))).GetComponent<Rigidbody>();

            rb.AddForce((firePosition.transform.transform.forward) * 100f, ForceMode.Impulse);
            rb.AddTorque((firePosition.transform.transform.right) * 50f, ForceMode.Impulse);
        }
    }
}
