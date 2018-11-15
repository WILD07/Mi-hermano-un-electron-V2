using UnityEngine;
using System.Collections;

public class administradorBotones : MonoBehaviour {


//************** BOTONES MENU *********************************************************

	// este codigo abre la escena "Jugar"

	public void botonJugar(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Jugar");
	}

	// este codigo abre la escena "Creditos"

	public void botonCreditos(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (1);
	}

	// este codigo abre la escena "Opciones"

	public void botonOpciones(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (2);
	}

	// este codigo termina la ejecucion de la aplicacion

	public void salirApp(){
		UnityEngine.Application.Quit ();
	}

//************** FINAL BOTONES MENU *********************************************************



//************** BOTONES REDES SOCIALES *********************************************************


	// este codigo pide una url desde el boton y se lo asigna dentro la aplicacion

	public void botonesRedesSociales(string abrirUrl){
		UnityEngine.Application.OpenURL (abrirUrl);
	}


//************** FINAL BOTONES REDES SOCIALES *********************************************************

}
