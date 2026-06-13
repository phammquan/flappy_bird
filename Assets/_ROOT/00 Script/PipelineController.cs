using UnityEngine;

public class PipelineController : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private float speed;
    [SerializeField] private float destroyTime = 5;
    private float countDown;


    void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
        countDown = destroyTime;
    }

    private void MoveToLeft()
    {
        _transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void CountDownDestroy()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        MoveToLeft();
        CountDownDestroy();
    }
}