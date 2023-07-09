using System;
using Dummiesman;
using System.IO;
using System.Text;
using UnityEngine;
using TMPro;

public class ObjFromStream : MonoBehaviour
{
	public TextMeshProUGUI text; //Input Field

	void Start () {
		/*
		//var www = new WWW("https://people.sc.fsu.edu/~jburkardt/data/obj/lamp.obj");
        var www = new WWW("https://people.sc.fsu.edu/~jburkardt/data/obj/airboat.obj");
        
        while (!www.isDone){
	        Debug.Log(www.isDone);
	        System.Threading.Thread.Sleep(1);
        }
        
        //create stream and load
        var textStream = new MemoryStream(Encoding.UTF8.GetBytes(www.text));
        var loadedObj = new OBJLoader().Load(textStream);
        */
        
	}

	private static int count = 0;
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log(text.text);
			//var www = new WWW("https://people.sc.fsu.edu/~jburkardt/data/obj/airboat.obj");
			//var www = new WWW(text.text);
			Debug.Log(text.text);
			
			var www = new WWW("https://people.sc.fsu.edu/~jburkardt/data/obj/lamp.obj");

			if (count == 0)
			{
				www = new WWW("https://people.sc.fsu.edu/~jburkardt/data/obj/lamp.obj");
			}
			else
			{
				www = new WWW("https://people.sc.fsu.edu/~jburkardt/data/obj/airboat.obj");
			}
			
			while (!www.isDone){
	            System.Threading.Thread.Sleep(1);
            }
            
    		var textStream = new MemoryStream(Encoding.UTF8.GetBytes(www.text));
    		var loadedObj = new OBJLoader().Load(textStream);

            loadedObj.transform.position = new Vector3(0, 0, 0);

            count++;
		}

	}
	
}
