using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EnemyWeapon : MonoBehaviour
{
    public GameObject arrow;
    public Transform arrowOrigin;


    void Start()
    {
        switch (arrow.name)
        {
            case "JobArrow":
                InvokeRepeating(nameof(StartArrowSequenceWithPause), 0f, 4f);
                break;
            case "StressArrow":
                InvokeRepeating(nameof(StartArrowSequenceWithPause), 0f, 3.2f);
                break;
            case "FanArrow":
                InvokeRepeating(nameof(StartArrowSequenceWithPause), 0f, 3f);
                break;
            default:
                InvokeRepeating(nameof(StartArrowSequenceWithPause), 0f, 4f);
                break;
        }
    }


    void Update()
    {

    }
    public UnityEvent<Transform> Spawn;
    private void StartArrowSequence()
    {
        if (gameObject.GetComponent<EnemyWeapon>().enabled)
        {
            Instantiate(arrow, this.transform);
            Spawn.Invoke(transform);
        }
    }
    IEnumerator StartArrowSequenceWithPauseCoroutine()
    {
        yield return new WaitForSeconds(1f);
        StartArrowSequence();
    }
    private void StartArrowSequenceWithPause()
    {
        StartCoroutine(StartArrowSequenceWithPauseCoroutine());
    }
    public void PauseArrowShooting(bool isChasing)
    {
        gameObject.GetComponent<EnemyWeapon>().enabled = isChasing;
    }
    public void Shoot()
    {
        Instantiate(arrow, arrowOrigin.position, Quaternion.identity);
    }
}
public enum ArrowType
{
    JobArrow = 0,
    StressArrow = 1,
    FanArrow = 2
}