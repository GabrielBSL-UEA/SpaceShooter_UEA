using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private float speed = .15f;
    
    private Vector2 savedOffset;
    private Renderer renderer;

    // Start is called before the first frame update
    void Awake()
    {
        TryGetComponent(out renderer);
        savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * speed, 1);
        Vector2 offset = new Vector2(savedOffset.x, y);

        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
