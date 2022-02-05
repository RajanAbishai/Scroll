using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonReader : MonoBehaviour
{

    public TextAsset textJSON;
    public GameObject UiText;

    [System.Serializable]
    public class Data
    {
        public string name;
        public int code;

    }
    [System.Serializable]
    public class DataList
    {
        public Data[] data; //this is the data in the JSON file. You won't get errors if they're not the same, but you won't get any data
    }

    public DataList myDataList = new DataList();

    private void Start()
    {
        myDataList = JsonUtility.FromJson<DataList>(textJSON.text);
        //UiText.Text = textJSON.text;
    }
    /*
    foreach(Animal animal in Anmimals){
			GameObject newAnimal = Instantiate(ListItemPrefab) as GameObject;
    ListItemController controller = newAnimal.GetComponent();
    controller.Icon.sprite = animal.Icon;
			controller.Name.text = animal.Name;
			controller.Description.text = animal.Description;
			newAnimal.transform.parent = ContentPanel.transform;
			newAnimal.transform.localScale = Vector3.one;
        */



}
