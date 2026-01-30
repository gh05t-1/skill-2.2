using UnityEngine;

public class Kinetic : MonoBehaviour
{
    [SerializeField] private GameObject _a;
    [SerializeField] private GameObject _b;
    //[SerializeField] private GameObject _luna;
    Vector3 _velocity = new Vector3(1, 2, 3);

    Vector3 _diffrenceVector;
    Vector3 _direction;
    Vector3 _acceleration;
    float r;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _diffrenceVector = _a.transform.position - _b.transform.position;
        //_diffrenceVector = _a.transform.position - _luna.transform.position;

        r = _diffrenceVector.magnitude;

        _direction = _diffrenceVector.normalized;
        _acceleration = _direction * 100 / (r * r);

        //kinetic loop
        _velocity += _acceleration * Time.deltaTime;
        _b.transform.position += _velocity * Time.deltaTime;
        //_luna.transform.position += _velocity * Time.deltaTime;
    }
}
