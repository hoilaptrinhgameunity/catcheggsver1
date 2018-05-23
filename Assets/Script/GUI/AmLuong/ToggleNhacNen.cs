//Attach this script to a Toggle GameObject. To do this, go to Create>UI>Toggle.
//Set your own Text in the Inspector window

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ToggleNhacNen : MonoBehaviour
{
	Toggle m_Toggle;
	public AudioMixer audioMixer;
	public Slider sliDer;
	void Start()
	{
		
		//Fetch the Toggle GameObject
		m_Toggle = GetComponent<Toggle>();
		//Add listener for when the state of the Toggle changes, to take action
		m_Toggle.onValueChanged.AddListener(delegate {
			ToggleValueChanged(m_Toggle);
		});
	}
	void Update () {
		if (sliDer.value.ToString() == "-80") {
			m_Toggle.isOn = true;
		}
	}
	//Output the new state of the Toggle into Text
	void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn) {
			//tat am thanh
			Debug.Log(m_Toggle.name.ToString());
			if (m_Toggle.name == "Toggle_NhacNen") {
				audioMixer.SetFloat ("NhacNen", -80f);
			} else {
				audioMixer.SetFloat ("NhacGame", -80);
			}
		} else {
			//batamthanh
			Debug.Log(m_Toggle.name.ToString());
			if (m_Toggle.name == "Toggle_NhacGame") {
				if (sliDer.value.ToString() == "-80") {
					sliDer.value = -79.99f;
				}
				audioMixer.SetFloat ("NhacGame", sliDer.value);
			} else {
				if (sliDer.value.ToString() == "-80") {
					sliDer.value = -79.99f;
				}
				audioMixer.SetFloat ("NhacNen", sliDer.value);
			}
		}
	}
}
