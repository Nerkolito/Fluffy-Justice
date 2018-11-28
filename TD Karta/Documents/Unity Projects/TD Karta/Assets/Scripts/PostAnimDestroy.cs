using UnityEngine;
using System.Collections;

public class PostAnimDestroy : MonoBehaviour
{
    public float delay = 0f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);

    }
    void Update()
    {
        
    }
}