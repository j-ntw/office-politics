using UnityEngine;

public class JobArrow : BaseArrow
{
    public ArrowType arrowType = ArrowType.JobArrow;
    private float speed;
    private bool isTrackingPlayer = true;
    private GameObject trackedBoss;

    private void Awake()
    {
        speed = weaponGameConstants.jobArrowSpeed;
    }
    public void SpawnArrow(Transform bossCoords)
    {
        Shoot(bossCoords, speed);
        GetComponent<PositionGameEventListener>().enabled = false;

        // sfx for throw job arrow
        GameManager.instance.PlayAudioElement(GameManager.instance.audioElements.throwJobArrow);
    }

    public override void OnParry()
    {
        isTrackingPlayer = false;
        foreach (GameObject boss in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            if (
                trackedBoss == null ||
                (transform.position - boss.transform.position).magnitude <
                (transform.position - trackedBoss.transform.position).magnitude
            )
            {
                trackedBoss = boss;
            }
        }
    }

    public void FixedUpdate()
    {
        if (isTrackingPlayer)
        {
            Pursue(player.transform);
        }
        else
        {
            Seek(trackedBoss.transform);
        }
    }

    public void Pursue(Transform target)
    {
        Vector2 desired = (0.5f * player.gameObject.GetComponent<Rigidbody2D>().velocity) + (Vector2)(target.position - transform.position);
        desired = desired.normalized * weaponGameConstants.jobArrowSpeed;

        Vector3 steering = desired - rb.velocity;
        steering = Vector2.ClampMagnitude(steering, weaponGameConstants.jobArrowMaxForce);

        rb.AddForce(steering, ForceMode2D.Impulse);

        rb.velocity = Vector2.ClampMagnitude(rb.velocity, weaponGameConstants.jobArrowSpeed);

        float rot = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 45 - 180);

    }
    public void Seek(Transform target)
    {
        Vector2 desired = (Vector2)(target.position - transform.position);
        desired = desired.normalized * weaponGameConstants.jobArrowSpeed;

        Vector3 steering = desired - rb.velocity;
        steering = Vector2.ClampMagnitude(steering, weaponGameConstants.jobArrowMaxForce);

        rb.AddForce(steering, ForceMode2D.Impulse);

        rb.velocity = Vector2.ClampMagnitude(rb.velocity, weaponGameConstants.jobArrowSpeed);

        float rot = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 45 - 180);
    }
}