using System.Collections;
using UnityEngine;
/*
public class CameraManager : MonoBehaviour
{
    new Transform transform;

    float speed = 10f;
    float fieldHeight = 10;
    float viewHeight;

    void Awake()
    {
        transform = GetComponent<Transform>();
	}

    void Start()
    {
        viewHeight = fieldHeight / 2 + Camera.main.orthographicSize;
    }

    public IEnumerator MoveRandomField(Field field, int levelNum)
    {
        Vector3 pos = transform.position;
        while (pos.y > -viewHeight)
        {
            pos.y -= Time.deltaTime * speed;
            transform.position = pos;
            yield return null;
        }
        pos.y = viewHeight;
        transform.position = pos;
        field.GenerateField(levelNum);
        while (pos.y > 0)
        {
            pos.y -= Time.deltaTime * speed;
            transform.position = pos;
            yield return null;
        }
        pos.y = 0;
        transform.position = pos;
        yield return null;
    }
}
*/