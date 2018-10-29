using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    public Vector3 clampedPosition;

    // Update is called once per frame
    void Update () {

        transform.position = player.position + offset;

        clampedPosition = transform.position;

        clampedPosition.y = Mathf.Clamp(transform.position.y, 2.5f, 2.5f);

        transform.position = clampedPosition;

    }
}

