using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AssemblyCSharp
{
	public class IndicationBar: MonoBehaviour
	{
		

		public int iType;//0:hp|1:amour|2:exp
		private Text textPercent;
		Image FillBar;
		[SerializeField]
		private Text FillText;

		void Start(){
			FillBar = GetComponent<Image> ();
		}

		void Update () {
			FillBar.fillAmount = GameObject.Find ("GameManager").GetComponent<GameMNG> ().CaculatingExpPercent ();
			Debug.Log ("Exp percent:" + GameObject.Find ("GameManager").GetComponent<GameMNG> ().CaculatingExpPercent ());
			//string[] tmp = HealthText.text.Split (':');
			//HealthText.text =//tmp [0] + ": " + GameMNG.health + "/" + GameMNG.maxHealth;
			//FillBar.text = GameMNG.health + "/" + GameMNG.maxHealth;
			FillText.text=  GameObject.Find ("GameManager").GetComponent<GameMNG> ().CaculatingExpPercent ().ToString()+"%";
		}
	}
}

