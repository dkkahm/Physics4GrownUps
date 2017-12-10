using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPanel : MonoBehaviour {
    public Image m_left_arrow_image;
    public Image m_right_arrow_image;

    RectTransform m_tr;

    Vector2 m_target_position;

    private const float SHOW_POSTION_X = -250.0f;
    private const float HIDE_POSTION_X = 200.0f;

    private const float MOVE_SPEED = 10.0f;

    // Use this for initialization
    void Start () {
        m_tr = GetComponent<RectTransform>();
        m_left_arrow_image.gameObject.SetActive(false);

        m_target_position = new Vector2(SHOW_POSTION_X, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        m_tr.anchoredPosition = Vector2.Lerp(m_tr.anchoredPosition, m_target_position, MOVE_SPEED * Time.deltaTime);
    }

    public void OnLeftArrowClicked()
    {
        m_target_position = new Vector2(SHOW_POSTION_X, 0f);
        m_left_arrow_image.gameObject.SetActive(false);
        m_right_arrow_image.gameObject.SetActive(true);
    }

    public void OnRightArrowClicked()
    {
        m_target_position = new Vector2(HIDE_POSTION_X, 0f);
        m_left_arrow_image.gameObject.SetActive(true);
        m_right_arrow_image.gameObject.SetActive(false);
    }

}
