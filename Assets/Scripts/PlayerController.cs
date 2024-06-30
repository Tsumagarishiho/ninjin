using UnityEngine;

/// <summary>
/// 砲台 (Canon) を制御するコンポーネント
/// </summary>
public class CanonController : MonoBehaviour
{
    /// <summary>砲弾として生成するプレハブ</summary>
    [SerializeField] GameObject m_shellPrefab = default;
    /// <summary>砲口を指定する</summary>
    [SerializeField] Transform m_muzzle = default;
    [SerializeField] Transform m_crosshair;
    AudioSource m_audio = default;

    [SerializeField] GameObject m_prefab = default;
    [SerializeField] float m_interval = 1f;
    float m_timer;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        //transform.up = Vector2.right;
        transform.up = m_crosshair.position - transform.position;


        // Time.deltaTime は「前フレームからの経過時間」を取得する
        // これを積算して「経過時間」を求めるのは Unity での典型的なプログラミングのパターンである
        m_timer += Time.deltaTime;

        // 「経過時間」が「生成する間隔」を超えたら
        if (m_timer > m_interval)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                m_timer = 0;    // タイマーをリセットしている
                m_audio.Play();
                Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
            }
        }
    }
}
